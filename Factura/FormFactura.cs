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

namespace Factura
{
    public partial class FormFactura : Form
    {
        public FormFactura()
        {
            InitializeComponent();
        }
        
        private void FormFactura_Load(object sender, EventArgs e)
        {
            Factura.LoadList();

            if (Factura.Find(1))
            {
                Factura c = Factura.ListaFactura.ElementAt(0);
                LoadShowinvoice(c);
                ShowPositionID(c);
            }
            else
            {
                labelPositionID.Text = "0 / 0";
            }

            ImprimirData(splitContainer1.Panel2).Show();
        }

        private FormImprimir ImprimirData(Panel panel)
        {

            FormImprimir imprimir = new FormImprimir();
            imprimir.TopLevel = false;

            GestionArchivo gs = new GestionArchivo();

            gs.Path = Factura.path;
            gs.CreateFile();

            panel.Controls.Add(imprimir);

            imprimir.TitleWindow = "Lista de Items";
            imprimir.DataInput = gs.GetDataString();
            imprimir.Titles = Factura.Titles;

            return imprimir;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxIdFactura.Text != "" && textBoxIdVenta.Text != "" && textBoxPrecioFinal.Text != "")
            {

                if (!Factura.Find(Convert.ToInt32(textBoxIdFactura.Text)))
                {

                    Factura v = new Factura();

                    v.IdFactura = Convert.ToInt32(textBoxIdFactura.Text); 
                    v.IdVenta = Convert.ToInt32(textBoxIdVenta.Text);
                    v.precioFinal = Convert.ToInt32(textBoxPrecioFinal.Text);
                    
                    v.Add();

                    if (Factura.Find(v.IdFactura))
                    {
                        splitContainer1.Panel2.Controls.Clear();
                        ImprimirData(splitContainer1.Panel2).Show();
                        MessageBox.Show("Operación éxitosa");
                        labelPositionID.Text = (Factura.ListaFactura.IndexOf(v) + 1).ToString() + " / " + Factura.ListaFactura.Count.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Operación fallida");
                    }
                }
                else
                {
                    MessageBox.Show("La factura ya existe");
                }
            }
            else
            {
                MessageBox.Show("Campo vacio.\n¡Complete el campo!");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (textBoxIdFactura.Text != "" && textBoxIdVenta.Text != "" && textBoxPrecioFinal.Text != "")
            {
                int IdFactura = Convert.ToInt32(textBoxIdFactura.Text);
                if (Factura.Find(IdFactura))
                {
                    Factura c = Factura.Search(IdFactura);
                    var result = MessageBox.Show("¿Desea eliminar la factura " + c.IdFactura, "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        c.Delete();
                        Factura.Delete(c);
                        ShowPositionID(c);
                        CleanBox();
                        splitContainer1.Panel2.Controls.Clear();
                        ImprimirData(splitContainer1.Panel2).Show();
                        MessageBox.Show("Operación éxitosa.");
                    }
                }
                else
                {
                    MessageBox.Show("Operación fallida");
                }
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (textBoxBuscar.Text != "")
            {
                int IdCliente = Convert.ToInt32(textBoxBuscar.Text);
                if (Factura.Find(IdCliente))
                {
                    Factura c = Factura.Search(IdCliente);

                    LoadShowinvoice(c);
                    ShowPositionID(c);
                    Factura.Index = Factura.ListaFactura.IndexOf(c);

                }
                else
                {
                    MessageBox.Show("Cliente no encontrado.");
                }
            }
            else
            {
                MessageBox.Show("Campo vacio.\n¡Complete el campo!");
            }
        }

        private void CleanBox()
        {
            textBoxIdFactura.Text = "";
            textBoxIdVenta.Text = "";
            textBoxPrecioFinal.Text = "";
           
        }
        
        private void buttonCleanBoxs_Click(object sender, EventArgs e)
        {
            CleanBox();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (textBoxIdFactura.Text != "" && textBoxIdVenta.Text != "" && textBoxPrecioFinal.Text != "")
            {
                Factura v = Factura.Search(Convert.ToInt32(textBoxIdFactura.Text));

                v.IdVenta = Convert.ToInt32(textBoxIdVenta.Text);
                v.precioFinal = Convert.ToInt32(textBoxPrecioFinal.Text);
                
                if (Factura.Find(v.IdFactura))
                {

                    Factura.Update(v);

                    splitContainer1.Panel2.Controls.Clear();
                    ImprimirData(splitContainer1.Panel2).Show();
                    MessageBox.Show("Operación éxitosa");
                    LoadShowinvoice(v);
                    ShowPositionID(v);
                }
                else
                {
                    MessageBox.Show("Operación fallida");
                }
            }
            else
            {
                MessageBox.Show("Campo vacio.\n¡Complete el campo!");
            }
        }
        private void LoadShowinvoice(Factura c)
        {
            if (c != null)
            {
                textBoxIdFactura.Text = c.IdFactura.ToString();
                textBoxIdVenta.Text = c.IdVenta.ToString();
                textBoxPrecioFinal.Text = c.precioFinal.ToString();
            }
        }
        private void ShowPositionID(Factura c)
        {
            if (c != null)
            {
                int index = Factura.ListaFactura.IndexOf(c) + 1;
                labelPositionID.Text = index.ToString() + " / " + Factura.ListaFactura.Count.ToString();
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Factura c = Factura.BackList();
            ShowPositionID(c);
            LoadShowinvoice(c);
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (Factura.ListaFactura.Count != 0)
            {
                Factura c = Factura.NextList();
                ShowPositionID(c);
                LoadShowinvoice(c);
            }
        }

        private void buttonBackStart_Click(object sender, EventArgs e)
        {
            Factura c = Factura.StartList();
            ShowPositionID(c);
            LoadShowinvoice(c);
        }

        private void buttonNextEnd_Click(object sender, EventArgs e)
        {
            Factura c = Factura.EndList();
            ShowPositionID(c);
            LoadShowinvoice(c);
        }

        private void buttonCleanBoxs_Click_1(object sender, EventArgs e)
        {
            CleanBox(); 
        }
    }
}
