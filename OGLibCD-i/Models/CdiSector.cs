using OGLibCDi.Enums;
using OGLibCDi.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGLibCDi.Models
{
  public class CdiSector
  {
    private const short SECTOR_SIZE = 2352;
    private const byte HEADER_SIZE = 16;
    private const short SUB_HEADER_DATA_SIZE = 4;
    
    private const short DATA_SECTOR_SIZE = 2048;
    private const short VIDEO_SECTOR_SIZE = 2324;
    private const short AUDIO_SECTOR_SIZE = 2304;

    private byte[] _subHeaderData; // 4 bytes, technically but that's only because the 4 bytes are duplicated
    private byte[] _sectorData; // 2352 bytes


    public CodingInfo Coding { get; private set; }
    public CdiSectorType SectorType { get; private set; }

    public CdiSector(byte[] sectorData)
    {
      _sectorData = sectorData;
      _subHeaderData = _sectorData.Skip(HEADER_SIZE).Take(SUB_HEADER_DATA_SIZE).ToArray();
      Coding = new CodingInfo(_subHeaderData[(int)SubHeaderByte.CodingInfo]);
      SectorType = GetSectorType();
    }

    private CdiSectorType GetSectorType()
    {
      var subMode = _subHeaderData[(int)SubHeaderByte.Submode];
      if (subMode.IsBitSet(1))
      {
        return CdiSectorType.Video;
      } else if (subMode.IsBitSet(2))
      {
        return CdiSectorType.Audio;
      } else if (subMode.IsBitSet(3))
      {
        return CdiSectorType.Data;
      } else
      {
        return CdiSectorType.Empty;
      }
    }

    public byte[] GetSectorData()
    {
      var bytes = _sectorData.Skip(HEADER_SIZE + (2 * SUB_HEADER_DATA_SIZE)).ToArray();
      
      switch(SectorType)
      {
        case CdiSectorType.Audio:
          return bytes.Take(AUDIO_SECTOR_SIZE).ToArray();
        case CdiSectorType.Video:
          return bytes.Take(VIDEO_SECTOR_SIZE).ToArray();
        case CdiSectorType.Data:
          return bytes.Take(DATA_SECTOR_SIZE).ToArray();
        default:
          return bytes;
      }
    }
  }
}
