using System.Runtime.InteropServices;

namespace BashNeft.CSCource2022.TestAppCore
{
    internal class Program
    {
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
         public static extern int MessageBox(IntPtr hWnd, String text, String caption, uint type);   
        static void Main(string[] args)
        {
        //--  gggggg
        MessageBox(IntPtr.Zero, "Hello World!", "Hello Dialog", 0);
        Console.WriteLine("Hello, World!");
        }
    }
}