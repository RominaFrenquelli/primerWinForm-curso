using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelos;
using Business;

namespace PokemonWinFormApp
{
    public partial class Form1 : Form
    {
        private List<Pokemon> listaPokemons;
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Cargar();
            cboCampo.Items.Add("Numero");
            cboCampo.Items.Add("Nombre");
            cboCampo.Items.Add("Descripcion");


        }

        private void dgvPokemon_load(object sender, EventArgs e)
        {
            if(dgvPokemon.CurrentRow != null)
            {
                Pokemon seleccionado = (Pokemon)dgvPokemon.CurrentRow.DataBoundItem;
                CargarImagen(seleccionado.UrlImagen);

            }
        }

        private void Cargar()
        {
            PokemonBusiness business = new PokemonBusiness();
            try
            {
                listaPokemons = business.Listar();
                dgvPokemon.DataSource = listaPokemons;
                OcultarColumna();
                CargarImagen(listaPokemons[0].UrlImagen);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void OcultarColumna()
        {
            dgvPokemon.Columns["UrlImagen"].Visible = false;
            dgvPokemon.Columns["Id"].Visible = false;
        }

        private void CargarImagen(string imagen)
        {
            try
            {
                pbxPokemons.Load(imagen);

            }
            catch(Exception ex)
            {
                pbxPokemons.Load("https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.freepik.es%2Fvector-premium%2Ficono-marco-fotos-foto-vacia-blanco-vector-sobre-fondo-transparente-aislado-eps-10_16496345.htm&psig=AOvVaw3jw1y5XVkjZce3I52NIgO4&ust=1712588533768000&source=images&cd=vfe&opi=89978449&ved=0CBIQjRxqFwoTCMj7-8uvsIUDFQAAAAAdAAAAABAE");
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaPokemon nuevo = new frmAltaPokemon();
            nuevo.ShowDialog();
            Cargar();
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            Pokemon seleccionado;
            seleccionado = (Pokemon)dgvPokemon.CurrentRow.DataBoundItem;
            frmAltaPokemon modificado = new frmAltaPokemon(seleccionado);
            modificado.ShowDialog();
            Cargar();
        }

        private void btnEliminarFisico_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void btnEliminaLogico_Click(object sender, EventArgs e)
        {
            Eliminar(true);
        }

        private void Eliminar(bool logico = false)
        {
            PokemonBusiness negocio = new PokemonBusiness();
            Pokemon seleccionado;
            try
            {
                DialogResult resultado = MessageBox.Show("Desea eliminar el item?", "Eliminado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    seleccionado = (Pokemon)dgvPokemon.CurrentRow.DataBoundItem;

                    if (logico)
                    {
                        negocio.EliminarLogico(seleccionado.Id);
                    }
                    else
                    {
                        negocio.Eliminar(seleccionado.Id);

                    }
                    Cargar();

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            PokemonBusiness negocio = new PokemonBusiness();
            try
            {
                string campo = cboCampo.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro = txtFiltroAvanzado.Text;
                dgvPokemon.DataSource = negocio.Filtrar(campo, criterio, filtro);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            List<Pokemon> listaFiltrada;
            string filtro = txtFiltro.Text;

            if (filtro != "")
            {
                listaFiltrada = listaPokemons.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()));

            }
            else
            {
                listaFiltrada = listaPokemons;
            }

            dgvPokemon.DataSource = null;
            dgvPokemon.DataSource = listaFiltrada;
            OcultarColumna();
        }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboCampo.SelectedItem.ToString();
            if(opcion == "Numero")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Mayor a");
                cboCriterio.Items.Add("Menor a");
                cboCriterio.Items.Add("Igual a");
            }
            else
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Comienza con");
                cboCriterio.Items.Add("Termina con");
                cboCriterio.Items.Add("Contiene");
            }
        }
    }
}
