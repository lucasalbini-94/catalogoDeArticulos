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

namespace Ventanas
{
    public partial class frmDescripcion : Form
    {
        public frmDescripcion()
        {
            InitializeComponent();
        }
        public frmDescripcion(Articulo seleccionado)
        {
            InitializeComponent();
            cargarFormulario(seleccionado);
        }
        private void cargarFormulario(Articulo seleccionado)
        {
            lblArticuloDescripcion.Text = seleccionado.Nombre;
            lblCodigoDescripcion.Text = seleccionado.Codigo;
            lblCategoriaDescripcion.Text = seleccionado.Categoria.Descripcion;
            lblMarcaDescripcion.Text = seleccionado.Marca.Descripcion;
            lblImagenDescripcion.Text = seleccionado.ImagenUrl;
            lblPrecioDescripcion.Text = seleccionado.Precio.ToString();
            lblDescripcionDescripcion.Text = seleccionado.Descripcion;

        }
    }
}
