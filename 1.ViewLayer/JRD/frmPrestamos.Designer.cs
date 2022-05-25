namespace JRD
{
    partial class frmPrestamos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrestamos));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnAgregar = new DevExpress.XtraBars.BarButtonItem();
            this.btnEditar = new DevExpress.XtraBars.BarButtonItem();
            this.btnEliminar = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gcPrestamos = new DevExpress.XtraGrid.GridControl();
            this.prestamoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvPrestamos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidPrestamo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidEstudiante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ruleEstudiantes = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.estudianteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colidLibro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ruleLibro = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.libroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colfechaPrestamo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfechaReingreso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ruleEstudianteA = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPrestamos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPrestamos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ruleEstudiantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ruleLibro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ruleEstudianteA)).BeginInit();
            this.SuspendLayout();
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
            this.btnAgregar,
            this.btnEditar,
            this.btnEliminar});
            this.barManager1.MaxItemId = 3;
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
            this.btnAgregar.Id = 0;
            this.btnAgregar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAgregar.ImageOptions.SvgImage")));
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAgregar_ItemClick);
            // 
            // btnEditar
            // 
            this.btnEditar.Caption = "Editar";
            this.btnEditar.Id = 1;
            this.btnEditar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnEditar.ImageOptions.SvgImage")));
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEditar_ItemClick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Caption = "Eliminar";
            this.btnEliminar.Id = 2;
            this.btnEliminar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnEliminar.ImageOptions.SvgImage")));
            this.btnEliminar.Name = "btnEliminar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1022, 34);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 628);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1022, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 34);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 594);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1022, 34);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 594);
            // 
            // gcPrestamos
            // 
            this.gcPrestamos.DataSource = this.prestamoBindingSource;
            this.gcPrestamos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcPrestamos.EmbeddedNavigator.Buttons.Append.Enabled = false;
            this.gcPrestamos.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcPrestamos.EmbeddedNavigator.Buttons.CancelEdit.Enabled = false;
            this.gcPrestamos.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcPrestamos.EmbeddedNavigator.Buttons.Edit.Enabled = false;
            this.gcPrestamos.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcPrestamos.EmbeddedNavigator.Buttons.EndEdit.Enabled = false;
            this.gcPrestamos.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcPrestamos.EmbeddedNavigator.Buttons.Remove.Enabled = false;
            this.gcPrestamos.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcPrestamos.Location = new System.Drawing.Point(0, 34);
            this.gcPrestamos.MainView = this.gvPrestamos;
            this.gcPrestamos.MenuManager = this.barManager1;
            this.gcPrestamos.Name = "gcPrestamos";
            this.gcPrestamos.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ruleEstudiantes,
            this.ruleEstudianteA,
            this.ruleLibro});
            this.gcPrestamos.Size = new System.Drawing.Size(1022, 594);
            this.gcPrestamos.TabIndex = 4;
            this.gcPrestamos.UseEmbeddedNavigator = true;
            this.gcPrestamos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPrestamos});
            // 
            // prestamoBindingSource
            // 
            this.prestamoBindingSource.DataSource = typeof(BML.Prestamo);
            // 
            // gvPrestamos
            // 
            this.gvPrestamos.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Transparent;
            this.gvPrestamos.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.gvPrestamos.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvPrestamos.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvPrestamos.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvPrestamos.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvPrestamos.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gvPrestamos.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvPrestamos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidPrestamo,
            this.colidEstudiante,
            this.colidLibro,
            this.colfechaPrestamo,
            this.colfechaReingreso,
            this.gridColumn1});
            this.gvPrestamos.GridControl = this.gcPrestamos;
            this.gvPrestamos.Name = "gvPrestamos";
            this.gvPrestamos.OptionsBehavior.Editable = false;
            this.gvPrestamos.OptionsCustomization.AllowFilter = false;
            this.gvPrestamos.OptionsView.ColumnAutoWidth = false;
            this.gvPrestamos.OptionsView.ShowAutoFilterRow = true;
            this.gvPrestamos.OptionsView.ShowGroupPanel = false;
            // 
            // colidPrestamo
            // 
            this.colidPrestamo.Caption = "Id Prestamo";
            this.colidPrestamo.FieldName = "idPrestamo";
            this.colidPrestamo.MinWidth = 30;
            this.colidPrestamo.Name = "colidPrestamo";
            this.colidPrestamo.OptionsColumn.AllowMove = false;
            this.colidPrestamo.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colidPrestamo.Visible = true;
            this.colidPrestamo.VisibleIndex = 0;
            this.colidPrestamo.Width = 112;
            // 
            // colidEstudiante
            // 
            this.colidEstudiante.Caption = "Nombre del Estudiante";
            this.colidEstudiante.ColumnEdit = this.ruleEstudiantes;
            this.colidEstudiante.FieldName = "idEstudiante";
            this.colidEstudiante.MinWidth = 30;
            this.colidEstudiante.Name = "colidEstudiante";
            this.colidEstudiante.OptionsColumn.AllowMove = false;
            this.colidEstudiante.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colidEstudiante.Visible = true;
            this.colidEstudiante.VisibleIndex = 1;
            this.colidEstudiante.Width = 112;
            // 
            // ruleEstudiantes
            // 
            this.ruleEstudiantes.AutoHeight = false;
            this.ruleEstudiantes.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ruleEstudiantes.DataSource = this.estudianteBindingSource;
            this.ruleEstudiantes.DisplayMember = "nombre";
            this.ruleEstudiantes.Name = "ruleEstudiantes";
            this.ruleEstudiantes.ValueMember = "idEstudiante";
            // 
            // estudianteBindingSource
            // 
            this.estudianteBindingSource.DataSource = typeof(BML.Estudiante);
            // 
            // colidLibro
            // 
            this.colidLibro.Caption = "Libro";
            this.colidLibro.ColumnEdit = this.ruleLibro;
            this.colidLibro.FieldName = "idLibro";
            this.colidLibro.MinWidth = 30;
            this.colidLibro.Name = "colidLibro";
            this.colidLibro.OptionsColumn.AllowMove = false;
            this.colidLibro.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colidLibro.Visible = true;
            this.colidLibro.VisibleIndex = 3;
            this.colidLibro.Width = 112;
            // 
            // ruleLibro
            // 
            this.ruleLibro.AutoHeight = false;
            this.ruleLibro.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ruleLibro.DataSource = this.libroBindingSource;
            this.ruleLibro.DisplayMember = "nombre";
            this.ruleLibro.Name = "ruleLibro";
            this.ruleLibro.ValueMember = "idLibro";
            // 
            // libroBindingSource
            // 
            this.libroBindingSource.DataSource = typeof(BML.Libro);
            // 
            // colfechaPrestamo
            // 
            this.colfechaPrestamo.Caption = "Fecha de Prestamo";
            this.colfechaPrestamo.FieldName = "fechaPrestamo";
            this.colfechaPrestamo.MinWidth = 30;
            this.colfechaPrestamo.Name = "colfechaPrestamo";
            this.colfechaPrestamo.OptionsColumn.AllowMove = false;
            this.colfechaPrestamo.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colfechaPrestamo.Visible = true;
            this.colfechaPrestamo.VisibleIndex = 4;
            this.colfechaPrestamo.Width = 112;
            // 
            // colfechaReingreso
            // 
            this.colfechaReingreso.Caption = "Fecha de Reingreso";
            this.colfechaReingreso.FieldName = "fechaReingreso";
            this.colfechaReingreso.MinWidth = 30;
            this.colfechaReingreso.Name = "colfechaReingreso";
            this.colfechaReingreso.OptionsColumn.AllowMove = false;
            this.colfechaReingreso.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colfechaReingreso.Visible = true;
            this.colfechaReingreso.VisibleIndex = 5;
            this.colfechaReingreso.Width = 112;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Apellido del Estudiante";
            this.gridColumn1.ColumnEdit = this.ruleEstudianteA;
            this.gridColumn1.FieldName = "idEstudiante";
            this.gridColumn1.MinWidth = 30;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowMove = false;
            this.gridColumn1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            this.gridColumn1.Width = 161;
            // 
            // ruleEstudianteA
            // 
            this.ruleEstudianteA.AutoHeight = false;
            this.ruleEstudianteA.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ruleEstudianteA.DataSource = this.estudianteBindingSource;
            this.ruleEstudianteA.DisplayMember = "apellido";
            this.ruleEstudianteA.Name = "ruleEstudianteA";
            this.ruleEstudianteA.ValueMember = "idEstudiante";
            // 
            // frmPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 628);
            this.Controls.Add(this.gcPrestamos);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmPrestamos";
            this.Text = "Prestamos";
            this.Load += new System.EventHandler(this.frmPrestamos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPrestamos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPrestamos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ruleEstudiantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ruleLibro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ruleEstudianteA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnAgregar;
        private DevExpress.XtraBars.BarButtonItem btnEditar;
        private DevExpress.XtraBars.BarButtonItem btnEliminar;
        private DevExpress.XtraGrid.GridControl gcPrestamos;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPrestamos;
        private System.Windows.Forms.BindingSource prestamoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colidPrestamo;
        private DevExpress.XtraGrid.Columns.GridColumn colidEstudiante;
        private DevExpress.XtraGrid.Columns.GridColumn colidLibro;
        private DevExpress.XtraGrid.Columns.GridColumn colfechaPrestamo;
        private DevExpress.XtraGrid.Columns.GridColumn colfechaReingreso;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ruleEstudiantes;
        private System.Windows.Forms.BindingSource estudianteBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ruleEstudianteA;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ruleLibro;
        private System.Windows.Forms.BindingSource libroBindingSource;
    }
}