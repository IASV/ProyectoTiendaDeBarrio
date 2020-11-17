using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factura
{
    static class Program
    {
       
        [STAThread]
        static void Main()
        {

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FormFacturaImprimir());

            FormFacturaImprimir Fact = new FormFacturaImprimir();
            Fact.Show();

        }
    }
}
