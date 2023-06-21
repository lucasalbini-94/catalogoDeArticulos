
namespace Ventanas
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.pbxArticulo = new System.Windows.Forms.PictureBox();
            this.btnComprar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSlogan = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblNombreArticulo = new System.Windows.Forms.Label();
            this.btnDescripcion = new System.Windows.Forms.Button();
            this.btnAñadirCarrito = new System.Windows.Forms.Button();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.tbxBuscar = new System.Windows.Forms.TextBox();
            this.lblFiltros = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.cbxMarca = new System.Windows.Forms.ComboBox();
            this.pbxCarrito = new System.Windows.Forms.PictureBox();
            this.lblCarrito = new System.Windows.Forms.Label();
            this.btnVerCarrito = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblAdministrarArticulos = new System.Windows.Forms.Label();
            this.chbFiltro = new System.Windows.Forms.CheckBox();
            this.gbxFiltros = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCarrito)).BeginInit();
            this.gbxFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.Location = new System.Drawing.Point(338, 95);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(243, 360);
            this.dgvArticulos.TabIndex = 0;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // pbxArticulo
            // 
            this.pbxArticulo.Location = new System.Drawing.Point(614, 95);
            this.pbxArticulo.Name = "pbxArticulo";
            this.pbxArticulo.Size = new System.Drawing.Size(285, 283);
            this.pbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxArticulo.TabIndex = 1;
            this.pbxArticulo.TabStop = false;
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(614, 420);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(75, 35);
            this.btnComprar.TabIndex = 1;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft JhengHei", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTitulo.Location = new System.Drawing.Point(35, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(165, 39);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "maxistore";
            // 
            // lblSlogan
            // 
            this.lblSlogan.AutoSize = true;
            this.lblSlogan.Location = new System.Drawing.Point(39, 48);
            this.lblSlogan.Name = "lblSlogan";
            this.lblSlogan.Size = new System.Drawing.Size(162, 13);
            this.lblSlogan.TabIndex = 4;
            this.lblSlogan.Text = "Todo lo que la people necesita...";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(611, 388);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(0, 25);
            this.lblPrecio.TabIndex = 5;
            this.lblPrecio.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblNombreArticulo
            // 
            this.lblNombreArticulo.AutoSize = true;
            this.lblNombreArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreArticulo.Location = new System.Drawing.Point(609, 53);
            this.lblNombreArticulo.Name = "lblNombreArticulo";
            this.lblNombreArticulo.Size = new System.Drawing.Size(0, 25);
            this.lblNombreArticulo.TabIndex = 6;
            // 
            // btnDescripcion
            // 
            this.btnDescripcion.Location = new System.Drawing.Point(824, 420);
            this.btnDescripcion.Name = "btnDescripcion";
            this.btnDescripcion.Size = new System.Drawing.Size(75, 35);
            this.btnDescripcion.TabIndex = 3;
            this.btnDescripcion.Text = "Descripción";
            this.btnDescripcion.UseVisualStyleBackColor = true;
            this.btnDescripcion.Click += new System.EventHandler(this.btnDescripcion_Click);
            // 
            // btnAñadirCarrito
            // 
            this.btnAñadirCarrito.Location = new System.Drawing.Point(719, 420);
            this.btnAñadirCarrito.Name = "btnAñadirCarrito";
            this.btnAñadirCarrito.Size = new System.Drawing.Size(75, 35);
            this.btnAñadirCarrito.TabIndex = 2;
            this.btnAñadirCarrito.Text = "Añadir al carrito";
            this.btnAñadirCarrito.UseVisualStyleBackColor = true;
            this.btnAñadirCarrito.Click += new System.EventHandler(this.btnAñadirCarrito_Click);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(335, 65);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(40, 13);
            this.lblBuscar.TabIndex = 9;
            this.lblBuscar.Text = "Buscar";
            // 
            // tbxBuscar
            // 
            this.tbxBuscar.Location = new System.Drawing.Point(381, 62);
            this.tbxBuscar.Name = "tbxBuscar";
            this.tbxBuscar.Size = new System.Drawing.Size(200, 20);
            this.tbxBuscar.TabIndex = 4;
            this.tbxBuscar.TextChanged += new System.EventHandler(this.tbxBuscar_TextChanged);
            // 
            // lblFiltros
            // 
            this.lblFiltros.AutoSize = true;
            this.lblFiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltros.Location = new System.Drawing.Point(39, 95);
            this.lblFiltros.Name = "lblFiltros";
            this.lblFiltros.Size = new System.Drawing.Size(101, 17);
            this.lblFiltros.TabIndex = 11;
            this.lblFiltros.Text = "Añadir filtros";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(21, 29);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(54, 13);
            this.lblCategoria.TabIndex = 12;
            this.lblCategoria.Text = "Categoría";
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(95, 26);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(121, 21);
            this.cbxCategoria.TabIndex = 0;
            this.cbxCategoria.SelectedIndexChanged += new System.EventHandler(this.filtrarLista);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(21, 63);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 14;
            this.lblMarca.Text = "Marca";
            // 
            // cbxMarca
            // 
            this.cbxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.Location = new System.Drawing.Point(95, 60);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(121, 21);
            this.cbxMarca.TabIndex = 1;
            this.cbxMarca.SelectedIndexChanged += new System.EventHandler(this.filtrarLista);
            // 
            // pbxCarrito
            // 
            this.pbxCarrito.Location = new System.Drawing.Point(42, 249);
            this.pbxCarrito.Name = "pbxCarrito";
            this.pbxCarrito.Size = new System.Drawing.Size(100, 91);
            this.pbxCarrito.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxCarrito.TabIndex = 16;
            this.pbxCarrito.TabStop = false;
            // 
            // lblCarrito
            // 
            this.lblCarrito.AutoSize = true;
            this.lblCarrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarrito.Location = new System.Drawing.Point(39, 216);
            this.lblCarrito.Name = "lblCarrito";
            this.lblCarrito.Size = new System.Drawing.Size(0, 17);
            this.lblCarrito.TabIndex = 17;
            // 
            // btnVerCarrito
            // 
            this.btnVerCarrito.Enabled = false;
            this.btnVerCarrito.Location = new System.Drawing.Point(196, 278);
            this.btnVerCarrito.Name = "btnVerCarrito";
            this.btnVerCarrito.Size = new System.Drawing.Size(75, 35);
            this.btnVerCarrito.TabIndex = 7;
            this.btnVerCarrito.Text = "Ver carrito";
            this.btnVerCarrito.UseVisualStyleBackColor = true;
            this.btnVerCarrito.Click += new System.EventHandler(this.btnVerCarrito_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(42, 420);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(142, 420);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 9;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(242, 420);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblAdministrarArticulos
            // 
            this.lblAdministrarArticulos.AutoSize = true;
            this.lblAdministrarArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdministrarArticulos.Location = new System.Drawing.Point(39, 376);
            this.lblAdministrarArticulos.Name = "lblAdministrarArticulos";
            this.lblAdministrarArticulos.Size = new System.Drawing.Size(157, 17);
            this.lblAdministrarArticulos.TabIndex = 22;
            this.lblAdministrarArticulos.Text = "Administrar artículos";
            // 
            // chbFiltro
            // 
            this.chbFiltro.AutoSize = true;
            this.chbFiltro.Location = new System.Drawing.Point(146, 97);
            this.chbFiltro.Name = "chbFiltro";
            this.chbFiltro.Size = new System.Drawing.Size(15, 14);
            this.chbFiltro.TabIndex = 5;
            this.chbFiltro.UseVisualStyleBackColor = true;
            this.chbFiltro.CheckedChanged += new System.EventHandler(this.filtrarLista);
            // 
            // gbxFiltros
            // 
            this.gbxFiltros.Controls.Add(this.lblCategoria);
            this.gbxFiltros.Controls.Add(this.cbxCategoria);
            this.gbxFiltros.Controls.Add(this.lblMarca);
            this.gbxFiltros.Controls.Add(this.cbxMarca);
            this.gbxFiltros.Location = new System.Drawing.Point(42, 117);
            this.gbxFiltros.Name = "gbxFiltros";
            this.gbxFiltros.Size = new System.Drawing.Size(275, 100);
            this.gbxFiltros.TabIndex = 6;
            this.gbxFiltros.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 469);
            this.Controls.Add(this.gbxFiltros);
            this.Controls.Add(this.chbFiltro);
            this.Controls.Add(this.lblAdministrarArticulos);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnVerCarrito);
            this.Controls.Add(this.lblCarrito);
            this.Controls.Add(this.pbxCarrito);
            this.Controls.Add(this.lblFiltros);
            this.Controls.Add(this.tbxBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.btnAñadirCarrito);
            this.Controls.Add(this.btnDescripcion);
            this.Controls.Add(this.lblNombreArticulo);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblSlogan);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.pbxArticulo);
            this.Controls.Add(this.dgvArticulos);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catálogo de artículos";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCarrito)).EndInit();
            this.gbxFiltros.ResumeLayout(false);
            this.gbxFiltros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.PictureBox pbxArticulo;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSlogan;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblNombreArticulo;
        private System.Windows.Forms.Button btnDescripcion;
        private System.Windows.Forms.Button btnAñadirCarrito;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox tbxBuscar;
        private System.Windows.Forms.Label lblFiltros;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.ComboBox cbxMarca;
        private System.Windows.Forms.PictureBox pbxCarrito;
        private System.Windows.Forms.Label lblCarrito;
        private System.Windows.Forms.Button btnVerCarrito;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblAdministrarArticulos;
        private System.Windows.Forms.CheckBox chbFiltro;
        private System.Windows.Forms.GroupBox gbxFiltros;
    }
}

