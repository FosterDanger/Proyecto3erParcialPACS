namespace JRD
{
    partial class frmCompras
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
            this.lookUpEditProveedor = new DevExpress.XtraEditors.LookUpEdit();
            this.proveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lookUpEdit2 = new DevExpress.XtraEditors.LookUpEdit();
            this.libroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtCantidad = new DevExpress.XtraEditors.TextEdit();
            this.txtCostoUnitario = new DevExpress.XtraEditors.TextEdit();
            this.btnAgregarAutor = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnAgregarEditorial = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.btnEliminarFila = new DevExpress.XtraEditors.SimpleButton();
            this.btnEliminarTodo = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.popupMenuLibro = new DevExpress.XtraBars.PopupMenu(this.components);
            this.btnNuevoLibro = new DevExpress.XtraBars.BarButtonItem();
            this.btnModificarLibro = new DevExpress.XtraBars.BarButtonItem();
            this.cmbBuscarPor = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnAgregarProveedor = new DevExpress.XtraBars.BarButtonItem();
            this.btnModificarProveedor = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenuProveedor = new DevExpress.XtraBars.PopupMenu(this.components);
            this.gcCompras = new DevExpress.XtraGrid.GridControl();
            this.gvCompras = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtCodigoCompra = new DevExpress.XtraEditors.TextEdit();
            this.stackPanel1 = new DevExpress.Utils.Layout.StackPanel();
            this.txtTotal = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditProveedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCostoUnitario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuLibro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoCompra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel1)).BeginInit();
            this.stackPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lookUpEditProveedor
            // 
            this.lookUpEditProveedor.Location = new System.Drawing.Point(211, 27);
            this.lookUpEditProveedor.Name = "lookUpEditProveedor";
            this.lookUpEditProveedor.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookUpEditProveedor.Properties.Appearance.Options.UseFont = true;
            this.lookUpEditProveedor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditProveedor.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("idProveedor", "id Proveedor", 103, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombreProveedor", "Proveedor", 145, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombreContacto", "nombre Contacto", 135, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("cargoContacto", "cargo Contacto", 119, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("calle", "calle", 44, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colonia", "colonia", 63, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigoPostal", "codigo Postal", 107, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ciudad", "ciudad", 59, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("telefono", "telefono", 70, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("email", "email", 51, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lookUpEditProveedor.Properties.DataSource = this.proveedorBindingSource;
            this.lookUpEditProveedor.Properties.DisplayMember = "nombreProveedor";
            this.lookUpEditProveedor.Properties.NullText = "Elige un Proveedor";
            this.lookUpEditProveedor.Properties.ValueMember = "idProveedor";
            this.lookUpEditProveedor.Size = new System.Drawing.Size(358, 28);
            this.lookUpEditProveedor.TabIndex = 1;
            // 
            // proveedorBindingSource
            // 
            this.proveedorBindingSource.DataSource = typeof(BML.Proveedor);
            // 
            // lookUpEdit2
            // 
            this.lookUpEdit2.Location = new System.Drawing.Point(211, 120);
            this.lookUpEdit2.Name = "lookUpEdit2";
            this.lookUpEdit2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookUpEdit2.Properties.Appearance.Options.UseFont = true;
            this.lookUpEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit2.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("idLibro", "id Libro", 67, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Libro", 68, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("idAutor", "id Autor", 71, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("idEditorial", "id Editorial", 89, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("idCategoria", "id Categoria", 98, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("precioUnitario", "precio Unitario", 117, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("fechaLanzamiento", "fecha Lanzamiento", 144, DevExpress.Utils.FormatType.DateTime, "dd/MM/yyyy", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ventaPrestamo", "venta Prestamo", 122, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("activo", "activo", 54, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "codigo", 60, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigoLibro", "Codigo", 101, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lookUpEdit2.Properties.DataSource = this.libroBindingSource;
            this.lookUpEdit2.Properties.DisplayMember = "codigoLibro";
            this.lookUpEdit2.Properties.NullText = "Elige un Libro";
            this.lookUpEdit2.Properties.ValueMember = "idLibro";
            this.lookUpEdit2.Size = new System.Drawing.Size(358, 28);
            this.lookUpEdit2.TabIndex = 3;
            // 
            // libroBindingSource
            // 
            this.libroBindingSource.DataSource = typeof(BML.Libro);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(855, 12);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Properties.AdvancedModeOptions.Label = "Cantidad";
            this.txtCantidad.Properties.AdvancedModeOptions.LabelAppearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtCantidad.Properties.AdvancedModeOptions.LabelAppearance.Options.UseFont = true;
            this.txtCantidad.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCantidad.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.txtCantidad.Properties.MaskSettings.Set("MaskManagerSignature", "isOptimistic=False");
            this.txtCantidad.Properties.MaskSettings.Set("mask", "\\d+");
            this.txtCantidad.Properties.MaxLength = 3;
            this.txtCantidad.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            this.txtCantidad.Size = new System.Drawing.Size(365, 49);
            this.txtCantidad.TabIndex = 5;
            // 
            // txtCostoUnitario
            // 
            this.txtCostoUnitario.Location = new System.Drawing.Point(855, 109);
            this.txtCostoUnitario.Name = "txtCostoUnitario";
            this.txtCostoUnitario.Properties.AdvancedModeOptions.Label = "Costo Unitario";
            this.txtCostoUnitario.Properties.AdvancedModeOptions.LabelAppearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtCostoUnitario.Properties.AdvancedModeOptions.LabelAppearance.Options.UseFont = true;
            this.txtCostoUnitario.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCostoUnitario.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtCostoUnitario.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtCostoUnitario.Properties.MaskSettings.Set("mask", "c");
            this.txtCostoUnitario.Properties.MaxLength = 8;
            this.txtCostoUnitario.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            this.txtCostoUnitario.Size = new System.Drawing.Size(365, 49);
            this.txtCostoUnitario.TabIndex = 6;
            // 
            // btnAgregarAutor
            // 
            this.btnAgregarAutor.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(146)))), ((int)(((byte)(139)))));
            this.btnAgregarAutor.Appearance.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.btnAgregarAutor.Appearance.Options.UseBackColor = true;
            this.btnAgregarAutor.Appearance.Options.UseFont = true;
            this.btnAgregarAutor.Location = new System.Drawing.Point(600, 15);
            this.btnAgregarAutor.Name = "btnAgregarAutor";
            this.btnAgregarAutor.Size = new System.Drawing.Size(51, 51);
            this.btnAgregarAutor.TabIndex = 2;
            this.btnAgregarAutor.Text = "+";
            this.btnAgregarAutor.Click += new System.EventHandler(this.btnAgregarAutor_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(146)))), ((int)(((byte)(139)))));
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Location = new System.Drawing.Point(600, 108);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(51, 51);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "+";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnAgregarEditorial
            // 
            this.btnAgregarEditorial.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(146)))), ((int)(((byte)(139)))));
            this.btnAgregarEditorial.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnAgregarEditorial.Appearance.Options.UseBackColor = true;
            this.btnAgregarEditorial.Appearance.Options.UseFont = true;
            this.btnAgregarEditorial.ImageOptions.Image = global::JRD.Properties.Resources.Add1;
            this.btnAgregarEditorial.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnAgregarEditorial.ImageOptions.ImageToTextIndent = 12;
            this.btnAgregarEditorial.Location = new System.Drawing.Point(15, 9);
            this.btnAgregarEditorial.Margin = new System.Windows.Forms.Padding(3, 3, 85, 3);
            this.btnAgregarEditorial.Name = "btnAgregarEditorial";
            this.btnAgregarEditorial.Size = new System.Drawing.Size(174, 53);
            this.btnAgregarEditorial.TabIndex = 8;
            this.btnAgregarEditorial.Text = "Agregar";
            this.btnAgregarEditorial.Click += new System.EventHandler(this.btnAgregarEditorial_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(146)))), ((int)(((byte)(139)))));
            this.btnGuardar.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.Appearance.Options.UseBackColor = true;
            this.btnGuardar.Appearance.Options.UseFont = true;
            this.btnGuardar.ImageOptions.Image = global::JRD.Properties.Resources.save;
            this.btnGuardar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnGuardar.ImageOptions.ImageToTextIndent = 12;
            this.btnGuardar.Location = new System.Drawing.Point(277, 9);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 3, 85, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(223, 53);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar Compra";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminarFila
            // 
            this.btnEliminarFila.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.btnEliminarFila.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnEliminarFila.Appearance.Options.UseBackColor = true;
            this.btnEliminarFila.Appearance.Options.UseFont = true;
            this.btnEliminarFila.ImageOptions.Image = global::JRD.Properties.Resources.Delete_One;
            this.btnEliminarFila.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnEliminarFila.ImageOptions.ImageToTextIndent = 12;
            this.btnEliminarFila.Location = new System.Drawing.Point(588, 9);
            this.btnEliminarFila.Margin = new System.Windows.Forms.Padding(3, 3, 85, 3);
            this.btnEliminarFila.Name = "btnEliminarFila";
            this.btnEliminarFila.Size = new System.Drawing.Size(179, 53);
            this.btnEliminarFila.TabIndex = 10;
            this.btnEliminarFila.Text = "Eliminar Fila";
            this.btnEliminarFila.Click += new System.EventHandler(this.btnEliminarFila_Click);
            // 
            // btnEliminarTodo
            // 
            this.btnEliminarTodo.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.btnEliminarTodo.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnEliminarTodo.Appearance.Options.UseBackColor = true;
            this.btnEliminarTodo.Appearance.Options.UseFont = true;
            this.btnEliminarTodo.ImageOptions.Image = global::JRD.Properties.Resources.Delete_All2;
            this.btnEliminarTodo.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnEliminarTodo.ImageOptions.ImageToTextIndent = 12;
            this.btnEliminarTodo.Location = new System.Drawing.Point(855, 9);
            this.btnEliminarTodo.Name = "btnEliminarTodo";
            this.btnEliminarTodo.Size = new System.Drawing.Size(198, 53);
            this.btnEliminarTodo.TabIndex = 11;
            this.btnEliminarTodo.Text = "Eliminar Todo";
            this.btnEliminarTodo.Click += new System.EventHandler(this.btnEliminarTodo_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(1092, 614);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(70, 29);
            this.labelControl1.TabIndex = 18;
            this.labelControl1.Text = "Total:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(61, 616);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(228, 29);
            this.labelControl2.TabIndex = 19;
            this.labelControl2.Text = "Codigo de Compra:";
            // 
            // popupMenuLibro
            // 
            this.popupMenuLibro.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnNuevoLibro),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnModificarLibro),
            new DevExpress.XtraBars.LinkPersistInfo(this.cmbBuscarPor)});
            this.popupMenuLibro.Manager = this.barManager1;
            this.popupMenuLibro.Name = "popupMenuLibro";
            // 
            // btnNuevoLibro
            // 
            this.btnNuevoLibro.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.btnNuevoLibro.Caption = "Agregar nuevo libro";
            this.btnNuevoLibro.Id = 1;
            this.btnNuevoLibro.Name = "btnNuevoLibro";
            this.btnNuevoLibro.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNuevoLibro_ItemClick);
            // 
            // btnModificarLibro
            // 
            this.btnModificarLibro.Caption = "Modificar Libro";
            this.btnModificarLibro.Id = 4;
            this.btnModificarLibro.Name = "btnModificarLibro";
            this.btnModificarLibro.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnModificarLibro_ItemClick);
            // 
            // cmbBuscarPor
            // 
            this.cmbBuscarPor.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.cmbBuscarPor.AutoFillWidth = true;
            this.cmbBuscarPor.AutoFillWidthInMenu = DevExpress.Utils.DefaultBoolean.True;
            this.cmbBuscarPor.Caption = "Buscar por:";
            this.cmbBuscarPor.Edit = this.repositoryItemComboBox1;
            this.cmbBuscarPor.EditWidth = 80;
            this.cmbBuscarPor.Id = 0;
            this.cmbBuscarPor.MaxWidth = 80;
            this.cmbBuscarPor.Name = "cmbBuscarPor";
            this.cmbBuscarPor.Size = new System.Drawing.Size(80, 0);
            this.cmbBuscarPor.EditValueChanged += new System.EventHandler(this.cmbBuscarPor_EditValueChanged);
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Items.AddRange(new object[] {
            "Codigo",
            "Libro"});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            this.repositoryItemComboBox1.NullText = "Codigo";
            this.repositoryItemComboBox1.Sorted = true;
            this.repositoryItemComboBox1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.cmbBuscarPor,
            this.btnNuevoLibro,
            this.btnAgregarProveedor,
            this.btnModificarProveedor,
            this.btnModificarLibro});
            this.barManager1.MaxItemId = 5;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1});
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1458, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 670);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1458, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 670);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1458, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 670);
            // 
            // btnAgregarProveedor
            // 
            this.btnAgregarProveedor.Caption = "Agregar nuevo Proveedor";
            this.btnAgregarProveedor.Id = 2;
            this.btnAgregarProveedor.Name = "btnAgregarProveedor";
            this.btnAgregarProveedor.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAgregarProveedor_ItemClick);
            // 
            // btnModificarProveedor
            // 
            this.btnModificarProveedor.Caption = "Modificar Proveedor";
            this.btnModificarProveedor.Id = 3;
            this.btnModificarProveedor.Name = "btnModificarProveedor";
            this.btnModificarProveedor.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnModificarProveedor_ItemClick);
            // 
            // popupMenuProveedor
            // 
            this.popupMenuProveedor.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAgregarProveedor),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnModificarProveedor)});
            this.popupMenuProveedor.Manager = this.barManager1;
            this.popupMenuProveedor.Name = "popupMenuProveedor";
            // 
            // gcCompras
            // 
            this.gcCompras.EmbeddedNavigator.Buttons.Append.Enabled = false;
            this.gcCompras.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcCompras.EmbeddedNavigator.Buttons.CancelEdit.Enabled = false;
            this.gcCompras.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcCompras.EmbeddedNavigator.Buttons.Edit.Enabled = false;
            this.gcCompras.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcCompras.EmbeddedNavigator.Buttons.EndEdit.Enabled = false;
            this.gcCompras.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcCompras.EmbeddedNavigator.Buttons.Remove.Enabled = false;
            this.gcCompras.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcCompras.Location = new System.Drawing.Point(44, 285);
            this.gcCompras.MainView = this.gvCompras;
            this.gcCompras.MenuManager = this.barManager1;
            this.gcCompras.Name = "gcCompras";
            this.gcCompras.Size = new System.Drawing.Size(1369, 295);
            this.gcCompras.TabIndex = 12;
            this.gcCompras.UseEmbeddedNavigator = true;
            this.gcCompras.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCompras});
            // 
            // gvCompras
            // 
            this.gvCompras.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvCompras.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvCompras.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvCompras.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvCompras.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gvCompras.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvCompras.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9F);
            this.gvCompras.Appearance.Row.Options.UseFont = true;
            this.gvCompras.GridControl = this.gcCompras;
            this.gvCompras.Name = "gvCompras";
            this.gvCompras.OptionsBehavior.Editable = false;
            this.gvCompras.OptionsCustomization.AllowColumnMoving = false;
            this.gvCompras.OptionsCustomization.AllowFilter = false;
            this.gvCompras.OptionsCustomization.AllowSort = false;
            this.gvCompras.OptionsView.ColumnAutoWidth = false;
            this.gvCompras.OptionsView.ShowAutoFilterRow = true;
            this.gvCompras.OptionsView.ShowGroupPanel = false;
            // 
            // txtCodigoCompra
            // 
            this.txtCodigoCompra.Enabled = false;
            this.txtCodigoCompra.Location = new System.Drawing.Point(300, 614);
            this.txtCodigoCompra.MenuManager = this.barManager1;
            this.txtCodigoCompra.Name = "txtCodigoCompra";
            this.txtCodigoCompra.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoCompra.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtCodigoCompra.Properties.Appearance.Options.UseFont = true;
            this.txtCodigoCompra.Properties.Appearance.Options.UseForeColor = true;
            this.txtCodigoCompra.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtCodigoCompra.Properties.ReadOnly = true;
            this.txtCodigoCompra.Size = new System.Drawing.Size(199, 34);
            this.txtCodigoCompra.TabIndex = 13;
            // 
            // stackPanel1
            // 
            this.stackPanel1.Controls.Add(this.btnAgregarEditorial);
            this.stackPanel1.Controls.Add(this.btnGuardar);
            this.stackPanel1.Controls.Add(this.btnEliminarFila);
            this.stackPanel1.Controls.Add(this.btnEliminarTodo);
            this.stackPanel1.Location = new System.Drawing.Point(190, 189);
            this.stackPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.stackPanel1.Name = "stackPanel1";
            this.stackPanel1.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.stackPanel1.Size = new System.Drawing.Size(1049, 72);
            this.stackPanel1.TabIndex = 7;
            this.stackPanel1.TabStop = true;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(1174, 612);
            this.txtTotal.MenuManager = this.barManager1;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtTotal.Properties.Appearance.Options.UseFont = true;
            this.txtTotal.Properties.Appearance.Options.UseForeColor = true;
            this.txtTotal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtTotal.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtTotal.Properties.MaskSettings.Set("mask", "c");
            this.txtTotal.Properties.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(228, 34);
            this.txtTotal.TabIndex = 14;
            // 
            // frmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1458, 670);
            this.Controls.Add(this.stackPanel1);
            this.Controls.Add(this.txtCodigoCompra);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.gcCompras);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btnAgregarAutor);
            this.Controls.Add(this.txtCostoUnitario);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lookUpEdit2);
            this.Controls.Add(this.lookUpEditProveedor);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmCompras";
            this.Text = "Nueva Compra";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCompras_FormClosing);
            this.Load += new System.EventHandler(this.frmCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditProveedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCostoUnitario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuLibro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoCompra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel1)).EndInit();
            this.stackPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit lookUpEditProveedor;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit2;
        private DevExpress.XtraEditors.TextEdit txtCantidad;
        private DevExpress.XtraEditors.TextEdit txtCostoUnitario;
        private DevExpress.XtraEditors.SimpleButton btnAgregarAutor;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnAgregarEditorial;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private DevExpress.XtraEditors.SimpleButton btnEliminarFila;
        private DevExpress.XtraEditors.SimpleButton btnEliminarTodo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.BindingSource proveedorBindingSource;
        private System.Windows.Forms.BindingSource libroBindingSource;
        private DevExpress.XtraBars.PopupMenu popupMenuLibro;
        private DevExpress.XtraBars.BarButtonItem btnNuevoLibro;
        private DevExpress.XtraBars.BarEditItem cmbBuscarPor;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnAgregarProveedor;
        private DevExpress.XtraBars.BarButtonItem btnModificarProveedor;
        private DevExpress.XtraBars.PopupMenu popupMenuProveedor;
        private DevExpress.XtraBars.BarButtonItem btnModificarLibro;
        private DevExpress.XtraGrid.GridControl gcCompras;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCompras;
        private DevExpress.XtraEditors.TextEdit txtCodigoCompra;
        private DevExpress.Utils.Layout.StackPanel stackPanel1;
        private DevExpress.XtraEditors.TextEdit txtTotal;
    }
}