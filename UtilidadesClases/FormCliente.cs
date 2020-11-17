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
    public partial class FormCliente : Form
    {
        public FormCliente()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonAddClient_Click(object sender, EventArgs e)
        {
            if (textBoxNombre.Text != "" && textBoxCedula.Text != "" && comboBoxSexo.Text != "" && textBoxTelefono.Text != ""
                && textBoxCorreo.Text != "" && textBoxDireccion.Text != "" && comboBoxEstadoCivil.Text != "") {

                if (!Cliente.Find(Convert.ToInt64(textBoxCedula.Text)))
                {

                    Cliente v = new Cliente();

                    v.Nombre = textBoxNombre.Text;
                    v.Cedula = Convert.ToInt64(textBoxCedula.Text);
                    v.FechaNacimiento = Convert.ToDateTime(dateTimePickerFechaNacimiento.Value.ToShortDateString());//Cambiar
                    v.Sexo = (Sexo)Sexo.Parse(typeof(Sexo), comboBoxSexo.Text);
                    v.Telefono = Convert.ToInt64(textBoxTelefono.Text);
                    v.Correo = textBoxCorreo.Text;
                    v.Direccion = textBoxDireccion.Text;
                    v.EstadoCivil = (EstadoCivil)EstadoCivil.Parse(typeof(EstadoCivil), comboBoxEstadoCivil.Text);

                    v.Add();

                    if (Cliente.Find(v.Cedula))
                    {
                        splitContainer1.Panel2.Controls.Clear();
                        ImprimirData(splitContainer1.Panel2).Show();
                        MessageBox.Show("Operación éxitosa");
                        labelPositionID.Text = (Cliente.ListaClientes.IndexOf(v) + 1).ToString() + " / " + Cliente.ListaClientes.Count.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Operación fallida");
                    }
                }
                else
                {
                    MessageBox.Show("El cliente ya existe");
                }
            }
            else
            {
                MessageBox.Show("Campo vacio.\n¡Complete el campo!");
            }
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            Cliente.LoadList();

            if (Cliente.Find(1))
            {
                Cliente c = Cliente.ListaClientes.ElementAt(0);
                LoadShowClient(c);
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

            gs.Path = Cliente.path;
            gs.CreateFile();

            imprimir.Size = panel.Size;

            panel.Controls.Add(imprimir);

            imprimir.TitleWindow = "Lista de Items";
            imprimir.DataInput = gs.GetDataString();
            imprimir.Titles = Cliente.Titles;

            return imprimir;
        }

        private void buttonDeleteClient_Click(object sender, EventArgs e)
        {
            if (textBoxNombre.Text != "" && textBoxCedula.Text != "" && comboBoxSexo.Text != "" && textBoxTelefono.Text != ""
                && textBoxCorreo.Text != "" && textBoxDireccion.Text != "" && comboBoxEstadoCivil.Text != "")
            {
                long cedCliente = Convert.ToInt64(textBoxCedula.Text);
                if (Cliente.Find(cedCliente))
                {
                    Cliente c = Cliente.SearchCed(cedCliente);
                    var result = MessageBox.Show("¿Desea eliminar a " + c.Nombre, "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        c.Delete();
                        Cliente.Delete(c);
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
            if(textBoxBuscar.Text != "")
            {
                int IdCliente = Convert.ToInt32(textBoxBuscar.Text);
                if (Cliente.Find(IdCliente))
                {
                    Cliente c = Cliente.SearchID(IdCliente);

                    LoadShowClient(c);
                    ShowPositionID(c);
                    Cliente.Index = Cliente.ListaClientes.IndexOf(c);

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
            textBoxNombre.Text = "";
            textBoxCedula.Text = "";
            textBoxID.Text = "";
            dateTimePickerFechaNacimiento.Value = DateTime.Now;
            comboBoxSexo.Text = "";
            textBoxTelefono.Text = "";
            textBoxCorreo.Text = "";
            textBoxDireccion.Text = "";
            comboBoxEstadoCivil.Text = "";
        }

        private void buttonCleanBoxs_Click(object sender, EventArgs e)
        {
            CleanBox();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (textBoxNombre.Text != "" && textBoxCedula.Text != "" && comboBoxSexo.Text != "" && textBoxTelefono.Text != ""
                && textBoxCorreo.Text != "" && textBoxDireccion.Text != "" && comboBoxEstadoCivil.Text != "")
            {
                Cliente v = Cliente.SearchCed(Convert.ToInt64(textBoxCedula.Text));

                v.Nombre = textBoxNombre.Text;
                v.Cedula = Convert.ToInt64(textBoxCedula.Text);
                v.FechaNacimiento = Convert.ToDateTime(dateTimePickerFechaNacimiento.Value.ToShortDateString());//Cambiar
                v.Sexo = (Sexo)Sexo.Parse(typeof(Sexo), comboBoxSexo.Text);
                v.Telefono = Convert.ToInt64(textBoxTelefono.Text);
                v.Correo = textBoxCorreo.Text;
                v.Direccion = textBoxDireccion.Text;
                v.EstadoCivil = (EstadoCivil)EstadoCivil.Parse(typeof(EstadoCivil), comboBoxEstadoCivil.Text);


                if (Cliente.Find(v.Cedula))
                {

                    Cliente.Update(v);

                    splitContainer1.Panel2.Controls.Clear();
                    ImprimirData(splitContainer1.Panel2).Show();
                    MessageBox.Show("Operación éxitosa");
                    LoadShowClient(v);
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

        private void LoadShowClient(Cliente c)
        {
            if (c != null)
            {
                textBoxNombre.Text = c.Nombre;
                textBoxCedula.Text = c.Cedula.ToString();
                textBoxID.Text = c.IdCliente.ToString();
                dateTimePickerFechaNacimiento.Value = c.FechaNacimiento;
                comboBoxSexo.Text = c.Sexo.ToString();
                textBoxTelefono.Text = c.Telefono.ToString();
                textBoxCorreo.Text = c.Correo;
                textBoxDireccion.Text = c.Direccion;
                comboBoxEstadoCivil.Text = c.EstadoCivil.ToString();
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            Cliente c = Cliente.NextList();
            ShowPositionID(c);
            LoadShowClient(c);
        }

        private void buttonNextEnd_Click(object sender, EventArgs e)
        {
            Cliente c = Cliente.EndList();
            ShowPositionID(c);
            LoadShowClient(c);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Cliente c = Cliente.BackList();
            ShowPositionID(c);
            LoadShowClient(c);
        }

        private void buttonBackStart_Click(object sender, EventArgs e)
        {
            Cliente c = Cliente.StartList();
            ShowPositionID(c);
            LoadShowClient(c);
        }

        private void ShowPositionID(Cliente c)
        {
            if (c != null)
            {
                int index = Cliente.ListaClientes.IndexOf(c) + 1;
                labelPositionID.Text = index.ToString() + " / " + Cliente.ListaClientes.Count.ToString();
            }
        }

        //borrar
        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
        }
    }
}
