using CD_i_Image_Parser.Helpers;
using Color = System.Drawing.Color;
using Image = System.Drawing.Image;
using System.Windows.Forms;

namespace CD_i_Image_Parser
{
  public partial class Form1 : Form
  {
    private bool isPaletteLoaded = false;
    private string paletteFilename;
    private string imageFilename;
    private string paletteDir;
    private bool isImageLoaded = false;
    private byte[] paletteBin;
    private byte[] imageBin;
    private List<Color> colors;
    private List<string> paletteFiles;
    private FileSystemWatcher watcher;

    public Form1()
    {
      InitializeComponent();
      cmbProcessList.Items.AddRange(MemoryHelper.GetRunningProcesses().Select(p => p.ProcessName).ToArray());
    }

    private void InitializeFileSystemWatcher()
    {
      watcher = new FileSystemWatcher();
      watcher.Path = paletteDir; // Specify the folder you want to watch
      watcher.NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.DirectoryName;
      watcher.Filter = "*.bin*"; // Watch bin files

      // Subscribe to events
      watcher.Changed += OnChanged;
      watcher.Created += OnChanged;
      watcher.Deleted += OnChanged;
      watcher.Renamed += OnChanged;

      // Enable the watcher
      watcher.EnableRaisingEvents = true;
      UpdateMethod();
    }

    private void OnChanged(object sender, FileSystemEventArgs e)
    {
      UpdateMethod();
    }

    private void UpdateMethod()
    {
      if (lstPalettes.InvokeRequired)
      {
        lstPalettes.Invoke(new MethodInvoker(UpdateMethod));
      }
      else
      {
        paletteFiles = Directory.GetFiles(paletteDir, "*.bin").ToList();
        paletteFiles = paletteFiles.OrderBy(f => f).ToList();
        lstPalettes.Items.Clear();
        lstPalettes.Items.AddRange(paletteFiles.ToArray());
      }
    }

    private void btnLoadPalette_Click(object sender, EventArgs e)
    {
      openFileDialog1 = new OpenFileDialog()
      {
        FileName = "Select a file",
        Title = "Open file"
      };
      if (openFileDialog1.ShowDialog() == DialogResult.OK)
      {
        paletteFilename = openFileDialog1.FileName;
        this.Text = $"BIN File: {paletteFilename}";
        try
        {
          paletteBin = File.ReadAllBytes(paletteFilename);
          isPaletteLoaded = true;
        }
        catch (Exception)
        {

          return;
        }
      }
    }

    private void btnLoadImage_Click(object sender, EventArgs e)
    {

      openFileDialog1 = new OpenFileDialog()
      {
        FileName = "Select a file",
        Title = "Open file"
      };
      if (openFileDialog1.ShowDialog() == DialogResult.OK)
      {
        imageFilename = openFileDialog1.FileName;
        this.Text = $"BIN File: {imageFilename}";
        try
        {
          imageBin = File.ReadAllBytes(imageFilename);
          isImageLoaded = true;
        }
        catch (Exception)
        {

          throw;
        }
      }
    }

    private void btnParsePalette_Click(object sender, EventArgs e)
    {
      ParsePalette();
    }

    private void ParsePalette()
    {
      if (paletteBin == null) return;
      if (radRgb.Checked)
      {
        var palBytes = paletteBin.Skip((int)paletteOffset.Value).Take((int)paletteLength.Value).ToArray();
        colors = ColorHelper.ConvertBytesToRGB(palBytes);
      }
      else if (radIndexed.Checked)
      {
        var palBytes = paletteBin.Skip((int)paletteOffset.Value).Take((int)paletteLength.Value).ToArray();
        colors = ColorHelper.ReadPalette(palBytes);
      }
      else if (radCLUT.Checked)
      {
        var bankCount = (int)paletteLength.Value;
        var bytesToTake = bankCount * 0x104;
        var palBytes = paletteBin.Skip((int)paletteOffset.Value).Take(bytesToTake).ToArray();
        colors = ColorHelper.ReadClutBankPalettes(palBytes, (byte)bankCount);
      }
      else
      {
        MessageBox.Show("No Palette Type selected");
        return;
      }
      var palBitmap = ColorHelper.CreateLabelledPalette(colors);
      palettePicBox.Image = palBitmap;
    }

    private void btnParseGrayscale_Click(object sender, EventArgs e)
    {
      colors = ColorHelper.GenerateColors(128).ToList();
      var palBitmap = ColorHelper.CreateLabelledPalette(colors);
      palettePicBox.Image = palBitmap;
      palettePicBox.Size = palettePicBox.Parent.Size;
      palettePicBox.SizeMode = PictureBoxSizeMode.Zoom;
      btnParseImage.PerformClick();
    }

    private void btnParseImage_Click(object sender, EventArgs e)
    {
      ParseImage();

    }

