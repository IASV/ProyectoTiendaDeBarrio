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
    public partial class Login123 : Form
    {
        public Login123()
        {
            InitializeComponent();
        }
        public static Login User { get; set; }
        public static bool StateLogin { get; set; }
      
        
        private void Login123_Load(object sender, EventArgs e)
        {
            StateLogin = false;
            User = new Login();
        }


       
        private void IniciarSesionbutton1_Click(object sender, EventArgs e)
        {

            string user = UsertextBox1.Text;
            string pass = PasswordtextBox2.Text;
            if (UsertextBox1.Text != "")
            {
                if (PasswordtextBox2.Text != "")
                {
                    Login.LoadList();
                    User = Login.Search(user);
                    if (User != null)
                    {
                        if (User.User.Equals(user))
                        {
                           
                            if (User.password.Equals(pass))
                            {

                                MessageBox.Show("Bienvenido " + user + " a Tesla Shop");
                                this.Close();

                            }
                            else
                            {
                                MessageBox.Show("Contraseña incorrecta");
                            }
                        }
                        else
                        {
                            MessageBox.Show("El ususario no existe");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuario no encontrado");
                    }
                    
                }
                else
                {
                    ShowMessajeError("Por favor ingrese su contraseña");
                }
            }
            else
            {

                ShowMessajeError("Por favor ingrese su nombre de usuario");
            }
        }

        private void ShowMessajeError(string mess)
        {
            MessageErrorlabel1.Text = "      " + mess;
            MessageErrorlabel1.Visible = true;

        }

        private void CloseLogin_Click(object sender, EventArgs e)
        {
            this.Close();

            StateLogin = true;

            Fondo fondo = new Fondo();
            fondo.Close();
        }

    }
}
