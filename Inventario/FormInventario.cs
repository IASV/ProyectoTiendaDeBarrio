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

namespace Inventario
{
    public partial class FormInventario : Form
    {
        public FormInventario()
        {
            InitializeComponent();
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            if (textBoxCantidad.Text != "" && textBoxPrecioVenta.Text != "" && textBoxPrecioBase.Text != "")
            {
                if (!Inventario.FindForIDProduct(Convert.ToInt32(textBoxIDProducto.Text)))
                {
                    Inventario v = new Inventario();

                    v.IdProducto = Convert.ToInt32(textBoxIDProducto.Text);
                    v.Cantidad = Convert.ToInt32(textBoxCantidad.Text);
                    v.PrecioBase = Convert.ToInt64(textBoxPrecioBase.Text);
                    v.PrecioVenta = Convert.ToInt64(textBoxPrecioVenta.Text);
                    v.FechaIngreso = Convert.ToDateTime(dateTimePickerFechaIngreso.Value.ToShortDateString());
                    v.FechaSalida = Convert.ToDateTime(dateTimePickerFechaSalida.Value.ToShortDateString());

                    v.Add();

                    if (Inventario.Find(v.IdInventario))
                    {
                        splitContainer1.Panel2.Controls.Clear();
                        ImprimirData(splitContainer1.Panel2).Show();
                        MessageBox.Show("Operación éxitosa");
                        labelPositionID.Text = (Inventario.ListaInventario.IndexOf(v) + 1).ToString() + " / " + Inventario.ListaInventario.Count.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Operación fallida");
                    }
                }
                else
                {
                    MessageBox.Show("El Item ya existe");
                }
            }
            else
            {
                MessageBox.Show("Campo vacio.\n¡Complete el campo!");
            }
        }

        private void FormInventario_Load(object sender, EventArgs e)
        {
            Inventario.LoadList();

            if (Inventario.Find(1))
            {
                Inventario i = Inventario.ListaInventario.ElementAt(0);
                LoadShowInventory(i);
                ShowPositionID(i);
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

            gs.Path = Inventario.path;
            gs.CreateFile();

            panel.Controls.Add(imprimir);

            imprimir.TitleWindow = "Lista de Items";
            imprimir.DataInput = gs.GetDataString();
            imprimir.Titles = Inventario.Titles;
            
            return imprimir;
        }

        private void buttonDeleteClient_Click(object sender, EventArgs e)
        {
            if (textBoxCantidad.Text != "" && textBoxPrecioVenta.Text != "" && textBoxPrecioBase.Text != "")
            {
                int IdItem = Convert.ToInt32(textBoxID.Text);
                if (Inventario.Find(IdItem))
                {
                    Inventario c = Inventario.Search(IdItem);
                    var result = MessageBox.Show("¿Desea eliminar item " + c.IdInventario, "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes) 
                    {
                        c.Delete();
                        Inventario.Delete(c);
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
                int IdItem = Convert.ToInt32(textBoxBuscar.Text);
                if (Inventario.Find(IdItem))
                {
                    Inventario c = Inventario.Search(IdItem);

                    LoadShowInventory(c);
                    ShowPositionID(c);
                    Inventario.Index = Inventario.ListaInventario.IndexOf(c);

                }
                else
                {
                    MessageBox.Show("Item no encontrado.");
                }
            }
            else
            {
                MessageBox.Show("Campo vacio.\n¡Complete el campo!");
            }
        }

        private void CleanBox()
        {
            textBoxID.Text = "";
            textBoxIDProducto.Text = "";
            textBoxCantidad.Text = "";
            textBoxPrecioBase.Text = "";
            textBoxPrecioVenta.Text = "";
            dateTimePickerFechaIngreso.Value = DateTime.Now;
            dateTimePickerFechaSalida.Value = DateTime.Now;
        }

        private void buttonCleanBoxs_Click(object sender, EventArgs e)
        {
            CleanBox();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (textBoxCantidad.Text != "" && textBoxPrecioVenta.Text != "" && textBoxPrecioBase.Text != "")
            {
                Inventario v = Inventario.Search(Convert.ToInt32(textBoxID.Text));

                v.IdProducto = Convert.ToInt32(textBoxIDProducto.Text);
                v.Cantidad = Convert.ToInt32(textBoxCantidad.Text);
                v.PrecioBase = Convert.ToInt64(textBoxPrecioBase.Text);
                v.PrecioVenta = Convert.ToInt64(textBoxPrecioVenta.Text);
                v.FechaIngreso = Convert.ToDateTime(dateTimePickerFechaIngreso.Value.ToShortDateString());
                v.FechaSalida = Convert.ToDateTime(dateTimePickerFechaSalida.Value.ToShortDateString());

                if (Inventario.Find(v.IdInventario))
                {
                    Inventario.Update(v);

                    splitContainer1.Panel2.Controls.Clear();
                    ImprimirData(splitContainer1.Panel2).Show();
                    MessageBox.Show("Operación éxitosa");
                    LoadShowInventory(v);
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

        private void LoadShowInventory(Inventario c)
        {
            if (c != null)
            {
                textBoxID.Text = c.IdInventario.ToString();
                textBoxIDProducto.Text = c.IdProducto.ToString();
                textBoxCantidad.Text = c.Cantidad.ToString();
                textBoxPrecioBase.Text = c.PrecioBase.ToString();
                textBoxPrecioVenta.Text = c.PrecioVenta.ToString();
                dateTimePickerFechaIngreso.Value = c.FechaIngreso;
                dateTimePickerFechaSalida.Value = c.FechaSalida;
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            Inventario c = Inventario.NextList();
            ShowPositionID(c);
            LoadShowInventory(c);
        }

        private void buttonNextEnd_Click_1(object sender, EventArgs e)
        {
            Inventario c = Inventario.EndList();
            ShowPositionID(c);
            LoadShowInventory(c);
        }

        private void buttonBack_Click_1(object sender, EventArgs e)
        {
            Inventario c = Inventario.BackList();
            ShowPositionID(c);
            LoadShowInventory(c);
        }

        private void buttonBackStart_Click_1(object sender, EventArgs e)
        {
            Inventario c = Inventario.StartList();
            ShowPositionID(c);
            LoadShowInventory(c);
        }

        private void ShowPositionID(Inventario c)
        {
            if (c != null)
            {
                int index = Inventario.ListaInventario.IndexOf(c) + 1;
                labelPositionID.Text = index.ToString() + " / " + Inventario.ListaInventario.Count.ToString();
            }
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
    }
}
