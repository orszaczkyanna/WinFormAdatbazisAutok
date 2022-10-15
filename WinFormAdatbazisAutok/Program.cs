using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormAdatbazisAutok
{
    static class Program
    {
        public static FormNyito formNyito = null;
        public static Adatbazis adatbazis = new Adatbazis();


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            formNyito = new FormNyito();            
            
            Application.Run(formNyito);
        }
    }
}
