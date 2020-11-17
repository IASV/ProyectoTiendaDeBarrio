namespace Inventario
{
    partial class FormInventario
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonCleanBoxs = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.labelPositionID = new System.Windows.Forms.Label();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonBackStart = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonNextEnd = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonDeleteClient = new System.Windows.Forms.Button();
            this.buttonAddClient = new System.Windows.Forms.Button();
            this.dateTimePickerFechaSalida = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxIDProducto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.textBoxPrecioVenta = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxPrecioBase = new System.Windows.Forms.TextBox();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.dateTimePickerFechaSalida);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxIDProducto);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.dateTimePickerFechaIngreso);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxPrecioVenta);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxID);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxPrecioBase);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxCantidad);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.buttonCleanBoxs);
            this.panel1.Controls.Add(this.buttonUpdate);
            this.panel1.Controls.Add(this.labelPositionID);
            this.panel1.Controls.Add(this.textBoxBuscar);
            this.panel1.Controls.Add(this.buttonSearch);
            this.panel1.Controls.Add(this.buttonBackStart);
            this.panel1.Controls.Add(this.buttonBack);
            this.panel1.Controls.Add(this.buttonNextEnd);
            this.panel1.Controls.Add(this.buttonNext);
            this.panel1.Controls.Add(this.buttonDeleteClient);
            this.panel1.Controls.Add(this.buttonAddClient);
            this.panel1.Location = new System.Drawing.Point(4, 363);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 84);
            this.panel1.TabIndex = 43;
            // 
            // buttonCleanBoxs
            // 
            this.buttonCleanBoxs.Location = new System.Drawing.Point(180, 29);
            this.buttonCleanBoxs.Name = "buttonCleanBoxs";
            this.buttonCleanBoxs.Size = new System.Drawing.Size(75, 23);
            this.buttonCleanBoxs.TabIndex = 11;
            this.buttonCleanBoxs.Text = "Limpiar";
            this.buttonCleanBoxs.UseVisualStyleBackColor = true;
            this.buttonCleanBoxs.Click += new System.EventHandler(this.buttonCleanBoxs_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(87, 57);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(85, 23);
            this.buttonUpdate.TabIndex = 10;
            this.buttonUpdate.Text = "Actualizar";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // labelPositionID
            // 
            this.labelPositionID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPositionID.Location = new System.Drawing.Point(87, 8);
            this.labelPositionID.Name = "labelPositionID";
            this.labelPositionID.Size = new System.Drawing.Size(85, 13);
            this.labelPositionID.TabIndex = 9;
            this.labelPositionID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBuscar.Location = new System.Drawing.Point(118, 30);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(20, 20);
            this.textBoxBuscar.TabIndex = 8;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSearch.Location = new System.Drawing.Point(4, 29);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 7;
            this.buttonSearch.Text = "Buscar";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonBackStart
            // 
            this.buttonBackStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBackStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBackStart.Location = new System.Drawing.Point(26, 3);
            this.buttonBackStart.Margin = new System.Windows.Forms.Padding(1);
            this.buttonBackStart.Name = "buttonBackStart";
            this.buttonBackStart.Size = new System.Drawing.Size(29, 23);
            this.buttonBackStart.TabIndex = 5;
            this.buttonBackStart.Text = "<<";
            this.buttonBackStart.UseVisualStyleBackColor = true;
            this.buttonBackStart.Click += new System.EventHandler(this.buttonBackStart_Click_1);
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBack.Location = new System.Drawing.Point(57, 3);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(1);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(26, 23);
            this.buttonBack.TabIndex = 4;
            this.buttonBack.Text = "<";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click_1);
            // 
            // buttonNextEnd
            // 
            this.buttonNextEnd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNextEnd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNextEnd.Location = new System.Drawing.Point(204, 3);
            this.buttonNextEnd.Margin = new System.Windows.Forms.Padding(1);
            this.buttonNextEnd.Name = "buttonNextEnd";
            this.buttonNextEnd.Size = new System.Drawing.Size(29, 23);
            this.buttonNextEnd.TabIndex = 3;
            this.buttonNextEnd.Text = ">>";
            this.buttonNextEnd.UseVisualStyleBackColor = true;
            this.buttonNextEnd.Click += new System.EventHandler(this.buttonNextEnd_Click_1);
            // 
            // buttonNext
            // 
            this.buttonNext.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNext.Location = new System.Drawing.Point(176, 3);
            this.buttonNext.Margin = new System.Windows.Forms.Padding(1);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(26, 23);
            this.buttonNext.TabIndex = 2;
            this.buttonNext.Text = ">";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonDeleteClient
            // 
            this.buttonDeleteClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeleteClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeleteClient.Location = new System.Drawing.Point(180, 57);
            this.buttonDeleteClient.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDeleteClient.Name = "buttonDeleteClient";
            this.buttonDeleteClient.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteClient.TabIndex = 1;
            this.buttonDeleteClient.Text = "Eliminar";
            this.buttonDeleteClient.UseVisualStyleBackColor = true;
            this.buttonDeleteClient.Click += new System.EventHandler(this.buttonDeleteClient_Click);
            // 
            // buttonAddClient
            // 
            this.buttonAddClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddClient.Location = new System.Drawing.Point(4, 57);
            this.buttonAddClient.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddClient.Name = "buttonAddClient";
            this.buttonAddClient.Size = new System.Drawing.Size(75, 23);
            this.buttonAddClient.TabIndex = 0;
            this.buttonAddClient.Text = "Añadir";
            this.buttonAddClient.UseVisualStyleBackColor = true;
            this.buttonAddClient.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // dateTimePickerFechaSalida
            // 
            this.dateTimePickerFechaSalida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePickerFechaSalida.CustomFormat = "d/MM/yyyy";
            this.dateTimePickerFechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFechaSalida.Location = new System.Drawing.Point(132, 216);
            this.dateTimePickerFechaSalida.Name = "dateTimePickerFechaSalida";
            this.dateTimePickerFechaSalida.Size = new System.Drawing.Size(131, 20);
            this.dateTimePickerFechaSalida.TabIndex = 42;
            this.dateTimePickerFechaSalida.Value = new System.DateTime(2020, 10, 1, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "Fecha de salida";
            // 
            // textBoxIDProducto
            // 
            this.textBoxIDProducto.Location = new System.Drawing.Point(132, 45);
            this.textBoxIDProducto.Name = "textBoxIDProducto";
            this.textBoxIDProducto.Size = new System.Drawing.Size(131, 20);
            this.textBoxIDProducto.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "ID Producto";
            // 
            // dateTimePickerFechaIngreso
            // 
            this.dateTimePickerFechaIngreso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePickerFechaIngreso.CustomFormat = "d/MM/yyyy";
            this.dateTimePickerFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFechaIngreso.Location = new System.Drawing.Point(132, 180);
            this.dateTimePickerFechaIngreso.Name = "dateTimePickerFechaIngreso";
            this.dateTimePickerFechaIngreso.Size = new System.Drawing.Size(131, 20);
            this.dateTimePickerFechaIngreso.TabIndex = 38;
            this.dateTimePickerFechaIngreso.Value = new System.DateTime(2020, 10, 1, 0, 0, 0, 0);
            // 
            // textBoxPrecioVenta
            // 
            this.textBoxPrecioVenta.Location = new System.Drawing.Point(132, 148);
            this.textBoxPrecioVenta.Name = "textBoxPrecioVenta";
            this.textBoxPrecioVenta.Size = new System.Drawing.Size(131, 20);
            this.textBoxPrecioVenta.TabIndex = 37;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(132, 12);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(131, 20);
            this.textBoxID.TabIndex = 36;
            // 
            // textBoxPrecioBase
            // 
            this.textBoxPrecioBase.Location = new System.Drawing.Point(132, 112);
            this.textBoxPrecioBase.Name = "textBoxPrecioBase";
            this.textBoxPrecioBase.Size = new System.Drawing.Size(131, 20);
            this.textBoxPrecioBase.TabIndex = 35;
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Location = new System.Drawing.Point(132, 77);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(131, 20);
            this.textBoxCantidad.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Precio Venta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Fecha de ingreso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Precio Base";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Cantidad";
            // 
            // FormInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.FormInventario_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonCleanBoxs;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label labelPositionID;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonBackStart;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonNextEnd;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonDeleteClient;
        private System.Windows.Forms.Button buttonAddClient;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaSalida;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxIDProducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaIngreso;
        private System.Windows.Forms.TextBox textBoxPrecioVenta;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxPrecioBase;
        private System.Windows.Forms.TextBox textBoxCantidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

