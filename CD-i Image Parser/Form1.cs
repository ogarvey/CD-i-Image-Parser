using CD_i_Image_Parser.Helpers;
using System.Windows.Forms;

namespace CD_i_Image_Parser
{
  public partial class Form1 : Form
  {
    private bool isPaletteLoaded = false;
    private string paletteFilename;
    private string imageFilename;
    private bool isImageLoaded = false;
    private byte[] paletteBin;
    private byte[] imageBin;
    private List<Color> colors;

    public Form1()
    {
      InitializeComponent();
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

          throw;
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
      var palBytes = paletteBin.Skip((int)paletteOffset.Value).Take((int)paletteLength.Value).ToArray();
      if (radRgb.Checked)
      {
        colors = ColorHelper.ConvertBytesToRGB(palBytes);
      }
      else
      {
        colors = ColorHelper.ReadPalette(palBytes);
        colors[0] = Color.Transparent;
      }
      var palBitmap = ColorHelper.CreateLabelledPalette(colors);
      palettePicBox.Image = palBitmap;
      palettePicBox.Size = palettePicBox.Parent.Size;
      palettePicBox.SizeMode = PictureBoxSizeMode.Zoom;
    }

    private void btnParseGrayscale_Click(object sender, EventArgs e)
    {
      colors = ColorHelper.GenerateColors(256).ToList();
      var palBitmap = ColorHelper.CreateLabelledPalette(colors);
      palettePicBox.Image = palBitmap;
      palettePicBox.Size = palettePicBox.Parent.Size;
      palettePicBox.SizeMode = PictureBoxSizeMode.Zoom;
      btnParseImage.PerformClick();
    }

    private void btnParseImage_Click(object sender, EventArgs e)
    {
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

      imagePicBox.Image = image;
      imagePicBox.Size = imagePicBox.Parent.Size;
      imagePicBox.SizeMode = PictureBoxSizeMode.Zoom;

    }

    private void pictureBox2_Click(object sender, EventArgs e)
    {

    }

    private void imagePicBox_Click(object sender, EventArgs e)
    {
      var outputDir = Path.GetDirectoryName(imageFilename);
      var outputFile = Path.GetFileNameWithoutExtension(imageFilename) + ".png";
      var output = "";
      var imageType = Utilities.GetCheckedRadioButton(grpImageType).Name;
      switch (imageType)
      {
        case "radRle7":
          Directory.CreateDirectory(outputDir + @"/output/Rle7");
          output = Path.Combine(outputDir + @"/output/Rle7", outputFile);
          imagePicBox.Image.Save(output);
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

    }
  }
}