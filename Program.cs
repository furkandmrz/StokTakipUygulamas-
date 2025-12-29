
using System;
using System.Windows.Forms;

namespace StokTakipUygulamasý
    public static class Program
    {
        [STAThread]
        public static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}

