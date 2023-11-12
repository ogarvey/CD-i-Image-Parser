using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGLibCDi.Models
{
  public class CdiFile
  {
    public string FileName { get; private set; }
    public string FilePath { get; private set; }
    public string FileExtension { get; private set; }
    public string FileSize { get; private set; }
    public string FileSizeBytes { get; private set; }
    public List<CdiSector> Sectors { get; private set; }
    public int SectorCount { get => Sectors.Count ; }
    private byte[] _cdiFileData { get; set; }

    
  }
}
