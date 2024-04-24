using Business;
using Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokemonWinFormApp
{
    public partial class frmAltaPokemon : Form
    {
        private Pokemon pokemon = null;
        private OpenFileDialog archivo = null;
        public frmAltaPokemon()
        {
            InitializeComponent();
        }

        public frmAltaPokemon(Pokemon pokemon)
        {
            InitializeComponent();
            this.pokemon = pokemon;
            Text = "Modificar Pokemon";
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptarNuevo_Click(object sender, EventArgs e)
        {
            
            PokemonBusiness negocios = new PokemonBusiness();
            try
            {
                if (pokemon == null)
                    pokemon = new Pokemon();

                pokemon.Numero = int.Parse(txtNumero.Text);
                pokemon.Nombre = txtNombre.Text;
                pokemon.Descripcion = txtDescripcion.Text;
                pokemon.UrlImagen = txtUrlImagen.Text;
                pokemon.Tipo = (Elemento)cboTipo.SelectedItem;
                pokemon.Debilidad = (Elemento)cboDebilidad.SelectedItem;

                if(pokemon.Id != 0)
                {
                    negocios.Modificar(pokemon);
                    MessageBox.Show("Se modificó exitosamente");

                }
                else
                {
                    negocios.Agregar(pokemon);
                    MessageBox.Show("Se agrego exitosamente");

                }

                //guardo imagen si levantó localmente
                if (archivo != null && !(txtUrlImagen.Text.ToUpper().Contains("HTTP")))
                    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images-folder"] + archivo.SafeFileName);

                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void frmAltaPokemon_Load(object sender, EventArgs e)
        {
            ElementoBusiness elementoNegocio = new ElementoBusiness();
            try
            {
                cboTipo.DataSource = elementoNegocio.Listar();
                cboTipo.ValueMember = "id";
                cboTipo.DisplayMember = "Descripcion";
                cboDebilidad.DataSource = elementoNegocio.Listar();
                cboDebilidad.ValueMember = "Id";
                cboDebilidad.DisplayMember = "Descripcion";

                if(pokemon != null)
                {
                    txtNumero.Text = pokemon.Numero.ToString();
                    txtNombre.Text = pokemon.Nombre;
                    txtDescripcion.Text = pokemon.Descripcion;
                    txtUrlImagen.Text = pokemon.UrlImagen;
                    CargarImagen(pokemon.UrlImagen);
                    cboTipo.SelectedValue = pokemon.Tipo.Id;
                    cboDebilidad.SelectedValue = pokemon.Debilidad.Id;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show (ex.ToString());
            }
        }

        private void txtUrlImagen_Leave(object sender, EventArgs e)
        {
            CargarImagen(txtUrlImagen.Text);
        }

        private void CargarImagen(string imagen)
        {
            try
            {
                pbxPokemons.Load(imagen);

            }
            catch (Exception ex)
            {
                pbxPokemons.Load("https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.freepik.es%2Fvector-premium%2Ficono-marco-fotos-foto-vacia-blanco-vector-sobre-fondo-transparente-aislado-eps-10_16496345.htm&psig=AOvVaw3jw1y5XVkjZce3I52NIgO4&ust=1712588533768000&source=images&cd=vfe&opi=89978449&ved=0CBIQjRxqFwoTCMj7-8uvsIUDFQAAAAAdAAAAABAE");
            }

        }

        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg; |png|*.png";
            if(archivo.ShowDialog() == DialogResult.OK)
            {
                txtUrlImagen.Text =archivo.FileName;
                CargarImagen(archivo.FileName);

                //guarda imagen localmente
                //File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images-folder"] + archivo.SafeFileName);
            }
        }
    }
}
