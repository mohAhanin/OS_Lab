using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Diagnostics;


namespace Program
{
    class Program{
        static void Main(string[] args)
        {

            Process[] processList = Process.GetProcesses();
            foreach (Process p in processList)
            {
                // Console.WriteLine(p.Id + "\t" + p.ProcessName);
            }
            // Console.WriteLine(processList.Length);

            // mouse_events

            // mouse_event((int)MouseEventFlags.LeftDown, 0, 0, 0, 0);
            // mouse_event((int)MouseEventFlags.LeftUp, 0, 0, 0, 0);
            // mouse_event((int)MouseEventFlags.RightDown, 0, 0, 0, 0);
            // mouse_event((int)MouseEventFlags.RightUp, 0, 0, 0, 0);
            mouse_event((int)MouseEventFlags.MiddleDown, 0, 0, 0, 0);
            mouse_event((int)MouseEventFlags.MiddleUp, 0, 0, 0, 0);
            mouse_event((int)MouseEventFlags.MiddleUp, 0, 0, 0, 0);
            mouse_event((int)MouseEventFlags.MiddleUp, 0, 0, 0, 0);



            
        }   

        [Flags]
        public enum MouseEventFlags{
            RightDown = 0x00000008,
            RightUp = 0x00000010,
            LeftDown = 0x00000002,
            LeftUp = 0x00000004,
            MiddleDown = 0x00000020,
            MiddleUp = 0x00000040,

        }

        [DllImport("user32.dll")]
        private static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

    }
    
}