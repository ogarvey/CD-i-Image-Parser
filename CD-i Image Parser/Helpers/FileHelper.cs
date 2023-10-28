using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD_i_Image_Parser.Helpers
{
  public static class FileHelper
  {
    public static List<byte[]> SplitBinaryFileByNullBytes(string filePath)
    {
      var chunks = new List<byte[]>();
      var buffer = new List<byte>();
      using (var fs = new FileStream(filePath, FileMode.Open))
      {
        int currentByte = 0;
        bool isPreviousByteZero = false;
        while ((currentByte = fs.ReadByte()) != -1)
        {
          if (currentByte == 0x00)
          {
            if (isPreviousByteZero)
            {
              // remove the previous 0x00 byte from buffer
              buffer.RemoveAt(buffer.Count - 1);

              // add chunk to list and clear buffer
              if (buffer.Count > 0)
              {
                if (buffer.Last() != 0x00) buffer.Add(0x00);
                chunks.Add(buffer.ToArray());
              }
              buffer.Clear();

              // skip the rest of the zeros
              while ((currentByte = fs.ReadByte()) == 0x00) { }
              if (currentByte == -1) break;
            }
            else
            {
              isPreviousByteZero = true;
            }
          }
          else
          {
            isPreviousByteZero = false;
          }

          buffer.Add((byte)currentByte);
        }
        if (buffer.Count > 0)
        {
          while (buffer.Count > 0 && buffer.Last() == 0x00)
          {
            buffer.RemoveAt(buffer.Count - 1);
          }
          if (buffer.Count > 0)
          {
            if (buffer.Last() != 0x00) buffer.Add(0x00);
            chunks.Add(buffer.ToArray());
          }
        }
      }
      return chunks;
    }
 
    public static List<byte[]> SplitBinaryFileBy0xFFFF(string filePath)
    {
      List<byte[]> chunks = new List<byte[]>();
      using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
      {
        List<byte> currentChunk = new List<byte>();
        byte? previousByte = null;

        while (reader.BaseStream.Position != reader.BaseStream.Length)
        {
          byte currentByte = reader.ReadByte();

          if (previousByte == 0xFF && currentByte == 0xFF)
          {

            // Skip the 0xFF 0xFF bytes
            currentChunk.RemoveAt(currentChunk.Count - 1);

            // Remove trailing 0x00 bytes and add chunk to list
            while (currentChunk.Count > 0 && currentChunk.Last() == 0x00)
            {
              currentChunk.RemoveAt(currentChunk.Count - 1);
            }
            // Remove trailing 0x00 bytes and add chunk to list
            while (currentChunk.Count > 0 && currentChunk.First() == 0x00)
            {
              currentChunk.RemoveAt(0);
            }
            if (currentChunk.Count > 0)
            {
              if (currentChunk.Last() == 0x80) currentChunk.Add(0x00);
              chunks.Add(currentChunk.ToArray());
            }
            currentChunk.Clear();
          }
          else
          {
            currentChunk.Add(currentByte);
          }

          previousByte = currentByte;
        }
      }

      return chunks;
    }

    public static List<byte[]> SplitBinaryFileIntoChunks(string filePath, byte[] separator, bool removeTrailing0x00, bool removeLeading0x00)
    {
      List<byte[]> chunks = new List<byte[]>();
      List<byte> currentChunk = new List<byte>();

      using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
      {
        Queue<byte> separatorQueue = new Queue<byte>(separator);
        Queue<byte> matchingQueue = new Queue<byte>();

        while (reader.BaseStream.Position != reader.BaseStream.Length)
        {
          byte currentByte = reader.ReadByte();

          // Check if currentByte matches the next byte in the separator sequence
          if (separatorQueue.Count > 0 && currentByte == separatorQueue.Peek())
          {
            matchingQueue.Enqueue(currentByte);
            separatorQueue.Dequeue();

            // If we've matched the entire separator sequence
            if (!separatorQueue.Any())
            {
              if (currentChunk.Count == 0) continue;
              // Remove the separator sequence from the end of the current chunk
              currentChunk.RemoveRange(currentChunk.Count - separator.Length + 1, separator.Length - 1);

              if (removeTrailing0x00)
              {
                // Remove trailing 0x00 bytes
                while (currentChunk.Count > 0 && currentChunk.Last() == 0x00)
                {
                  currentChunk.RemoveAt(currentChunk.Count - 1);
                }
              }

              if (removeLeading0x00)
              {
                // Remove leading 0x00 bytes
                while (currentChunk.Count > 0 && currentChunk.First() == 0x00)
                {
                  currentChunk.RemoveAt(0);
                }
              }

              // Add chunk to list and start a new one

              if (currentChunk.Count > 0)
              {
                if (currentChunk.Last() == 0x80) currentChunk.Add(0x00);
                chunks.Add(currentChunk.ToArray());
              }
              currentChunk.Clear();

              // Reset the separator queue
              separatorQueue = new Queue<byte>(separator);
            }
          }
          else
          {
            // If we were in the middle of matching a separator sequence, we need to add the matched bytes back into the chunk
            while (matchingQueue.Any())
            {
              currentChunk.Add(matchingQueue.Dequeue());
            }

            // Reset the separator queue
            separatorQueue = new Queue<byte>(separator);

            // Add currentByte to chunk
            currentChunk.Add(currentByte);
          }
        }
      }

      // Add any remaining bytes as the last chunk
      if (currentChunk.Any())
      {
        chunks.Add(currentChunk.ToArray());
      }

      return chunks;
    }
  }
}
