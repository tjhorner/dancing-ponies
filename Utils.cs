using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PonyDancer
{
    // yeah, utils... right...
    // by that I mean everything that's kinda useful

    class Utils
    {
        public static int RandomNumber(int min, int max)
        {
            int seed = (int) DateTime.Now.Ticks;
            Random rnd = new Random(seed);
            return rnd.Next(min, max);
        }
    }

    class Window
    {
        public string Title = "Generic Window";
        public string ProcessName = "invalid";
        public int ProcessId = 0;
        private Process Process;

        public Window(Process process)
        {
            this.Title = process.MainWindowTitle;
            this.ProcessName = process.ProcessName;
            this.ProcessId = process.Id;
            this.Process = process;
        }

        public Window(string title, string processName, int processId)
        {
            this.Title = title;
            this.ProcessName = processName;
            this.ProcessId = processId;
            this.Process = null;
        }

        public override string ToString()
        {
            return ProcessName + ": " + Title;
        }

        public Process GetProcess()
        {
            return Process;
        }
    }
}
