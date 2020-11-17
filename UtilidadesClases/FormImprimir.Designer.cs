namespace UtilidadesClases
{
    partial class FormImprimir
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
            this.panelImprimir = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelImprimir
            // 
            this.panelImprimir.AutoScroll = true;
            this.panelImprimir.AutoSize = true;
            this.panelImprimir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelImprimir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelImprimir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelImprimir.Location = new System.Drawing.Point(0, 0);
            this.panelImprimir.Margin = new System.Windows.Forms.Padding(0);
            this.panelImprimir.Name = "panelImprimir";
            this.panelImprimir.Size = new System.Drawing.Size(800, 450);
            this.panelImprimir.TabIndex = 0;
            // 
            // FormImprimir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelImprimir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "FormImprimir";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Imprimir";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormImprimir_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelImprimir;
    }
}