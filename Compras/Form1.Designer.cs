namespace Compras
{
    partial class Form1
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
            this.panelDataClient = new System.Windows.Forms.Panel();
            this.groupLoginData = new System.Windows.Forms.GroupBox();
            this.labelMessageInfoAlert = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxCedClient = new System.Windows.Forms.TextBox();
            this.panelDataClient.SuspendLayout();
            this.groupLoginData.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDataClient
            // 
            this.panelDataClient.BackColor = System.Drawing.SystemColors.Control;
            this.panelDataClient.Controls.Add(this.groupLoginData);
            this.panelDataClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDataClient.Location = new System.Drawing.Point(0, 0);
            this.panelDataClient.Name = "panelDataClient";
            this.panelDataClient.Size = new System.Drawing.Size(824, 672);
            this.panelDataClient.TabIndex = 4;
            // 
            // groupLoginData
            // 
            this.groupLoginData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.groupLoginData.BackColor = System.Drawing.SystemColors.Control;
            this.groupLoginData.Controls.Add(this.labelMessageInfoAlert);
            this.groupLoginData.Controls.Add(this.buttonCancel);
            this.groupLoginData.Controls.Add(this.buttonOk);
            this.groupLoginData.Controls.Add(this.label7);
            this.groupLoginData.Controls.Add(this.textBoxCedClient);
            this.groupLoginData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupLoginData.Location = new System.Drawing.Point(259, 257);
            this.groupLoginData.Name = "groupLoginData";
            this.groupLoginData.Size = new System.Drawing.Size(295, 153);
            this.groupLoginData.TabIndex = 0;
            this.groupLoginData.TabStop = false;
            this.groupLoginData.Text = "Cliente";
            // 
            // labelMessageInfoAlert
            // 
            this.labelMessageInfoAlert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelMessageInfoAlert.AutoSize = true;
            this.labelMessageInfoAlert.Location = new System.Drawing.Point(97, 110);
            this.labelMessageInfoAlert.Name = "labelMessageInfoAlert";
            this.labelMessageInfoAlert.Size = new System.Drawing.Size(89, 13);
            this.labelMessageInfoAlert.TabIndex = 4;
            this.labelMessageInfoAlert.Text = "MessageInfoAlert";
            this.labelMessageInfoAlert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.buttonCancel.FlatAppearance.BorderSize = 0;
            this.buttonCancel.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonCancel.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Location = new System.Drawing.Point(144, 106);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(20);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(81, 24);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonOk.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.buttonOk.FlatAppearance.BorderSize = 0;
            this.buttonOk.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonOk.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOk.Location = new System.Drawing.Point(63, 106);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(20);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(81, 24);
            this.buttonOk.TabIndex = 2;
            this.buttonOk.Text = "Aceptar";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(80, 36);
            this.label7.Margin = new System.Windows.Forms.Padding(20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Ingrese cédula del cliente";
            // 
            // textBoxCedClient
            // 
            this.textBoxCedClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBoxCedClient.Location = new System.Drawing.Point(63, 72);
            this.textBoxCedClient.Name = "textBoxCedClient";
            this.textBoxCedClient.Size = new System.Drawing.Size(162, 20);
            this.textBoxCedClient.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 672);
            this.Controls.Add(this.panelDataClient);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelDataClient.ResumeLayout(false);
            this.groupLoginData.ResumeLayout(false);
            this.groupLoginData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDataClient;
        private System.Windows.Forms.GroupBox groupLoginData;
        private System.Windows.Forms.Label labelMessageInfoAlert;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxCedClient;
    }
}