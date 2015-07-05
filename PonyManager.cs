using NAudio.CoreAudioApi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace PonyDancer
{
    public partial class PonyManager : Form
    {
        public struct Rect
        {
            public int Left { get; set; }
            public int Top { get; set; }
            public int Right { get; set; }
            public int Bottom { get; set; }
        }

        /* START DLL IMPORTS */
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr FindWindow(string strClassName, string strWindowName);

        [DllImport("user32.dll")]
        public static extern bool GetWindowRect(IntPtr hwnd, ref Rect rectangle);
        /* END DLL IMPORTS */

        MMDeviceEnumerator devEnum = new MMDeviceEnumerator();
        MMDevice defaultDevice;
        private DancingPony pForm;

        private bool debug = false;

        private Process hangOnWindowProcess = null;

        public PonyManager()
        {
            InitializeComponent();
            defaultDevice = devEnum.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);
            timer1.Start();
            pForm = new DancingPony();
            pForm.Show();
            notifier.Visible = true;
            if (debug)
            {
                AllocConsole();
            }
            InitializeWindows();
        }

        private void InitializeWindows()
        {
            Process[] processes = Process.GetProcesses();

            for (int i = 0; i < processes.Length; i++)
            {
                Process process = processes[i];
                if (!String.IsNullOrEmpty(process.MainWindowTitle))
                {
                    windowBox.Items.Add(new Window(process));
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int volume = (int) (defaultDevice.AudioMeterInformation.MasterPeakValue * 100);
            progressBarEx1.Value = volume;
            if (volume > 70)
            {
                progressBarEx1.ForeColor = Color.Red;
                pForm.SetDancing();
            }
            else if (volume > 30)
            {
                progressBarEx1.ForeColor = Color.Yellow;
                pForm.SetDancing();
            }
            else
            {
                progressBarEx1.ForeColor = Color.LightGreen;
                pForm.SetIdle();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            notifier.ShowBalloonTip(2000, "Dancing Ponies", "Click here to bring up the control panel.", ToolTipIcon.Info);
        }

        private void notifier_MouseClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }

        private void posManager_Tick(object sender, EventArgs e)
        {
            if (hangOnWindowProcess != null)
            {
                Rect processWindow = new Rect();
                GetWindowRect(hangOnWindowProcess.MainWindowHandle, ref processWindow);
                pForm.SetPosition(new Point(processWindow.Left, processWindow.Top));
            }
        }

        private void windowBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            hangOnWindowProcess = ((Window)windowBox.SelectedItem).GetProcess();
        }

        private void clearWindowButton_Click(object sender, EventArgs e)
        {
            windowBox.Items.Clear();
            InitializeWindows();
            hangOnWindowProcess = null;
        }
    }
}
