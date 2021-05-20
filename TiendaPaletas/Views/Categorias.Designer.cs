using System;

namespace TiendaPaletas.Views
{
    partial class Categorias
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Categorias));
            this.pnContenido = new System.Windows.Forms.Panel();
            this.pnAgregarCategoria = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_volver = new System.Windows.Forms.Button();
            this.bt_agregar = new System.Windows.Forms.Button();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.pnCategoria = new System.Windows.Forms.Panel();
            this.flowPnCategorias = new System.Windows.Forms.FlowLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnAgregarGrupo = new System.Windows.Forms.Button();
            this.pnProductos = new System.Windows.Forms.Panel();
            this.btnEliminarProd = new System.Windows.Forms.Button();
            this.dataGridViewProd = new System.Windows.Forms.DataGridView();
            this.nombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tamañoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tiendaPaletasDataSet = new TiendaPaletas.tiendaPaletasDataSet();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnAgregarProducto2 = new System.Windows.Forms.Button();
            this.pnTxtAgregarProducto = new System.Windows.Forms.Panel();
            this.pnDatosProducto = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBoxProd = new System.Windows.Forms.PictureBox();
            this.cbTamañoProducto = new System.Windows.Forms.ComboBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.dataSetProductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetProductos = new TiendaPaletas.DataSetProductos();
            this.dlg = new System.Windows.Forms.OpenFileDialog();
            this.productosTableAdapter = new TiendaPaletas.tiendaPaletasDataSetTableAdapters.ProductosTableAdapter();
            this.productosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.productosTableAdapter1 = new TiendaPaletas.DataSetProductosTableAdapters.ProductosTableAdapter();
            this.errorProviderNombreProducto = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPrecioProducto = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderCantidadProducto = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderNombreCategoria = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnContenido.SuspendLayout();
            this.pnAgregarCategoria.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnCategoria.SuspendLayout();
            this.panel5.SuspendLayout();
            this.pnProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiendaPaletasDataSet)).BeginInit();
            this.pnTxtAgregarProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnDatosProducto)).BeginInit();
            this.pnDatosProducto.Panel1.SuspendLayout();
            this.pnDatosProducto.Panel2.SuspendLayout();
            this.pnDatosProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetProductosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNombreProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPrecioProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCantidadProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNombreCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // pnContenido
            // 
            this.pnContenido.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnContenido.Controls.Add(this.pnAgregarCategoria);
            this.pnContenido.Controls.Add(this.pnCategoria);
            this.pnContenido.Controls.Add(this.pnProductos);
            this.pnContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContenido.Location = new System.Drawing.Point(0, 0);
            this.pnContenido.Name = "pnContenido";
            this.pnContenido.Size = new System.Drawing.Size(935, 729);
            this.pnContenido.TabIndex = 1;
            this.pnContenido.Paint += new System.Windows.Forms.PaintEventHandler(this.pnContenido_Paint);
            // 
            // pnAgregarCategoria
            // 
            this.pnAgregarCategoria.Controls.Add(this.label3);
            this.pnAgregarCategoria.Controls.Add(this.panel3);
            this.pnAgregarCategoria.Controls.Add(this.bt_volver);
            this.pnAgregarCategoria.Controls.Add(this.bt_agregar);
            this.pnAgregarCategoria.Controls.Add(this.txtCategoria);
            this.pnAgregarCategoria.Location = new System.Drawing.Point(476, 119);
            this.pnAgregarCategoria.Name = "pnAgregarCategoria";
            this.pnAgregarCategoria.Size = new System.Drawing.Size(676, 291);
            this.pnAgregarCategoria.TabIndex = 0;
            this.pnAgregarCategoria.Visible = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(165)))), ((int)(((byte)(173)))));
            this.label3.Location = new System.Drawing.Point(26, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nombre de Categoría:";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(188, 69);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(252, 78);
            this.panel3.TabIndex = 13;
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(165)))), ((int)(((byte)(173)))));
            this.button4.Image = global::TiendaPaletas.Properties.Resources.camara_icono;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.Location = new System.Drawing.Point(34, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(240, 78);
            this.button4.TabIndex = 6;
            this.button4.Text = "Imagen de categoría";
            this.button4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::TiendaPaletas.Properties.Resources.advertencia;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bt_volver
            // 
            this.bt_volver.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bt_volver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(140)))), ((int)(((byte)(19)))), ((int)(((byte)(93)))));
            this.bt_volver.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_volver.FlatAppearance.BorderSize = 0;
            this.bt_volver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(140)))), ((int)(((byte)(19)))), ((int)(((byte)(93)))));
            this.bt_volver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(140)))), ((int)(((byte)(19)))), ((int)(((byte)(93)))));
            this.bt_volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_volver.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_volver.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_volver.Location = new System.Drawing.Point(452, 213);
            this.bt_volver.Name = "bt_volver";
            this.bt_volver.Size = new System.Drawing.Size(170, 30);
            this.bt_volver.TabIndex = 11;
            this.bt_volver.Text = "Volver";
            this.bt_volver.UseVisualStyleBackColor = false;
            this.bt_volver.Click += new System.EventHandler(this.bt_volver_Click);
            // 
            // bt_agregar
            // 
            this.bt_agregar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bt_agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(140)))), ((int)(((byte)(19)))), ((int)(((byte)(93)))));
            this.bt_agregar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_agregar.FlatAppearance.BorderSize = 0;
            this.bt_agregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(140)))), ((int)(((byte)(19)))), ((int)(((byte)(93)))));
            this.bt_agregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(140)))), ((int)(((byte)(19)))), ((int)(((byte)(93)))));
            this.bt_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_agregar.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_agregar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_agregar.Location = new System.Drawing.Point(64, 211);
            this.bt_agregar.Name = "bt_agregar";
            this.bt_agregar.Size = new System.Drawing.Size(170, 30);
            this.bt_agregar.TabIndex = 10;
            this.bt_agregar.Text = "Agregar";
            this.bt_agregar.UseVisualStyleBackColor = false;
            this.bt_agregar.Click += new System.EventHandler(this.bt_agregar_Click);
            // 
            // txtCategoria
            // 
            this.txtCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCategoria.BackColor = System.Drawing.Color.White;
            this.txtCategoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCategoria.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCategoria.Font = new System.Drawing.Font("Roboto Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(165)))), ((int)(((byte)(173)))));
            this.txtCategoria.Location = new System.Drawing.Point(249, 15);
            this.txtCategoria.MaxLength = 100;
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(394, 23);
            this.txtCategoria.TabIndex = 8;
            this.txtCategoria.Validating += new System.ComponentModel.CancelEventHandler(this.txtCategoria_Validating);
            // 
            // pnCategoria
            // 
            this.pnCategoria.Controls.Add(this.flowPnCategorias);
            this.pnCategoria.Controls.Add(this.panel5);
            this.pnCategoria.Location = new System.Drawing.Point(494, 47);
            this.pnCategoria.Name = "pnCategoria";
            this.pnCategoria.Size = new System.Drawing.Size(139, 292);
            this.pnCategoria.TabIndex = 3;
            this.pnCategoria.Visible = false;
            // 
            // flowPnCategorias
            // 
            this.flowPnCategorias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowPnCategorias.Location = new System.Drawing.Point(0, 48);
            this.flowPnCategorias.Name = "flowPnCategorias";
            this.flowPnCategorias.Size = new System.Drawing.Size(139, 244);
            this.flowPnCategorias.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnAgregarGrupo);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(139, 48);
            this.panel5.TabIndex = 13;
            // 
            // btnAgregarGrupo
            // 
            this.btnAgregarGrupo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregarGrupo.FlatAppearance.BorderSize = 0;
            this.btnAgregarGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarGrupo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregarGrupo.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarGrupo.Image")));
            this.btnAgregarGrupo.Location = new System.Drawing.Point(0, 0);
            this.btnAgregarGrupo.Margin = new System.Windows.Forms.Padding(0);
            this.btnAgregarGrupo.Name = "btnAgregarGrupo";
            this.btnAgregarGrupo.Size = new System.Drawing.Size(42, 42);
            this.btnAgregarGrupo.TabIndex = 12;
            this.btnAgregarGrupo.UseVisualStyleBackColor = false;
            this.btnAgregarGrupo.Click += new System.EventHandler(this.btnAgregarGrupo_Click);
            // 
            // pnProductos
            // 
            this.pnProductos.Controls.Add(this.btnEliminarProd);
            this.pnProductos.Controls.Add(this.dataGridViewProd);
            this.pnProductos.Controls.Add(this.btnRegresar);
            this.pnProductos.Controls.Add(this.btnAgregarProducto2);
            this.pnProductos.Controls.Add(this.pnTxtAgregarProducto);
            this.pnProductos.Controls.Add(this.btnAgregarProducto);
            this.pnProductos.Location = new System.Drawing.Point(40, 20);
            this.pnProductos.Name = "pnProductos";
            this.pnProductos.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.pnProductos.Size = new System.Drawing.Size(400, 589);
            this.pnProductos.TabIndex = 0;
            this.pnProductos.Visible = false;
            // 
            // btnEliminarProd
            // 
            this.btnEliminarProd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEliminarProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(140)))), ((int)(((byte)(19)))), ((int)(((byte)(93)))));
            this.btnEliminarProd.FlatAppearance.BorderSize = 0;
            this.btnEliminarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarProd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminarProd.Location = new System.Drawing.Point(192, 536);
            this.btnEliminarProd.MaximumSize = new System.Drawing.Size(75, 22);
            this.btnEliminarProd.Name = "btnEliminarProd";
            this.btnEliminarProd.Size = new System.Drawing.Size(75, 22);
            this.btnEliminarProd.TabIndex = 15;
            this.btnEliminarProd.Text = "Eliminar";
            this.btnEliminarProd.UseVisualStyleBackColor = false;
            this.btnEliminarProd.Click += new System.EventHandler(this.btnEliminarProd_Click);
            // 
            // dataGridViewProd
            // 
            this.dataGridViewProd.AllowUserToAddRows = false;
            this.dataGridViewProd.AllowUserToResizeRows = false;
            this.dataGridViewProd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProd.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewProd.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridViewProd.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreProducto,
            this.precioProducto,
            this.cantidadProducto,
            this.tamañoProducto});
            this.dataGridViewProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridViewProd.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.productosBindingSource, "precioProd", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.dataGridViewProd.Location = new System.Drawing.Point(150, 380);
            this.dataGridViewProd.MaximumSize = new System.Drawing.Size(750, 150);
            this.dataGridViewProd.MultiSelect = false;
            this.dataGridViewProd.Name = "dataGridViewProd";
            this.dataGridViewProd.ReadOnly = true;
            this.dataGridViewProd.RowHeadersVisible = false;
            this.dataGridViewProd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProd.Size = new System.Drawing.Size(400, 150);
            this.dataGridViewProd.TabIndex = 14;
            this.dataGridViewProd.VirtualMode = true;
            this.dataGridViewProd.SelectionChanged += new System.EventHandler(this.DataGridViewProd_SelectionChanged);
            // 
            // nombreProducto
            // 
            this.nombreProducto.DataPropertyName = "nombre";
            this.nombreProducto.Frozen = true;
            this.nombreProducto.HeaderText = "Nombre";
            this.nombreProducto.MaxInputLength = 100;
            this.nombreProducto.MinimumWidth = 10;
            this.nombreProducto.Name = "nombreProducto";
            this.nombreProducto.ReadOnly = true;
            this.nombreProducto.Width = 350;
            // 
            // precioProducto
            // 
            this.precioProducto.DataPropertyName = "precioProd";
            this.precioProducto.Frozen = true;
            this.precioProducto.HeaderText = "Precio";
            this.precioProducto.MaxInputLength = 50;
            this.precioProducto.MinimumWidth = 10;
            this.precioProducto.Name = "precioProducto";
            this.precioProducto.ReadOnly = true;
            // 
            // cantidadProducto
            // 
            this.cantidadProducto.DataPropertyName = "cantidadProd";
            this.cantidadProducto.Frozen = true;
            this.cantidadProducto.HeaderText = "Cantidad";
            this.cantidadProducto.MaxInputLength = 50;
            this.cantidadProducto.MinimumWidth = 10;
            this.cantidadProducto.Name = "cantidadProducto";
            this.cantidadProducto.ReadOnly = true;
            // 
            // tamañoProducto
            // 
            this.tamañoProducto.DataPropertyName = "tamañoProd";
            this.tamañoProducto.Frozen = true;
            this.tamañoProducto.HeaderText = "Tamaño";
            this.tamañoProducto.MaxInputLength = 50;
            this.tamañoProducto.MinimumWidth = 10;
            this.tamañoProducto.Name = "tamañoProducto";
            this.tamañoProducto.ReadOnly = true;
            this.tamañoProducto.Width = 200;
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataMember = "Productos";
            this.productosBindingSource.DataSource = this.tiendaPaletasDataSet;
            // 
            // tiendaPaletasDataSet
            // 
            this.tiendaPaletasDataSet.DataSetName = "tiendaPaletasDataSet";
            this.tiendaPaletasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(140)))), ((int)(((byte)(19)))), ((int)(((byte)(93)))));
            this.btnRegresar.FlatAppearance.BorderSize = 0;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRegresar.Location = new System.Drawing.Point(287, 536);
            this.btnRegresar.MaximumSize = new System.Drawing.Size(75, 22);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 22);
            this.btnRegresar.TabIndex = 13;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Visible = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnAgregarProducto2
            // 
            this.btnAgregarProducto2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregarProducto2.FlatAppearance.BorderSize = 0;
            this.btnAgregarProducto2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProducto2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProducto2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregarProducto2.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarProducto2.Image")));
            this.btnAgregarProducto2.Location = new System.Drawing.Point(0, 0);
            this.btnAgregarProducto2.Name = "btnAgregarProducto2";
            this.btnAgregarProducto2.Size = new System.Drawing.Size(42, 42);
            this.btnAgregarProducto2.TabIndex = 12;
            this.btnAgregarProducto2.UseVisualStyleBackColor = false;
            this.btnAgregarProducto2.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // pnTxtAgregarProducto
            // 
            this.pnTxtAgregarProducto.Controls.Add(this.pnDatosProducto);
            this.pnTxtAgregarProducto.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTxtAgregarProducto.Location = new System.Drawing.Point(50, 0);
            this.pnTxtAgregarProducto.Name = "pnTxtAgregarProducto";
            this.pnTxtAgregarProducto.Size = new System.Drawing.Size(350, 380);
            this.pnTxtAgregarProducto.TabIndex = 12;
            // 
            // pnDatosProducto
            // 
            this.pnDatosProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnDatosProducto.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.pnDatosProducto.IsSplitterFixed = true;
            this.pnDatosProducto.Location = new System.Drawing.Point(0, 65);
            this.pnDatosProducto.Name = "pnDatosProducto";
            // 
            // pnDatosProducto.Panel1
            // 
            this.pnDatosProducto.Panel1.Controls.Add(this.label1);
            this.pnDatosProducto.Panel1.Controls.Add(this.label4);
            this.pnDatosProducto.Panel1.Controls.Add(this.label5);
            this.pnDatosProducto.Panel1.Controls.Add(this.label7);
            this.pnDatosProducto.Panel1.Controls.Add(this.label6);
            this.pnDatosProducto.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // pnDatosProducto.Panel2
            // 
            this.pnDatosProducto.Panel2.Controls.Add(this.pictureBoxProd);
            this.pnDatosProducto.Panel2.Controls.Add(this.cbTamañoProducto);
            this.pnDatosProducto.Panel2.Controls.Add(this.txtProducto);
            this.pnDatosProducto.Panel2.Controls.Add(this.txtPrecio);
            this.pnDatosProducto.Panel2.Controls.Add(this.txtCantidad);
            this.pnDatosProducto.Panel2.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.pnDatosProducto.Size = new System.Drawing.Size(370, 244);
            this.pnDatosProducto.SplitterDistance = 150;
            this.pnDatosProducto.TabIndex = 14;
            this.pnDatosProducto.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(165)))), ((int)(((byte)(173)))));
            this.label1.Location = new System.Drawing.Point(36, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 23);
            this.label1.TabIndex = 19;
            this.label1.Text = "Imagen:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(165)))), ((int)(((byte)(173)))));
            this.label4.Location = new System.Drawing.Point(19, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 23);
            this.label4.TabIndex = 15;
            this.label4.Text = "Producto:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(165)))), ((int)(((byte)(173)))));
            this.label5.Location = new System.Drawing.Point(22, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 16;
            this.label5.Text = "Cantidad:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(165)))), ((int)(((byte)(173)))));
            this.label7.Location = new System.Drawing.Point(45, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 23);
            this.label7.TabIndex = 18;
            this.label7.Text = "Precio:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(165)))), ((int)(((byte)(173)))));
            this.label6.Location = new System.Drawing.Point(31, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 23);
            this.label6.TabIndex = 17;
            this.label6.Text = "Tamaño:";
            // 
            // pictureBoxProd
            // 
            this.pictureBoxProd.Image = global::TiendaPaletas.Properties.Resources.advertencia;
            this.pictureBoxProd.Location = new System.Drawing.Point(37, 188);
            this.pictureBoxProd.Name = "pictureBoxProd";
            this.pictureBoxProd.Size = new System.Drawing.Size(60, 60);
            this.pictureBoxProd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxProd.TabIndex = 23;
            this.pictureBoxProd.TabStop = false;
            this.pictureBoxProd.Click += new System.EventHandler(this.pictureBoxProd_Click);
            // 
            // cbTamañoProducto
            // 
            this.cbTamañoProducto.FormattingEnabled = true;
            this.cbTamañoProducto.Items.AddRange(new object[] {
            "Chico",
            "Mediano",
            "Grande"});
            this.cbTamañoProducto.Location = new System.Drawing.Point(37, 160);
            this.cbTamañoProducto.Name = "cbTamañoProducto";
            this.cbTamañoProducto.Size = new System.Drawing.Size(121, 21);
            this.cbTamañoProducto.TabIndex = 22;
            // 
            // txtProducto
            // 
            this.txtProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProducto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtProducto.Location = new System.Drawing.Point(37, 70);
            this.txtProducto.MaxLength = 50;
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(110, 24);
            this.txtProducto.TabIndex = 10;
            this.txtProducto.Validating += new System.ComponentModel.CancelEventHandler(this.txtProducto_Validating);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPrecio.Location = new System.Drawing.Point(37, 100);
            this.txtPrecio.MaxLength = 10;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(110, 24);
            this.txtPrecio.TabIndex = 19;
            this.txtPrecio.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrecio_Validating);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtCantidad.Location = new System.Drawing.Point(37, 129);
            this.txtCantidad.MaxLength = 10;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(110, 24);
            this.txtCantidad.TabIndex = 21;
            this.txtCantidad.Validating += new System.ComponentModel.CancelEventHandler(this.txtCantidad_Validating);
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(140)))), ((int)(((byte)(19)))), ((int)(((byte)(93)))));
            this.btnAgregarProducto.FlatAppearance.BorderSize = 0;
            this.btnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProducto.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProducto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregarProducto.Location = new System.Drawing.Point(100, 536);
            this.btnAgregarProducto.Margin = new System.Windows.Forms.Padding(0);
            this.btnAgregarProducto.MaximumSize = new System.Drawing.Size(75, 22);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(75, 22);
            this.btnAgregarProducto.TabIndex = 2;
            this.btnAgregarProducto.Text = "Agregar";
            this.btnAgregarProducto.UseVisualStyleBackColor = false;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // dataSetProductosBindingSource
            // 
            this.dataSetProductosBindingSource.DataSource = this.dataSetProductos;
            this.dataSetProductosBindingSource.Position = 0;
            // 
            // dataSetProductos
            // 
            this.dataSetProductos.DataSetName = "DataSetProductos";
            this.dataSetProductos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productosTableAdapter
            // 
            this.productosTableAdapter.ClearBeforeFill = true;
            // 
            // productosBindingSource1
            // 
            this.productosBindingSource1.DataMember = "Productos";
            this.productosBindingSource1.DataSource = this.tiendaPaletasDataSet;
            // 
            // productosBindingSource2
            // 
            this.productosBindingSource2.DataMember = "Productos";
            this.productosBindingSource2.DataSource = this.dataSetProductos;
            // 
            // productosTableAdapter1
            // 
            this.productosTableAdapter1.ClearBeforeFill = true;
            // 
            // errorProviderNombreProducto
            // 
            this.errorProviderNombreProducto.ContainerControl = this;
            this.errorProviderNombreProducto.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderNombreProducto.Icon")));
            // 
            // errorProviderPrecioProducto
            // 
            this.errorProviderPrecioProducto.ContainerControl = this;
            this.errorProviderPrecioProducto.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderPrecioProducto.Icon")));
            // 
            // errorProviderCantidadProducto
            // 
            this.errorProviderCantidadProducto.ContainerControl = this;
            this.errorProviderCantidadProducto.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderCantidadProducto.Icon")));
            // 
            // errorProviderNombreCategoria
            // 
            this.errorProviderNombreCategoria.ContainerControl = this;
            this.errorProviderNombreCategoria.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderNombreCategoria.Icon")));
            // 
            // Categorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(965, 729);
            this.Controls.Add(this.pnContenido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Categorias";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.Text = "Categorias";
            this.Load += new System.EventHandler(this.Categorias_Load);
            this.pnContenido.ResumeLayout(false);
            this.pnAgregarCategoria.ResumeLayout(false);
            this.pnAgregarCategoria.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnCategoria.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.pnProductos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiendaPaletasDataSet)).EndInit();
            this.pnTxtAgregarProducto.ResumeLayout(false);
            this.pnDatosProducto.Panel1.ResumeLayout(false);
            this.pnDatosProducto.Panel1.PerformLayout();
            this.pnDatosProducto.Panel2.ResumeLayout(false);
            this.pnDatosProducto.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnDatosProducto)).EndInit();
            this.pnDatosProducto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetProductosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNombreProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPrecioProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCantidadProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNombreCategoria)).EndInit();
            this.ResumeLayout(false);

        }

        



        #endregion
        private System.Windows.Forms.Panel pnContenido;
        private System.Windows.Forms.Panel pnAgregarCategoria;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bt_volver;
        private System.Windows.Forms.Button bt_agregar;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.OpenFileDialog dlg;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Panel pnProductos;
        private System.Windows.Forms.Panel pnTxtAgregarProducto;
        private System.Windows.Forms.Button btnAgregarProducto2;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Panel pnCategoria;
        private System.Windows.Forms.FlowLayoutPanel flowPnCategorias;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnAgregarGrupo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.SplitContainer pnDatosProducto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.ComboBox cbTamañoProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxProd;
        private System.Windows.Forms.DataGridView dataGridViewProd;
        private tiendaPaletasDataSet tiendaPaletasDataSet;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private tiendaPaletasDataSetTableAdapters.ProductosTableAdapter productosTableAdapter;
        private System.Windows.Forms.BindingSource productosBindingSource1;
        private DataSetProductos dataSetProductos;
        private System.Windows.Forms.BindingSource productosBindingSource2;
        private DataSetProductosTableAdapters.ProductosTableAdapter productosTableAdapter1;
        private System.Windows.Forms.BindingSource dataSetProductosBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn tamañoProducto;
        private System.Windows.Forms.Button btnEliminarProd;
        private System.Windows.Forms.ErrorProvider errorProviderNombreProducto;
        private System.Windows.Forms.ErrorProvider errorProviderPrecioProducto;
        private System.Windows.Forms.ErrorProvider errorProviderCantidadProducto;
        private System.Windows.Forms.ErrorProvider errorProviderNombreCategoria;
    }
}