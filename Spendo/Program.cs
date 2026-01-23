using System;
using System.Windows.Forms;

namespace Spendo
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (SplashForm splash = new SplashForm())
            {
                splash.ShowDialog();

            }

            Application.Run(new Form1());
        }
    }
}
