namespace CD_i_Image_Parser
{
  partial class Form1
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      tableLayoutPanel1 = new TableLayoutPanel();
      tableLayoutPanel2 = new TableLayoutPanel();
      btnPaletteFolder = new Button();
      btnLoadImage = new Button();
      btnParseImage = new Button();
      btnParseGrayscale = new Button();
      btnParsePalette = new Button();
      btnLoadPalette = new Button();
      lstPalettes = new ComboBox();
      chkUseTransparency = new CheckBox();
      chkRLEGif = new CheckBox();
      cmbProcessList = new ComboBox();
      btnGetCdiMem = new Button();
      tableLayoutPanel3 = new TableLayoutPanel();
      tableLayoutPanel4 = new TableLayoutPanel();
      grpPaletteType = new GroupBox();
      radCLUT = new RadioButton();
      radIndexed = new RadioButton();
      radRgb = new RadioButton();
      paletteLength = new NumericUpDown();
      paletteOffset = new NumericUpDown();
      label1 = new Label();
      label2 = new Label();
      tableLayoutPanel5 = new TableLayoutPanel();
      label6 = new Label();
      label5 = new Label();
      imageWidth = new NumericUpDown();
      imageHeight = new NumericUpDown();
      grpImageType = new GroupBox();
      radFont = new RadioButton();
      radRle3 = new RadioButton();
      radClut7 = new RadioButton();
      radClut4 = new RadioButton();
      radRle7 = new RadioButton();
      radDyuv = new RadioButton();
      tableLayoutPanel6 = new TableLayoutPanel();
      label4 = new Label();
      imageLength = new NumericUpDown();
      imageOffset = new NumericUpDown();
      label3 = new Label();
      palettePicBox = new PictureBox();
      panel1 = new Panel();
      imagePicBox = new PictureBox();
      openFileDialog1 = new OpenFileDialog();
      folderBrowserDialog1 = new FolderBrowserDialog();
      tableLayoutPanel1.SuspendLayout();
      tableLayoutPanel2.SuspendLayout();
      tableLayoutPanel3.SuspendLayout();
      tableLayoutPanel4.SuspendLayout();
      grpPaletteType.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)paletteLength).BeginInit();
      ((System.ComponentModel.ISupportInitialize)paletteOffset).BeginInit();
      tableLayoutPanel5.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)imageWidth).BeginInit();
      ((System.ComponentModel.ISupportInitialize)imageHeight).BeginInit();
      grpImageType.SuspendLayout();
      tableLayoutPanel6.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)imageLength).BeginInit();
      ((System.ComponentModel.ISupportInitialize)imageOffset).BeginInit();
      ((System.ComponentModel.ISupportInitialize)palettePicBox).BeginInit();
      panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)imagePicBox).BeginInit();
      SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      tableLayoutPanel1.AutoScroll = true;
      tableLayoutPanel1.AutoSize = true;
      tableLayoutPanel1.ColumnCount = 1;
      tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
      tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
      tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
      tableLayoutPanel1.Dock = DockStyle.Fill;
      tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      tableLayoutPanel1.Margin = new Padding(2);
      tableLayoutPanel1.Name = "tableLayoutPanel1";
      tableLayoutPanel1.RowCount = 2;
      tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
      tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
      tableLayoutPanel1.Size = new System.Drawing.Size(1859, 1066);
      tableLayoutPanel1.TabIndex = 0;
      // 
      // tableLayoutPanel2
      // 
      tableLayoutPanel2.ColumnCount = 7;
      tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2853088F));
      tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2856579F));
      tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2853041F));
      tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2856655F));
      tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2856655F));
      tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2842369F));
      tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2881632F));
      tableLayoutPanel2.Controls.Add(btnPaletteFolder, 1, 0);
      tableLayoutPanel2.Controls.Add(btnLoadImage, 2, 0);
      tableLayoutPanel2.Controls.Add(btnParseImage, 5, 0);
      tableLayoutPanel2.Controls.Add(btnParseGrayscale, 4, 0);
      tableLayoutPanel2.Controls.Add(btnParsePalette, 3, 0);
      tableLayoutPanel2.Controls.Add(btnLoadPalette, 0, 0);
      tableLayoutPanel2.Controls.Add(lstPalettes, 1, 1);
      tableLayoutPanel2.Controls.Add(chkUseTransparency, 4, 1);
      tableLayoutPanel2.Controls.Add(chkRLEGif, 5, 1);
      tableLayoutPanel2.Controls.Add(cmbProcessList, 0, 1);
      tableLayoutPanel2.Controls.Add(btnGetCdiMem, 6, 0);
      tableLayoutPanel2.Dock = DockStyle.Fill;
      tableLayoutPanel2.Location = new System.Drawing.Point(2, 2);
      tableLayoutPanel2.Margin = new Padding(2);
      tableLayoutPanel2.Name = "tableLayoutPanel2";
      tableLayoutPanel2.RowCount = 2;
      tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 66.6666641F));
      tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
      tableLayoutPanel2.Size = new System.Drawing.Size(1855, 102);
      tableLayoutPanel2.TabIndex = 0;
      // 
      // btnPaletteFolder
      // 
      btnPaletteFolder.Dock = DockStyle.Fill;
      btnPaletteFolder.Location = new System.Drawing.Point(266, 2);
      btnPaletteFolder.Margin = new Padding(2);
      btnPaletteFolder.Name = "btnPaletteFolder";
      btnPaletteFolder.Size = new System.Drawing.Size(260, 63);
      btnPaletteFolder.TabIndex = 5;
      btnPaletteFolder.Text = "Choose Palette Folder";
      btnPaletteFolder.UseVisualStyleBackColor = true;
      btnPaletteFolder.Click += btnPaletteFolder_Click;
      // 
      // btnLoadImage
      // 
      btnLoadImage.Dock = DockStyle.Fill;
      btnLoadImage.Location = new System.Drawing.Point(530, 2);
      btnLoadImage.Margin = new Padding(2);
      btnLoadImage.Name = "btnLoadImage";
      btnLoadImage.Size = new System.Drawing.Size(260, 63);
      btnLoadImage.TabIndex = 1;
      btnLoadImage.Text = "Choose Image File";
      btnLoadImage.UseVisualStyleBackColor = true;
      btnLoadImage.Click += btnLoadImage_Click;
      // 
      // btnParseImage
      // 
      btnParseImage.Dock = DockStyle.Fill;
      btnParseImage.Location = new System.Drawing.Point(1322, 2);
      btnParseImage.Margin = new Padding(2);
      btnParseImage.Name = "btnParseImage";
      btnParseImage.Size = new System.Drawing.Size(260, 63);
      btnParseImage.TabIndex = 3;
      btnParseImage.Text = "Parse Image (With Palette)";
      btnParseImage.UseVisualStyleBackColor = true;
      btnParseImage.Click += btnParseImage_Click;
      // 
      // btnParseGrayscale
      // 
      btnParseGrayscale.Dock = DockStyle.Fill;
      btnParseGrayscale.Location = new System.Drawing.Point(1058, 2);
      btnParseGrayscale.Margin = new Padding(2);
      btnParseGrayscale.Name = "btnParseGrayscale";
      btnParseGrayscale.Size = new System.Drawing.Size(260, 63);
      btnParseGrayscale.TabIndex = 2;
      btnParseGrayscale.Text = "Parse Image (Grayscale)";
      btnParseGrayscale.UseVisualStyleBackColor = true;
      btnParseGrayscale.Click += btnParseGrayscale_Click;
      // 
      // btnParsePalette
      // 
      btnParsePalette.Dock = DockStyle.Fill;
      btnParsePalette.Location = new System.Drawing.Point(794, 2);
      btnParsePalette.Margin = new Padding(2);
      btnParsePalette.Name = "btnParsePalette";
      btnParsePalette.Size = new System.Drawing.Size(260, 63);
      btnParsePalette.TabIndex = 4;
      btnParsePalette.Text = "Parse Palette";
      btnParsePalette.UseVisualStyleBackColor = true;
      btnParsePalette.Click += btnParsePalette_Click;
      // 
      // btnLoadPalette
      // 
      btnLoadPalette.Dock = DockStyle.Fill;
      btnLoadPalette.Location = new System.Drawing.Point(2, 2);
      btnLoadPalette.Margin = new Padding(2);
      btnLoadPalette.Name = "btnLoadPalette";
      btnLoadPalette.Size = new System.Drawing.Size(260, 63);
      btnLoadPalette.TabIndex = 0;
      btnLoadPalette.Text = "Choose Palette File";
      btnLoadPalette.UseVisualStyleBackColor = true;
      btnLoadPalette.Click += btnLoadPalette_Click;
      // 
      // lstPalettes
      // 
      tableLayoutPanel2.SetColumnSpan(lstPalettes, 3);
      lstPalettes.Dock = DockStyle.Fill;
      lstPalettes.FormattingEnabled = true;
      lstPalettes.Location = new System.Drawing.Point(267, 70);
      lstPalettes.Name = "lstPalettes";
      lstPalettes.Size = new System.Drawing.Size(786, 23);
      lstPalettes.TabIndex = 6;
      lstPalettes.SelectedIndexChanged += lstPalettes_SelectedIndexChanged;
      // 
      // chkUseTransparency
      // 
      chkUseTransparency.AutoSize = true;
      chkUseTransparency.Location = new System.Drawing.Point(1059, 70);
      chkUseTransparency.Name = "chkUseTransparency";
      chkUseTransparency.Size = new System.Drawing.Size(100, 19);
      chkUseTransparency.TabIndex = 7;
      chkUseTransparency.Text = "Transparency?";
      chkUseTransparency.UseVisualStyleBackColor = true;
      // 
      // chkRLEGif
      // 
      chkRLEGif.AutoSize = true;
      chkRLEGif.Location = new System.Drawing.Point(1323, 70);
      chkRLEGif.Name = "chkRLEGif";
      chkRLEGif.Size = new System.Drawing.Size(68, 19);
      chkRLEGif.TabIndex = 8;
      chkRLEGif.Text = "RLE Gif?";
      chkRLEGif.UseVisualStyleBackColor = true;
      // 
      // cmbProcessList
      // 
      cmbProcessList.Dock = DockStyle.Fill;
      cmbProcessList.FormattingEnabled = true;
      cmbProcessList.Location = new System.Drawing.Point(3, 70);
      cmbProcessList.Name = "cmbProcessList";
      cmbProcessList.Size = new System.Drawing.Size(258, 23);
      cmbProcessList.TabIndex = 9;
      // 
      // btnGetCdiMem
      // 
      btnGetCdiMem.Dock = DockStyle.Fill;
      btnGetCdiMem.Location = new System.Drawing.Point(1587, 3);
      btnGetCdiMem.Name = "btnGetCdiMem";
      btnGetCdiMem.Size = new System.Drawing.Size(265, 61);
      btnGetCdiMem.TabIndex = 10;
      btnGetCdiMem.Text = "Get CDiEmu Memory";
      btnGetCdiMem.UseVisualStyleBackColor = true;
      btnGetCdiMem.Click += btnGetCdiMem_Click;
      // 
      // tableLayoutPanel3
      // 
      tableLayoutPanel3.AutoScroll = true;
      tableLayoutPanel3.AutoSize = true;
      tableLayoutPanel3.ColumnCount = 2;
      tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.05391F));
      tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 79.94609F));
      tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 0);
      tableLayoutPanel3.Controls.Add(tableLayoutPanel5, 0, 1);
      tableLayoutPanel3.Controls.Add(palettePicBox, 1, 0);
      tableLayoutPanel3.Controls.Add(panel1, 1, 1);
      tableLayoutPanel3.Dock = DockStyle.Fill;
      tableLayoutPanel3.Location = new System.Drawing.Point(2, 108);
      tableLayoutPanel3.Margin = new Padding(2);
      tableLayoutPanel3.Name = "tableLayoutPanel3";
      tableLayoutPanel3.RowCount = 2;
      tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
      tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 75F));
      tableLayoutPanel3.Size = new System.Drawing.Size(1855, 956);
      tableLayoutPanel3.TabIndex = 1;
      // 
      // tableLayoutPanel4
      // 
      tableLayoutPanel4.ColumnCount = 1;
      tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
      tableLayoutPanel4.Controls.Add(grpPaletteType, 0, 0);
      tableLayoutPanel4.Controls.Add(paletteLength, 0, 4);
      tableLayoutPanel4.Controls.Add(paletteOffset, 0, 2);
      tableLayoutPanel4.Controls.Add(label1, 0, 1);
      tableLayoutPanel4.Controls.Add(label2, 0, 3);
      tableLayoutPanel4.Dock = DockStyle.Fill;
      tableLayoutPanel4.Location = new System.Drawing.Point(2, 2);
      tableLayoutPanel4.Margin = new Padding(2);
      tableLayoutPanel4.Name = "tableLayoutPanel4";
      tableLayoutPanel4.RowCount = 5;
      tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 32F));
      tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 17F));
      tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 17F));
      tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 17F));
      tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 17F));
      tableLayoutPanel4.Size = new System.Drawing.Size(368, 235);
      tableLayoutPanel4.TabIndex = 0;
      // 
      // grpPaletteType
      // 
      grpPaletteType.Controls.Add(radCLUT);
      grpPaletteType.Controls.Add(radIndexed);
      grpPaletteType.Controls.Add(radRgb);
      grpPaletteType.Dock = DockStyle.Fill;
      grpPaletteType.Location = new System.Drawing.Point(2, 2);
      grpPaletteType.Margin = new Padding(2);
      grpPaletteType.Name = "grpPaletteType";
      grpPaletteType.Padding = new Padding(2);
      grpPaletteType.Size = new System.Drawing.Size(364, 71);
      grpPaletteType.TabIndex = 2;
      grpPaletteType.TabStop = false;
      grpPaletteType.Text = "Palette Type";
      // 
      // radCLUT
      // 
      radCLUT.AutoSize = true;
      radCLUT.Location = new System.Drawing.Point(90, 18);
      radCLUT.Name = "radCLUT";
      radCLUT.Size = new System.Drawing.Size(87, 19);
      radCLUT.TabIndex = 2;
      radCLUT.Text = "CLUT Banks";
      radCLUT.UseVisualStyleBackColor = true;
      // 
      // radIndexed
      // 
      radIndexed.AutoSize = true;
      radIndexed.Location = new System.Drawing.Point(4, 39);
      radIndexed.Margin = new Padding(2);
      radIndexed.Name = "radIndexed";
      radIndexed.Size = new System.Drawing.Size(67, 19);
      radIndexed.TabIndex = 1;
      radIndexed.Text = "Indexed";
      radIndexed.UseVisualStyleBackColor = true;
      // 
      // radRgb
      // 
      radRgb.AutoSize = true;
      radRgb.Checked = true;
      radRgb.Location = new System.Drawing.Point(4, 18);
      radRgb.Margin = new Padding(2);
      radRgb.Name = "radRgb";
      radRgb.Size = new System.Drawing.Size(47, 19);
      radRgb.TabIndex = 0;
      radRgb.TabStop = true;
      radRgb.Text = "RGB";
      radRgb.UseVisualStyleBackColor = true;
      // 
      // paletteLength
      // 
      paletteLength.Location = new System.Drawing.Point(2, 194);
      paletteLength.Margin = new Padding(2);
      paletteLength.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
      paletteLength.Name = "paletteLength";
      paletteLength.Size = new System.Drawing.Size(126, 23);
      paletteLength.TabIndex = 1;
      paletteLength.Value = new decimal(new int[] { 384, 0, 0, 0 });
      // 
      // paletteOffset
      // 
      paletteOffset.Location = new System.Drawing.Point(2, 116);
      paletteOffset.Margin = new Padding(2);
      paletteOffset.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
      paletteOffset.Name = "paletteOffset";
      paletteOffset.Size = new System.Drawing.Size(126, 23);
      paletteOffset.TabIndex = 0;
      paletteOffset.Value = new decimal(new int[] { 76, 0, 0, 0 });
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Location = new System.Drawing.Point(3, 75);
      label1.Name = "label1";
      label1.Size = new System.Drawing.Size(78, 15);
      label1.TabIndex = 3;
      label1.Text = "Palette Offset";
      // 
      // label2
      // 
      label2.AutoSize = true;
      label2.Location = new System.Drawing.Point(3, 153);
      label2.Name = "label2";
      label2.Size = new System.Drawing.Size(122, 15);
      label2.TabIndex = 4;
      label2.Text = "Palette Length (bytes)";
      // 
      // tableLayoutPanel5
      // 
      tableLayoutPanel5.ColumnCount = 1;
      tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
      tableLayoutPanel5.Controls.Add(label6, 0, 6);
      tableLayoutPanel5.Controls.Add(label5, 0, 4);
      tableLayoutPanel5.Controls.Add(imageWidth, 0, 5);
      tableLayoutPanel5.Controls.Add(imageHeight, 0, 7);
      tableLayoutPanel5.Controls.Add(grpImageType, 0, 0);
      tableLayoutPanel5.Controls.Add(tableLayoutPanel6, 0, 3);
      tableLayoutPanel5.Controls.Add(imageOffset, 0, 2);
      tableLayoutPanel5.Controls.Add(label3, 0, 1);
      tableLayoutPanel5.Dock = DockStyle.Fill;
      tableLayoutPanel5.Location = new System.Drawing.Point(2, 241);
      tableLayoutPanel5.Margin = new Padding(2);
      tableLayoutPanel5.Name = "tableLayoutPanel5";
      tableLayoutPanel5.RowCount = 8;
      tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 19.9995346F));
      tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 6.66667938F));
      tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 13.33569F));
      tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 6.666013F));
      tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 13.3330231F));
      tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 13.3330231F));
      tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 13.3330231F));
      tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 13.3330231F));
      tableLayoutPanel5.Size = new System.Drawing.Size(368, 713);
      tableLayoutPanel5.TabIndex = 3;
      // 
      // label6
      // 
      label6.AutoSize = true;
      label6.Location = new System.Drawing.Point(3, 521);
      label6.Name = "label6";
      label6.Size = new System.Drawing.Size(79, 15);
      label6.TabIndex = 6;
      label6.Text = "Image Height";
      // 
      // label5
      // 
      label5.AutoSize = true;
      label5.Location = new System.Drawing.Point(3, 331);
      label5.Name = "label5";
      label5.Size = new System.Drawing.Size(75, 15);
      label5.TabIndex = 5;
      label5.Text = "Image Width";
      // 
      // imageWidth
      // 
      imageWidth.Location = new System.Drawing.Point(2, 428);
      imageWidth.Margin = new Padding(2);
      imageWidth.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
      imageWidth.Name = "imageWidth";
      imageWidth.Size = new System.Drawing.Size(126, 23);
      imageWidth.TabIndex = 0;
      imageWidth.Value = new decimal(new int[] { 384, 0, 0, 0 });
      imageWidth.ValueChanged += imageProperty_ValueChanged;
      // 
      // imageHeight
      // 
      imageHeight.Location = new System.Drawing.Point(2, 618);
      imageHeight.Margin = new Padding(2);
      imageHeight.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
      imageHeight.Name = "imageHeight";
      imageHeight.Size = new System.Drawing.Size(126, 23);
      imageHeight.TabIndex = 1;
      imageHeight.Value = new decimal(new int[] { 240, 0, 0, 0 });
      imageHeight.ValueChanged += imageProperty_ValueChanged;
      // 
      // grpImageType
      // 
      grpImageType.Controls.Add(radFont);
      grpImageType.Controls.Add(radRle3);
      grpImageType.Controls.Add(radClut7);
      grpImageType.Controls.Add(radClut4);
      grpImageType.Controls.Add(radRle7);
      grpImageType.Controls.Add(radDyuv);
      grpImageType.Dock = DockStyle.Fill;
      grpImageType.Location = new System.Drawing.Point(2, 2);
      grpImageType.Margin = new Padding(2);
      grpImageType.Name = "grpImageType";
      grpImageType.Padding = new Padding(2);
      grpImageType.Size = new System.Drawing.Size(364, 138);
      grpImageType.TabIndex = 2;
      grpImageType.TabStop = false;
      grpImageType.Text = "Image Type";
      // 
      // radFont
      // 
      radFont.AutoSize = true;
      radFont.Location = new System.Drawing.Point(4, 123);
      radFont.Margin = new Padding(2);
      radFont.Name = "radFont";
      radFont.Size = new System.Drawing.Size(49, 19);
      radFont.TabIndex = 5;
      radFont.Text = "Font";
      radFont.UseVisualStyleBackColor = true;
      // 
      // radRle3
      // 
      radRle3.AutoSize = true;
      radRle3.Location = new System.Drawing.Point(4, 102);
      radRle3.Margin = new Padding(2);
      radRle3.Name = "radRle3";
      radRle3.Size = new System.Drawing.Size(50, 19);
      radRle3.TabIndex = 4;
      radRle3.Text = "RLE3";
      radRle3.UseVisualStyleBackColor = true;
      // 
      // radClut7
      // 
      radClut7.AutoSize = true;
      radClut7.Location = new System.Drawing.Point(4, 39);
      radClut7.Margin = new Padding(2);
      radClut7.Name = "radClut7";
      radClut7.Size = new System.Drawing.Size(59, 19);
      radClut7.TabIndex = 3;
      radClut7.Text = "CLUT7";
      radClut7.UseVisualStyleBackColor = true;
      // 
      // radClut4
      // 
      radClut4.AutoSize = true;
      radClut4.Location = new System.Drawing.Point(4, 60);
      radClut4.Margin = new Padding(2);
      radClut4.Name = "radClut4";
      radClut4.Size = new System.Drawing.Size(59, 19);
      radClut4.TabIndex = 2;
      radClut4.Text = "CLUT4";
      radClut4.UseVisualStyleBackColor = true;
      // 
      // radRle7
      // 
      radRle7.AutoSize = true;
      radRle7.Checked = true;
      radRle7.Location = new System.Drawing.Point(4, 81);
      radRle7.Margin = new Padding(2);
      radRle7.Name = "radRle7";
      radRle7.Size = new System.Drawing.Size(50, 19);
      radRle7.TabIndex = 1;
      radRle7.TabStop = true;
      radRle7.Text = "RLE7";
      radRle7.UseVisualStyleBackColor = true;
      // 
      // radDyuv
      // 
      radDyuv.AutoSize = true;
      radDyuv.Location = new System.Drawing.Point(4, 18);
      radDyuv.Margin = new Padding(2);
      radDyuv.Name = "radDyuv";
      radDyuv.Size = new System.Drawing.Size(55, 19);
      radDyuv.TabIndex = 0;
      radDyuv.Text = "DYUV";
      radDyuv.UseVisualStyleBackColor = true;
      // 
      // tableLayoutPanel6
      // 
      tableLayoutPanel6.ColumnCount = 1;
      tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
      tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 14F));
      tableLayoutPanel6.Controls.Add(label4, 0, 0);
      tableLayoutPanel6.Controls.Add(imageLength, 0, 1);
      tableLayoutPanel6.Dock = DockStyle.Fill;
      tableLayoutPanel6.Location = new System.Drawing.Point(2, 286);
      tableLayoutPanel6.Margin = new Padding(2);
      tableLayoutPanel6.Name = "tableLayoutPanel6";
      tableLayoutPanel6.RowCount = 2;
      tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
      tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
      tableLayoutPanel6.Size = new System.Drawing.Size(364, 43);
      tableLayoutPanel6.TabIndex = 3;
      // 
      // label4
      // 
      label4.AutoSize = true;
      label4.Location = new System.Drawing.Point(3, 0);
      label4.Name = "label4";
      label4.Size = new System.Drawing.Size(119, 15);
      label4.TabIndex = 5;
      label4.Text = "Image Length (bytes)";
      // 
      // imageLength
      // 
      imageLength.Location = new System.Drawing.Point(2, 23);
      imageLength.Margin = new Padding(2);
      imageLength.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
      imageLength.Name = "imageLength";
      imageLength.Size = new System.Drawing.Size(126, 23);
      imageLength.TabIndex = 1;
      imageLength.Value = new decimal(new int[] { 99999999, 0, 0, 0 });
      // 
      // imageOffset
      // 
      imageOffset.Location = new System.Drawing.Point(2, 191);
      imageOffset.Margin = new Padding(2);
      imageOffset.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
      imageOffset.Name = "imageOffset";
      imageOffset.Size = new System.Drawing.Size(126, 23);
      imageOffset.TabIndex = 0;
      imageOffset.ValueChanged += imageProperty_ValueChanged;
      // 
      // label3
      // 
      label3.AutoSize = true;
      label3.Location = new System.Drawing.Point(3, 142);
      label3.Name = "label3";
      label3.Size = new System.Drawing.Size(75, 15);
      label3.TabIndex = 4;
      label3.Text = "Image Offset";
      // 
      // palettePicBox
      // 
      palettePicBox.Location = new System.Drawing.Point(374, 2);
      palettePicBox.Margin = new Padding(2);
      palettePicBox.Name = "palettePicBox";
      palettePicBox.Size = new System.Drawing.Size(1009, 235);
      palettePicBox.TabIndex = 1;
      palettePicBox.TabStop = false;
      palettePicBox.Click += palettePicBox_Click;
      // 
      // panel1
      // 
      panel1.AutoScroll = true;
      panel1.AutoSize = true;
      panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
      panel1.Controls.Add(imagePicBox);
      panel1.Dock = DockStyle.Fill;
      panel1.Location = new System.Drawing.Point(375, 242);
      panel1.Name = "panel1";
      panel1.Size = new System.Drawing.Size(1477, 711);
      panel1.TabIndex = 4;
      // 
      // imagePicBox
      // 
      imagePicBox.BackgroundImageLayout = ImageLayout.Stretch;
      imagePicBox.Location = new System.Drawing.Point(0, 0);
      imagePicBox.Margin = new Padding(2);
      imagePicBox.Name = "imagePicBox";
      imagePicBox.Size = new System.Drawing.Size(1477, 732);
      imagePicBox.SizeMode = PictureBoxSizeMode.StretchImage;
      imagePicBox.TabIndex = 3;
      imagePicBox.TabStop = false;
      imagePicBox.Click += imagePicBox_Click;
      // 
      // openFileDialog1
      // 
      openFileDialog1.FileName = "openFileDialog1";
      // 
      // Form1
      // 
      AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      AutoScroll = true;
      AutoSize = true;
      AutoSizeMode = AutoSizeMode.GrowAndShrink;
      ClientSize = new System.Drawing.Size(1859, 1066);
      Controls.Add(tableLayoutPanel1);
      Margin = new Padding(2);
      Name = "Form1";
      Text = "Form1";
      tableLayoutPanel1.ResumeLayout(false);
      tableLayoutPanel1.PerformLayout();
      tableLayoutPanel2.ResumeLayout(false);
      tableLayoutPanel2.PerformLayout();
      tableLayoutPanel3.ResumeLayout(false);
      tableLayoutPanel3.PerformLayout();
      tableLayoutPanel4.ResumeLayout(false);
      tableLayoutPanel4.PerformLayout();
      grpPaletteType.ResumeLayout(false);
      grpPaletteType.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)paletteLength).EndInit();
      ((System.ComponentModel.ISupportInitialize)paletteOffset).EndInit();
      tableLayoutPanel5.ResumeLayout(false);
      tableLayoutPanel5.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)imageWidth).EndInit();
      ((System.ComponentModel.ISupportInitialize)imageHeight).EndInit();
      grpImageType.ResumeLayout(false);
      grpImageType.PerformLayout();
      tableLayoutPanel6.ResumeLayout(false);
      tableLayoutPanel6.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)imageLength).EndInit();
      ((System.ComponentModel.ISupportInitialize)imageOffset).EndInit();
      ((System.ComponentModel.ISupportInitialize)palettePicBox).EndInit();
      panel1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)imagePicBox).EndInit();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private TableLayoutPanel tableLayoutPanel1;
    private TableLayoutPanel tableLayoutPanel2;
    private TableLayoutPanel tableLayoutPanel3;
    private TableLayoutPanel tableLayoutPanel4;
    private NumericUpDown paletteOffset;
    private NumericUpDown paletteLength;
    private GroupBox grpPaletteType;
    private RadioButton radRgb;
    private PictureBox palettePicBox;
    private TableLayoutPanel tableLayoutPanel5;
    private NumericUpDown imageLength;
    private NumericUpDown imageOffset;
    private RadioButton radIndexed;
    private GroupBox grpImageType;
    private RadioButton radRle3;
    private RadioButton radClut7;
    private RadioButton radClut4;
    private RadioButton radRle7;
    private RadioButton radDyuv;
    private Button btnLoadPalette;
    private Button btnLoadImage;
    private Button btnParseGrayscale;
    private Button btnParseImage;
    private Button btnParsePalette;
    private OpenFileDialog openFileDialog1;
    private TableLayoutPanel tableLayoutPanel6;
    private NumericUpDown imageHeight;
    private NumericUpDown imageWidth;
    private RadioButton radFont;
    private Label label1;
    private Label label2;
    private Label label6;
    private Label label5;
    private Label label4;
    private Label label3;
    private RadioButton radCLUT;
    private Button btnPaletteFolder;
    private FolderBrowserDialog folderBrowserDialog1;
    private ComboBox lstPalettes;
    private Panel panel1;
    private PictureBox imagePicBox;
    private CheckBox chkUseTransparency;
    private CheckBox chkRLEGif;
    private ComboBox cmbProcessList;
    private Button btnGetCdiMem;
  }
}