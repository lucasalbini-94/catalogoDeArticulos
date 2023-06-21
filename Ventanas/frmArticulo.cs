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
using System.Configuration;
using System.IO;

namespace Ventanas
{
    public partial class frmArticulo : Form
    {
        private Articulo articulo = null;
        private OpenFileDialog archivo = null;
        public frmArticulo()
        {
            InitializeComponent();
        }
        public frmArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pbxImagenArticulo.Load(imagen);
            }
            catch (Exception)
            {
                pbxImagenArticulo.Load("https://www.shutterstock.com/image-vector/ui-image-placeholder-wireframes-apps-260nw-1037719204.jpg");
            }
        }
        private bool validarCamposCargados()
        {
            if (tbxArticulo.Text == "" || tbxCodigo.Text == "" || tbxDescripcion.Text == "" || tbxPrecio.Text == "")
                return true;
            if (!(soloNumeros(tbxPrecio.Text)))
            {
                MessageBox.Show("En el campo 'Precio' solo se admiten números");
                return true;
            }
            return false;
        }
        private bool soloNumeros(string cadena)
        {
            foreach (char item in cadena)
            {
                if (!(char.IsNumber(item)))
                    return false;
            }
            return true;
        }
        private void resaltarCampos()
        {
            if (tbxArticulo.Text == "")
                tbxArticulo.BackColor = Color.Red;
            if (tbxCodigo.Text == "")
                tbxCodigo.BackColor = Color.Red;
            if (tbxDescripcion.Text == "")
                tbxDescripcion.BackColor = Color.Red;
            if (tbxPrecio.Text == "")
                tbxPrecio.BackColor = Color.Red;
        }
        private void frmArticulo_Load(object sender, EventArgs e)
        {
                CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
                MarcaNegocio marcaNegocio = new MarcaNegocio();
            try
            {
                cbxCategoria.DataSource = categoriaNegocio.listarCategorias();
                cbxCategoria.ValueMember = "Id";
                cbxCategoria.DisplayMember = "Descripcion";
                cbxMarca.DataSource = marcaNegocio.listarMarcas();
                cbxMarca.ValueMember = "Id";
                cbxMarca.DisplayMember = "Descripcion";

                if (articulo != null)
                {
                    cbxCategoria.SelectedValue = articulo.Categoria.Id;
                    tbxArticulo.Text = articulo.Nombre;
                    tbxCodigo.Text = articulo.Codigo;
                    cbxMarca.SelectedValue = articulo.Marca.Id;
                    tbxUrlImagen.Text = articulo.ImagenUrl;
                    tbxDescripcion.Text = articulo.Descripcion;
                    tbxPrecio.Text = articulo.Precio.ToString("0.00");
                    cargarImagen(articulo.ImagenUrl);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (validarCamposCargados())
            {
                MessageBox.Show("Hay campos sin cargar");
                resaltarCampos();
                return;
            }
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                if (articulo == null)
                    articulo = new Articulo();

                articulo.Categoria = (Categoria)cbxCategoria.SelectedItem;
                articulo.Nombre = tbxArticulo.Text;
                articulo.Codigo = tbxCodigo.Text;
                articulo.Marca = (Marca)cbxMarca.SelectedItem;
                articulo.ImagenUrl = tbxUrlImagen.Text;
                articulo.Descripcion = tbxDescripcion.Text;
                articulo.Precio = decimal.Parse(tbxPrecio.Text);

                if(articulo.Id != 0)
                {
                    negocio.modificar(articulo);
                    MessageBox.Show("Se modificó un artículo");
                }
                else
                {
                    negocio.agregar(articulo);
                    MessageBox.Show("Se agregó un nuevo artículo");
                }
                if(archivo != null && !(tbxUrlImagen.Text.ToLower().Contains("http")))
                {
                    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images-folder"] + archivo.SafeFileName);
                }

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void tbxUrlImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(tbxUrlImagen.Text);
        }
        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg; |png|*.png";
            if(archivo.ShowDialog() == DialogResult.OK)
            {
                tbxUrlImagen.Text = archivo.FileName;
                cargarImagen(archivo.FileName);
            }
        }
        private void tbxArticulo_Click(object sender, EventArgs e)
        {
            if (tbxArticulo.BackColor == Color.Red)
                tbxArticulo.BackColor = SystemColors.Control;
        }
        private void tbxCodigo_Click(object sender, EventArgs e)
        {
            if (tbxCodigo.BackColor == Color.Red)
                tbxCodigo.BackColor = SystemColors.Control;
        }
        private void tbxDescripcion_Click(object sender, EventArgs e)
        {
            if (tbxDescripcion.BackColor == Color.Red)
                tbxDescripcion.BackColor = SystemColors.Control;
        }
        private void tbxPrecio_Click(object sender, EventArgs e)
        {
            if (tbxPrecio.BackColor == Color.Red)
                tbxPrecio.BackColor = SystemColors.Control;
        }
    }
}
