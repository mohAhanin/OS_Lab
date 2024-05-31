using System;
using System.Windows.Forms;

namespace CafeManagementSystem2
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form4()); // Change this line to use Form4
        }
    }
}
