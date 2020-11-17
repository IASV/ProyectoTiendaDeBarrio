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

namespace UtilidadesClases
{
    public partial class FormProducto : Form
    {
        public FormProducto()
        {
            InitializeComponent();
        }

        private void FormProducto_Load(object sender, EventArgs e)
        {
            Producto.LoadList();

            if (Producto.Find(1))
            {
                Producto i = Producto.ListaProductos.ElementAt(0);
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

            gs.Path = Producto.path;
            gs.CreateFile();

            imprimir.Size = panel.Size;

            panel.Controls.Add(imprimir);

            imprimir.TitleWindow = "Lista de Items";
            imprimir.DataInput = gs.GetDataString();
            imprimir.Titles = Producto.Titles;

            return imprimir;
        }
        private void buttonAddClient_Click(object sender, EventArgs e)
        {
            if (textBoxInfo.Text != "" && textBoxNombre.Text != "")
            {
                
                Producto v = new Producto();

                v.Nombre = textBoxNombre.Text;
                v.Info = textBoxInfo.Text;
                v.FechaIngreso = Convert.ToDateTime(dateTimePickerFechaIngreso.Value.ToShortDateString());
                v.FechaSalida = Convert.ToDateTime(dateTimePickerFechaSalida.Value.ToShortDateString());

                v.Add();

                if (Producto.Find(v.IdProducto))
                {
                    splitContainer1.Panel2.Controls.Clear();
                    ImprimirData(splitContainer1.Panel2).Show();
                    MessageBox.Show("Operación éxitosa");
                    labelPositionID.Text = (Producto.ListaProductos.IndexOf(v) + 1).ToString() + " / " + Producto.ListaProductos.Count.ToString();
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

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (textBoxInfo.Text != "" && textBoxNombre.Text != "")
            {
                int IdItem = Convert.ToInt32(textBoxID.Text);
                if (Producto.Find(IdItem))
                {
                    Producto c = Producto.Search(IdItem);
                    var result = MessageBox.Show("¿Desea eliminar item " + c.IdProducto, "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        c.Delete();
                        Producto.Delete(c);
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
                if (Producto.Find(IdItem))
                {
                    Producto c = Producto.Search(IdItem);

                    LoadShowInventory(c);
                    ShowPositionID(c);
                    Producto.Index = Producto.ListaProductos.IndexOf(c);

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
            textBoxNombre.Text = "";
            textBoxInfo.Text = "";
            dateTimePickerFechaIngreso.Value = DateTime.Now;
            dateTimePickerFechaSalida.Value = DateTime.Now;
        }

        private void buttonCleanBoxes_Click(object sender, EventArgs e)
        {
            CleanBox();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (textBoxInfo.Text != "" && textBoxNombre.Text != "")
            {
                Producto v = Producto.Search(Convert.ToInt32(textBoxID.Text));

                v.IdProducto = Convert.ToInt32(textBoxID.Text);
                v.Nombre = textBoxNombre.Text;
                v.Info = textBoxInfo.Text;
                v.FechaIngreso = Convert.ToDateTime(dateTimePickerFechaIngreso.Value.ToShortDateString());
                v.FechaSalida = Convert.ToDateTime(dateTimePickerFechaSalida.Value.ToShortDateString());

                if (Producto.Find(v.IdProducto))
                {

                    Producto.Update(v);

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

        private void LoadShowInventory(Producto c)
        {
            if (c != null)
            {
                textBoxID.Text = c.IdProducto.ToString();
                textBoxNombre.Text = c.Nombre.ToString();
                textBoxInfo.Text = c.Info.ToString();
                dateTimePickerFechaIngreso.Value = c.FechaIngreso;
                dateTimePickerFechaSalida.Value = c.FechaSalida;
            }
        }

        private void ShowPositionID(Producto c)
        {
            if (c != null)
            {
                int index = Producto.ListaProductos.IndexOf(c) + 1;
                labelPositionID.Text = index.ToString() + " / " + Producto.ListaProductos.Count.ToString();
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            Producto c = Producto.NextList();
            ShowPositionID(c);
            LoadShowInventory(c);
        }

        private void buttonNextEnd_Click(object sender, EventArgs e)
        {
            Producto c = Producto.EndList();
            ShowPositionID(c);
            LoadShowInventory(c);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Producto c = Producto.BackList();
            ShowPositionID(c);
            LoadShowInventory(c);
        }

        private void buttonBackStart_Click(object sender, EventArgs e)
        {
            Producto c = Producto.StartList();
            ShowPositionID(c);
            LoadShowInventory(c);
        }

        private void textBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
        }
    }
}