    private void ParseImage()
    {
      if (colors?.Count == 0)
      {
        MessageBox.Show("Palette not populated! Parse it and try again");
        return;
      }
      if (imageBin == null || imageBin.Length == 0)
      {
        MessageBox.Show("Image not populated! Select it and try again");
        return;
      }
      int width = (int)imageWidth.Value;
      int height = (int)imageHeight.Value;
      var image = new Bitmap(width, height);

      var imageBytes = imageBin.Skip((int)imageOffset.Value).Take(Math.Min((int)imageLength.Value, imageBin.Length)).ToArray();

      var imageType = Utilities.GetCheckedRadioButton(grpImageType)?.Name;

      if (imageType == null)
      {
        MessageBox.Show("Please select an image type");
        return;
      }

      switch (imageType)
      {
        case "radRle7":
          image = ImageFormatHelper.GenerateRle7Image(colors, imageBytes, width, height);
          break;
        case "radRle3":
          image = ImageFormatHelper.GenerateRle3Image(colors, imageBytes, width, height);
          break;
        case "radClut7":
          image = ImageFormatHelper.GenerateClutImage(colors, imageBytes, width, height);
          break;
        case "radClut4":
          image = ImageFormatHelper.GenerateClut4Image(colors, imageBytes, width, height);
          break;
        case "radDyuv":
          image = ImageFormatHelper.DecodeDYUVImage(imageBytes, width, height);
          break;
        case "radFont":
          image = ImageFormatHelper.GenerateFontImage(colors, imageBytes, width, height);
          break;
        default:
          break;
      }
      panel1.AutoScroll = false;
      panel1.Height = image.Height;
      panel1.Width = image.Width;
      imagePicBox.Size = image.Size;
      imagePicBox.Image = image;
      panel1.AutoScroll = true;
    }

    private void imagePicBox_Click(object sender, EventArgs e)
    {
      if (imagePicBox.Image == null) return;
      var outputDir = Path.GetDirectoryName(imageFilename);
      var outputFile = Path.GetFileNameWithoutExtension(imageFilename) + ".png";
      string output;
      var imageType = Utilities.GetCheckedRadioButton(grpImageType).Name;
      switch (imageType)
      {
        case "radRle7":
          Directory.CreateDirectory(outputDir + @"/output/Rle7");
          output = Path.Combine(outputDir + @"/output/Rle7", outputFile);
          imagePicBox.Image.Save(output);
          if (chkRLEGif.Checked)
          {
            var outputPath = Path.Combine(outputDir + @"/output/Rle7", "gif");
            Directory.CreateDirectory(outputPath);
            var outputFilePath = Path.Combine(outputPath, $"{outputFile}.gif");
            var offset = (int)imageOffset.Value;
            var length = (int)imageLength.Value;
            var bytes = imageBin.Skip(offset).Take(length).ToArray();
            var images = new List<Image>();
            ImageFormatHelper.Rle7_AllBytes(bytes, colors, 384, (int)imageHeight.Value, images);
            foreach (var (image, index) in images.WithIndex())
            {
              var imageName = $"{outputFile}_{index}.png";
              var imagePath = Path.Combine(outputPath, imageName);
              image.Save(imagePath);
            }
            ImageFormatHelper.CreateGifFromImageList(images, outputFilePath);
          }
          break;
        case "radRle3":
          Directory.CreateDirectory(outputDir + @"/output/Rle3");
          output = Path.Combine(outputDir + @"/output/Rle3", outputFile);
          imagePicBox.Image.Save(output);
          break;
        case "radClut7":
          Directory.CreateDirectory(outputDir + @"/output/Clut7");
          output = Path.Combine(outputDir + @"/output/Clut7", outputFile);
          imagePicBox.Image.Save(output);
          break;
        case "radClut4":
          Directory.CreateDirectory(outputDir + @"/output/Clut4");
          output = Path.Combine(outputDir + @"/output/Clut4", outputFile);
          imagePicBox.Image.Save(output);
          break;
        case "radDyuv":
          Directory.CreateDirectory(outputDir + @"/output/DYUV");
          output = Path.Combine(outputDir + @"/output/DYUV", outputFile);
          imagePicBox.Image.Save(output);
          break;
        case "radFont":
          Directory.CreateDirectory(outputDir + @"/output/Font");
          output = Path.Combine(outputDir + @"/output/Font", outputFile);
          imagePicBox.Image.Save(output);
          break;
        default:
          break;
      }

    }

    private void paletteLength_ValueChanged(object sender, EventArgs e)
    {
      ParsePalette();
    }

    private void btnPaletteFolder_Click(object sender, EventArgs e)
    {
      folderBrowserDialog1 = new FolderBrowserDialog()
      {
        Description = "Select a folder to load the palettes from",
        ShowNewFolderButton = false
      };
      if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
      {
        paletteDir = folderBrowserDialog1.SelectedPath;
        InitializeFileSystemWatcher();
      }
    }

    private void lstPalettes_SelectedIndexChanged(object sender, EventArgs e)
    {
      paletteFilename = (sender as ComboBox).SelectedItem.ToString();
      if (!string.IsNullOrEmpty(paletteFilename))
      {
        paletteBin = File.ReadAllBytes(paletteFilename);
        ParsePalette();
        ParseImage();
      }
    }

    private void palettePicBox_Click(object sender, EventArgs e)
    {
      if (palettePicBox.Image != null)
      {
        var outputDir = Path.GetDirectoryName(paletteFilename);
      var outputFile = Path.GetFileNameWithoutExtension(paletteFilename) + "_palette.png";
      string output;
      output = Path.Combine(outputDir, outputFile);
       palettePicBox.Image.Save(output); 
      }
    }

    private void btnGetCdiMem_Click(object sender, EventArgs e)
    {
      var cdiMem = MemoryHelper.GetCDiEmuMemory();
      if (cdiMem.Length > 0)
      {
        File.WriteAllBytes(@"C:\Dev\Projects\Gaming\CD-i\CDiEmuMemoryDumps\cdiMem.bin", cdiMem);
      }
    }

    private void imageProperty_ValueChanged(object sender, EventArgs e)
    {
      if(imageBin?.Length > 0)
      {
        ParseImage();
      }
    }
  }
}