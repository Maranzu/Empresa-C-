namespace empresa
{
    partial class Form_productos
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
            System.Windows.Forms.Label cod_productoLabel;
            System.Windows.Forms.Label des_productoLabel;
            System.Windows.Forms.Label fec_productoLabel;
            System.Windows.Forms.Label sto_productoLabel;
            System.Windows.Forms.Label gar_productoLabel;
            System.Windows.Forms.Label pco_productoLabel;
            System.Windows.Forms.Label pve_productoLabel;
            System.Windows.Forms.Label img_productoLabel;
            System.Windows.Forms.Label obs_productoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_productos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DS_PRODUCTOS = new empresa.ds_empresa();
            this.BS_categoria = new System.Windows.Forms.BindingSource(this.components);
            this.categoriaTableAdapter = new empresa.ds_empresaTableAdapters.CategoriaTableAdapter();
            this.productosTableAdapter = new empresa.ds_empresaTableAdapters.ProductosTableAdapter();
            this.GB_categoria = new System.Windows.Forms.GroupBox();
            this.CB_categorias = new System.Windows.Forms.ComboBox();
            this.Barra_herramientas = new System.Windows.Forms.ToolStrip();
            this.Nuevo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Guardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Cancelar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.Editar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.Eliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.TS_buscar = new System.Windows.Forms.ToolStripLabel();
            this.TB_buscar = new System.Windows.Forms.ToolStripTextBox();
            this.Salir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.GB_productos = new System.Windows.Forms.GroupBox();
            this.sto_productoNumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.BS_Productos = new System.Windows.Forms.BindingSource(this.components);
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.obs_productoTextBox = new System.Windows.Forms.TextBox();
            this.Fotografia = new System.Windows.Forms.PictureBox();
            this.pve_productoTextBox = new System.Windows.Forms.TextBox();
            this.pco_productoTextBox = new System.Windows.Forms.TextBox();
            this.gar_productoComboBox = new System.Windows.Forms.ComboBox();
            this.fec_productoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.des_productoTextBox = new System.Windows.Forms.TextBox();
            this.cod_productoTextBox = new System.Windows.Forms.TextBox();
            this.BN_empresa = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tableAdapterManager = new empresa.ds_empresaTableAdapters.TableAdapterManager();
            this.OFD_abrirArchivo = new System.Windows.Forms.OpenFileDialog();
            this.DGV_Productos = new System.Windows.Forms.DataGridView();
            this.codproductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desproductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecproductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stoproductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obsproductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cod_productoLabel = new System.Windows.Forms.Label();
            des_productoLabel = new System.Windows.Forms.Label();
            fec_productoLabel = new System.Windows.Forms.Label();
            sto_productoLabel = new System.Windows.Forms.Label();
            gar_productoLabel = new System.Windows.Forms.Label();
            pco_productoLabel = new System.Windows.Forms.Label();
            pve_productoLabel = new System.Windows.Forms.Label();
            img_productoLabel = new System.Windows.Forms.Label();
            obs_productoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DS_PRODUCTOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_categoria)).BeginInit();
            this.GB_categoria.SuspendLayout();
            this.Barra_herramientas.SuspendLayout();
            this.GB_productos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sto_productoNumericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Productos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fotografia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BN_empresa)).BeginInit();
            this.BN_empresa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Productos)).BeginInit();
            this.SuspendLayout();
            // 
            // cod_productoLabel
            // 
            cod_productoLabel.AutoSize = true;
            cod_productoLabel.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cod_productoLabel.Location = new System.Drawing.Point(10, 25);
            cod_productoLabel.Name = "cod_productoLabel";
            cod_productoLabel.Size = new System.Drawing.Size(49, 15);
            cod_productoLabel.TabIndex = 0;
            cod_productoLabel.Text = "Código:";
            // 
            // des_productoLabel
            // 
            des_productoLabel.AutoSize = true;
            des_productoLabel.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            des_productoLabel.Location = new System.Drawing.Point(10, 54);
            des_productoLabel.Name = "des_productoLabel";
            des_productoLabel.Size = new System.Drawing.Size(73, 15);
            des_productoLabel.TabIndex = 2;
            des_productoLabel.Text = "Descripción";
            // 
            // fec_productoLabel
            // 
            fec_productoLabel.AutoSize = true;
            fec_productoLabel.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fec_productoLabel.Location = new System.Drawing.Point(10, 84);
            fec_productoLabel.Name = "fec_productoLabel";
            fec_productoLabel.Size = new System.Drawing.Size(43, 15);
            fec_productoLabel.TabIndex = 4;
            fec_productoLabel.Text = "Fecha:";
            // 
            // sto_productoLabel
            // 
            sto_productoLabel.AutoSize = true;
            sto_productoLabel.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sto_productoLabel.Location = new System.Drawing.Point(10, 109);
            sto_productoLabel.Name = "sto_productoLabel";
            sto_productoLabel.Size = new System.Drawing.Size(43, 15);
            sto_productoLabel.TabIndex = 6;
            sto_productoLabel.Text = "Stock:";
            // 
            // gar_productoLabel
            // 
            gar_productoLabel.AutoSize = true;
            gar_productoLabel.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gar_productoLabel.Location = new System.Drawing.Point(10, 141);
            gar_productoLabel.Name = "gar_productoLabel";
            gar_productoLabel.Size = new System.Drawing.Size(61, 15);
            gar_productoLabel.TabIndex = 8;
            gar_productoLabel.Text = "Garantía:";
            // 
            // pco_productoLabel
            // 
            pco_productoLabel.AutoSize = true;
            pco_productoLabel.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pco_productoLabel.Location = new System.Drawing.Point(10, 170);
            pco_productoLabel.Name = "pco_productoLabel";
            pco_productoLabel.Size = new System.Drawing.Size(91, 15);
            pco_productoLabel.TabIndex = 10;
            pco_productoLabel.Text = "Precio compra:";
            // 
            // pve_productoLabel
            // 
            pve_productoLabel.AutoSize = true;
            pve_productoLabel.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pve_productoLabel.Location = new System.Drawing.Point(10, 196);
            pve_productoLabel.Name = "pve_productoLabel";
            pve_productoLabel.Size = new System.Drawing.Size(85, 15);
            pve_productoLabel.TabIndex = 12;
            pve_productoLabel.Text = "Precio venta:";
            // 
            // img_productoLabel
            // 
            img_productoLabel.AutoSize = true;
            img_productoLabel.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            img_productoLabel.Location = new System.Drawing.Point(413, 10);
            img_productoLabel.Name = "img_productoLabel";
            img_productoLabel.Size = new System.Drawing.Size(49, 15);
            img_productoLabel.TabIndex = 14;
            img_productoLabel.Text = "Imagen:";
            // 
            // obs_productoLabel
            // 
            obs_productoLabel.AutoSize = true;
            obs_productoLabel.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            obs_productoLabel.Location = new System.Drawing.Point(413, 162);
            obs_productoLabel.Name = "obs_productoLabel";
            obs_productoLabel.Size = new System.Drawing.Size(79, 15);
            obs_productoLabel.TabIndex = 16;
            obs_productoLabel.Text = "Observación:";
            // 
            // DS_PRODUCTOS
            // 
            this.DS_PRODUCTOS.DataSetName = "ds_empresa";
            this.DS_PRODUCTOS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BS_categoria
            // 
            this.BS_categoria.DataMember = "Categoria";
            this.BS_categoria.DataSource = this.DS_PRODUCTOS;
            // 
            // categoriaTableAdapter
            // 
            this.categoriaTableAdapter.ClearBeforeFill = true;
            // 
            // productosTableAdapter
            // 
            this.productosTableAdapter.ClearBeforeFill = true;
            // 
            // GB_categoria
            // 
            this.GB_categoria.Controls.Add(this.CB_categorias);
            this.GB_categoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.GB_categoria.Font = new System.Drawing.Font("Cascadia Mono", 10F);
            this.GB_categoria.Location = new System.Drawing.Point(0, 0);
            this.GB_categoria.Name = "GB_categoria";
            this.GB_categoria.Size = new System.Drawing.Size(857, 63);
            this.GB_categoria.TabIndex = 0;
            this.GB_categoria.TabStop = false;
            this.GB_categoria.Text = "Seleccionar la categoría:";
            // 
            // CB_categorias
            // 
            this.CB_categorias.DataSource = this.BS_categoria;
            this.CB_categorias.DisplayMember = "nom_categoria";
            this.CB_categorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_categorias.FormattingEnabled = true;
            this.CB_categorias.Location = new System.Drawing.Point(6, 32);
            this.CB_categorias.Name = "CB_categorias";
            this.CB_categorias.Size = new System.Drawing.Size(213, 25);
            this.CB_categorias.TabIndex = 0;
            // 
            // Barra_herramientas
            // 
            this.Barra_herramientas.Font = new System.Drawing.Font("Cascadia Mono", 9F);
            this.Barra_herramientas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Nuevo,
            this.toolStripSeparator1,
            this.Guardar,
            this.toolStripSeparator2,
            this.Cancelar,
            this.toolStripSeparator3,
            this.Editar,
            this.toolStripSeparator4,
            this.Eliminar,
            this.toolStripSeparator5,
            this.TS_buscar,
            this.TB_buscar,
            this.Salir,
            this.toolStripSeparator6});
            this.Barra_herramientas.Location = new System.Drawing.Point(0, 63);
            this.Barra_herramientas.Name = "Barra_herramientas";
            this.Barra_herramientas.Size = new System.Drawing.Size(857, 25);
            this.Barra_herramientas.TabIndex = 1;
            this.Barra_herramientas.Text = "toolStrip1";
            // 
            // Nuevo
            // 
            this.Nuevo.Image = ((System.Drawing.Image)(resources.GetObject("Nuevo.Image")));
            this.Nuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Nuevo.Name = "Nuevo";
            this.Nuevo.Size = new System.Drawing.Size(62, 22);
            this.Nuevo.Text = "Nuevo";
            this.Nuevo.Click += new System.EventHandler(this.Nuevo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // Guardar
            // 
            this.Guardar.Enabled = false;
            this.Guardar.Image = ((System.Drawing.Image)(resources.GetObject("Guardar.Image")));
            this.Guardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(76, 22);
            this.Guardar.Text = "Guardar";
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // Cancelar
            // 
            this.Cancelar.Enabled = false;
            this.Cancelar.Image = ((System.Drawing.Image)(resources.GetObject("Cancelar.Image")));
            this.Cancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(83, 22);
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // Editar
            // 
            this.Editar.Image = ((System.Drawing.Image)(resources.GetObject("Editar.Image")));
            this.Editar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(69, 22);
            this.Editar.Text = "Editar";
            this.Editar.Click += new System.EventHandler(this.Editar_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // Eliminar
            // 
            this.Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Eliminar.Image")));
            this.Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(83, 22);
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // TS_buscar
            // 
            this.TS_buscar.Name = "TS_buscar";
            this.TS_buscar.Size = new System.Drawing.Size(133, 22);
            this.TS_buscar.Text = "Buscar por código:";
            // 
            // TB_buscar
            // 
            this.TB_buscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TB_buscar.Name = "TB_buscar";
            this.TB_buscar.Size = new System.Drawing.Size(150, 25);
            this.TB_buscar.TextChanged += new System.EventHandler(this.TB_buscar_TextChanged);
            // 
            // Salir
            // 
            this.Salir.Image = ((System.Drawing.Image)(resources.GetObject("Salir.Image")));
            this.Salir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(62, 22);
            this.Salir.Text = "Salir";
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // GB_productos
            // 
            this.GB_productos.Controls.Add(this.sto_productoNumericUpDown1);
            this.GB_productos.Controls.Add(this.Btn_guardar);
            this.GB_productos.Controls.Add(obs_productoLabel);
            this.GB_productos.Controls.Add(this.obs_productoTextBox);
            this.GB_productos.Controls.Add(img_productoLabel);
            this.GB_productos.Controls.Add(this.Fotografia);
            this.GB_productos.Controls.Add(pve_productoLabel);
            this.GB_productos.Controls.Add(this.pve_productoTextBox);
            this.GB_productos.Controls.Add(pco_productoLabel);
            this.GB_productos.Controls.Add(this.pco_productoTextBox);
            this.GB_productos.Controls.Add(gar_productoLabel);
            this.GB_productos.Controls.Add(this.gar_productoComboBox);
            this.GB_productos.Controls.Add(sto_productoLabel);
            this.GB_productos.Controls.Add(fec_productoLabel);
            this.GB_productos.Controls.Add(this.fec_productoDateTimePicker);
            this.GB_productos.Controls.Add(des_productoLabel);
            this.GB_productos.Controls.Add(this.des_productoTextBox);
            this.GB_productos.Controls.Add(cod_productoLabel);
            this.GB_productos.Controls.Add(this.cod_productoTextBox);
            this.GB_productos.Dock = System.Windows.Forms.DockStyle.Top;
            this.GB_productos.Font = new System.Drawing.Font("Cascadia Mono", 10F);
            this.GB_productos.Location = new System.Drawing.Point(0, 88);
            this.GB_productos.Name = "GB_productos";
            this.GB_productos.Size = new System.Drawing.Size(857, 241);
            this.GB_productos.TabIndex = 2;
            this.GB_productos.TabStop = false;
            this.GB_productos.Text = "Información del producto";
            // 
            // sto_productoNumericUpDown1
            // 
            this.sto_productoNumericUpDown1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.BS_Productos, "sto_producto", true));
            this.sto_productoNumericUpDown1.Location = new System.Drawing.Point(107, 105);
            this.sto_productoNumericUpDown1.Name = "sto_productoNumericUpDown1";
            this.sto_productoNumericUpDown1.Size = new System.Drawing.Size(200, 23);
            this.sto_productoNumericUpDown1.TabIndex = 20;
            this.sto_productoNumericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // BS_Productos
            // 
            this.BS_Productos.DataMember = "FK_Productos_Categoria";
            this.BS_Productos.DataSource = this.BS_categoria;
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.Font = new System.Drawing.Font("Cascadia Mono", 8F);
            this.Btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_guardar.Image")));
            this.Btn_guardar.Location = new System.Drawing.Point(652, 126);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(75, 24);
            this.Btn_guardar.TabIndex = 18;
            this.Btn_guardar.UseVisualStyleBackColor = true;
            this.Btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // obs_productoTextBox
            // 
            this.obs_productoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_Productos, "obs_producto", true));
            this.obs_productoTextBox.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.obs_productoTextBox.Location = new System.Drawing.Point(510, 156);
            this.obs_productoTextBox.MaxLength = 100;
            this.obs_productoTextBox.Multiline = true;
            this.obs_productoTextBox.Name = "obs_productoTextBox";
            this.obs_productoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.obs_productoTextBox.Size = new System.Drawing.Size(217, 65);
            this.obs_productoTextBox.TabIndex = 17;
            // 
            // Fotografia
            // 
            this.Fotografia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Fotografia.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.BS_Productos, "img_producto", true));
            this.Fotografia.Location = new System.Drawing.Point(510, 10);
            this.Fotografia.Name = "Fotografia";
            this.Fotografia.Size = new System.Drawing.Size(217, 110);
            this.Fotografia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Fotografia.TabIndex = 15;
            this.Fotografia.TabStop = false;
            // 
            // pve_productoTextBox
            // 
            this.pve_productoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_Productos, "pve_producto", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.pve_productoTextBox.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pve_productoTextBox.Location = new System.Drawing.Point(107, 193);
            this.pve_productoTextBox.Name = "pve_productoTextBox";
            this.pve_productoTextBox.Size = new System.Drawing.Size(200, 20);
            this.pve_productoTextBox.TabIndex = 13;
            // 
            // pco_productoTextBox
            // 
            this.pco_productoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_Productos, "pco_producto", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.pco_productoTextBox.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pco_productoTextBox.Location = new System.Drawing.Point(107, 167);
            this.pco_productoTextBox.Name = "pco_productoTextBox";
            this.pco_productoTextBox.Size = new System.Drawing.Size(200, 20);
            this.pco_productoTextBox.TabIndex = 11;
            // 
            // gar_productoComboBox
            // 
            this.gar_productoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.BS_Productos, "gar_producto", true));
            this.gar_productoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.BS_Productos, "gar_producto", true));
            this.gar_productoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gar_productoComboBox.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gar_productoComboBox.FormattingEnabled = true;
            this.gar_productoComboBox.Items.AddRange(new object[] {
            "1 año",
            "2 años",
            "3 años",
            "4 años"});
            this.gar_productoComboBox.Location = new System.Drawing.Point(107, 138);
            this.gar_productoComboBox.Name = "gar_productoComboBox";
            this.gar_productoComboBox.Size = new System.Drawing.Size(200, 23);
            this.gar_productoComboBox.TabIndex = 9;
            // 
            // fec_productoDateTimePicker
            // 
            this.fec_productoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_Productos, "fec_producto", true));
            this.fec_productoDateTimePicker.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fec_productoDateTimePicker.Location = new System.Drawing.Point(107, 80);
            this.fec_productoDateTimePicker.Name = "fec_productoDateTimePicker";
            this.fec_productoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fec_productoDateTimePicker.TabIndex = 5;
            // 
            // des_productoTextBox
            // 
            this.des_productoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.des_productoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_Productos, "des_producto", true));
            this.des_productoTextBox.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.des_productoTextBox.Location = new System.Drawing.Point(107, 51);
            this.des_productoTextBox.Name = "des_productoTextBox";
            this.des_productoTextBox.Size = new System.Drawing.Size(200, 20);
            this.des_productoTextBox.TabIndex = 3;
            // 
            // cod_productoTextBox
            // 
            this.cod_productoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cod_productoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_Productos, "cod_producto", true));
            this.cod_productoTextBox.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cod_productoTextBox.Location = new System.Drawing.Point(107, 22);
            this.cod_productoTextBox.MaxLength = 5;
            this.cod_productoTextBox.Name = "cod_productoTextBox";
            this.cod_productoTextBox.Size = new System.Drawing.Size(200, 20);
            this.cod_productoTextBox.TabIndex = 1;
            // 
            // BN_empresa
            // 
            this.BN_empresa.AddNewItem = null;
            this.BN_empresa.BindingSource = this.BS_Productos;
            this.BN_empresa.CountItem = this.bindingNavigatorCountItem;
            this.BN_empresa.DeleteItem = null;
            this.BN_empresa.Dock = System.Windows.Forms.DockStyle.None;
            this.BN_empresa.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BN_empresa.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.BN_empresa.Location = new System.Drawing.Point(0, 455);
            this.BN_empresa.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.BN_empresa.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.BN_empresa.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.BN_empresa.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.BN_empresa.Name = "BN_empresa";
            this.BN_empresa.PositionItem = this.bindingNavigatorPositionItem;
            this.BN_empresa.Size = new System.Drawing.Size(223, 25);
            this.BN_empresa.TabIndex = 4;
            this.BN_empresa.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(49, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriaTableAdapter = this.categoriaTableAdapter;
            this.tableAdapterManager.ProductosTableAdapter = this.productosTableAdapter;
            this.tableAdapterManager.UpdateOrder = empresa.ds_empresaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // OFD_abrirArchivo
            // 
            this.OFD_abrirArchivo.FileName = "openFileDialog1";
            // 
            // DGV_Productos
            // 
            this.DGV_Productos.AllowUserToAddRows = false;
            this.DGV_Productos.AllowUserToDeleteRows = false;
            this.DGV_Productos.AutoGenerateColumns = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cascadia Mono", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Productos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Productos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codproductoDataGridViewTextBoxColumn,
            this.desproductoDataGridViewTextBoxColumn,
            this.fecproductoDataGridViewTextBoxColumn,
            this.stoproductoDataGridViewTextBoxColumn,
            this.obsproductoDataGridViewTextBoxColumn});
            this.DGV_Productos.DataSource = this.BS_Productos;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Cascadia Mono", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_Productos.DefaultCellStyle = dataGridViewCellStyle4;
            this.DGV_Productos.Dock = System.Windows.Forms.DockStyle.Top;
            this.DGV_Productos.Location = new System.Drawing.Point(0, 329);
            this.DGV_Productos.Name = "DGV_Productos";
            this.DGV_Productos.ReadOnly = true;
            this.DGV_Productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Productos.Size = new System.Drawing.Size(857, 122);
            this.DGV_Productos.TabIndex = 5;
            // 
            // codproductoDataGridViewTextBoxColumn
            // 
            this.codproductoDataGridViewTextBoxColumn.DataPropertyName = "cod_producto";
            this.codproductoDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codproductoDataGridViewTextBoxColumn.Name = "codproductoDataGridViewTextBoxColumn";
            this.codproductoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codproductoDataGridViewTextBoxColumn.Width = 110;
            // 
            // desproductoDataGridViewTextBoxColumn
            // 
            this.desproductoDataGridViewTextBoxColumn.DataPropertyName = "des_producto";
            this.desproductoDataGridViewTextBoxColumn.HeaderText = "Descripción";
            this.desproductoDataGridViewTextBoxColumn.Name = "desproductoDataGridViewTextBoxColumn";
            this.desproductoDataGridViewTextBoxColumn.ReadOnly = true;
            this.desproductoDataGridViewTextBoxColumn.Width = 250;
            // 
            // fecproductoDataGridViewTextBoxColumn
            // 
            this.fecproductoDataGridViewTextBoxColumn.DataPropertyName = "fec_producto";
            this.fecproductoDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fecproductoDataGridViewTextBoxColumn.Name = "fecproductoDataGridViewTextBoxColumn";
            this.fecproductoDataGridViewTextBoxColumn.ReadOnly = true;
            this.fecproductoDataGridViewTextBoxColumn.Width = 200;
            // 
            // stoproductoDataGridViewTextBoxColumn
            // 
            this.stoproductoDataGridViewTextBoxColumn.DataPropertyName = "sto_producto";
            this.stoproductoDataGridViewTextBoxColumn.HeaderText = "Stock";
            this.stoproductoDataGridViewTextBoxColumn.Name = "stoproductoDataGridViewTextBoxColumn";
            this.stoproductoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // obsproductoDataGridViewTextBoxColumn
            // 
            this.obsproductoDataGridViewTextBoxColumn.DataPropertyName = "obs_producto";
            this.obsproductoDataGridViewTextBoxColumn.HeaderText = "Observación";
            this.obsproductoDataGridViewTextBoxColumn.Name = "obsproductoDataGridViewTextBoxColumn";
            this.obsproductoDataGridViewTextBoxColumn.ReadOnly = true;
            this.obsproductoDataGridViewTextBoxColumn.Width = 150;
            // 
            // Form_productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 481);
            this.Controls.Add(this.DGV_Productos);
            this.Controls.Add(this.BN_empresa);
            this.Controls.Add(this.GB_productos);
            this.Controls.Add(this.Barra_herramientas);
            this.Controls.Add(this.GB_categoria);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_productos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Form_productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DS_PRODUCTOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_categoria)).EndInit();
            this.GB_categoria.ResumeLayout(false);
            this.Barra_herramientas.ResumeLayout(false);
            this.Barra_herramientas.PerformLayout();
            this.GB_productos.ResumeLayout(false);
            this.GB_productos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sto_productoNumericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Productos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fotografia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BN_empresa)).EndInit();
            this.BN_empresa.ResumeLayout(false);
            this.BN_empresa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Productos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ds_empresa DS_PRODUCTOS;
        private System.Windows.Forms.BindingSource BS_categoria;
        private ds_empresaTableAdapters.CategoriaTableAdapter categoriaTableAdapter;
        private ds_empresaTableAdapters.ProductosTableAdapter productosTableAdapter;
        private System.Windows.Forms.GroupBox GB_categoria;
        private System.Windows.Forms.ToolStrip Barra_herramientas;
        private System.Windows.Forms.ToolStripButton Nuevo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton Guardar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton Cancelar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton Editar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton Eliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripLabel TS_buscar;
        private System.Windows.Forms.ToolStripTextBox TB_buscar;
        private System.Windows.Forms.ToolStripButton Salir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.GroupBox GB_productos;
        private System.Windows.Forms.BindingNavigator BN_empresa;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ComboBox CB_categorias;
        private System.Windows.Forms.TextBox obs_productoTextBox;
        private System.Windows.Forms.PictureBox Fotografia;
        private System.Windows.Forms.TextBox pve_productoTextBox;
        private System.Windows.Forms.TextBox pco_productoTextBox;
        private System.Windows.Forms.ComboBox gar_productoComboBox;
        private System.Windows.Forms.DateTimePicker fec_productoDateTimePicker;
        private System.Windows.Forms.TextBox des_productoTextBox;
        private System.Windows.Forms.TextBox cod_productoTextBox;
        private ds_empresaTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.OpenFileDialog OFD_abrirArchivo;
        private System.Windows.Forms.NumericUpDown sto_productoNumericUpDown1;
        private System.Windows.Forms.BindingSource BS_Productos;
        private System.Windows.Forms.DataGridView DGV_Productos;
        private System.Windows.Forms.DataGridViewTextBoxColumn codproductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn desproductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecproductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stoproductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn obsproductoDataGridViewTextBoxColumn;
    }
}