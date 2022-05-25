namespace JRD
{
    partial class frmNVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNVenta));
            this.spinEdit1 = new DevExpress.XtraEditors.SpinEdit();
            this.gcVentas = new DevExpress.XtraGrid.GridControl();
            this.gvVenta = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtCodigoVenta = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtSubTotal = new DevExpress.XtraEditors.TextEdit();
            this.txtDecuento = new DevExpress.XtraEditors.TextEdit();
            this.txtTotal = new DevExpress.XtraEditors.TextEdit();
            this.txtUsuario = new DevExpress.XtraEditors.TextEdit();
            this.lookUpLibro = new DevExpress.XtraEditors.LookUpEdit();
            this.libroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtPrecio = new DevExpress.XtraEditors.TextEdit();
            this.stackPanel1 = new DevExpress.Utils.Layout.StackPanel();
            this.btnAgregarEditorial = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.btnEliminarFila = new DevExpress.XtraEditors.SimpleButton();
            this.btnEliminarTodo = new DevExpress.XtraEditors.SimpleButton();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.cmbImpresora = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.cmbImprimir = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.cmbImpresoras = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.cmbBuscarPor = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemComboBox3 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.popupMenuLibro = new DevExpress.XtraBars.PopupMenu(this.components);
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtEfectivo = new DevExpress.XtraEditors.TextEdit();
            this.txtCambio = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoVenta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDecuento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpLibro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel1)).BeginInit();
            this.stackPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuLibro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEfectivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCambio.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // spinEdit1
            // 
            this.spinEdit1.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinEdit1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.spinEdit1.Location = new System.Drawing.Point(699, 140);
            this.spinEdit1.Name = "spinEdit1";
            this.spinEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.spinEdit1.Properties.Appearance.Options.UseFont = true;
            this.spinEdit1.Properties.BeepOnError = true;
            this.spinEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinEdit1.Properties.HideSelection = false;
            this.spinEdit1.Properties.IsFloatValue = false;
            this.spinEdit1.Properties.MaskSettings.Set("mask", "d");
            this.spinEdit1.Properties.MaxValue = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.spinEdit1.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinEdit1.Properties.UseReadOnlyAppearance = false;
            this.spinEdit1.Size = new System.Drawing.Size(128, 34);
            this.spinEdit1.TabIndex = 3;
            this.spinEdit1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.spinEdit1_KeyDown);
            // 
            // gcVentas
            // 
            this.gcVentas.EmbeddedNavigator.Buttons.Append.Enabled = false;
            this.gcVentas.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcVentas.EmbeddedNavigator.Buttons.CancelEdit.Enabled = false;
            this.gcVentas.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcVentas.EmbeddedNavigator.Buttons.Edit.Enabled = false;
            this.gcVentas.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcVentas.EmbeddedNavigator.Buttons.EndEdit.Enabled = false;
            this.gcVentas.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcVentas.EmbeddedNavigator.Buttons.Remove.Enabled = false;
            this.gcVentas.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcVentas.Location = new System.Drawing.Point(38, 299);
            this.gcVentas.MainView = this.gvVenta;
            this.gcVentas.Name = "gcVentas";
            this.gcVentas.Size = new System.Drawing.Size(1379, 277);
            this.gcVentas.TabIndex = 0;
            this.gcVentas.TabStop = false;
            this.gcVentas.UseEmbeddedNavigator = true;
            this.gcVentas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvVenta});
            // 
            // gvVenta
            // 
            this.gvVenta.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvVenta.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvVenta.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvVenta.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvVenta.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gvVenta.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvVenta.GridControl = this.gcVentas;
            this.gvVenta.Name = "gvVenta";
            this.gvVenta.OptionsBehavior.Editable = false;
            this.gvVenta.OptionsCustomization.AllowColumnMoving = false;
            this.gvVenta.OptionsCustomization.AllowFilter = false;
            this.gvVenta.OptionsCustomization.AllowGroup = false;
            this.gvVenta.OptionsCustomization.AllowSort = false;
            this.gvVenta.OptionsView.ShowAutoFilterRow = true;
            this.gvVenta.OptionsView.ShowGroupPanel = false;
            // 
            // txtCodigoVenta
            // 
            this.txtCodigoVenta.Enabled = false;
            this.txtCodigoVenta.Location = new System.Drawing.Point(79, 47);
            this.txtCodigoVenta.Name = "txtCodigoVenta";
            this.txtCodigoVenta.Properties.AdvancedModeOptions.Label = "Codigo de Venta";
            this.txtCodigoVenta.Properties.AdvancedModeOptions.LabelAppearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtCodigoVenta.Properties.AdvancedModeOptions.LabelAppearance.Options.UseFont = true;
            this.txtCodigoVenta.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoVenta.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.txtCodigoVenta.Properties.MaskSettings.Set("MaskManagerSignature", "isOptimistic=False");
            this.txtCodigoVenta.Properties.MaskSettings.Set("mask", "\\d+");
            this.txtCodigoVenta.Properties.MaxLength = 3;
            this.txtCodigoVenta.Properties.ReadOnly = true;
            this.txtCodigoVenta.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            this.txtCodigoVenta.Size = new System.Drawing.Size(298, 49);
            this.txtCodigoVenta.TabIndex = 6;
            this.txtCodigoVenta.TabStop = false;
            this.txtCodigoVenta.EditValueChanged += new System.EventHandler(this.txtCodigoVenta_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(231, 611);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(96, 29);
            this.labelControl1.TabIndex = 19;
            this.labelControl1.Text = "Totales:";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Enabled = false;
            this.txtSubTotal.Location = new System.Drawing.Point(339, 597);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Properties.AdvancedModeOptions.Label = "Subtotal";
            this.txtSubTotal.Properties.AdvancedModeOptions.LabelAppearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtSubTotal.Properties.AdvancedModeOptions.LabelAppearance.Options.UseFont = true;
            this.txtSubTotal.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubTotal.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtSubTotal.Properties.Appearance.Options.UseFont = true;
            this.txtSubTotal.Properties.Appearance.Options.UseForeColor = true;
            this.txtSubTotal.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSubTotal.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtSubTotal.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtSubTotal.Properties.MaskSettings.Set("mask", "c");
            this.txtSubTotal.Properties.MaxLength = 8;
            this.txtSubTotal.Properties.ReadOnly = true;
            this.txtSubTotal.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            this.txtSubTotal.Size = new System.Drawing.Size(234, 49);
            this.txtSubTotal.TabIndex = 21;
            this.txtSubTotal.TabStop = false;
            this.txtSubTotal.EditValueChanged += new System.EventHandler(this.txtCostoUnitario_EditValueChanged);
            // 
            // txtDecuento
            // 
            this.txtDecuento.Enabled = false;
            this.txtDecuento.Location = new System.Drawing.Point(597, 597);
            this.txtDecuento.Name = "txtDecuento";
            this.txtDecuento.Properties.AdvancedModeOptions.Label = "Descuento";
            this.txtDecuento.Properties.AdvancedModeOptions.LabelAppearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtDecuento.Properties.AdvancedModeOptions.LabelAppearance.Options.UseFont = true;
            this.txtDecuento.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDecuento.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtDecuento.Properties.Appearance.Options.UseFont = true;
            this.txtDecuento.Properties.Appearance.Options.UseForeColor = true;
            this.txtDecuento.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDecuento.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtDecuento.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtDecuento.Properties.MaskSettings.Set("mask", "c");
            this.txtDecuento.Properties.MaxLength = 8;
            this.txtDecuento.Properties.ReadOnly = true;
            this.txtDecuento.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            this.txtDecuento.Size = new System.Drawing.Size(234, 49);
            this.txtDecuento.TabIndex = 22;
            this.txtDecuento.TabStop = false;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(856, 597);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Properties.AdvancedModeOptions.Label = "Total";
            this.txtTotal.Properties.AdvancedModeOptions.LabelAppearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtTotal.Properties.AdvancedModeOptions.LabelAppearance.Options.UseFont = true;
            this.txtTotal.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtTotal.Properties.Appearance.Options.UseFont = true;
            this.txtTotal.Properties.Appearance.Options.UseForeColor = true;
            this.txtTotal.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTotal.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtTotal.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtTotal.Properties.MaskSettings.Set("mask", "c");
            this.txtTotal.Properties.MaxLength = 8;
            this.txtTotal.Properties.ReadOnly = true;
            this.txtTotal.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            this.txtTotal.Size = new System.Drawing.Size(234, 49);
            this.txtTotal.TabIndex = 23;
            this.txtTotal.TabStop = false;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Location = new System.Drawing.Point(436, 47);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Properties.AdvancedModeOptions.Label = "Usuario";
            this.txtUsuario.Properties.AdvancedModeOptions.LabelAppearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtUsuario.Properties.AdvancedModeOptions.LabelAppearance.Options.UseFont = true;
            this.txtUsuario.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUsuario.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.txtUsuario.Properties.MaskSettings.Set("MaskManagerSignature", "isOptimistic=False");
            this.txtUsuario.Properties.MaskSettings.Set("mask", "\\d+");
            this.txtUsuario.Properties.MaxLength = 3;
            this.txtUsuario.Properties.ReadOnly = true;
            this.txtUsuario.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            this.txtUsuario.Size = new System.Drawing.Size(440, 49);
            this.txtUsuario.TabIndex = 24;
            this.txtUsuario.TabStop = false;
            // 
            // lookUpLibro
            // 
            this.lookUpLibro.Location = new System.Drawing.Point(938, 56);
            this.lookUpLibro.Name = "lookUpLibro";
            this.lookUpLibro.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookUpLibro.Properties.Appearance.Options.UseFont = true;
            this.lookUpLibro.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpLibro.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
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
            this.lookUpLibro.Properties.DataSource = this.libroBindingSource;
            this.lookUpLibro.Properties.DisplayMember = "codigoLibro";
            this.lookUpLibro.Properties.NullText = "Elige un Libro";
            this.lookUpLibro.Properties.ValueMember = "idLibro";
            this.lookUpLibro.Size = new System.Drawing.Size(358, 28);
            this.lookUpLibro.TabIndex = 1;
            this.lookUpLibro.EditValueChanged += new System.EventHandler(this.lookUpLibro_EditValueChanged);
            this.lookUpLibro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lookUpLibro_KeyDown_1);
            // 
            // libroBindingSource
            // 
            this.libroBindingSource.DataSource = typeof(BML.Libro);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Location = new System.Drawing.Point(155, 134);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Properties.AdvancedModeOptions.Label = "Precio";
            this.txtPrecio.Properties.AdvancedModeOptions.LabelAppearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtPrecio.Properties.AdvancedModeOptions.LabelAppearance.Options.UseFont = true;
            this.txtPrecio.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtPrecio.Properties.Appearance.Options.UseFont = true;
            this.txtPrecio.Properties.Appearance.Options.UseForeColor = true;
            this.txtPrecio.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPrecio.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtPrecio.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtPrecio.Properties.MaskSettings.Set("mask", "c");
            this.txtPrecio.Properties.MaxLength = 8;
            this.txtPrecio.Properties.ReadOnly = true;
            this.txtPrecio.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            this.txtPrecio.Size = new System.Drawing.Size(365, 49);
            this.txtPrecio.TabIndex = 27;
            this.txtPrecio.TabStop = false;
            // 
            // stackPanel1
            // 
            this.stackPanel1.Controls.Add(this.btnAgregarEditorial);
            this.stackPanel1.Controls.Add(this.btnGuardar);
            this.stackPanel1.Controls.Add(this.btnEliminarFila);
            this.stackPanel1.Controls.Add(this.btnEliminarTodo);
            this.stackPanel1.Location = new System.Drawing.Point(183, 209);
            this.stackPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.stackPanel1.Name = "stackPanel1";
            this.stackPanel1.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.stackPanel1.Size = new System.Drawing.Size(1049, 72);
            this.stackPanel1.TabIndex = 28;
            this.stackPanel1.TabStop = true;
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
            this.btnGuardar.Text = "Guardar Venta";
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
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barSubItem1,
            this.cmbImpresora,
            this.cmbImpresoras,
            this.cmbImprimir,
            this.cmbBuscarPor});
            this.barManager1.MaxItemId = 6;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1,
            this.repositoryItemLookUpEdit1,
            this.repositoryItemComboBox2,
            this.repositoryItemComboBox3});
            this.barManager1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barManager1_ItemClick);
            // 
            // bar1
            // 
            this.bar1.BarName = "Herramientas";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barSubItem1, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.OptionsBar.DrawBorder = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.Text = "Herramientas";
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "Opciones de Impresion";
            this.barSubItem1.Id = 1;
            this.barSubItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barSubItem1.ImageOptions.SvgImage")));
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.cmbImpresora),
            new DevExpress.XtraBars.LinkPersistInfo(this.cmbImprimir)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // cmbImpresora
            // 
            this.cmbImpresora.Caption = "Elige una impresora";
            this.cmbImpresora.Edit = this.repositoryItemComboBox1;
            this.cmbImpresora.EditWidth = 120;
            this.cmbImpresora.Id = 2;
            this.cmbImpresora.MaxWidth = 120;
            this.cmbImpresora.Name = "cmbImpresora";
            this.cmbImpresora.Size = new System.Drawing.Size(120, 0);
            this.cmbImpresora.EditValueChanged += new System.EventHandler(this.cmbImpresora_EditValueChanged);
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            this.repositoryItemComboBox1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // cmbImprimir
            // 
            this.cmbImprimir.Caption = "Elige una opcion";
            this.cmbImprimir.Edit = this.repositoryItemComboBox2;
            this.cmbImprimir.Id = 4;
            this.cmbImprimir.Name = "cmbImprimir";
            // 
            // repositoryItemComboBox2
            // 
            this.repositoryItemComboBox2.AutoHeight = false;
            this.repositoryItemComboBox2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox2.Items.AddRange(new object[] {
            "IMPRIMIR TICKET",
            "NO IMPRIMIR TICKET"});
            this.repositoryItemComboBox2.Name = "repositoryItemComboBox2";
            this.repositoryItemComboBox2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1458, 34);
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
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 34);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 636);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1458, 34);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 636);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Opciones de Impresion";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // cmbImpresoras
            // 
            this.cmbImpresoras.Caption = "barEditItem1";
            this.cmbImpresoras.Edit = this.repositoryItemLookUpEdit1;
            this.cmbImpresoras.EditWidth = 90;
            this.cmbImpresoras.Id = 3;
            this.cmbImpresoras.MaxWidth = 90;
            this.cmbImpresoras.Name = "cmbImpresoras";
            this.cmbImpresoras.Size = new System.Drawing.Size(90, 0);
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            // 
            // cmbBuscarPor
            // 
            this.cmbBuscarPor.Caption = "Buscar Por";
            this.cmbBuscarPor.Edit = this.repositoryItemComboBox3;
            this.cmbBuscarPor.EditWidth = 80;
            this.cmbBuscarPor.Id = 5;
            this.cmbBuscarPor.MaxWidth = 80;
            this.cmbBuscarPor.Name = "cmbBuscarPor";
            this.cmbBuscarPor.Size = new System.Drawing.Size(80, 0);
            this.cmbBuscarPor.EditValueChanged += new System.EventHandler(this.cmbBuscarPor_EditValueChanged);
            // 
            // repositoryItemComboBox3
            // 
            this.repositoryItemComboBox3.AutoHeight = false;
            this.repositoryItemComboBox3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox3.Items.AddRange(new object[] {
            "Codigo",
            "Libro"});
            this.repositoryItemComboBox3.Name = "repositoryItemComboBox3";
            this.repositoryItemComboBox3.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(146)))), ((int)(((byte)(139)))));
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Location = new System.Drawing.Point(1327, 45);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(51, 51);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "+";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // popupMenuLibro
            // 
            this.popupMenuLibro.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.cmbBuscarPor)});
            this.popupMenuLibro.Manager = this.barManager1;
            this.popupMenuLibro.Name = "popupMenuLibro";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(596, 147);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(87, 22);
            this.labelControl2.TabIndex = 39;
            this.labelControl2.Text = "Cantidad:";
            // 
            // txtEfectivo
            // 
            this.txtEfectivo.Enabled = false;
            this.txtEfectivo.Location = new System.Drawing.Point(925, 133);
            this.txtEfectivo.Name = "txtEfectivo";
            this.txtEfectivo.Properties.AdvancedModeOptions.Label = "Efectivo";
            this.txtEfectivo.Properties.AdvancedModeOptions.LabelAppearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtEfectivo.Properties.AdvancedModeOptions.LabelAppearance.Options.UseFont = true;
            this.txtEfectivo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEfectivo.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtEfectivo.Properties.MaskSettings.Set("mask", "d");
            this.txtEfectivo.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            this.txtEfectivo.Properties.UseMaskAsDisplayFormat = true;
            this.txtEfectivo.Size = new System.Drawing.Size(351, 49);
            this.txtEfectivo.TabIndex = 44;
            this.txtEfectivo.TabStop = false;
            this.txtEfectivo.EditValueChanged += new System.EventHandler(this.txtEfectivo_EditValueChanged);
            this.txtEfectivo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEfectivo_KeyPress);
            this.txtEfectivo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtEfectivo_KeyUp);
            // 
            // txtCambio
            // 
            this.txtCambio.Enabled = false;
            this.txtCambio.Location = new System.Drawing.Point(1116, 597);
            this.txtCambio.Name = "txtCambio";
            this.txtCambio.Properties.AdvancedModeOptions.Label = "Cambio";
            this.txtCambio.Properties.AdvancedModeOptions.LabelAppearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtCambio.Properties.AdvancedModeOptions.LabelAppearance.Options.UseFont = true;
            this.txtCambio.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCambio.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtCambio.Properties.Appearance.Options.UseFont = true;
            this.txtCambio.Properties.Appearance.Options.UseForeColor = true;
            this.txtCambio.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCambio.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtCambio.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtCambio.Properties.MaskSettings.Set("mask", "c");
            this.txtCambio.Properties.MaxLength = 8;
            this.txtCambio.Properties.ReadOnly = true;
            this.txtCambio.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            this.txtCambio.Size = new System.Drawing.Size(234, 49);
            this.txtCambio.TabIndex = 45;
            this.txtCambio.TabStop = false;
            // 
            // frmNVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1458, 670);
            this.Controls.Add(this.txtCambio);
            this.Controls.Add(this.txtEfectivo);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.spinEdit1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.stackPanel1);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lookUpLibro);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtDecuento);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtCodigoVenta);
            this.Controls.Add(this.gcVentas);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.KeyPreview = true;
            this.Name = "frmNVenta";
            this.Text = "Nueva Venta";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmNVenta_FormClosing);
            this.Load += new System.EventHandler(this.frmNVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoVenta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDecuento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpLibro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel1)).EndInit();
            this.stackPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuLibro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEfectivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCambio.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcVentas;
        private DevExpress.XtraGrid.Views.Grid.GridView gvVenta;
        private DevExpress.XtraEditors.TextEdit txtCodigoVenta;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtSubTotal;
        private DevExpress.XtraEditors.TextEdit txtDecuento;
        private DevExpress.XtraEditors.TextEdit txtTotal;
        private DevExpress.XtraEditors.TextEdit txtUsuario;
        private DevExpress.XtraEditors.LookUpEdit lookUpLibro;
        private DevExpress.XtraEditors.TextEdit txtPrecio;
        private DevExpress.Utils.Layout.StackPanel stackPanel1;
        private DevExpress.XtraEditors.SimpleButton btnAgregarEditorial;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private DevExpress.XtraEditors.SimpleButton btnEliminarFila;
        private DevExpress.XtraEditors.SimpleButton btnEliminarTodo;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarEditItem cmbImpresora;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraBars.BarEditItem cmbImpresoras;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraBars.BarEditItem cmbImprimir;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox2;
        private System.Windows.Forms.BindingSource libroBindingSource;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraBars.BarEditItem cmbBuscarPor;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox3;
        private DevExpress.XtraBars.PopupMenu popupMenuLibro;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SpinEdit spinEdit1;
        private DevExpress.XtraEditors.TextEdit txtCambio;
        private DevExpress.XtraEditors.TextEdit txtEfectivo;
    }
}