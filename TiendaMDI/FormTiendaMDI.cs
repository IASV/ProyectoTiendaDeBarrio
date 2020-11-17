using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilidadesGestionArchivo;
using UtilidadesClases;
using Venta;
using Inventario;
using Compras;


namespace TiendaMDI
{
    public partial class FormTiendaMDI : Form
    {
        public FormTiendaMDI()
        {
            InitializeComponent();
            StatePanel();
        }

        private void OpenClose()
        {
            this.Opacity = 0;

            Fondo fondo = new Fondo();
            fondo.Show();

            Login123 login1 = new Login123();
            login1.ShowDialog();

            fondo.Close();



            if (Login123.StateLogin)
            {
                this.Close();
            }
            else
            {
                Opacity = 100;
            }
        }

        private void FormTiendaMDI_Load_1(object sender, EventArgs e)
        {
            OpenClose();
            PanelBuy();
        }

        private void StatePanel()
        {
            panel1Herramientas.Visible = false;
            panel1Usuario.Visible = false;
            
        }

        private void OcultarSubMenu()
        {
            if (panel1Herramientas.Visible == true)
            {
                panel1Herramientas.Visible = false;
                
            }

            if (panel1Usuario.Visible == true)
            {
                panel1Usuario.Visible = false;
                
            }


        }

