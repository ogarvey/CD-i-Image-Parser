using Memory;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static CD_i_Image_Parser.Helpers.MemoryHelper;

namespace CD_i_Image_Parser.Helpers
{
  public class MemoryHelper
  {
    [DllImport("kernel32.dll")]
    public static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

    [DllImport("kernel32.dll")]
    public static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesRead);

    [DllImport("kernel32.dll")]
    public static extern bool CloseHandle(IntPtr hObject);

    [DllImport("kernel32.dll")]
    static extern void GetSystemInfo(out SystemInfo lpSystemInfo);

    [DllImport("kernel32.dll", SetLastError = true)]
    static extern int VirtualQueryEx(IntPtr hProcess, IntPtr lpAddress, out MEMORY_BASIC_INFORMATION lpBuffer, int dwLength);

    const int PROCESS_QUERY_INFORMATION = 0x0400;
    const int MEM_COMMIT = 0x00001000;
    const int PAGE_READWRITE = 0x04;
    const int PROCESS_WM_READ = 0x0010;
    static Dictionary<IntPtr, byte[]> Regions = new Dictionary<IntPtr, byte[]>();
    static List<SearchResult> _results = new List<SearchResult>();

    static Mem MemLib = new Mem();

    // REQUIRED STRUCTS
    [StructLayout(LayoutKind.Sequential)]
    public struct SystemInfo
    {
      public ProcessorArchitecture ProcessorArchitecture;
      public uint PageSize;
      public IntPtr MinimumApplicationAddress;
      public IntPtr MaximumApplicationAddress;
      public IntPtr ActiveProcessorMask;
      public uint NumberOfProcessors;
      public uint ProcessorType;
      public uint AllocationGranularity;
      public ushort ProcessorLevel;
      public ushort ProcessorRevision;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MEMORY_BASIC_INFORMATION
    {
      public IntPtr BaseAddress;
      public IntPtr AllocationBase;
      public uint AllocationProtect;
      public IntPtr RegionSize;
      public uint State;
      public uint Protect;
      public uint Type;
    }

    public static List<Process> GetRunningProcesses()
    {
      var list = new List<Process>();

      list.AddRange(Process.GetProcesses());

      return list;
    }

    public static Process? GetCDiEmuProcess()
    {
      var processes = GetRunningProcesses();
      var cdiEmu = processes.Where(p => p.ProcessName.Contains("wcdiemu")).First();
      return cdiEmu;
    }
    public static async void FindProcessMemory(int processId)
    {
      MemLib.OpenProcess(processId);
      IEnumerable<long> AoBScanResults = await MemLib.AoBScan(0x00000000, 0x7fffffffffff, "9A DC 22 00 1A D2 06 00 24 CF 06 00 64 CE 06 00", true, true);
      long SingleAoBScanResult = AoBScanResults.FirstOrDefault();
      MessageBox.Show("Our First Found Address is " + SingleAoBScanResult);

      AoBScanResults = await MemLib.AoBScan(0x0, 0x7fffffffffff, "00 06 CE 64 00 06 CF 24 00 06 D2 1A 00 22 DC 99", true, true);
      SingleAoBScanResult = AoBScanResults.FirstOrDefault();

      // pop up message box that shows our first result
      MessageBox.Show("Our First Found Address is " + SingleAoBScanResult);
    }

    public static byte[] GetCDiEmuMemory()
    {
      var process= GetCDiEmuProcess();
      if (process == null) return new byte[] { };
      FindProcessMemory(process.Id);
      IntPtr processHandle = OpenProcess(PROCESS_WM_READ, false, process.Id);

      // Define the memory address and buffer
      IntPtr address = new IntPtr(0xb24000); // Replace with the actual address
      byte[] buffer = new byte[ushort.MaxValue]; // Size depends on the data you want to read
      int bytesRead = 0;

      // Read memory
      ReadProcessMemory(processHandle, address, buffer, buffer.Length, ref bytesRead);


      // Close the handle
      CloseHandle(processHandle);

      MessageBox.Show($"Read {bytesRead} bytes of CDiEmu memory");

      return buffer;
    }
  }
}
