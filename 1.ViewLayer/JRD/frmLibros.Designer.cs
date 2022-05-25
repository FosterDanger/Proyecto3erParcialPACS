namespace JRD
{
    partial class frmLibros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLibros));
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnAgregar = new DevExpress.XtraBars.BarButtonItem();
            this.btnEditar = new DevExpress.XtraBars.BarButtonItem();
            this.btnEliminar = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.libroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.editorialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gcLibros = new DevExpress.XtraGrid.GridControl();
            this.gvLibros = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidLibro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Inventario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ruleInventario = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.inventarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colidAutor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ruleAutor = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colidEditorial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ruleEditorial = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colidCategoria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ruleCategoria = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colprecioUnitario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfechaLanzamiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colventaPrestamo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colactivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigoLibro = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editorialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLibros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLibros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ruleInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ruleAutor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ruleEditorial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ruleCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 34);
            this.barDockControlTop.Manager = null;
            this.barDockControlTop.Size = new System.Drawing.Size(881, 0);
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 34);
            this.barDockControl1.Manager = null;
            this.barDockControl1.Size = new System.Drawing.Size(881, 0);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControl2);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barSubItem1,
            this.btnAgregar,
            this.btnEditar,
            this.btnEliminar});
            this.barManager1.MaxItemId = 4;
            // 
            // bar1
            // 
            this.bar1.BarName = "Herramientas";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnAgregar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnEditar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnEliminar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.OptionsBar.DrawBorder = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.Text = "Herramientas";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Caption = "Agregar";
            this.btnAgregar.Id = 1;
            this.btnAgregar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAgregar.ImageOptions.SvgImage")));
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAgregar_ItemClick);
            // 
            // btnEditar
            // 
            this.btnEditar.Caption = "Editar";
            this.btnEditar.Id = 2;
            this.btnEditar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnEditar.ImageOptions.SvgImage")));
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEditar_ItemClick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Caption = "Eliminar";
            this.btnEliminar.Id = 3;
            this.btnEliminar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnEliminar.ImageOptions.SvgImage")));
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEliminar_ItemClick);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl2.Location = new System.Drawing.Point(0, 0);
            this.barDockControl2.Manager = this.barManager1;
            this.barDockControl2.Size = new System.Drawing.Size(881, 34);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 524);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(881, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 34);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 490);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(881, 34);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 490);
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "barSubItem1";
            this.barSubItem1.Id = 0;
            this.barSubItem1.Name = "barSubItem1";
            // 
            // libroBindingSource
            // 
            this.libroBindingSource.DataSource = typeof(BML.Libro);
            // 
            // autorBindingSource
            // 
            this.autorBindingSource.DataSource = typeof(BML.Autor);
            // 
            // editorialBindingSource
            // 
            this.editorialBindingSource.DataSource = typeof(BML.Editorial);
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataSource = typeof(BML.Categoria);
            // 
            // gcLibros
            // 
            this.gcLibros.DataSource = this.libroBindingSource;
            this.gcLibros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcLibros.EmbeddedNavigator.Buttons.Append.Enabled = false;
            this.gcLibros.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcLibros.EmbeddedNavigator.Buttons.CancelEdit.Enabled = false;
            this.gcLibros.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcLibros.EmbeddedNavigator.Buttons.Edit.Enabled = false;
            this.gcLibros.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcLibros.EmbeddedNavigator.Buttons.EndEdit.Enabled = false;
            this.gcLibros.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcLibros.EmbeddedNavigator.Buttons.Remove.Enabled = false;
            this.gcLibros.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcLibros.Location = new System.Drawing.Point(0, 34);
            this.gcLibros.MainView = this.gvLibros;
            this.gcLibros.MenuManager = this.barManager1;
            this.gcLibros.Name = "gcLibros";
            this.gcLibros.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ruleInventario,
            this.ruleAutor,
            this.ruleEditorial,
            this.ruleCategoria});
            this.gcLibros.Size = new System.Drawing.Size(881, 490);
            this.gcLibros.TabIndex = 36;
            this.gcLibros.UseEmbeddedNavigator = true;
            this.gcLibros.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvLibros});
            // 
            // gvLibros
            // 
            this.gvLibros.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvLibros.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvLibros.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvLibros.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvLibros.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gvLibros.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvLibros.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidLibro,
            this.colnombre,
            this.Inventario,
            this.colidAutor,
            this.colidEditorial,
            this.colidCategoria,
            this.colprecioUnitario,
            this.colfechaLanzamiento,
            this.colventaPrestamo,
            this.colactivo,
            this.colcodigo,
            this.colcodigoLibro});
            this.gvLibros.GridControl = this.gcLibros;
            this.gvLibros.Name = "gvLibros";
            this.gvLibros.OptionsBehavior.Editable = false;
            this.gvLibros.OptionsCustomization.AllowColumnMoving = false;
            this.gvLibros.OptionsCustomization.AllowFilter = false;
            this.gvLibros.OptionsCustomization.AllowGroup = false;
            this.gvLibros.OptionsCustomization.AllowSort = false;
            this.gvLibros.OptionsView.ColumnAutoWidth = false;
            this.gvLibros.OptionsView.ShowAutoFilterRow = true;
            this.gvLibros.OptionsView.ShowGroupPanel = false;
            // 
            // colidLibro
            // 
            this.colidLibro.Caption = "Id Libro";
            this.colidLibro.FieldName = "idLibro";
            this.colidLibro.MinWidth = 30;
            this.colidLibro.Name = "colidLibro";
            this.colidLibro.Visible = true;
            this.colidLibro.VisibleIndex = 0;
            this.colidLibro.Width = 112;
            // 
            // colnombre
            // 
            this.colnombre.Caption = "Libro";
            this.colnombre.FieldName = "nombre";
            this.colnombre.MinWidth = 30;
            this.colnombre.Name = "colnombre";
            this.colnombre.Visible = true;
            this.colnombre.VisibleIndex = 1;
            this.colnombre.Width = 112;
            // 
            // Inventario
            // 
            this.Inventario.Caption = "Cantidad Disponible";
            this.Inventario.ColumnEdit = this.ruleInventario;
            this.Inventario.FieldName = "idLibro";
            this.Inventario.MinWidth = 30;
            this.Inventario.Name = "Inventario";
            this.Inventario.Visible = true;
            this.Inventario.VisibleIndex = 2;
            this.Inventario.Width = 112;
            // 
            // ruleInventario
            // 
            this.ruleInventario.AutoHeight = false;
            this.ruleInventario.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ruleInventario.DataSource = this.inventarioBindingSource;
            this.ruleInventario.DisplayMember = "cantidadDisponible";
            this.ruleInventario.Name = "ruleInventario";
            this.ruleInventario.ValueMember = "idProducto";
            // 
            // inventarioBindingSource
            // 
            this.inventarioBindingSource.DataSource = typeof(BML.Inventario);
            // 
            // colidAutor
            // 
            this.colidAutor.Caption = "Autor";
            this.colidAutor.ColumnEdit = this.ruleAutor;
            this.colidAutor.FieldName = "idAutor";
            this.colidAutor.MinWidth = 30;
            this.colidAutor.Name = "colidAutor";
            this.colidAutor.Visible = true;
            this.colidAutor.VisibleIndex = 3;
            this.colidAutor.Width = 112;
            // 
            // ruleAutor
            // 
            this.ruleAutor.AutoHeight = false;
            this.ruleAutor.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ruleAutor.DataSource = this.autorBindingSource;
            this.ruleAutor.DisplayMember = "nombre";
            this.ruleAutor.Name = "ruleAutor";
            this.ruleAutor.ValueMember = "idAutor";
            // 
            // colidEditorial
            // 
            this.colidEditorial.Caption = "Editorial";
            this.colidEditorial.ColumnEdit = this.ruleEditorial;
            this.colidEditorial.FieldName = "idEditorial";
            this.colidEditorial.MinWidth = 30;
            this.colidEditorial.Name = "colidEditorial";
            this.colidEditorial.Visible = true;
            this.colidEditorial.VisibleIndex = 4;
            this.colidEditorial.Width = 112;
            // 
            // ruleEditorial
            // 
            this.ruleEditorial.AutoHeight = false;
            this.ruleEditorial.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ruleEditorial.DataSource = this.editorialBindingSource;
            this.ruleEditorial.DisplayMember = "nombre";
            this.ruleEditorial.Name = "ruleEditorial";
            this.ruleEditorial.ValueMember = "idEditorial";
            // 
            // colidCategoria
            // 
            this.colidCategoria.Caption = "Categoria";
            this.colidCategoria.ColumnEdit = this.ruleCategoria;
            this.colidCategoria.FieldName = "idCategoria";
            this.colidCategoria.MinWidth = 30;
            this.colidCategoria.Name = "colidCategoria";
            this.colidCategoria.Visible = true;
            this.colidCategoria.VisibleIndex = 5;
            this.colidCategoria.Width = 112;
            // 
            // ruleCategoria
            // 
            this.ruleCategoria.AutoHeight = false;
            this.ruleCategoria.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ruleCategoria.DataSource = this.categoriaBindingSource;
            this.ruleCategoria.DisplayMember = "descripcion";
            this.ruleCategoria.Name = "ruleCategoria";
            this.ruleCategoria.ValueMember = "idCategoria";
            // 
            // colprecioUnitario
            // 
            this.colprecioUnitario.Caption = "Precio";
            this.colprecioUnitario.FieldName = "precioUnitario";
            this.colprecioUnitario.MinWidth = 30;
            this.colprecioUnitario.Name = "colprecioUnitario";
            this.colprecioUnitario.Visible = true;
            this.colprecioUnitario.VisibleIndex = 6;
            this.colprecioUnitario.Width = 112;
            // 
            // colfechaLanzamiento
            // 
            this.colfechaLanzamiento.Caption = "Fecha de Lanzamiento";
            this.colfechaLanzamiento.FieldName = "fechaLanzamiento";
            this.colfechaLanzamiento.MinWidth = 30;
            this.colfechaLanzamiento.Name = "colfechaLanzamiento";
            this.colfechaLanzamiento.Visible = true;
            this.colfechaLanzamiento.VisibleIndex = 7;
            this.colfechaLanzamiento.Width = 112;
            // 
            // colventaPrestamo
            // 
            this.colventaPrestamo.FieldName = "ventaPrestamo";
            this.colventaPrestamo.MinWidth = 30;
            this.colventaPrestamo.Name = "colventaPrestamo";
            this.colventaPrestamo.Width = 112;
            // 
            // colactivo
            // 
            this.colactivo.FieldName = "activo";
            this.colactivo.MinWidth = 30;
            this.colactivo.Name = "colactivo";
            this.colactivo.Width = 112;
            // 
            // colcodigo
            // 
            this.colcodigo.FieldName = "codigo";
            this.colcodigo.MinWidth = 30;
            this.colcodigo.Name = "colcodigo";
            this.colcodigo.Width = 112;
            // 
            // colcodigoLibro
            // 
            this.colcodigoLibro.Caption = "Codigo de Libro";
            this.colcodigoLibro.FieldName = "codigoLibro";
            this.colcodigoLibro.MinWidth = 30;
            this.colcodigoLibro.Name = "colcodigoLibro";
            this.colcodigoLibro.Visible = true;
            this.colcodigoLibro.VisibleIndex = 8;
            this.colcodigoLibro.Width = 112;
            // 
            // frmLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 524);
            this.Controls.Add(this.gcLibros);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.barDockControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControl2);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frmLibros.IconOptions.Image")));
            this.Name = "frmLibros";
            this.Text = "Libros";
            this.Load += new System.EventHandler(this.frmLibros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editorialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLibros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLibros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ruleInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ruleAutor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ruleEditorial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ruleCategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnAgregar;
        private DevExpress.XtraBars.BarButtonItem btnEditar;
        private DevExpress.XtraBars.BarButtonItem btnEliminar;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private System.Windows.Forms.BindingSource editorialBindingSource;
        private System.Windows.Forms.BindingSource autorBindingSource;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private System.Windows.Forms.BindingSource libroBindingSource;
        private DevExpress.XtraGrid.GridControl gcLibros;
        private DevExpress.XtraGrid.Views.Grid.GridView gvLibros;
        private DevExpress.XtraGrid.Columns.GridColumn colidLibro;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
        private DevExpress.XtraGrid.Columns.GridColumn colidAutor;
        private DevExpress.XtraGrid.Columns.GridColumn colidEditorial;
        private DevExpress.XtraGrid.Columns.GridColumn colidCategoria;
        private DevExpress.XtraGrid.Columns.GridColumn colprecioUnitario;
        private DevExpress.XtraGrid.Columns.GridColumn colfechaLanzamiento;
        private DevExpress.XtraGrid.Columns.GridColumn colventaPrestamo;
        private DevExpress.XtraGrid.Columns.GridColumn colactivo;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigoLibro;
        private DevExpress.XtraGrid.Columns.GridColumn Inventario;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ruleInventario;
        private System.Windows.Forms.BindingSource inventarioBindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ruleAutor;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ruleEditorial;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ruleCategoria;
    }
}