﻿namespace Compras
{
    partial class FormCompras
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
            this.label5 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonBuy = new System.Windows.Forms.Button();
            this.panelListBuy = new System.Windows.Forms.Panel();
            this.panelDetailsBuy = new System.Windows.Forms.Panel();
            this.labelIVA = new System.Windows.Forms.Label();
            this.labelSubtotal = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelListProducts = new System.Windows.Forms.Panel();
            this.tableLayoutPanelFatherBuy = new System.Windows.Forms.TableLayoutPanel();
            this.groupLoginData = new System.Windows.Forms.GroupBox();
            this.textBoxCedClient = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.labelMessageInfoAlert = new System.Windows.Forms.Label();
            this.panelDataClient = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.boxAdd = new Compras.BoxSearch();
            this.boxSearch = new Compras.BoxSearch();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panelDetailsBuy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanelFatherBuy.SuspendLayout();
            this.groupLoginData.SuspendLayout();
            this.panelDataClient.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.boxSearch);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 78);
            this.panel1.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Filtrar por nombre";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 413);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.buttonBuy);
            this.splitContainer1.Panel1.Controls.Add(this.boxAdd);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panelListBuy);
            this.splitContainer1.Panel2.Controls.Add(this.panelDetailsBuy);
            this.splitContainer1.Size = new System.Drawing.Size(774, 299);
            this.splitContainer1.SplitterDistance = 379;
            this.splitContainer1.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "ID Producto";
            // 
            // buttonBuy
            // 
            this.buttonBuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonBuy.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonBuy.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.buttonBuy.FlatAppearance.BorderSize = 0;
            this.buttonBuy.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonBuy.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuy.Location = new System.Drawing.Point(30, 210);
            this.buttonBuy.Margin = new System.Windows.Forms.Padding(30);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(115, 59);
            this.buttonBuy.TabIndex = 1;
            this.buttonBuy.Text = "Comprar";
            this.buttonBuy.UseVisualStyleBackColor = false;
            this.buttonBuy.Click += new System.EventHandler(this.buttonBuy_Click);
            // 
            // panelListBuy
            // 
            this.panelListBuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelListBuy.Location = new System.Drawing.Point(20, 0);
            this.panelListBuy.Margin = new System.Windows.Forms.Padding(0);
            this.panelListBuy.Name = "panelListBuy";
            this.panelListBuy.Size = new System.Drawing.Size(352, 169);
            this.panelListBuy.TabIndex = 1;
            this.panelListBuy.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.panelListBuy_ControlAdded);
            // 
            // panelDetailsBuy
            // 
            this.panelDetailsBuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDetailsBuy.BackColor = System.Drawing.SystemColors.Info;
            this.panelDetailsBuy.Controls.Add(this.labelIVA);
            this.panelDetailsBuy.Controls.Add(this.labelSubtotal);
            this.panelDetailsBuy.Controls.Add(this.labelTotal);
            this.panelDetailsBuy.Controls.Add(this.labelCantidad);
            this.panelDetailsBuy.Controls.Add(this.label4);
            this.panelDetailsBuy.Controls.Add(this.label3);
            this.panelDetailsBuy.Controls.Add(this.label2);
            this.panelDetailsBuy.Controls.Add(this.label1);
            this.panelDetailsBuy.Controls.Add(this.pictureBox1);
            this.panelDetailsBuy.Location = new System.Drawing.Point(20, 169);
            this.panelDetailsBuy.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.panelDetailsBuy.Name = "panelDetailsBuy";
            this.panelDetailsBuy.Size = new System.Drawing.Size(352, 100);
            this.panelDetailsBuy.TabIndex = 0;
            // 
            // labelIVA
            // 
            this.labelIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIVA.Location = new System.Drawing.Point(84, 48);
            this.labelIVA.Margin = new System.Windows.Forms.Padding(2);
            this.labelIVA.Name = "labelIVA";
            this.labelIVA.Size = new System.Drawing.Size(141, 20);
            this.labelIVA.TabIndex = 10;
            this.labelIVA.Text = "IVA";
            this.labelIVA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSubtotal
            // 
            this.labelSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubtotal.Location = new System.Drawing.Point(84, 24);
            this.labelSubtotal.Margin = new System.Windows.Forms.Padding(2);
            this.labelSubtotal.Name = "labelSubtotal";
            this.labelSubtotal.Size = new System.Drawing.Size(141, 20);
            this.labelSubtotal.TabIndex = 9;
            this.labelSubtotal.Text = "Subtotal";
            this.labelSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTotal
            // 
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(84, 72);
            this.labelTotal.Margin = new System.Windows.Forms.Padding(2);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(141, 20);
            this.labelTotal.TabIndex = 8;
            this.labelTotal.Text = "Total";
            this.labelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelCantidad
            // 
            this.labelCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantidad.Location = new System.Drawing.Point(84, 0);
            this.labelCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(141, 20);
            this.labelCantidad.TabIndex = 7;
            this.labelCantidad.Text = "Cantidad";
            this.labelCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 48);
            this.label4.Margin = new System.Windows.Forms.Padding(2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "IVA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Subtotal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Total";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cantidad";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Compras.Properties.Resources.TIENDA;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(252, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panelListProducts
            // 
            this.panelListProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelListProducts.Location = new System.Drawing.Point(30, 114);
            this.panelListProducts.Margin = new System.Windows.Forms.Padding(30);
            this.panelListProducts.Name = "panelListProducts";
            this.panelListProducts.Size = new System.Drawing.Size(720, 266);
            this.panelListProducts.TabIndex = 1;
            this.panelListProducts.Paint += new System.Windows.Forms.PaintEventHandler(this.panelListProducts_Paint);
            // 
            // tableLayoutPanelFatherBuy
            // 
            this.tableLayoutPanelFatherBuy.ColumnCount = 1;
            this.tableLayoutPanelFatherBuy.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelFatherBuy.Controls.Add(this.panelListProducts, 0, 1);
            this.tableLayoutPanelFatherBuy.Controls.Add(this.splitContainer1, 0, 2);
            this.tableLayoutPanelFatherBuy.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanelFatherBuy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelFatherBuy.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelFatherBuy.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelFatherBuy.Name = "tableLayoutPanelFatherBuy";
            this.tableLayoutPanelFatherBuy.RowCount = 3;
            this.tableLayoutPanelFatherBuy.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.5F));
            this.tableLayoutPanelFatherBuy.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.5F));
            this.tableLayoutPanelFatherBuy.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 304F));
            this.tableLayoutPanelFatherBuy.Size = new System.Drawing.Size(780, 715);
            this.tableLayoutPanelFatherBuy.TabIndex = 0;
            // 
            // groupLoginData
            // 
            this.groupLoginData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.groupLoginData.BackColor = System.Drawing.Color.Transparent;
            this.groupLoginData.Controls.Add(this.panel2);
            this.groupLoginData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupLoginData.Location = new System.Drawing.Point(237, 257);
            this.groupLoginData.Name = "groupLoginData";
            this.groupLoginData.Size = new System.Drawing.Size(295, 179);
            this.groupLoginData.TabIndex = 0;
            this.groupLoginData.TabStop = false;
            this.groupLoginData.Text = "Cliente";
            // 
            // textBoxCedClient
            // 
            this.textBoxCedClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBoxCedClient.Location = new System.Drawing.Point(62, 58);
            this.textBoxCedClient.Name = "textBoxCedClient";
            this.textBoxCedClient.Size = new System.Drawing.Size(162, 20);
            this.textBoxCedClient.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(79, 22);
            this.label7.Margin = new System.Windows.Forms.Padding(20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Ingrese cédula del cliente";
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonOk.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.buttonOk.FlatAppearance.BorderSize = 0;
            this.buttonOk.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonOk.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOk.Location = new System.Drawing.Point(99, 118);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(20);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(81, 24);
            this.buttonOk.TabIndex = 2;
            this.buttonOk.Text = "Validar";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // labelMessageInfoAlert
            // 
            this.labelMessageInfoAlert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelMessageInfoAlert.AutoSize = true;
            this.labelMessageInfoAlert.Location = new System.Drawing.Point(96, 96);
            this.labelMessageInfoAlert.Name = "labelMessageInfoAlert";
            this.labelMessageInfoAlert.Size = new System.Drawing.Size(89, 13);
            this.labelMessageInfoAlert.TabIndex = 4;
            this.labelMessageInfoAlert.Text = "MessageInfoAlert";
            this.labelMessageInfoAlert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelDataClient
            // 
            this.panelDataClient.BackColor = System.Drawing.SystemColors.Control;
            this.panelDataClient.Controls.Add(this.groupLoginData);
            this.panelDataClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDataClient.Location = new System.Drawing.Point(0, 0);
            this.panelDataClient.Name = "panelDataClient";
            this.panelDataClient.Size = new System.Drawing.Size(780, 715);
            this.panelDataClient.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.textBoxCedClient);
            this.panel2.Controls.Add(this.labelMessageInfoAlert);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.buttonOk);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(289, 160);
            this.panel2.TabIndex = 5;
            // 
            // boxAdd
            // 
            this.boxAdd.CantidadItem = 0;
            this.boxAdd.Location = new System.Drawing.Point(125, 3);
            this.boxAdd.Name = "boxAdd";
            this.boxAdd.panel = null;
            this.boxAdd.pathDataBase = null;
            this.boxAdd.SearchFor = null;
            this.boxAdd.Size = new System.Drawing.Size(213, 74);
            this.boxAdd.SubTotal = ((long)(0));
            this.boxAdd.TabIndex = 0;
            this.boxAdd.Titles = null;
            this.boxAdd.Total = 0D;
            this.boxAdd.VisibleButtonAdd = true;
            this.boxAdd.VisibleButtonSearch = false;
            this.boxAdd.Load += new System.EventHandler(this.boxAdd_Load);
            // 
            // boxSearch
            // 
            this.boxSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.boxSearch.CantidadItem = 0;
            this.boxSearch.Location = new System.Drawing.Point(162, 3);
            this.boxSearch.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.boxSearch.Name = "boxSearch";
            this.boxSearch.panel = null;
            this.boxSearch.pathDataBase = null;
            this.boxSearch.SearchFor = null;
            this.boxSearch.Size = new System.Drawing.Size(213, 72);
            this.boxSearch.SubTotal = ((long)(0));
            this.boxSearch.TabIndex = 0;
            this.boxSearch.Titles = null;
            this.boxSearch.Total = 0D;
            this.boxSearch.VisibleButtonAdd = false;
            this.boxSearch.VisibleButtonSearch = true;
            this.boxSearch.Load += new System.EventHandler(this.boxSearch_Load);
            // 
            // FormCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 715);
            this.Controls.Add(this.panelDataClient);
            this.Controls.Add(this.tableLayoutPanelFatherBuy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compras";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panelDetailsBuy.ResumeLayout(false);
            this.panelDetailsBuy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanelFatherBuy.ResumeLayout(false);
            this.groupLoginData.ResumeLayout(false);
            this.panelDataClient.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private BoxSearch boxSearch;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonBuy;
        private BoxSearch boxAdd;
        private System.Windows.Forms.Panel panelListBuy;
        private System.Windows.Forms.Panel panelDetailsBuy;
        private System.Windows.Forms.Label labelIVA;
        private System.Windows.Forms.Label labelSubtotal;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelCantidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelListProducts;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelFatherBuy;
        private System.Windows.Forms.GroupBox groupLoginData;
        private System.Windows.Forms.Label labelMessageInfoAlert;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxCedClient;
        private System.Windows.Forms.Panel panelDataClient;
        private System.Windows.Forms.Panel panel2;
    }
}