        private void MostrarSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                OcultarSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void button1Herramientas_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panel1Herramientas);
        }

        private void button1Usuario_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panel1Usuario);
        }

        private void button1CerrarSesión_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Desea cerrar Sesión ", "Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) 
            { 
                OpenClose();
                
            }
            
            

        }
        FormVendedor vendedor = new FormVendedor();
        FormCliente cliente = new FormCliente();
        FormVenta venta = new FormVenta();
        FormProducto producto = new FormProducto();
        FormCompras compras = new FormCompras();
        FormInventario inventario = new FormInventario();
        FormInfoVendedor infovendedor = new FormInfoVendedor();
        FormInfoCliente infocliente = new FormInfoCliente();



        private void VendedorForm()
        {
            cliente.Visible = false;
            venta.Visible = false;
            producto.Visible = false;
            compras.Visible = false;
            inventario.Visible = false;
            infovendedor.Visible = false;
            infocliente.Visible = false;


            vendedor.MaximumSize = panelOption.MaximumSize;
            vendedor.MinimumSize = panelOption.MinimumSize;

            vendedor.Size = panelOption.Size;
            vendedor.TopLevel = false;
            panelOption.Controls.Add(vendedor);
            vendedor.Show();
        }

        private void button1Vendedor_Click(object sender, EventArgs e)
        {

            VendedorForm();
            
        }

        private void button2Cliente_Click(object sender, EventArgs e)
        {
            /*HideForm2(vendedor, cliente, venta, producto, compras, inventario, 2 );*/

            vendedor.Visible = false;
            venta.Visible = false;
            producto.Visible = false;
            compras.Visible = false;
            inventario.Visible = false;
            infovendedor.Visible = false;
            infocliente.Visible = false;

            cliente.MaximumSize = panelOption.MaximumSize;
            cliente.MinimumSize = panelOption.MinimumSize;

            cliente.Size = panelOption.Size;
            cliente.TopLevel = false;
            panelOption.Controls.Add(cliente);
            cliente.Show();
        }

        private void button3Venta_Click(object sender, EventArgs e)
        {

            vendedor.Visible = false;
            cliente.Visible = false;
            producto.Visible = false;
            compras.Visible = false;
            inventario.Visible = false;
            infovendedor.Visible = false;
            infocliente.Visible = false;

            venta.MaximumSize = panelOption.MaximumSize;
            venta.MinimumSize = panelOption.MinimumSize;

            venta.Size = panelOption.Size;
            venta.TopLevel = false;
            panelOption.Controls.Add(venta);
            venta.Show();
        }
        private void buttonProductos_Click(object sender, EventArgs e)
        {
            vendedor.Visible = false;
            cliente.Visible = false;
            venta.Visible = false;           
            compras.Visible = false;
            inventario.Visible = false;
            infovendedor.Visible = false;
            infocliente.Visible = false;

            producto.MaximumSize = panelOption.MaximumSize;
            producto.MinimumSize = panelOption.MinimumSize;

            producto.Size = panelOption.Size;
            producto.TopLevel = false;
            panelOption.Controls.Add(producto);
            producto.Show();

        }

        private void buttonInventario_Click(object sender, EventArgs e)
        {
            vendedor.Visible = false;
            cliente.Visible = false;
            venta.Visible = false;
            compras.Visible = false;
            producto.Visible = false;
            inventario.Visible = false;
            infovendedor.Visible = false;
            infocliente.Visible = false;

            inventario.MaximumSize = panelOption.MaximumSize;
            inventario.MinimumSize = panelOption.MinimumSize;

            inventario.Size = panelOption.Size;
            inventario.TopLevel = false;
            panelOption.Controls.Add(inventario);
            inventario.Show();


        }

        private void button5UsuarioCliente_Click(object sender, EventArgs e)
        {
            vendedor.Visible = false;
            cliente.Visible = false;
            venta.Visible = false;
            compras.Visible = false;
            producto.Visible = false;
            inventario.Visible = false;
            infovendedor.Visible = false;

            infocliente.MaximumSize = panelOption.MaximumSize;
            infocliente.MinimumSize = panelOption.MinimumSize;

            infocliente.Size = panelOption.Size;
            infocliente.TopLevel = false;
            panelOption.Controls.Add(infocliente);
            infocliente.Show();

        }

        private void button3UsuarioVendedor_Click(object sender, EventArgs e)
        {
            
            /*Login.LoadList();
            if (Login123.User != null)
            {
                Login user = Login123.User;
                Vendedor v = Vendedor.Search(user.CedulaVendedor);

                

            }*/

            vendedor.Visible = false;
            cliente.Visible = false;
            venta.Visible = false;
            compras.Visible = false;
            producto.Visible = false;
            inventario.Visible = false;
            infocliente.Visible = false;

            infovendedor.MaximumSize = panelOption.MaximumSize;
            infovendedor.MinimumSize = panelOption.MinimumSize;

            infovendedor.Size = panelOption.Size;
            infovendedor.TopLevel = false;
            panelOption.Controls.Add(infovendedor);
            infovendedor.Show();
        }

        private void buttonComprar_Click(object sender, EventArgs e)
        {
            PanelBuy();
        }
        
        private void PanelBuy()
        {
            vendedor.Visible = false;
            cliente.Visible = false;
            venta.Visible = false;
            producto.Visible = false;
            inventario.Visible = false;
            infovendedor.Visible = false;
            infocliente.Visible = false;

            compras.MaximumSize = panelOption.MaximumSize;
            compras.MinimumSize = panelOption.MinimumSize;

            compras.Size = panelOption.Size;
            compras.TopLevel = false;
            panelOption.Controls.Add(compras);
            compras.Show();
        }

       

        /*private void HideForm(Form Vendedor, Form Cliente, Form Venta, Form Producto, Form Compras, Form Inventario,
           bool vendedor = false, bool cliente = false, bool venta = false, bool producto = false, bool compras= false, bool inventario=false)
       {
           Vendedor.Visible = vendedor;
           Cliente.Visible = cliente;
           Venta.Visible = venta;
           Producto.Visible = producto;
           Compras.Visible = compras;
           *//*Inventario.Visible = inventario;*//*
       }*/

        /* private void HideForm2(Form Vendedor, Form Cliente, Form Venta, Form Producto, Form Compras, Form Inventario, int form)
         {
             switch (form)
             {
                 case 1:
                     Cliente.Visible = false;
                     Venta.Visible = false;
                     Producto.Visible = false;
                     Compras.Visible = false;
                     break;
                 case 2:
                     Vendedor.Visible = false;
                     Venta.Visible = false;
                     Producto.Visible = false;
                     Compras.Visible = false;
                     break;
                 case 3:
                     Vendedor.Visible = false;
                     Cliente.Visible = false;
                     Producto.Visible = false;
                     Compras.Visible = false;
                     break;
                 case 4:
                     Vendedor.Visible = false;
                     Cliente.Visible = false;
                     Venta.Visible = false;
                     Compras.Visible = false;
                     break;
                 case 5:
                     Vendedor.Visible = false;
                     Cliente.Visible = false;
                     Venta.Visible = false;
                     Producto.Visible = false;
                     break;
                 default:
                     break;
             }

         }*/
    }
}
