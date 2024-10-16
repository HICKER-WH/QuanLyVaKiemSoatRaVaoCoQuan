using Project01.Controls;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Project01
{
  internal static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      string procName = Process.GetCurrentProcess().ProcessName;

      Process[] processes = Process.GetProcessesByName(procName);
      if (processes.Length > 1)
      {
        return;
      }

      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      //Application.Run(new FrmMain());
      AppCore.Ins.Init();
    }
  }
}
