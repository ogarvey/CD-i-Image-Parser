using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Encoder = System.Drawing.Imaging.Encoder;

namespace CD_i_Image_Parser.Helpers
{
  public static class Utilities
  {
    public static RadioButton GetCheckedRadioButton(GroupBox groupBox)
    {
      return groupBox.Controls.OfType<RadioButton>().FirstOrDefault(radio => radio.Checked);
    }
    public static bool MatchesSequence(BinaryReader reader, byte[] sequence)
    {
      for (int i = 0; i < sequence.Length; i++)
      {
        byte nextByte = reader.ReadByte();
        if (nextByte != sequence[i])
        {
          // rewind to the start of the sequence (including the byte we just read)
          reader.BaseStream.Position -= i + 1;
          return false;
        }
      }

      return true;
    }
    public static IEnumerable<(T item, int index)> WithIndex<T>(this IEnumerable<T> source)
    {
      return source.Select((item, index) => (item, index));
    }

    public static Bitmap CreateImage(byte[] imageBin, List<Color> colors, int Width, int Height)
    {
      // convert each byte of imageBin to an int and use that as an index into the colors array to create a 384 pixel wide image
      var image = new Bitmap(Width, Height);
      var graphics = Graphics.FromImage(image);
      var brush = new SolidBrush(Color.Black);
      var x = 0;
      var y = 0;
      var width = 1;
      var height = 1;
      foreach (var b in imageBin)
      {
        if (b >= colors.Count)
        {
          MessageBox.Show("Palette does not contain enough colours");
          return image;
        }
        brush.Color = colors[b];
        graphics.FillRectangle(brush, x, y, width, height);
        x += width;
        if (x >= Width)
        {
          x = 0;
          y += height;
        }
      }

      return image;

    }

    public static byte? PeekByte(this BinaryReader reader)
    {
      if (reader.BaseStream.Position >= reader.BaseStream.Length)
      {
        return null;
      }

      byte nextByte = reader.ReadByte();
      reader.BaseStream.Seek(-1, SeekOrigin.Current);
      return nextByte;
    }

  }
}
