using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilidadesGestionArchivo;
using UtilidadesClases;
using Venta;
using Inventario;



namespace Factura
{

    public partial class FormFacturaImprimir : Form
    {
        public FormFacturaImprimir()
        {
            InitializeComponent();
        }

        public Factura factura { get; set; }
        public Cliente Cliente { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }

        public string Telefono { get; set; }
        public static string[] Titles = { "Cantidad", "Descripción", "Precio", "Total" };
        private void FormFactura_Load(object sender, EventArgs e)
        {
            Factura.LoadList();

            factura = new Factura();

            //textBoxCliente.Text = Cliente.Nombre;
            //textBoxDireccion.Text = Cliente.Direccion;
            //textBoxTelefono.Text = Cliente.Telefono.ToString();
            //textBoxNumeroFactura.Text = factura.IdFactura.ToString();

            dateTimePickerFechaFactura.Value = DateTime.Now;

            ImprimirData(panelProductos, "Files/ListaCompra.txt", new string[] {"Nombre", "Información" }).Show();
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
    }
}
