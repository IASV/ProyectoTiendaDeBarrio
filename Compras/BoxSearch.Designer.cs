namespace Compras
{
    partial class BoxSearch
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.MessageInfoAlert = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(10, 19);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearch.TabIndex = 0;
            // 
            // MessageInfoAlert
            // 
            this.MessageInfoAlert.AutoSize = true;
            this.MessageInfoAlert.Location = new System.Drawing.Point(7, 44);
            this.MessageInfoAlert.Margin = new System.Windows.Forms.Padding(0);
            this.MessageInfoAlert.Name = "MessageInfoAlert";
            this.MessageInfoAlert.Size = new System.Drawing.Size(89, 13);
            this.MessageInfoAlert.TabIndex = 3;
            this.MessageInfoAlert.Text = "MessageInfoAlert";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackgroundImage = global::Compras.Properties.Resources.Add;
            this.buttonAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.buttonAdd.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Location = new System.Drawing.Point(120, 8);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(5);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(44, 41);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click_1);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackgroundImage = global::Compras.Properties.Resources.lupa;
            this.buttonSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSearch.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.buttonSearch.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Location = new System.Drawing.Point(120, 8);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(5);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(44, 41);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click_1);
            // 
            // BoxSearch
            // 
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.MessageInfoAlert);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Name = "BoxSearch";
            this.Size = new System.Drawing.Size(180, 69);
            this.Load += new System.EventHandler(this.BoxSearch_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label MessageInfoAlert;
        private System.Windows.Forms.Button buttonAdd;

        #endregion
    }
}
