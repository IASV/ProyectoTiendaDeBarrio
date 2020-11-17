namespace Venta
{
    partial class FormVenta
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
            this.comboBoxFormaPago = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIdItem = new System.Windows.Forms.TextBox();
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
            this.buttonDeleteVenta = new System.Windows.Forms.Button();
            this.buttonAddVenta = new System.Windows.Forms.Button();
            this.textBoxIdCliente = new System.Windows.Forms.TextBox();
            this.textBoxIdVendedor = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label4IdItem = new System.Windows.Forms.Label();
            this.label3IdCliente = new System.Windows.Forms.Label();
            this.label2IdVendedor = new System.Windows.Forms.Label();
            this.Label1IdVenta = new System.Windows.Forms.Label();
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
            this.splitContainer1.Panel1.Controls.Add(this.comboBoxFormaPago);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxIdItem);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxIdCliente);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxIdVendedor);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxID);
            this.splitContainer1.Panel1.Controls.Add(this.label4IdItem);
            this.splitContainer1.Panel1.Controls.Add(this.label3IdCliente);
            this.splitContainer1.Panel1.Controls.Add(this.label2IdVendedor);
            this.splitContainer1.Panel1.Controls.Add(this.Label1IdVenta);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 11;
            // 
            // comboBoxFormaPago
            // 
            this.comboBoxFormaPago.FormattingEnabled = true;
            this.comboBoxFormaPago.Items.AddRange(new object[] {
            "Credito",
            "Contado"});
            this.comboBoxFormaPago.Location = new System.Drawing.Point(132, 147);
            this.comboBoxFormaPago.Name = "comboBoxFormaPago";
            this.comboBoxFormaPago.Size = new System.Drawing.Size(131, 21);
            this.comboBoxFormaPago.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Forma de pago";
            // 
            // textBoxIdItem
            // 
            this.textBoxIdItem.Location = new System.Drawing.Point(132, 111);
            this.textBoxIdItem.Name = "textBoxIdItem";
            this.textBoxIdItem.Size = new System.Drawing.Size(131, 20);
            this.textBoxIdItem.TabIndex = 30;
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
            this.panel1.Controls.Add(this.buttonDeleteVenta);
            this.panel1.Controls.Add(this.buttonAddVenta);
            this.panel1.Location = new System.Drawing.Point(4, 363);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 84);
            this.panel1.TabIndex = 29;
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
            this.buttonBackStart.Click += new System.EventHandler(this.buttonBackStart_Click);
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
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
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
            this.buttonNextEnd.Click += new System.EventHandler(this.buttonNextEnd_Click);
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
            // buttonDeleteVenta
            // 
            this.buttonDeleteVenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeleteVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeleteVenta.Location = new System.Drawing.Point(180, 57);
            this.buttonDeleteVenta.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDeleteVenta.Name = "buttonDeleteVenta";
            this.buttonDeleteVenta.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteVenta.TabIndex = 1;
            this.buttonDeleteVenta.Text = "Eliminar";
            this.buttonDeleteVenta.UseVisualStyleBackColor = true;
            this.buttonDeleteVenta.Click += new System.EventHandler(this.buttonDeleteVenta_Click);
            // 
            // buttonAddVenta
            // 
            this.buttonAddVenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddVenta.Location = new System.Drawing.Point(4, 57);
            this.buttonAddVenta.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddVenta.Name = "buttonAddVenta";
            this.buttonAddVenta.Size = new System.Drawing.Size(75, 23);
            this.buttonAddVenta.TabIndex = 0;
            this.buttonAddVenta.Text = "Añadir";
            this.buttonAddVenta.UseVisualStyleBackColor = true;
            this.buttonAddVenta.Click += new System.EventHandler(this.buttonAddVenta_Click);
            // 
            // textBoxIdCliente
            // 
            this.textBoxIdCliente.Location = new System.Drawing.Point(132, 76);
            this.textBoxIdCliente.Name = "textBoxIdCliente";
            this.textBoxIdCliente.Size = new System.Drawing.Size(131, 20);
            this.textBoxIdCliente.TabIndex = 21;
            // 
            // textBoxIdVendedor
            // 
            this.textBoxIdVendedor.Location = new System.Drawing.Point(132, 41);
            this.textBoxIdVendedor.Name = "textBoxIdVendedor";
            this.textBoxIdVendedor.Size = new System.Drawing.Size(131, 20);
            this.textBoxIdVendedor.TabIndex = 20;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(132, 9);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(131, 20);
            this.textBoxID.TabIndex = 19;
            // 
            // label4IdItem
            // 
            this.label4IdItem.AutoSize = true;
            this.label4IdItem.Location = new System.Drawing.Point(10, 114);
            this.label4IdItem.Name = "label4IdItem";
            this.label4IdItem.Size = new System.Drawing.Size(41, 13);
            this.label4IdItem.TabIndex = 13;
            this.label4IdItem.Text = "ID Item";
            // 
            // label3IdCliente
            // 
            this.label3IdCliente.AutoSize = true;
            this.label3IdCliente.Location = new System.Drawing.Point(10, 79);
            this.label3IdCliente.Name = "label3IdCliente";
            this.label3IdCliente.Size = new System.Drawing.Size(53, 13);
            this.label3IdCliente.TabIndex = 12;
            this.label3IdCliente.Text = "ID Cliente";
            // 
            // label2IdVendedor
            // 
            this.label2IdVendedor.AutoSize = true;
            this.label2IdVendedor.Location = new System.Drawing.Point(10, 44);
            this.label2IdVendedor.Name = "label2IdVendedor";
            this.label2IdVendedor.Size = new System.Drawing.Size(67, 13);
            this.label2IdVendedor.TabIndex = 11;
            this.label2IdVendedor.Text = "ID Vendedor";
            // 
            // Label1IdVenta
            // 
            this.Label1IdVenta.AutoSize = true;
            this.Label1IdVenta.Location = new System.Drawing.Point(10, 12);
            this.Label1IdVenta.Name = "Label1IdVenta";
            this.Label1IdVenta.Size = new System.Drawing.Size(49, 13);
            this.Label1IdVenta.TabIndex = 10;
            this.Label1IdVenta.Text = "ID Venta";
            // 
            // FormVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venta";
            this.Load += new System.EventHandler(this.FormVenta_Load);
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
        private System.Windows.Forms.Button buttonDeleteVenta;
        private System.Windows.Forms.Button buttonAddVenta;
        private System.Windows.Forms.TextBox textBoxIdCliente;
        private System.Windows.Forms.TextBox textBoxIdVendedor;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label4IdItem;
        private System.Windows.Forms.Label label3IdCliente;
        private System.Windows.Forms.Label label2IdVendedor;
        private System.Windows.Forms.Label Label1IdVenta;
        private System.Windows.Forms.TextBox textBoxIdItem;
        private System.Windows.Forms.ComboBox comboBoxFormaPago;
        private System.Windows.Forms.Label label1;
    }
}

