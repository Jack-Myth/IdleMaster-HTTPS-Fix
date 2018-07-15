﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Steamworks;

namespace steam_idle
{

    static class Program
    {

        [System.Runtime.InteropServices.DllImportAttribute("kernel32.dll", EntryPoint = "SetProcessWorkingSetSize", ExactSpelling = true, CharSet =
System.Runtime.InteropServices.CharSet.Ansi, SetLastError = true)]
        private static extern int SetProcessWorkingSetSize(IntPtr process, int minimumWorkingSetSize, int maximumWorkingSetSize);

       

        [STAThread]
        static void Main(string[] args)
        {
            try
            {
                long appId;
                if (args.Length == 0)
                {
                    Application.EnableVisualStyles();
                    SetProcessWorkingSetSize(System.Diagnostics.Process.GetCurrentProcess().Handle, -1, -1);
                    Application.Run(new frmMain());
                }
                else
                {
                    appId = long.Parse(args[0]);
                    Environment.SetEnvironmentVariable("SteamAppId", appId.ToString());
                    if (!SteamAPI.Init())
                    {
                        return;
                    }
                    SetProcessWorkingSetSize(System.Diagnostics.Process.GetCurrentProcess().Handle, -1, -1);
                    Application.Run();
                    return;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}