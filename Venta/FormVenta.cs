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

namespace Venta
{
    public partial class FormVenta : Form
    {
        public FormVenta()
        {
            InitializeComponent();
        }

        private void FormVenta_Load(object sender, EventArgs e)
        {
            Venta.LoadList();

            if (Venta.Find(1))
            {
                Venta c = Venta.ListaVentas.ElementAt(0);
                LoadShowVenta(c);
                ShowPositionID(c);
            }
            else
                labelPositionID.Text = "0 / 0";

            ImprimirData(splitContainer1.Panel2).Show();
        }

        private FormImprimir ImprimirData(Panel panel)
        {

            FormImprimir imprimir = new FormImprimir();
            imprimir.TopLevel = false;

            GestionArchivo gs = new GestionArchivo();

            gs.Path = Venta.path;
            gs.CreateFile();

            panel.Controls.Add(imprimir);

            imprimir.TitleWindow = "Lista de Items";
            imprimir.DataInput = gs.GetDataString();
            imprimir.Titles = Venta.Titles;

            return imprimir;
        }

        private void buttonAddVenta_Click(object sender, EventArgs e)
        {
            if (textBoxIdVendedor.Text != "" && textBoxIdCliente.Text != "" && textBoxIdItem.Text != "")
            {
                Venta v = new Venta();

                textBoxID.Text = v.IdVenta.ToString();

                if (!Venta.Find(Convert.ToInt32(textBoxID.Text)))
                {

                    v.IdVenta = Convert.ToInt32(textBoxID.Text);
                    v.IdCliente = 1;
                    v.IdVendedor = Convert.ToInt32(textBoxIdVendedor.Text);
                    v.IdItem = Convert.ToInt32(textBoxIdItem.Text);
                    v.FormaPago = (FormaPago)FormaPago.Parse(typeof(FormaPago), comboBoxFormaPago.Text);

                    v.Add();

                    if (Venta.Find(v.IdVenta))
                    {
                        splitContainer1.Panel2.Controls.Clear();
                        ImprimirData(splitContainer1.Panel2).Show();
                        MessageBox.Show("Operación éxitosa");
                        labelPositionID.Text = (Venta.ListaVentas.IndexOf(v) + 1).ToString() + " / " + Venta.ListaVentas.Count.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Operación fallida");
                    }
                }
                else
                {
                    MessageBox.Show("La venta ya existe");
                }
            }
            else
            {
                MessageBox.Show("Campo vacio.\n¡Complete el campo!");
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (textBoxBuscar.Text != "")
            {
                int IdVenta = Convert.ToInt32(textBoxBuscar.Text);
                if (Venta.Find(IdVenta))
                {
                    Venta c = Venta.SearchID(IdVenta);

                    LoadShowVenta(c);
                    ShowPositionID(c);
                    Venta.Index = Venta.ListaVentas.IndexOf(c);

                }
                else
                {
                    MessageBox.Show("Venta no encontrada.");
                }
            }
            else
            {
                MessageBox.Show("Campo vacio.\n¡Complete el campo!");
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text != "" && textBoxIdVendedor.Text != "" && textBoxIdCliente.Text != "" && textBoxIdItem.Text != "")
            {
                Venta v = Venta.SearchID(Convert.ToInt32(textBoxID.Text));

                v.IdVenta = Convert.ToInt32(textBoxID.Text);
                v.IdCliente = Convert.ToInt32(textBoxIdCliente.Text);
                v.IdVendedor = Convert.ToInt32(textBoxIdVendedor.Text);
                v.IdItem = Convert.ToInt32(textBoxIdItem.Text);
                v.FormaPago = (FormaPago)FormaPago.Parse(typeof(FormaPago), comboBoxFormaPago.Text);

                if (Venta.Find(v.IdVenta))
                {

                    Venta.Update(v);

                    splitContainer1.Panel2.Controls.Clear();
                    ImprimirData(splitContainer1.Panel2).Show();
                    MessageBox.Show("Operación éxitosa");
                    LoadShowVenta(v);
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

        private void buttonDeleteVenta_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text != "" && textBoxIdVendedor.Text != "" && textBoxIdCliente.Text != "" && textBoxIdItem.Text != "")
            {
                int IdVenta = Convert.ToInt32(textBoxID.Text);
                if (Venta.Find(IdVenta))
                {
                    Venta c = Venta.SearchID(IdVenta);
                    var result = MessageBox.Show("¿Desea eliminar a " + c.IdVenta, "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        c.Delete();
                        Venta.Delete(c);
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

        private void CleanBox()
        {
            textBoxID.Text = "";
            textBoxIdCliente.Text = "";
            textBoxIdVendedor.Text = "";
            textBoxIdItem.Text = "";
            comboBoxFormaPago.Text = "";

        }

        private void buttonCleanBoxs_Click(object sender, EventArgs e)
        {
            CleanBox();
        }

        private void ShowPositionID(Venta c)
        {
            if (c != null)
            {
                int index = Venta.ListaVentas.IndexOf(c) + 1;
                labelPositionID.Text = index.ToString() + " / " + Venta.ListaVentas.Count.ToString();
            }
        }

        private void LoadShowVenta(Venta c)
        {
            if (c != null)
            {
                textBoxID.Text = c.IdVenta.ToString();
                textBoxIdCliente.Text = c.IdCliente.ToString();
                textBoxIdVendedor.Text = c.IdVendedor.ToString();
                textBoxIdItem.Text = c.IdItem.ToString();
                comboBoxFormaPago.Text = c.FormaPago.ToString();
            }
        }

        private void buttonBackStart_Click(object sender, EventArgs e)
        {
            Venta c = Venta.StartList();
            ShowPositionID(c);
            LoadShowVenta(c);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Venta c = Venta.BackList();
            ShowPositionID(c);
            LoadShowVenta(c);
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            Venta c = Venta.NextList();
            ShowPositionID(c);
            LoadShowVenta(c);
        }

        private void buttonNextEnd_Click(object sender, EventArgs e)
        {
            Venta c = Venta.EndList();
            ShowPositionID(c);
            LoadShowVenta(c);
        }
    }
}
