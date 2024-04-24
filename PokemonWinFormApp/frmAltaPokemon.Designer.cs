namespace PokemonWinFormApp
{
    partial class frmAltaPokemon
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
            this.btnAceptarNuevo = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.cboDebilidad = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblDebilidad = new System.Windows.Forms.Label();
            this.pbxPokemons = new System.Windows.Forms.PictureBox();
            this.txtUrlImagen = new System.Windows.Forms.TextBox();
            this.lblUrlImagen = new System.Windows.Forms.Label();
            this.btnCargarImagen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPokemons)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptarNuevo
            // 
            this.btnAceptarNuevo.Location = new System.Drawing.Point(45, 284);
            this.btnAceptarNuevo.Name = "btnAceptarNuevo";
            this.btnAceptarNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarNuevo.TabIndex = 6;
            this.btnAceptarNuevo.Text = "Aceptar";
            this.btnAceptarNuevo.UseVisualStyleBackColor = true;
            this.btnAceptarNuevo.Click += new System.EventHandler(this.btnAceptarNuevo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(223, 284);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(97, 45);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(44, 13);
            this.lblNumero.TabIndex = 2;
            this.lblNumero.Text = "Numero";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(102, 79);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(86, 116);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 4;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(174, 42);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(121, 20);
            this.txtNumero.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(173, 76);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(172, 113);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(121, 20);
            this.txtDescripcion.TabIndex = 2;
            // 
            // cboTipo
            // 
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(172, 186);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(121, 21);
            this.cboTipo.TabIndex = 4;
            // 
            // cboDebilidad
            // 
            this.cboDebilidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDebilidad.FormattingEnabled = true;
            this.cboDebilidad.Location = new System.Drawing.Point(172, 232);
            this.cboDebilidad.Name = "cboDebilidad";
            this.cboDebilidad.Size = new System.Drawing.Size(121, 21);
            this.cboDebilidad.TabIndex = 5;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(113, 189);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 10;
            this.lblTipo.Text = "Tipo";
            // 
            // lblDebilidad
            // 
            this.lblDebilidad.AutoSize = true;
            this.lblDebilidad.Location = new System.Drawing.Point(102, 235);
            this.lblDebilidad.Name = "lblDebilidad";
            this.lblDebilidad.Size = new System.Drawing.Size(51, 13);
            this.lblDebilidad.TabIndex = 11;
            this.lblDebilidad.Text = "Debilidad";
            // 
            // pbxPokemons
            // 
            this.pbxPokemons.Location = new System.Drawing.Point(347, 42);
            this.pbxPokemons.Name = "pbxPokemons";
            this.pbxPokemons.Size = new System.Drawing.Size(285, 265);
            this.pbxPokemons.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPokemons.TabIndex = 12;
            this.pbxPokemons.TabStop = false;
            // 
            // txtUrlImagen
            // 
            this.txtUrlImagen.Location = new System.Drawing.Point(172, 148);
            this.txtUrlImagen.Name = "txtUrlImagen";
            this.txtUrlImagen.Size = new System.Drawing.Size(121, 20);
            this.txtUrlImagen.TabIndex = 3;
            this.txtUrlImagen.Leave += new System.EventHandler(this.txtUrlImagen_Leave);
            // 
            // lblUrlImagen
            // 
            this.lblUrlImagen.AutoSize = true;
            this.lblUrlImagen.Location = new System.Drawing.Point(86, 151);
            this.lblUrlImagen.Name = "lblUrlImagen";
            this.lblUrlImagen.Size = new System.Drawing.Size(58, 13);
            this.lblUrlImagen.TabIndex = 13;
            this.lblUrlImagen.Text = "Url Imagen";
            // 
            // btnCargarImagen
            // 
            this.btnCargarImagen.Location = new System.Drawing.Point(299, 146);
            this.btnCargarImagen.Name = "btnCargarImagen";
            this.btnCargarImagen.Size = new System.Drawing.Size(29, 23);
            this.btnCargarImagen.TabIndex = 14;
            this.btnCargarImagen.Text = "+";
            this.btnCargarImagen.UseVisualStyleBackColor = true;
            this.btnCargarImagen.Click += new System.EventHandler(this.btnCargarImagen_Click);
            // 
            // frmAltaPokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 388);
            this.Controls.Add(this.btnCargarImagen);
            this.Controls.Add(this.txtUrlImagen);
            this.Controls.Add(this.lblUrlImagen);
            this.Controls.Add(this.pbxPokemons);
            this.Controls.Add(this.lblDebilidad);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.cboDebilidad);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptarNuevo);
            this.Name = "frmAltaPokemon";
            this.Text = "Nuevo Pokemon";
            this.Load += new System.EventHandler(this.frmAltaPokemon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxPokemons)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptarNuevo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.ComboBox cboDebilidad;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblDebilidad;
        private System.Windows.Forms.PictureBox pbxPokemons;
        private System.Windows.Forms.TextBox txtUrlImagen;
        private System.Windows.Forms.Label lblUrlImagen;
        private System.Windows.Forms.Button btnCargarImagen;
    }
}