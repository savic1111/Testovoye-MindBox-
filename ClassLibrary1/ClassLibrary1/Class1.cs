using System;
using System.Windows.Forms;

namespace ClassLibrary1
{
    public class Class1
    {
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            Application.Run(new Form2());
        }
    }

    
}
