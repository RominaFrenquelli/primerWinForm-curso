namespace ejercicio1
{
    partial class Form1MiPrimerApp
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
            this.btnSaludar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSaludo = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSaludar
            // 
            this.btnSaludar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaludar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSaludar.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral;
            this.btnSaludar.FlatAppearance.BorderSize = 3;
            this.btnSaludar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaludar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSaludar.Image = global::ejercicio1.Properties.Resources.images1;
            this.btnSaludar.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnSaludar.Location = new System.Drawing.Point(502, 419);
            this.btnSaludar.Name = "btnSaludar";
            this.btnSaludar.Size = new System.Drawing.Size(135, 53);
            this.btnSaludar.TabIndex = 0;
            this.btnSaludar.Text = "Saludar";
            this.btnSaludar.UseVisualStyleBackColor = false;
            this.btnSaludar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(38, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            this.label2.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label2_MouseMove);
            // 
            // lblSaludo
            // 
            this.lblSaludo.AutoSize = true;
            this.lblSaludo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSaludo.Location = new System.Drawing.Point(319, 228);
            this.lblSaludo.Name = "lblSaludo";
            this.lblSaludo.Size = new System.Drawing.Size(0, 13);
            this.lblSaludo.TabIndex = 3;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNombre.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxNombre.Location = new System.Drawing.Point(116, 94);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(509, 20);
            this.textBoxNombre.TabIndex = 4;
            // 
            // Form1MiPrimerApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(676, 567);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.lblSaludo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSaludar);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1144, 718);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(692, 606);
            this.Name = "Form1MiPrimerApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mi Primer APP";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1AppBienvenida_FormClosing);
            this.Load += new System.EventHandler(this.Form1MiPrimerApp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaludar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSaludo;
        private System.Windows.Forms.TextBox textBoxNombre;
    }
}

