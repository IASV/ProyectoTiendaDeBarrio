using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilidadesClases;
using UtilidadesGestionArchivo;
using Inventario;


namespace Compras
{
    public partial class BoxSearch : UserControl
    {
        public string PathLista = "Files/ListaCompra.txt";
        public string PathTemp = "Files/CompraTemp.txt";

        public long SubTotal { get; set; }
        public int CantidadItem { get; set; }
        public double Total { get; set; }
        public Panel panel { get; set; }
        public string pathDataBase { get; set; }
        public string[] Titles { get; set; }
        public string SearchFor { get; set; }
        public bool VisibleButtonSearch { get; set; }
        public bool VisibleButtonAdd { get; set; }

        public BoxSearch()
        {
            InitializeComponent();
        }

        private int getPosition(string[] titles, string title)
        {
            for (int i = 0; i < titles.Length; i++)
            {
                if (titles[i] == title)
                {
                    return i;
                }
            }
            return -1;
        }

        private void BoxSearch_Load_1(object sender, EventArgs e)
        {
            buttonAdd.Visible = VisibleButtonAdd;
            buttonSearch.Visible = VisibleButtonSearch;
            MessageInfoAlert.Text = "";
            SubTotal = 0;
            CantidadItem = 0;
            Total = 0;
        }

        private void buttonAdd_Click_1(object sender, EventArgs e)
        {
            if (textBoxSearch.Text != "")
            {
                string validationData;

                GestionArchivo gs = new GestionArchivo(PathTemp);
                gs.PathTemp = PathLista;

                int position = getPosition(Titles, SearchFor);

                validationData = gs.SearchDate(textBoxSearch.Text, position);
                if (validationData != null)
                {
                    MessageInfoAlert.ForeColor = Color.Green;
                    MessageInfoAlert.Text = "¡Busqueda exitosa!";

                    //Actualizar cantidad y obtener precio de venta
                    int IdProducto = Convert.ToInt32(validationData.Split(',')[0]);
                    Inventario.Inventario.LoadList();
                    Inventario.Inventario item = Inventario.Inventario.Search(IdProducto);

                    if (item.Cantidad != 0)
                    {
                        item.Cantidad = item.Cantidad - 1;
                        SubTotal += item.PrecioVenta;
                        CantidadItem++;
                        Total += item.PrecioVenta + (item.PrecioVenta * 0.19);
                        Inventario.Inventario.Update(item);
                    }
                    else
                    {
                        Inventario.Inventario.Delete(item);
                    }

                    panel.Controls.Clear();
                    ImprimirData(panel, PathLista, Titles).Show();
                }
                else
                {
                    MessageInfoAlert.ForeColor = Color.Red;
                    MessageInfoAlert.Text = "¡No encontrado!";
                }
            }
            else
                MessageInfoAlert.Text = "¡Campo vacio!";
        }

        private void buttonSearch_Click_1(object sender, EventArgs e)
        {
            if (textBoxSearch.Text != "")
            {
                bool validationData;
                GestionArchivo gs = new GestionArchivo(pathDataBase);
                gs.PathTemp = PathTemp;

                int position = getPosition(Titles, SearchFor);

                validationData = gs.SearchData(textBoxSearch.Text, position);
                if (validationData)
                {
                    MessageInfoAlert.ForeColor = Color.Green;
                    MessageInfoAlert.Text = "¡Busqueda exitosa!";
                    panel.Controls.Clear();
                    ImprimirData(panel, PathTemp, Titles).Show();
                }
                else
                {
                    MessageInfoAlert.ForeColor = Color.Red;
                    MessageInfoAlert.Text = "¡No encontrado!";
                }
            }
            else
                MessageInfoAlert.Text = "¡Campo vacio!";
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

        public void DeleteFile()
        {
            GestionArchivo gs = new GestionArchivo();
            gs.DeleteFile();
        }

        private void buttonAdd_MouseDown(object sender, MouseEventArgs e)
        {
            BackgroundImage = Properties.Resources.AddDown;
        }

        private void buttonAdd_MouseEnter(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.AddOver;
        }

        private void buttonAdd_MouseLeave(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.Add;
        }

        private void buttonSearch_MouseDown(object sender, MouseEventArgs e)
        {
            BackgroundImage = Properties.Resources.lupaDown;
        }

        private void buttonSearch_MouseEnter(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.lupaOver;
        }

        private void buttonSearch_MouseLeave(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.lupa;
        }
    }
}

