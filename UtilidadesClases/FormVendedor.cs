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
    public partial class FormVendedor : Form
    {
        public FormVendedor()
        {
            InitializeComponent();
        }

        private void buttonAddClient_Click(object sender, EventArgs e)
        {
            if (CedulatextBox.Text != "" && NombretextBox.Text != "" && SexocomboBox.Text != "" && TelefonotextBox.Text != ""
                && CorreotextBox.Text != "" && DirecciontextBox.Text != "" && EstadoCivilcomboBox.Text != "" && SalariotextBox1.Text != ""
                && ProfesióntextBox2.Text != "" && CalificaciontextBox3.Text != "")
            {
                if (!Vendedor.Find(Convert.ToInt64(CedulatextBox.Text)))
                {

                    Vendedor v = new Vendedor();

                    v.Cedula = Convert.ToInt64(CedulatextBox.Text);
                    v.Nombre = NombretextBox.Text;
                    v.FechaNacimiento = Convert.ToDateTime(dateTimePickerFechaNacimiento.Value.ToShortDateString());
                    v.Sexo = (Sexo)Sexo.Parse(typeof(Sexo), SexocomboBox.Text);
                    v.Telefono = Convert.ToInt64(TelefonotextBox.Text);
                    v.Correo = CorreotextBox.Text;
                    v.Direccion = DirecciontextBox.Text;
                    v.EstadoCivil = (EstadoCivil)EstadoCivil.Parse(typeof(EstadoCivil), EstadoCivilcomboBox.Text);                   
                    v.FechaIngreso = Convert.ToDateTime(FechaIngresodateTimePicker1.Value);
                    v.Salario = Convert.ToInt32(SalariotextBox1.Text);
                    v.Profesion = ProfesióntextBox2.Text;
                    v.Calificacion = Convert.ToInt32(CalificaciontextBox3.Text);

                    v.Add();

                    if (Vendedor.Find(v.Cedula))
                    {
                        splitContainer1.Panel2.Controls.Clear();
                        ImprimirData(splitContainer1.Panel2).Show();
                        MessageBox.Show("Operación éxitosa");
                        labelPositionID.Text = (Vendedor.ListaVendedores.IndexOf(v) + 1).ToString() + " / " + Vendedor.ListaVendedores.Count.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Operación fallida");
                    }
                }
                else
                {
                    MessageBox.Show("El Vendedor ya existe");
                }
            }
            else
            {
                MessageBox.Show("Campo vacio.\n¡Complete el campo!");
            }
        }

        private void FormVendedor_Load(object sender, EventArgs e)
        {
            Vendedor.LoadList();

            if (Vendedor.Find(1))
            {
                Vendedor c = Vendedor.ListaVendedores.ElementAt(0);
                LoadShowVendedor(c);
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

            gs.Path = Vendedor.path;
            gs.CreateFile();

            imprimir.Size = panel.Size;

            panel.Controls.Add(imprimir);

            imprimir.TitleWindow = "Lista de Items";
            imprimir.DataInput = gs.GetDataString();
            imprimir.Titles = Vendedor.Titles;

            return imprimir;
        }

        private void buttonDeleteVendedor_Click(object sender, EventArgs e)
        {
            if (CedulatextBox.Text != "" && NombretextBox.Text != "" && SexocomboBox.Text != "" && TelefonotextBox.Text != ""
                && CorreotextBox.Text != "" && DirecciontextBox.Text != "" && EstadoCivilcomboBox.Text != "" && SalariotextBox1.Text != ""
                && ProfesióntextBox2.Text != "" && CalificaciontextBox3.Text != "")
            {
                long CedVendedor = Convert.ToInt64(CedulatextBox.Text);
                if (Vendedor.Find(CedVendedor))
                {
                    Vendedor c = Vendedor.Search(CedVendedor);
                    var result = MessageBox.Show("¿Desea eliminar a " + c.Nombre, "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        c.Delete();
                        Vendedor.Delete(c);
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
                int IdVendedor = Convert.ToInt32(textBoxBuscar.Text);
                if (Vendedor.Find(IdVendedor))
                {
                    Vendedor c = Vendedor.SearchID(IdVendedor);

                    LoadShowVendedor(c);
                    ShowPositionID(c);
                    Vendedor.Index = Vendedor.ListaVendedores.IndexOf(c);

                }
                else
                {
                    MessageBox.Show("Vendedor no encontrado.");
                }
            }
            else
            {
                MessageBox.Show("Campo vacio.\n¡Complete el campo!");
            }
        }

        private void CleanBox()
        {
            CedulatextBox.Text = "";
            NombretextBox.Text = "";
            dateTimePickerFechaNacimiento.Value = DateTime.Now;
            SexocomboBox.Text = "";
            TelefonotextBox.Text = "";
            CorreotextBox.Text = "";
            DirecciontextBox.Text = "";
            EstadoCivilcomboBox.Text = "";
            IdVendedortextBox.Text = "";
            FechaIngresodateTimePicker1.Value = DateTime.Now;
            SalariotextBox1.Text = "";
            ProfesióntextBox2.Text = "";
            CalificaciontextBox3.Text = "";


        }

        private void buttonCleanBoxs_Click(object sender, EventArgs e)
        {
            CleanBox();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (CedulatextBox.Text != "" && NombretextBox.Text != "" && SexocomboBox.Text != "" && TelefonotextBox.Text != ""
                && CorreotextBox.Text != "" && DirecciontextBox.Text != "" && EstadoCivilcomboBox.Text != "" && SalariotextBox1.Text != ""
                && ProfesióntextBox2.Text != "" && CalificaciontextBox3.Text != "")
            {
                Vendedor v = Vendedor.Search(Convert.ToInt64(CedulatextBox.Text));

                v.Cedula = Convert.ToInt64(CedulatextBox.Text);
                v.Nombre = NombretextBox.Text;
                v.FechaNacimiento = Convert.ToDateTime(dateTimePickerFechaNacimiento.Value.ToShortDateString());
                v.Sexo = (Sexo)Sexo.Parse(typeof(Sexo), SexocomboBox.Text);
                v.Telefono = Convert.ToInt64(TelefonotextBox.Text);
                v.Correo = CorreotextBox.Text;
                v.Direccion = DirecciontextBox.Text;
                v.EstadoCivil = (EstadoCivil)EstadoCivil.Parse(typeof(EstadoCivil), EstadoCivilcomboBox.Text);               
                v.FechaIngreso = Convert.ToDateTime(FechaIngresodateTimePicker1.Value);
                v.Salario = Convert.ToInt32(SalariotextBox1.Text);
                v.Profesion = ProfesióntextBox2.Text;
                v.Calificacion = Convert.ToInt32(CalificaciontextBox3.Text);


                if (Vendedor.Find(v.Cedula))
                {

                    Vendedor.Update(v);

                    splitContainer1.Panel2.Controls.Clear();
                    ImprimirData(splitContainer1.Panel2).Show();
                    MessageBox.Show("Operación éxitosa");
                    LoadShowVendedor(v);
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
        private void LoadShowVendedor(Vendedor v)
        {
            if (v != null)
            {
                CedulatextBox.Text = v.Cedula.ToString();
                NombretextBox.Text = v.Nombre;
                dateTimePickerFechaNacimiento.Value = v.FechaNacimiento;
                SexocomboBox.Text = v.Sexo.ToString();
                TelefonotextBox.Text = v.Telefono.ToString();
                CorreotextBox.Text = v.Correo;
                DirecciontextBox.Text = v.Direccion;
                EstadoCivilcomboBox.Text = v.EstadoCivil.ToString();
                IdVendedortextBox.Text = v.IdVendedor.ToString();
                FechaIngresodateTimePicker1.Value = v.FechaIngreso;
                SalariotextBox1.Text = v.Salario.ToString();
                ProfesióntextBox2.Text = v.Profesion;
                CalificaciontextBox3.Text = v.Calificacion.ToString();
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            Vendedor v = Vendedor.NextList();
            ShowPositionID(v);
            LoadShowVendedor(v);
        }

        private void buttonNextEnd_Click(object sender, EventArgs e)
        {
            Vendedor v = Vendedor.EndList();
            ShowPositionID(v);
            LoadShowVendedor(v);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Vendedor v = Vendedor.BackList();
            ShowPositionID(v);
            LoadShowVendedor(v);
        }

        private void buttonBackStart_Click(object sender, EventArgs e)
        {
            Vendedor v = Vendedor.StartList();
            ShowPositionID(v);
            LoadShowVendedor(v);
        }
        private void ShowPositionID(Vendedor v)
        {
            if (v != null)
            {
                int index = Vendedor.ListaVendedores.IndexOf(v) + 1;
                labelPositionID.Text = index.ToString() + " / " + Vendedor.ListaVendedores.Count.ToString();
            }
        }

        private void splitContainer1_Panel2_SizeChanged(object sender, EventArgs e)
        {

        }
    }
}
