using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Ventanas
{
    public partial class frmCarrito : Form
    {
        private List<Articulo> lista;
        private Helper helper = new Helper();
        private decimal precio = 0;
        public frmCarrito(ref List<Articulo> lista)
        {
            InitializeComponent();
            this.lista = lista;
        }
        private void ocultarColumnas()
        {
            dgvCarrito.Columns["Id"].Visible = false;
            dgvCarrito.Columns["Codigo"].Visible = false;
            dgvCarrito.Columns["Descripcion"].Visible = false;
            dgvCarrito.Columns["Categoria"].Visible = false;
            dgvCarrito.Columns["ImagenUrl"].Visible = false;
        }
        private void calcularPrecio()
        {
            precio = 0;
            for (int x = 0; x < dgvCarrito.Rows.Count; x++)
            {
                precio += (decimal)dgvCarrito.Rows[x].Cells["Precio"].Value;
            }
            lblPrecio.Text = "$" + precio.ToString("0.00");
        }
        private void frmCarrito_Load(object sender, EventArgs e)
        {
            dgvCarrito.DataSource = lista;
            ocultarColumnas();
            calcularPrecio();
        }
        private void btnAñadir_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnQuitar_Click(object sender, EventArgs e)
        {
            try
            {
                if(dgvCarrito.CurrentRow != null)
                {
                    int item = dgvCarrito.CurrentRow.Index;
                    lista.RemoveAt(item);
                    dgvCarrito.DataSource = null;
                    dgvCarrito.DataSource = lista;
                }
                else
                {
                    MessageBox.Show("Seleccione un artículo para quitar");
                }
                if (lista.Count == 0)
                    btnQuitar.Enabled = false;
                ocultarColumnas();
                calcularPrecio();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnComprar_Click(object sender, EventArgs e)
        {
            if (dgvCarrito.DataSource is null || dgvCarrito.Rows.Count == 0)
            {
                MessageBox.Show("No hay articulos en su lista");
            }
            else
            {
                MessageBox.Show(helper.mensajeDeCompra());
            }
        }
    }
}
