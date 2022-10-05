using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BashNeft.CSCource2022.TestAppFr
{

    internal class Program
    {
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern int MessageBox(IntPtr hWnd, String text, String caption, uint type);

        static void Main(string[] args)
        {
            //lhhhhhhh
            MessageBox(IntPtr.Zero, "Hello World!", "Hello Dialog", 0);
        }
    }
}
