using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilidadesClases;
using UtilidadesGestionArchivo;
using Inventario;
using Factura;
using Venta;

namespace Compras
{
    public partial class FormCompras : Form
    {
        public FormCompras()
        {
            InitializeComponent();
        }

        private Cliente Cliente { get; set; }
        private Vendedor Vendedor { get; set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cliente = null;
            Vendedor = null;
            //labelMessageInfoAlert.Text = "";
            GestionArchivo gs = new GestionArchivo();
            gs.Duplicate(Producto.path, "Files/CompraTemp.txt");
            ImprimirData(panelListProducts, "Files/CompraTemp.txt", Producto.Titles).Show();
            ImprimirData(panelListBuy, boxSearch.PathLista, new string[] { "Nombre", "Imformación" }).Show();
        }

        private void boxSearch_Load(object sender, EventArgs e)
        {
            boxSearch.pathDataBase = Producto.path;
            boxSearch.Titles = Producto.Titles;
            boxSearch.SearchFor = "Nombre";
            boxSearch.panel = panelListProducts;
        }

        private void panelListProducts_Paint(object sender, PaintEventArgs e)
        {

        }

        private FormImprimir ImprimirData(Panel panel, string path, string[] Titles)
        {

            FormImprimir imprimir = new FormImprimir();
            imprimir.TopLevel = false;

            GestionArchivo gs = new GestionArchivo();

            gs.Path = path;
            gs.CreateFile();

            imprimir.Size = panel.Size;

            panel.Controls.Add(imprimir);

            imprimir.TitleWindow = "Lista de Items";
            imprimir.DataInput = gs.GetDataString();
            imprimir.Titles = Titles;

            return imprimir;
        }

        private void boxAdd_Load(object sender, EventArgs e)
        {
            GestionArchivo gs = new GestionArchivo(boxAdd.PathLista);
            gs.DeleteFile();
            boxAdd.Titles = new string[] { "Nombre", "Infomación" };
            boxAdd.SearchFor = "Nombre";
            boxAdd.panel = panelListBuy;
            boxAdd.DeleteFile();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelListBuy_ControlAdded(object sender, ControlEventArgs e)
        {
            labelCantidad.Text = boxAdd.CantidadItem.ToString();
            labelSubtotal.Text = boxAdd.SubTotal.ToString();
            labelIVA.Text = "19%";
            labelTotal.Text = boxAdd.Total.ToString();
            
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            FormFacturaImprimir factura = new FormFacturaImprimir();
            factura.Show();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            //string cedClient = textBoxCedClient.Text;
            //if (cedClient != "")
            //{
            //    Cliente = Cliente.SearchCed(Convert.ToInt64(cedClient));
            //    if (Cliente != null)
            //    {
            //        labelMessageInfoAlert.BackColor = Color.Green;
            //        labelMessageInfoAlert.Text = "¡Búsqueda exitosa!";
            //        panelDataClient.Visible = false;
            //        panel1.Visible = true;
            //    }
            //    else
            //    {
            //        labelMessageInfoAlert.BackColor = Color.Red;
            //        labelMessageInfoAlert.Text = "¡Cliente no encontrado!";
            //    }
            //}
        }
    }
}
