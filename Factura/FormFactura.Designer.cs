namespace Factura
{
    partial class FormFactura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.textBoxPrecioFinal = new System.Windows.Forms.TextBox();
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
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxIdVenta = new System.Windows.Forms.TextBox();
            this.textBoxIdFactura = new System.Windows.Forms.TextBox();
            this.label4PrecioFinal = new System.Windows.Forms.Label();
            this.label2IdVenta = new System.Windows.Forms.Label();
            this.label1IdFactura = new System.Windows.Forms.Label();
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
            this.splitContainer1.Panel1.Controls.Add(this.textBoxPrecioFinal);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxIdVenta);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxIdFactura);
            this.splitContainer1.Panel1.Controls.Add(this.label4PrecioFinal);
            this.splitContainer1.Panel1.Controls.Add(this.label2IdVenta);
            this.splitContainer1.Panel1.Controls.Add(this.label1IdFactura);
            this.splitContainer1.Size = new System.Drawing.Size(800, 466);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 12;
            // 
            // textBoxPrecioFinal
            // 
            this.textBoxPrecioFinal.Location = new System.Drawing.Point(132, 72);
            this.textBoxPrecioFinal.Name = "textBoxPrecioFinal";
            this.textBoxPrecioFinal.Size = new System.Drawing.Size(131, 20);
            this.textBoxPrecioFinal.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonCleanBoxs);
            this.panel1.Controls.Add(this.buttonUpdate);
            this.panel1.Controls.Add(this.labelPositionID);
            this.panel1.Controls.Add(this.textBoxBuscar);
            this.panel1.Controls.Add(this.buttonSearch);
            this.panel1.Controls.Add(this.buttonBackStart);
            this.panel1.Controls.Add(this.buttonBack);
            this.panel1.Controls.Add(this.buttonNextEnd);
            this.panel1.Controls.Add(this.buttonNext);
            this.panel1.Controls.Add(this.buttonDelete);
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Location = new System.Drawing.Point(4, 377);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 88);
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
            this.buttonCleanBoxs.Click += new System.EventHandler(this.buttonCleanBoxs_Click_1);
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
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.Location = new System.Drawing.Point(180, 57);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "Eliminar";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.Location = new System.Drawing.Point(4, 57);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Añadir";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxIdVenta
            // 
            this.textBoxIdVenta.Location = new System.Drawing.Point(132, 41);
            this.textBoxIdVenta.Name = "textBoxIdVenta";
            this.textBoxIdVenta.Size = new System.Drawing.Size(131, 20);
            this.textBoxIdVenta.TabIndex = 20;
            // 
            // textBoxIdFactura
            // 
            this.textBoxIdFactura.Location = new System.Drawing.Point(132, 9);
            this.textBoxIdFactura.Name = "textBoxIdFactura";
            this.textBoxIdFactura.ReadOnly = true;
            this.textBoxIdFactura.Size = new System.Drawing.Size(131, 20);
            this.textBoxIdFactura.TabIndex = 19;
            // 
            // label4PrecioFinal
            // 
            this.label4PrecioFinal.AutoSize = true;
            this.label4PrecioFinal.Location = new System.Drawing.Point(10, 75);
            this.label4PrecioFinal.Name = "label4PrecioFinal";
            this.label4PrecioFinal.Size = new System.Drawing.Size(62, 13);
            this.label4PrecioFinal.TabIndex = 13;
            this.label4PrecioFinal.Text = "Precio Final";
            // 
            // label2IdVenta
            // 
            this.label2IdVenta.AutoSize = true;
            this.label2IdVenta.Location = new System.Drawing.Point(10, 44);
            this.label2IdVenta.Name = "label2IdVenta";
            this.label2IdVenta.Size = new System.Drawing.Size(49, 13);
            this.label2IdVenta.TabIndex = 11;
            this.label2IdVenta.Text = "ID Venta";
            // 
            // label1IdFactura
            // 
            this.label1IdFactura.AutoSize = true;
            this.label1IdFactura.Location = new System.Drawing.Point(10, 12);
            this.label1IdFactura.Name = "label1IdFactura";
            this.label1IdFactura.Size = new System.Drawing.Size(57, 13);
            this.label1IdFactura.TabIndex = 10;
            this.label1IdFactura.Text = "ID Factura";
            // 
            // FormFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 466);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormFactura";
            this.Text = "FormFactura";
            this.Load += new System.EventHandler(this.FormFactura_Load);
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
        private System.Windows.Forms.TextBox textBoxPrecioFinal;
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
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxIdVenta;
        private System.Windows.Forms.TextBox textBoxIdFactura;
        private System.Windows.Forms.Label label4PrecioFinal;
        private System.Windows.Forms.Label label2IdVenta;
        private System.Windows.Forms.Label label1IdFactura;
    }
}