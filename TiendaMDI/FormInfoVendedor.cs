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
    public partial class FormInfoVendedor : Form
    {
        public FormInfoVendedor()
        {
            InitializeComponent();
        }

        private void FormInfoVendedor_Load(object sender, EventArgs e)
        {
            Login.LoadList();
            if (Login123.User != null)
            {
                Login user = Login123.User;
                Vendedor.LoadList();
                Vendedor v = Vendedor.Search(user.CedulaVendedor);

                textBoxIdInfo.Text = v.IdVendedor.ToString();
                textBoxCedulainfo.Text = v.Cedula.ToString();
                textBoxNombreInfo.Text = v.Nombre;
                textBoxFechaNacimientoInfo.Text = v.FechaNacimiento.ToString();
                textBoxSexoInfo.Text = v.Sexo.ToString();
                textBoxTelefonoInfo.Text = v.Telefono.ToString();
                textBoxCorreoInfo.Text = v.Correo;
                textBoxDireccionInfo.Text = v.Direccion;
                textBoxEstadoCivilInfo.Text = v.EstadoCivil.ToString();
                textBoxFechaIngreso.Text = v.FechaIngreso.ToString();
                textBoxSalario.Text = v.Salario.ToString();
                textBoxProfesionInfo.Text = v.Profesion;
                textBoxCalificacionInfo.Text = v.Calificacion.ToString();

            }
        }
    }
}
