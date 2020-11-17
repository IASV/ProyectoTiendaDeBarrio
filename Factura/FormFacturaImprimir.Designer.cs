namespace Factura
{
    partial class FormFacturaImprimir
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelProductos = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxCliente = new System.Windows.Forms.TextBox();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.label1Cliente = new System.Windows.Forms.Label();
            this.label1Telefono = new System.Windows.Forms.Label();
            this.label1Direccion = new System.Windows.Forms.Label();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.textBoxNumeroFactura = new System.Windows.Forms.TextBox();
            this.label1NumeroFactura = new System.Windows.Forms.Label();
            this.dateTimePickerFechaFactura = new System.Windows.Forms.DateTimePicker();
            this.label1Fecha = new System.Windows.Forms.Label();
            this.Titulolabel1 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Controls.Add(this.panelProductos);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.textBoxNumeroFactura);
            this.panel1.Controls.Add(this.label1NumeroFactura);
            this.panel1.Controls.Add(this.dateTimePickerFechaFactura);
            this.panel1.Controls.Add(this.label1Fecha);
            this.panel1.Controls.Add(this.Titulolabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(629, 437);
            this.panel1.TabIndex = 0;
            // 
            // panelProductos
            // 
            this.panelProductos.Location = new System.Drawing.Point(13, 234);
            this.panelProductos.Name = "panelProductos";
            this.panelProductos.Size = new System.Drawing.Size(604, 161);
            this.panelProductos.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBoxCliente);
            this.panel2.Controls.Add(this.textBoxTelefono);
            this.panel2.Controls.Add(this.label1Cliente);
            this.panel2.Controls.Add(this.label1Telefono);
            this.panel2.Controls.Add(this.label1Direccion);
            this.panel2.Controls.Add(this.textBoxDireccion);
            this.panel2.Location = new System.Drawing.Point(12, 117);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 100);
            this.panel2.TabIndex = 19;
            // 
            // textBoxCliente
            // 
            this.textBoxCliente.Location = new System.Drawing.Point(79, 25);
            this.textBoxCliente.Name = "textBoxCliente";
            this.textBoxCliente.Size = new System.Drawing.Size(273, 20);
            this.textBoxCliente.TabIndex = 6;
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(456, 60);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(127, 20);
            this.textBoxTelefono.TabIndex = 10;
            // 
            // label1Cliente
            // 
            this.label1Cliente.AutoSize = true;
            this.label1Cliente.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1Cliente.Location = new System.Drawing.Point(8, 29);
            this.label1Cliente.Name = "label1Cliente";
            this.label1Cliente.Size = new System.Drawing.Size(65, 16);
            this.label1Cliente.TabIndex = 5;
            this.label1Cliente.Text = "CLIENTE:";
            // 
            // label1Telefono
            // 
            this.label1Telefono.AutoSize = true;
            this.label1Telefono.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1Telefono.Location = new System.Drawing.Point(371, 60);
            this.label1Telefono.Name = "label1Telefono";
            this.label1Telefono.Size = new System.Drawing.Size(79, 16);
            this.label1Telefono.TabIndex = 9;
            this.label1Telefono.Text = "TELEFONO:";
            // 
            // label1Direccion
            // 
            this.label1Direccion.AutoSize = true;
            this.label1Direccion.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1Direccion.Location = new System.Drawing.Point(8, 64);
            this.label1Direccion.Name = "label1Direccion";
            this.label1Direccion.Size = new System.Drawing.Size(84, 16);
            this.label1Direccion.TabIndex = 7;
            this.label1Direccion.Text = "DIRECCIÓN:";
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(98, 60);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(252, 20);
            this.textBoxDireccion.TabIndex = 8;
            // 
            // textBoxNumeroFactura
            // 
            this.textBoxNumeroFactura.Location = new System.Drawing.Point(512, 84);
            this.textBoxNumeroFactura.Name = "textBoxNumeroFactura";
            this.textBoxNumeroFactura.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumeroFactura.TabIndex = 18;
            // 
            // label1NumeroFactura
            // 
            this.label1NumeroFactura.AutoSize = true;
            this.label1NumeroFactura.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1NumeroFactura.Location = new System.Drawing.Point(419, 85);
            this.label1NumeroFactura.Name = "label1NumeroFactura";
            this.label1NumeroFactura.Size = new System.Drawing.Size(87, 16);
            this.label1NumeroFactura.TabIndex = 17;
            this.label1NumeroFactura.Text = "FACTURA N°";
            // 
            // dateTimePickerFechaFactura
            // 
            this.dateTimePickerFechaFactura.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFechaFactura.Location = new System.Drawing.Point(79, 85);
            this.dateTimePickerFechaFactura.Name = "dateTimePickerFechaFactura";
            this.dateTimePickerFechaFactura.Size = new System.Drawing.Size(114, 20);
            this.dateTimePickerFechaFactura.TabIndex = 16;
            // 
            // label1Fecha
            // 
            this.label1Fecha.AutoSize = true;
            this.label1Fecha.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1Fecha.Location = new System.Drawing.Point(19, 85);
            this.label1Fecha.Name = "label1Fecha";
            this.label1Fecha.Size = new System.Drawing.Size(54, 16);
            this.label1Fecha.TabIndex = 15;
            this.label1Fecha.Text = "FECHA:";
            // 
            // Titulolabel1
            // 
            this.Titulolabel1.AutoSize = true;
            this.Titulolabel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Titulolabel1.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulolabel1.Location = new System.Drawing.Point(236, 9);
            this.Titulolabel1.Name = "Titulolabel1";
            this.Titulolabel1.Size = new System.Drawing.Size(128, 22);
            this.Titulolabel1.TabIndex = 14;
            this.Titulolabel1.Text = "TESLA SHOP";
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSave.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonSave.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Location = new System.Drawing.Point(13, 399);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(30);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(73, 29);
            this.buttonSave.TabIndex = 23;
            this.buttonSave.Text = "Guardar";
            this.buttonSave.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(100, 399);
            this.button1.Margin = new System.Windows.Forms.Padding(30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 29);
            this.button1.TabIndex = 24;
            this.button1.Text = "Imprimir";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // FormFacturaImprimir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 437);
            this.Controls.Add(this.panel1);
            this.Name = "FormFacturaImprimir";
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.FormFactura_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelProductos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxCliente;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.Label label1Cliente;
        private System.Windows.Forms.Label label1Telefono;
        private System.Windows.Forms.Label label1Direccion;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.TextBox textBoxNumeroFactura;
        private System.Windows.Forms.Label label1NumeroFactura;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaFactura;
        private System.Windows.Forms.Label label1Fecha;
        private System.Windows.Forms.Label Titulolabel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonSave;
    }
}

