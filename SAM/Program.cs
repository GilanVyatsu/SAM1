using System;
using System.Windows.Forms;

namespace SAM
{
    static class Program
    {
        public static SAMEntities sAM = new SAMEntities();
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormPersonal());
        }
    }
}
