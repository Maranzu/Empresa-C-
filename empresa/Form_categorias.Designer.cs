namespace empresa
{
    partial class Form_categorias
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
            System.Windows.Forms.Label cod_categoriaLabel;
            System.Windows.Forms.Label nom_categoriaLabel;
            System.Windows.Forms.Label bog_categoriaLabel;
            System.Windows.Forms.Label ubi_categoriaLabel;
            System.Windows.Forms.Label obs_categoriaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_categorias));
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
            this.Nuevo = new System.Windows.Forms.ToolStripButton();
            this.Guardar = new System.Windows.Forms.ToolStripButton();
            this.Cancelar = new System.Windows.Forms.ToolStripButton();
            this.Editar = new System.Windows.Forms.ToolStripButton();
            this.Eliminar = new System.Windows.Forms.ToolStripButton();
            this.Salir = new System.Windows.Forms.ToolStripButton();
            this.DGV_empresa = new System.Windows.Forms.DataGridView();
            this.codcategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomcategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bogcategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ubicategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obscategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BS_categoria = new System.Windows.Forms.BindingSource(this.components);
            this.ds_empresa = new empresa.ds_empresa();
            this.TS_empresa = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TxtBuscar = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.CB_categoria = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.Todos = new System.Windows.Forms.ToolStripButton();
            this.TA_categoria = new empresa.ds_empresaTableAdapters.CategoriaTableAdapter();
            this.tableAdapterManager = new empresa.ds_empresaTableAdapters.TableAdapterManager();
            this.cod_categoriaTextBox = new System.Windows.Forms.TextBox();
            this.nom_categoriaTextBox = new System.Windows.Forms.TextBox();
            this.bog_categoriaComboBox = new System.Windows.Forms.ComboBox();
            this.ubi_categoriaComboBox = new System.Windows.Forms.ComboBox();
            this.obs_categoriaTextBox = new System.Windows.Forms.TextBox();
            cod_categoriaLabel = new System.Windows.Forms.Label();
            nom_categoriaLabel = new System.Windows.Forms.Label();
            bog_categoriaLabel = new System.Windows.Forms.Label();
            ubi_categoriaLabel = new System.Windows.Forms.Label();
            obs_categoriaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BN_empresa)).BeginInit();
            this.BN_empresa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_empresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_categoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_empresa)).BeginInit();
            this.TS_empresa.SuspendLayout();
            this.SuspendLayout();
            // 
            // cod_categoriaLabel
            // 
            cod_categoriaLabel.AutoSize = true;
            cod_categoriaLabel.Font = new System.Drawing.Font("Cascadia Code Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cod_categoriaLabel.Location = new System.Drawing.Point(7, 82);
            cod_categoriaLabel.Name = "cod_categoriaLabel";
            cod_categoriaLabel.Size = new System.Drawing.Size(56, 16);
            cod_categoriaLabel.TabIndex = 3;
            cod_categoriaLabel.Text = "Código:";
            // 
            // nom_categoriaLabel
            // 
            nom_categoriaLabel.AutoSize = true;
            nom_categoriaLabel.Font = new System.Drawing.Font("Cascadia Code Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nom_categoriaLabel.Location = new System.Drawing.Point(7, 108);
            nom_categoriaLabel.Name = "nom_categoriaLabel";
            nom_categoriaLabel.Size = new System.Drawing.Size(56, 16);
            nom_categoriaLabel.TabIndex = 5;
            nom_categoriaLabel.Text = "Nombre:";
            // 
            // bog_categoriaLabel
            // 
            bog_categoriaLabel.AutoSize = true;
            bog_categoriaLabel.Font = new System.Drawing.Font("Cascadia Code Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bog_categoriaLabel.Location = new System.Drawing.Point(7, 134);
            bog_categoriaLabel.Name = "bog_categoriaLabel";
            bog_categoriaLabel.Size = new System.Drawing.Size(56, 16);
            bog_categoriaLabel.TabIndex = 7;
            bog_categoriaLabel.Text = "Bodega:";
            // 
            // ubi_categoriaLabel
            // 
            ubi_categoriaLabel.AutoSize = true;
            ubi_categoriaLabel.Font = new System.Drawing.Font("Cascadia Code Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ubi_categoriaLabel.Location = new System.Drawing.Point(7, 161);
            ubi_categoriaLabel.Name = "ubi_categoriaLabel";
            ubi_categoriaLabel.Size = new System.Drawing.Size(77, 16);
            ubi_categoriaLabel.TabIndex = 9;
            ubi_categoriaLabel.Text = "Ubicación:";
            // 
            // obs_categoriaLabel
            // 
            obs_categoriaLabel.AutoSize = true;
            obs_categoriaLabel.Font = new System.Drawing.Font("Cascadia Code Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            obs_categoriaLabel.Location = new System.Drawing.Point(7, 189);
            obs_categoriaLabel.Name = "obs_categoriaLabel";
            obs_categoriaLabel.Size = new System.Drawing.Size(91, 16);
            obs_categoriaLabel.TabIndex = 11;
            obs_categoriaLabel.Text = "Observación:";
            // 
            // BN_empresa
            // 
            this.BN_empresa.AddNewItem = null;
            this.BN_empresa.CountItem = this.bindingNavigatorCountItem;
            this.BN_empresa.DeleteItem = null;
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
            this.bindingNavigatorSeparator2,
            this.Nuevo,
            this.Guardar,
            this.Cancelar,
            this.Editar,
            this.Eliminar,
            this.Salir});
            this.BN_empresa.Location = new System.Drawing.Point(0, 0);
            this.BN_empresa.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.BN_empresa.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.BN_empresa.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.BN_empresa.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.BN_empresa.Name = "BN_empresa";
            this.BN_empresa.PositionItem = this.bindingNavigatorPositionItem;
            this.BN_empresa.Size = new System.Drawing.Size(800, 25);
            this.BN_empresa.TabIndex = 0;
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
            // Nuevo
            // 
            this.Nuevo.Image = ((System.Drawing.Image)(resources.GetObject("Nuevo.Image")));
            this.Nuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Nuevo.Name = "Nuevo";
            this.Nuevo.Size = new System.Drawing.Size(62, 22);
            this.Nuevo.Text = "Nuevo";
            this.Nuevo.Click += new System.EventHandler(this.Nuevo_Click);
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
            // Editar
            // 
            this.Editar.Image = ((System.Drawing.Image)(resources.GetObject("Editar.Image")));
            this.Editar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(69, 22);
            this.Editar.Text = "Editar";
            this.Editar.Click += new System.EventHandler(this.Editar_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Eliminar.Image")));
            this.Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(83, 22);
            this.Eliminar.Text = "Eliminar";
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
            // DGV_empresa
            // 
            this.DGV_empresa.AllowUserToAddRows = false;
            this.DGV_empresa.AllowUserToDeleteRows = false;
            this.DGV_empresa.AutoGenerateColumns = false;
            this.DGV_empresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_empresa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codcategoriaDataGridViewTextBoxColumn,
            this.nomcategoriaDataGridViewTextBoxColumn,
            this.bogcategoriaDataGridViewTextBoxColumn,
            this.ubicategoriaDataGridViewTextBoxColumn,
            this.obscategoriaDataGridViewTextBoxColumn});
            this.DGV_empresa.DataSource = this.BS_categoria;
            this.DGV_empresa.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DGV_empresa.Location = new System.Drawing.Point(0, 300);
            this.DGV_empresa.Name = "DGV_empresa";
            this.DGV_empresa.ReadOnly = true;
            this.DGV_empresa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_empresa.Size = new System.Drawing.Size(800, 150);
            this.DGV_empresa.TabIndex = 1;
            // 
            // codcategoriaDataGridViewTextBoxColumn
            // 
            this.codcategoriaDataGridViewTextBoxColumn.DataPropertyName = "cod_categoria";
            this.codcategoriaDataGridViewTextBoxColumn.HeaderText = "CÓDIGO";
            this.codcategoriaDataGridViewTextBoxColumn.Name = "codcategoriaDataGridViewTextBoxColumn";
            this.codcategoriaDataGridViewTextBoxColumn.ReadOnly = true;
            this.codcategoriaDataGridViewTextBoxColumn.Width = 150;
            // 
            // nomcategoriaDataGridViewTextBoxColumn
            // 
            this.nomcategoriaDataGridViewTextBoxColumn.DataPropertyName = "nom_categoria";
            this.nomcategoriaDataGridViewTextBoxColumn.HeaderText = "NOMBRE";
            this.nomcategoriaDataGridViewTextBoxColumn.Name = "nomcategoriaDataGridViewTextBoxColumn";
            this.nomcategoriaDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomcategoriaDataGridViewTextBoxColumn.Width = 150;
            // 
            // bogcategoriaDataGridViewTextBoxColumn
            // 
            this.bogcategoriaDataGridViewTextBoxColumn.DataPropertyName = "bog_categoria";
            this.bogcategoriaDataGridViewTextBoxColumn.HeaderText = "BODEGA";
            this.bogcategoriaDataGridViewTextBoxColumn.Name = "bogcategoriaDataGridViewTextBoxColumn";
            this.bogcategoriaDataGridViewTextBoxColumn.ReadOnly = true;
            this.bogcategoriaDataGridViewTextBoxColumn.Width = 150;
            // 
            // ubicategoriaDataGridViewTextBoxColumn
            // 
            this.ubicategoriaDataGridViewTextBoxColumn.DataPropertyName = "ubi_categoria";
            this.ubicategoriaDataGridViewTextBoxColumn.HeaderText = "UBICACIÓN";
            this.ubicategoriaDataGridViewTextBoxColumn.Name = "ubicategoriaDataGridViewTextBoxColumn";
            this.ubicategoriaDataGridViewTextBoxColumn.ReadOnly = true;
            this.ubicategoriaDataGridViewTextBoxColumn.Width = 150;
            // 
            // obscategoriaDataGridViewTextBoxColumn
            // 
            this.obscategoriaDataGridViewTextBoxColumn.DataPropertyName = "obs_categoria";
            this.obscategoriaDataGridViewTextBoxColumn.HeaderText = "OBSERVACIÓN";
            this.obscategoriaDataGridViewTextBoxColumn.Name = "obscategoriaDataGridViewTextBoxColumn";
            this.obscategoriaDataGridViewTextBoxColumn.ReadOnly = true;
            this.obscategoriaDataGridViewTextBoxColumn.Width = 150;
            // 
            // BS_categoria
            // 
            this.BS_categoria.DataMember = "Categoria";
            this.BS_categoria.DataSource = this.ds_empresa;
            // 
            // ds_empresa
            // 
            this.ds_empresa.DataSetName = "ds_empresa";
            this.ds_empresa.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TS_empresa
            // 
            this.TS_empresa.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TS_empresa.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TS_empresa.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.TxtBuscar,
            this.toolStripSeparator2,
            this.toolStripLabel2,
            this.toolStripSeparator3,
            this.CB_categoria,
            this.toolStripSeparator4,
            this.Todos});
            this.TS_empresa.Location = new System.Drawing.Point(0, 275);
            this.TS_empresa.Name = "TS_empresa";
            this.TS_empresa.Size = new System.Drawing.Size(800, 25);
            this.TS_empresa.TabIndex = 2;
            this.TS_empresa.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(161, 22);
            this.toolStripLabel1.Text = "Buscar por nombres -->";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(77, 22);
            this.toolStripLabel2.Text = "Categoría:";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // CB_categoria
            // 
            this.CB_categoria.Name = "CB_categoria";
            this.CB_categoria.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // Todos
            // 
            this.Todos.Image = ((System.Drawing.Image)(resources.GetObject("Todos.Image")));
            this.Todos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Todos.Name = "Todos";
            this.Todos.Size = new System.Drawing.Size(55, 22);
            this.Todos.Text = "Todo";
            // 
            // TA_categoria
            // 
            this.TA_categoria.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriaTableAdapter = this.TA_categoria;
            this.tableAdapterManager.ProductosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = empresa.ds_empresaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cod_categoriaTextBox
            // 
            this.cod_categoriaTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cod_categoriaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_categoria, "cod_categoria", true));
            this.cod_categoriaTextBox.Font = new System.Drawing.Font("Cascadia Code Light", 9F);
            this.cod_categoriaTextBox.Location = new System.Drawing.Point(104, 82);
            this.cod_categoriaTextBox.MaxLength = 5;
            this.cod_categoriaTextBox.Name = "cod_categoriaTextBox";
            this.cod_categoriaTextBox.Size = new System.Drawing.Size(210, 21);
            this.cod_categoriaTextBox.TabIndex = 4;
            // 
            // nom_categoriaTextBox
            // 
            this.nom_categoriaTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nom_categoriaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_categoria, "nom_categoria", true));
            this.nom_categoriaTextBox.Font = new System.Drawing.Font("Cascadia Code Light", 9F);
            this.nom_categoriaTextBox.Location = new System.Drawing.Point(104, 108);
            this.nom_categoriaTextBox.MaxLength = 50;
            this.nom_categoriaTextBox.Name = "nom_categoriaTextBox";
            this.nom_categoriaTextBox.Size = new System.Drawing.Size(210, 21);
            this.nom_categoriaTextBox.TabIndex = 6;
            // 
            // bog_categoriaComboBox
            // 
            this.bog_categoriaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_categoria, "bog_categoria", true));
            this.bog_categoriaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.BS_categoria, "bog_categoria", true));
            this.bog_categoriaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.BS_categoria, "bog_categoria", true));
            this.bog_categoriaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bog_categoriaComboBox.Font = new System.Drawing.Font("Cascadia Code Light", 9F);
            this.bog_categoriaComboBox.FormattingEnabled = true;
            this.bog_categoriaComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.bog_categoriaComboBox.Location = new System.Drawing.Point(104, 132);
            this.bog_categoriaComboBox.Name = "bog_categoriaComboBox";
            this.bog_categoriaComboBox.Size = new System.Drawing.Size(210, 24);
            this.bog_categoriaComboBox.TabIndex = 8;
            // 
            // ubi_categoriaComboBox
            // 
            this.ubi_categoriaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_categoria, "ubi_categoria", true));
            this.ubi_categoriaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.BS_categoria, "ubi_categoria", true));
            this.ubi_categoriaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.BS_categoria, "ubi_categoria", true));
            this.ubi_categoriaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ubi_categoriaComboBox.Font = new System.Drawing.Font("Cascadia Code Light", 9F);
            this.ubi_categoriaComboBox.FormattingEnabled = true;
            this.ubi_categoriaComboBox.Items.AddRange(new object[] {
            "Sección 1 - Estantería A",
            "Sección 1 - Estantería B",
            "Sección 1 - Estantería C",
            "Sección 2 - Estantería A",
            "Sección 2 - Estantería B",
            "Sección 2 - Estantería C",
            "Sección 3 - Estantería A",
            "Sección 3 - Estantería B",
            "Sección 3 - Estantería C"});
            this.ubi_categoriaComboBox.Location = new System.Drawing.Point(104, 159);
            this.ubi_categoriaComboBox.Name = "ubi_categoriaComboBox";
            this.ubi_categoriaComboBox.Size = new System.Drawing.Size(210, 24);
            this.ubi_categoriaComboBox.TabIndex = 10;
            // 
            // obs_categoriaTextBox
            // 
            this.obs_categoriaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_categoria, "obs_categoria", true));
            this.obs_categoriaTextBox.Font = new System.Drawing.Font("Cascadia Code Light", 9F);
            this.obs_categoriaTextBox.Location = new System.Drawing.Point(104, 186);
            this.obs_categoriaTextBox.MaxLength = 100;
            this.obs_categoriaTextBox.Multiline = true;
            this.obs_categoriaTextBox.Name = "obs_categoriaTextBox";
            this.obs_categoriaTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.obs_categoriaTextBox.Size = new System.Drawing.Size(210, 68);
            this.obs_categoriaTextBox.TabIndex = 12;
            // 
            // Form_categorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(obs_categoriaLabel);
            this.Controls.Add(this.obs_categoriaTextBox);
            this.Controls.Add(ubi_categoriaLabel);
            this.Controls.Add(this.ubi_categoriaComboBox);
            this.Controls.Add(bog_categoriaLabel);
            this.Controls.Add(this.bog_categoriaComboBox);
            this.Controls.Add(nom_categoriaLabel);
            this.Controls.Add(this.nom_categoriaTextBox);
            this.Controls.Add(cod_categoriaLabel);
            this.Controls.Add(this.cod_categoriaTextBox);
            this.Controls.Add(this.TS_empresa);
            this.Controls.Add(this.DGV_empresa);
            this.Controls.Add(this.BN_empresa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_categorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categorías";
            this.Load += new System.EventHandler(this.Form_categorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BN_empresa)).EndInit();
            this.BN_empresa.ResumeLayout(false);
            this.BN_empresa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_empresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_categoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_empresa)).EndInit();
            this.TS_empresa.ResumeLayout(false);
            this.TS_empresa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.ToolStripButton Guardar;
        private System.Windows.Forms.ToolStripButton Cancelar;
        private System.Windows.Forms.ToolStripButton Editar;
        private System.Windows.Forms.ToolStripButton Salir;
        private System.Windows.Forms.DataGridView DGV_empresa;
        private System.Windows.Forms.ToolStrip TS_empresa;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox TxtBuscar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripComboBox CB_categoria;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton Todos;
        private ds_empresa ds_empresa;
        private System.Windows.Forms.BindingSource BS_categoria;
        private ds_empresaTableAdapters.CategoriaTableAdapter TA_categoria;
        private ds_empresaTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox cod_categoriaTextBox;
        private System.Windows.Forms.TextBox nom_categoriaTextBox;
        private System.Windows.Forms.ComboBox bog_categoriaComboBox;
        private System.Windows.Forms.ComboBox ubi_categoriaComboBox;
        private System.Windows.Forms.TextBox obs_categoriaTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn codcategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomcategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bogcategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ubicategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn obscategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripButton Nuevo;
        private System.Windows.Forms.ToolStripButton Eliminar;
    }
}