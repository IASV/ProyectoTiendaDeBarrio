using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilidadesGestionArchivo;

namespace UtilidadesClases
{
    public partial class BoxSearch : UserControl
    {
        private string PathLista = "Files/ListaCompra.txt";
        private string PathTemp = "Files/CompraTemp.txt";
        public string pathDataBase { get; set; }
        public string data { get; set; }
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
            int position = -1;
            for (int i = 0; i < titles.Length; i++)
            {
                if (titles[i] == title)
                {
                    position = i;
                    return position;
                }
            }

            if (position != -1)
                return position;
            else
                return position;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (textBoxSearch.Text != "")
            {
                string validationData;
                GestionArchivo gs = new GestionArchivo(Cliente.path);
                gs.PathTemp = PathTemp;

                int position = getPosition(Titles, SearchFor);

                validationData = gs.SearchData(textBoxSearch.Text, position);
                if (validationData != null)
                {
                    data = validationData;
                    MessageInfoAlert.ForeColor = Color.Green;
                    MessageInfoAlert.Text = "¡Busqueda exitosa!";
                }
                else
                {
                    data = null;
                    MessageInfoAlert.ForeColor = Color.Red;
                    MessageInfoAlert.Text = "¡No encontrado!";
                }
            }
            else
                MessageInfoAlert.Text = "¡Campo vacio!";
        }

        private void BoxSearch_Load(object sender, EventArgs e)
        {
            buttonAdd.Visible = VisibleButtonAdd;
            buttonSearch.Visible = VisibleButtonSearch;
            MessageInfoAlert.Text = "";
        }

        private void buttonSearch_MouseDown(object sender, MouseEventArgs e)
        {
            buttonSearch.BackgroundImage = Properties.Resources.lupaDown;
        }

        private void buttonSearch_MouseEnter(object sender, EventArgs e)
        {
            buttonSearch.BackgroundImage = Properties.Resources.lupaOver;
        }

        private void buttonSearch_MouseLeave(object sender, EventArgs e)
        {
            buttonSearch.BackgroundImage = Properties.Resources.lupa;
        }

        private void buttonAdd_MouseDown(object sender, MouseEventArgs e)
        {
            buttonAdd.BackgroundImage = Properties.Resources.AddDown;
        }

        private void buttonAdd_MouseEnter(object sender, EventArgs e)
        {
            buttonAdd.BackgroundImage = Properties.Resources.AddOver;
        }

        private void buttonAdd_MouseLeave(object sender, EventArgs e)
        {
            buttonAdd.BackgroundImage = Properties.Resources.Add;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
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
                    data = validationData;
                    MessageInfoAlert.ForeColor = Color.Green;
                    MessageInfoAlert.Text = "¡Busqueda exitosa!";
                    MessageBox.Show(data);
                }
                else
                {
                    data = null;
                    MessageInfoAlert.ForeColor = Color.Red;
                    MessageInfoAlert.Text = "¡No encontrado!";
                }
            }
            else
                MessageInfoAlert.Text = "¡Campo vacio!";
        }
    }
}
