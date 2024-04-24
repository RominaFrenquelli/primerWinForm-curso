using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio1
{
    public partial class Form1MiPrimerApp : Form
    {
        public Form1MiPrimerApp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string texto = textBoxNombre.Text;
            lblSaludo.Text = "Hola " + texto;
        }

        private void Form1AppBienvenida_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Hasta pronto " + textBoxNombre.Text);
        }

        private void Form1MiPrimerApp_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido a C#");
        }

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            label2.BackColor = Color.Cyan;
            label2.Cursor = Cursors.Hand;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            //label2.BackColor = System.Drawing.SystemColors.Control;
        }
    }
}
