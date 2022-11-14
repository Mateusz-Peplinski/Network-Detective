using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Network_Detective.src.processDumperClass
{
    public partial class processDumperForm : Form
    {
        public processDumperForm()
        {
            InitializeComponent();
            displayRunningProcesses();
        }

        private void displayRunningProcesses()
        {
            Process[] processlist = Process.GetProcesses();
            foreach (Process theprocess in processlist)
            {
                processListBox.Items.Add(String.Format("PID: {0,-10}  {1, 20}", theprocess.Id, theprocess.ProcessName));      
            }
        }

        private void startDump_Click(object sender, EventArgs e)
        {
            dumpStatusTextBox.Clear();
            fileSaveBox.Clear();

            var folderBrowser = new FolderBrowserDialog();
            Process[] processlist = Process.GetProcesses();

            DialogResult result = folderBrowser.ShowDialog();
            if (result == DialogResult.OK)
            {
                string folderName = folderBrowser.SelectedPath;

                String processforDumping = (string)processListBox.SelectedItem;
                if (processListBox.SelectedItem == null)
                {
                    MessageBox.Show("Please Select a Process \nto dump","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                foreach (Process theprocess in processlist)
                {
                    String verifyProcess = String.Format("PID: {0,-10}  {1, 20}", theprocess.Id, theprocess.ProcessName);

                    if (processforDumping == verifyProcess)
                    {
                        createDump(theprocess.Handle, (uint)theprocess.Id, theprocess.ProcessName, folderName);
                        break;
                    }
                }
            }
        }

        [DllImport("dbghelp.dll", SetLastError = true)]
        static extern bool MiniDumpWriteDump(IntPtr hProcess, uint processId, SafeHandle hFile, uint dumpType, IntPtr expParam, IntPtr userStreamParam, IntPtr callbackParam);

        public void createDump(IntPtr processhandle, uint processId, string processname, String saveLocation)
        {
            try
            {
                bool status;
                
                string filename = saveLocation + processname + "_" + processId + ".dmp";

                 
                using (FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.ReadWrite, FileShare.Write))
                {
                    //call MiniDumpWriteDump from the .dll with correct parameters returns bool value 
                    status = MiniDumpWriteDump(processhandle, processId, fs.SafeFileHandle, (uint)2, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero);
                }
                
                if (status)
                {
                    dumpStatusTextBox.Text += "SUCCESS";

                    
                    fileSaveBox.Text += $"{processname} process dump saved at {saveLocation}";
                }
                
                else
                {
                    dumpStatusTextBox.Text += "ERROR - Cannot Dump the process";
                    MessageBox.Show("Note: Trying to dump SYSTEM level process\n(eg: system, registry, session manager)\nmay cause Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static class MINIDUMP_TYPE
        {
            public const int MiniDumpNormal = 0x00000000;
            public const int MiniDumpWithDataSegs = 0x00000001;
            public const int MiniDumpWithFullMemory = 0x00000002;
            public const int MiniDumpWithHandleData = 0x00000004;
            public const int MiniDumpFilterMemory = 0x00000008;
            public const int MiniDumpScanMemory = 0x00000010;
            public const int MiniDumpWithUnloadedModules = 0x00000020;
            public const int MiniDumpWithIndirectlyReferencedMemory = 0x00000040;
            public const int MiniDumpFilterModulePaths = 0x00000080;
            public const int MiniDumpWithProcessThreadData = 0x00000100;
            public const int MiniDumpWithPrivateReadWriteMemory = 0x00000200;
            public const int MiniDumpWithoutOptionalData = 0x00000400;
            public const int MiniDumpWithFullMemoryInfo = 0x00000800;
            public const int MiniDumpWithThreadInfo = 0x00001000;
            public const int MiniDumpWithCodeSegs = 0x00002000;
        }
    }
}
