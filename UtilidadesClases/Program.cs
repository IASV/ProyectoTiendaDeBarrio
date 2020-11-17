using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilidadesClases;

namespace UtilidadesGestionArchivo
{
    class Program
    {
        static void Main(string[] args)
        {
            //FormCliente form = new FormCliente();
            //form.ShowDialog();

            //FormVendedor vendedor = new FormVendedor();
            //vendedor.ShowDialog();

            FormProducto producto = new FormProducto();
            producto.ShowDialog();

        }
    }
}
