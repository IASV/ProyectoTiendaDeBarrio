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


namespace TiendaMDI
{
    public partial class FormInfoCliente : Form
    {
        public FormInfoCliente()
        {
            InitializeComponent();
        }

        

        private void FormInfoCliente_Load(object sender, EventArgs e)
        {
        
        }

        private void buttonEnvíarCedula_Click(object sender, EventArgs e)
        {
            
            if (textBoxCedBusqueda.Text != "")
            {
                try
                {
                    long ced = Convert.ToInt64(textBoxCedBusqueda.Text);
                    Cliente.LoadList();

                    try
                    {
                        if (Cliente.Find(ced))
                        {                          
                            Cliente c = Cliente.SearchCed(ced);

                            textBoxIdInfo.Text = Convert.ToString(c.IdCliente);
                            textBoxNombreInfo.Text = c.Nombre;
                            textBoxCedulainfo.Text = Convert.ToString(c.Cedula);
                            textBoxFechaNacimientoInfo.Text = Convert.ToDateTime(c.FechaNacimiento).ToString();
                            textBoxSexoInfo.Text = c.Sexo.ToString();
                            textBoxTelefonoInfo.Text = Convert.ToString(c.Telefono);
                            textBoxCorreoInfo.Text = c.Correo;
                            textBoxDireccionInfo.Text = c.Direccion;
                            textBoxEstadoCivilInfo.Text = c.EstadoCivil.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Cliente no encontrado");
                        }
                    }
                    catch (Exception a)
                    {
                        MessageBox.Show(a.ToString());

                    }

                    
                }
                catch (Exception)
                {

                    MessageBox.Show("Debe ingresar un valor correcto");
                }

            }
            else
            {
                MessageBox.Show("Porfavor ingrese la  cedula del cliente");
            }
        }
    }
}
