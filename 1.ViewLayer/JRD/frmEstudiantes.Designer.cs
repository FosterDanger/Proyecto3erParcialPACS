namespace JRD
{
    partial class frmEstudiantes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstudiantes));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnAgregar = new DevExpress.XtraBars.BarButtonItem();
            this.btnEditar = new DevExpress.XtraBars.BarButtonItem();
            this.btnEliminar = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gcEstudiantes = new DevExpress.XtraGrid.GridControl();
            this.estudianteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvEstudiantes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidEstudiante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcorreoElectronico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltelefono = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnumControl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colapellido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colactivo = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcEstudiantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEstudiantes)).BeginInit();
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
            this.barDockControlTop.Size = new System.Drawing.Size(844, 34);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 478);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(844, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 34);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 444);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(844, 34);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 444);
            // 
            // gcEstudiantes
            // 
            this.gcEstudiantes.DataSource = this.estudianteBindingSource;
            this.gcEstudiantes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcEstudiantes.EmbeddedNavigator.Buttons.Append.Enabled = false;
            this.gcEstudiantes.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcEstudiantes.EmbeddedNavigator.Buttons.CancelEdit.Enabled = false;
            this.gcEstudiantes.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcEstudiantes.EmbeddedNavigator.Buttons.Edit.Enabled = false;
            this.gcEstudiantes.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcEstudiantes.EmbeddedNavigator.Buttons.EndEdit.Enabled = false;
            this.gcEstudiantes.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcEstudiantes.EmbeddedNavigator.Buttons.Remove.Enabled = false;
            this.gcEstudiantes.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcEstudiantes.Location = new System.Drawing.Point(0, 34);
            this.gcEstudiantes.MainView = this.gvEstudiantes;
            this.gcEstudiantes.MenuManager = this.barManager1;
            this.gcEstudiantes.Name = "gcEstudiantes";
            this.gcEstudiantes.Size = new System.Drawing.Size(844, 444);
            this.gcEstudiantes.TabIndex = 4;
            this.gcEstudiantes.UseEmbeddedNavigator = true;
            this.gcEstudiantes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvEstudiantes});
            // 
            // estudianteBindingSource
            // 
            this.estudianteBindingSource.DataSource = typeof(BML.Estudiante);
            // 
            // gvEstudiantes
            // 
            this.gvEstudiantes.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvEstudiantes.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvEstudiantes.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvEstudiantes.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvEstudiantes.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gvEstudiantes.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvEstudiantes.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidEstudiante,
            this.colcorreoElectronico,
            this.coltelefono,
            this.colnumControl,
            this.colnombre,
            this.colapellido,
            this.colactivo});
            this.gvEstudiantes.GridControl = this.gcEstudiantes;
            this.gvEstudiantes.Name = "gvEstudiantes";
            this.gvEstudiantes.OptionsBehavior.Editable = false;
            this.gvEstudiantes.OptionsCustomization.AllowFilter = false;
            this.gvEstudiantes.OptionsView.ColumnAutoWidth = false;
            this.gvEstudiantes.OptionsView.ShowAutoFilterRow = true;
            this.gvEstudiantes.OptionsView.ShowGroupPanel = false;
            // 
            // colidEstudiante
            // 
            this.colidEstudiante.Caption = "Id Estudiante";
            this.colidEstudiante.FieldName = "idEstudiante";
            this.colidEstudiante.MinWidth = 30;
            this.colidEstudiante.Name = "colidEstudiante";
            this.colidEstudiante.OptionsColumn.AllowMove = false;
            this.colidEstudiante.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colidEstudiante.OptionsFilter.AllowFilter = false;
            this.colidEstudiante.Visible = true;
            this.colidEstudiante.VisibleIndex = 0;
            this.colidEstudiante.Width = 112;
            // 
            // colcorreoElectronico
            // 
            this.colcorreoElectronico.Caption = "Correo";
            this.colcorreoElectronico.FieldName = "correoElectronico";
            this.colcorreoElectronico.MinWidth = 30;
            this.colcorreoElectronico.Name = "colcorreoElectronico";
            this.colcorreoElectronico.OptionsColumn.AllowMove = false;
            this.colcorreoElectronico.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colcorreoElectronico.OptionsFilter.AllowFilter = false;
            this.colcorreoElectronico.Visible = true;
            this.colcorreoElectronico.VisibleIndex = 1;
            this.colcorreoElectronico.Width = 112;
            // 
            // coltelefono
            // 
            this.coltelefono.Caption = "Telefono";
            this.coltelefono.FieldName = "telefono";
            this.coltelefono.MinWidth = 30;
            this.coltelefono.Name = "coltelefono";
            this.coltelefono.OptionsColumn.AllowMove = false;
            this.coltelefono.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.coltelefono.OptionsFilter.AllowFilter = false;
            this.coltelefono.Visible = true;
            this.coltelefono.VisibleIndex = 2;
            this.coltelefono.Width = 112;
            // 
            // colnumControl
            // 
            this.colnumControl.Caption = "Numero de Control";
            this.colnumControl.FieldName = "numControl";
            this.colnumControl.MinWidth = 30;
            this.colnumControl.Name = "colnumControl";
            this.colnumControl.OptionsColumn.AllowMove = false;
            this.colnumControl.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colnumControl.OptionsFilter.AllowFilter = false;
            this.colnumControl.Visible = true;
            this.colnumControl.VisibleIndex = 3;
            this.colnumControl.Width = 112;
            // 
            // colnombre
            // 
            this.colnombre.Caption = "Nombre";
            this.colnombre.FieldName = "nombre";
            this.colnombre.MinWidth = 30;
            this.colnombre.Name = "colnombre";
            this.colnombre.OptionsColumn.AllowMove = false;
            this.colnombre.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colnombre.OptionsFilter.AllowFilter = false;
            this.colnombre.Visible = true;
            this.colnombre.VisibleIndex = 4;
            this.colnombre.Width = 112;
            // 
            // colapellido
            // 
            this.colapellido.Caption = "Apellido";
            this.colapellido.FieldName = "apellido";
            this.colapellido.MinWidth = 30;
            this.colapellido.Name = "colapellido";
            this.colapellido.OptionsColumn.AllowMove = false;
            this.colapellido.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colapellido.OptionsFilter.AllowFilter = false;
            this.colapellido.Visible = true;
            this.colapellido.VisibleIndex = 5;
            this.colapellido.Width = 112;
            // 
            // colactivo
            // 
            this.colactivo.FieldName = "activo";
            this.colactivo.MinWidth = 30;
            this.colactivo.Name = "colactivo";
            this.colactivo.Width = 112;
            // 
            // frmEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 478);
            this.Controls.Add(this.gcEstudiantes);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmEstudiantes";
            this.Text = "Estudiantes";
            this.Load += new System.EventHandler(this.frmEstudiantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcEstudiantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEstudiantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnAgregar;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnEditar;
        private DevExpress.XtraBars.BarButtonItem btnEliminar;
        private DevExpress.XtraGrid.GridControl gcEstudiantes;
        private System.Windows.Forms.BindingSource estudianteBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gvEstudiantes;
        private DevExpress.XtraGrid.Columns.GridColumn colidEstudiante;
        private DevExpress.XtraGrid.Columns.GridColumn colcorreoElectronico;
        private DevExpress.XtraGrid.Columns.GridColumn coltelefono;
        private DevExpress.XtraGrid.Columns.GridColumn colnumControl;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
        private DevExpress.XtraGrid.Columns.GridColumn colapellido;
        private DevExpress.XtraGrid.Columns.GridColumn colactivo;
    }
}