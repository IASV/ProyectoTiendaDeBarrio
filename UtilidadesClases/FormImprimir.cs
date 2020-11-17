using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilidadesGestionArchivo;

namespace UtilidadesClases
{
    public partial class FormImprimir : Form
    {
        public FormImprimir()
        {
            InitializeComponent();
        }

        public string[][] DataInput { get; set; }

        public string[] Titles { get; set; }

        public string TitleWindow { get; set; }

        public string Path { get; set; }

        private void FormImprimir_Load(object sender, EventArgs e)
        {
            Text = TitleWindow;
            panelImprimir.BackColor = Color.White;
            LoadInformation(panelImprimir);
        }

        private void LoadInformation(Panel panel)
        {
            int sizeX;
            bool titles = true;
            int[] dataSizeColum;

            dataSizeColum = new int[Titles.Length];

            if (DataInput != null)
            {
                for (int i = 0, y = 0; i < DataInput.Length + 1; i++, y += 20)
                {
                    for (int j = 0, x = 0; j < Titles.Length; j++, x += sizeX)
                    {
                        if (Titles[j].Length >= DataInput[0][j].Length)
                            dataSizeColum[j] = Titles[j].Length * 10;
                        else
                            dataSizeColum[j] = DataInput[0][j].Length * 10;

                        sizeX = dataSizeColum[j];

                        if (titles)
                        {
                            CreateTextBox(x, y, sizeX, 24, Titles[j], panel, Color.Cyan);
                        }
                        else
                            CreateTextBox(x, y, sizeX, 24, DataInput[i - 1][j].ToString(), panel, Color.LightBlue);
                    }

                    titles = false;
                }
            }
            else
            {
                for (int j = 0, x = 0, y = 0; j < Titles.Length; j++, x += sizeX)
                {
                    dataSizeColum[j] = Titles[j].Length * 10;

                    sizeX = dataSizeColum[j];

                        CreateTextBox(x, y, sizeX, 24, Titles[j], panel, Color.Cyan);                    
                }
            }

        }

        public void CreateTextBox(int x, int y, int sizeX, int sizeY, string date, Panel panel, Color color)
        {
            TextBox textBox = new TextBox();
            textBox.Size = new Size(sizeX, sizeY);
            textBox.Location = new Point(x, y);
            textBox.ReadOnly = true;
            textBox.BackColor = color;
            textBox.BorderStyle = BorderStyle.FixedSingle;

            textBox.Text = date;

            panel.Controls.Add(textBox);
        }
    }
}
