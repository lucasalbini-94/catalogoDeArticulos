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
    public partial class frmPrincipal : Form
    {
        private List<Articulo> listaArticulo;
        private List<Articulo> listaFiltrada;
        private List<Articulo> listaCarrito = null;
        private Helper helper = new Helper();
        public frmPrincipal()
        {
            InitializeComponent();
        }
        private void cargarFormulario()
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            MarcaNegocio marcaNegociio = new MarcaNegocio();

            try
            {
                cargarGrilla();
                verificarCarrito();
                cbxCategoria.DataSource = categoriaNegocio.listarCategorias();
                cbxMarca.DataSource = marcaNegociio.listarMarcas();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        private void cargarGrilla()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                listaArticulo = negocio.listarArticulos();
                dgvArticulos.DataSource = listaArticulo;
                ocultarColumnas();
                cargarImagen(listaArticulo[0].ImagenUrl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void ocultarColumnas()
        {
            dgvArticulos.Columns["Id"].Visible = false;
            dgvArticulos.Columns["Codigo"].Visible = false;
            dgvArticulos.Columns["Descripcion"].Visible = false;
            dgvArticulos.Columns["Categoria"].Visible = false;
            dgvArticulos.Columns["ImagenUrl"].Visible = false;
            dgvArticulos.Columns["Precio"].Visible = false;
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pbxArticulo.Load(imagen);
            }
            catch (Exception)
            {
                pbxArticulo.Load("https://www.shutterstock.com/image-vector/ui-image-placeholder-wireframes-apps-260nw-1037719204.jpg");
            }
        }
        private void cargarPrecio(decimal precio)
        {
            try
            {
                lblPrecio.Text = "$" + precio.ToString("0.00");
            }
            catch (Exception)
            {
                lblPrecio.Text = "Precio no encontrado";
            }
        }
        private void cargarNombre(string nombre)
        {
            try
            {
                lblNombreArticulo.Text = nombre;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void verificarCarrito()
        {
            try
            {
                if (listaCarrito is null || listaCarrito.Count == 0)
                {
                    lblCarrito.Text = "No hay articulos en el carrito";
                    pbxCarrito.Load("https://cdn-icons-png.flaticon.com/512/3225/3225200.png");
                    btnVerCarrito.Enabled = false;
                }
                else
                {
                    lblCarrito.Text = "Hay articulos en el carrito";
                    pbxCarrito.Load("https://cdn-icons-png.flaticon.com/512/3225/3225194.png");
                    btnVerCarrito.Enabled = true;
                }

                if (!(chbFiltro.Checked))
                {
                    cbxCategoria.Enabled = false;
                    cbxMarca.Enabled = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        private bool verificarNulo()
        {
            /*Este método lo hice porque al momento de filtrar el DGV con el filtro rápido o el filtro por comboBox, si seleccionaba
             el botón de descripción, modificar o añadir a carrito saltaba una excepción NullReference. Me dí cuenta que solo se
            selecciona el current row cuando hago click sobre la fila. En la primera columna, vi que aparece la flechita indicadora
            de la fila seleccionada, y al momento de filtrar el DGV desaparecía, si bien se colorea la fila en azul, pero 
            el CurrentRow figuraba como nulo. Busqué ducu y en foros. Sé que es engorroso tener que clickear para que se seleccione, pero
            no encontré la forma de solucionarlo. No recuerdo si vos lo mencionaste, pero repase los videos y no vi que hablaras de eso en específico
            te agradecería si me decis cómo arreglarlo. Igual seguiré buscando...*/

            if (dgvArticulos.CurrentRow is null)
            {
                MessageBox.Show("No hay un artículo seleccionado");
                return true;
            }
            return false;
        }
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            cargarFormulario();
        }
        private void btnDescripcion_Click(object sender, EventArgs e)
        {
            try
            {
                Articulo seleccionado;
                if (verificarNulo())
                    return;
                seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                frmDescripcion ventana = new frmDescripcion(seleccionado);
                ventana.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void tbxBuscar_TextChanged(object sender, EventArgs e)
        {
           
            string filtro = tbxBuscar.Text;
                  
            listaFiltrada = listaArticulo.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Marca.Descripcion.ToUpper().Contains(filtro.ToUpper()));
            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaFiltrada;
            ocultarColumnas();
        }
        private void filtrarLista(object sender, EventArgs e)
        {
            try
            {
                if (chbFiltro.Checked)
                {
                    cbxCategoria.Enabled = true;
                    cbxMarca.Enabled = true;
                    string opcionCategoria = cbxCategoria.SelectedItem?.ToString();
                    string opcionMarca = cbxMarca.SelectedItem?.ToString();

                    listaFiltrada = listaArticulo.Where(x => string.IsNullOrEmpty(opcionCategoria) || x.Categoria.Descripcion == opcionCategoria).Where(x => string.IsNullOrEmpty(opcionMarca) || x.Marca.Descripcion == opcionMarca).ToList();

                    dgvArticulos.DataSource = listaFiltrada;
                }
                else
                {
                    cbxCategoria.Enabled = false;
                    cbxMarca.Enabled = false;
                    dgvArticulos.DataSource = listaArticulo;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmArticulo agregar = new frmArticulo();
            agregar.ShowDialog();
            cargarFormulario();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgvArticulos.CurrentRow?.DataBoundItem;
            if (verificarNulo())
                return;
            frmArticulo modificar = new frmArticulo(seleccionado);
            modificar.ShowDialog();
            cargarFormulario();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (verificarNulo())
                return;
            DialogResult respuesta = MessageBox.Show("¿Desea eliminar este artículo?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(respuesta == DialogResult.Yes)
            {
                ArticuloNegocio negocio = new ArticuloNegocio();
                Articulo seleccionado;
                try
                {
                    seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    negocio.eliminar(seleccionado.Id);
                    MessageBox.Show("Artículo eliminado");
                    cargarGrilla();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }

            }
        }
        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.ImagenUrl);
                cargarPrecio(seleccionado.Precio);
                cargarNombre(seleccionado.Nombre);
            }
        }
        private void btnComprar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(helper.mensajeDeCompra());
        }
        private void btnVerCarrito_Click(object sender, EventArgs e)
        {
            frmCarrito carrito = new frmCarrito(ref listaCarrito);
            carrito.ShowDialog();
            verificarCarrito();
        }
        private void btnAñadirCarrito_Click(object sender, EventArgs e)
        {
            if(listaCarrito is null)
            {
                listaCarrito = new List<Articulo>();
            }
            listaCarrito.Add((Articulo)dgvArticulos.CurrentRow.DataBoundItem);
            verificarCarrito();
        }
    }
}
