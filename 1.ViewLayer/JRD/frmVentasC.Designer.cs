namespace JRD
{
    partial class frmVentasC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentasC));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gcVentas = new DevExpress.XtraGrid.GridControl();
            this.ventaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvVentas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidVenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Apellido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ruleApellido = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colidUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ruleUsuario = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colfecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsubtotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescuento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigoVenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.popupMenuDetalleVenta = new DevExpress.XtraBars.PopupMenu(this.components);
            this.btnDetalleVenta = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ruleApellido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ruleUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuDetalleVenta)).BeginInit();
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
            this.barButtonItem1,
            this.btnDetalleVenta});
            this.barManager1.MaxItemId = 2;
            // 
            // bar1
            // 
            this.bar1.BarName = "Herramientas";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.OptionsBar.DrawBorder = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.Text = "Herramientas";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Cancelar Venta";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1246, 34);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 689);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1246, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 34);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 655);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1246, 34);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 655);
            // 
            // gcVentas
            // 
            this.gcVentas.DataSource = this.ventaBindingSource;
            this.gcVentas.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this.gcVentas.Location = new System.Drawing.Point(0, 34);
            this.gcVentas.MainView = this.gvVentas;
            this.gcVentas.MenuManager = this.barManager1;
            this.gcVentas.Name = "gcVentas";
            this.gcVentas.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ruleUsuario,
            this.ruleApellido});
            this.gcVentas.Size = new System.Drawing.Size(1246, 655);
            this.gcVentas.TabIndex = 4;
            this.gcVentas.UseEmbeddedNavigator = true;
            this.gcVentas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvVentas});
            // 
            // ventaBindingSource
            // 
            this.ventaBindingSource.DataSource = typeof(BML.Venta);
            // 
            // gvVentas
            // 
            this.gvVentas.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.gvVentas.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvVentas.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvVentas.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvVentas.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gvVentas.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvVentas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidVenta,
            this.Apellido,
            this.colidUsuario,
            this.colfecha,
            this.colsubtotal,
            this.coldescuento,
            this.coltotal,
            this.colestado,
            this.colcodigo,
            this.colcodigoVenta});
            this.gvVentas.GridControl = this.gcVentas;
            this.gvVentas.Name = "gvVentas";
            this.gvVentas.OptionsBehavior.Editable = false;
            this.gvVentas.OptionsCustomization.AllowColumnMoving = false;
            this.gvVentas.OptionsCustomization.AllowFilter = false;
            this.gvVentas.OptionsCustomization.AllowGroup = false;
            this.gvVentas.OptionsCustomization.AllowSort = false;
            this.gvVentas.OptionsView.ColumnAutoWidth = false;
            this.gvVentas.OptionsView.ShowAutoFilterRow = true;
            this.gvVentas.OptionsView.ShowGroupPanel = false;
            this.gvVentas.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gvVentas_PopupMenuShowing);
            // 
            // colidVenta
            // 
            this.colidVenta.Caption = "Id Venta";
            this.colidVenta.FieldName = "idVenta";
            this.colidVenta.MinWidth = 30;
            this.colidVenta.Name = "colidVenta";
            this.colidVenta.Visible = true;
            this.colidVenta.VisibleIndex = 0;
            this.colidVenta.Width = 112;
            // 
            // Apellido
            // 
            this.Apellido.Caption = "Apellido de Usuario";
            this.Apellido.ColumnEdit = this.ruleApellido;
            this.Apellido.FieldName = "idUsuario";
            this.Apellido.MinWidth = 30;
            this.Apellido.Name = "Apellido";
            this.Apellido.Visible = true;
            this.Apellido.VisibleIndex = 2;
            this.Apellido.Width = 112;
            // 
            // ruleApellido
            // 
            this.ruleApellido.AutoHeight = false;
            this.ruleApellido.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ruleApellido.DataSource = this.usuarioBindingSource;
            this.ruleApellido.DisplayMember = "apellido";
            this.ruleApellido.KeyMember = "idUsuario";
            this.ruleApellido.Name = "ruleApellido";
            this.ruleApellido.ValueMember = "idUsuario";
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(BML.Usuario);
            // 
            // colidUsuario
            // 
            this.colidUsuario.Caption = "Nombre de Usuario";
            this.colidUsuario.ColumnEdit = this.ruleUsuario;
            this.colidUsuario.FieldName = "idUsuario";
            this.colidUsuario.MinWidth = 30;
            this.colidUsuario.Name = "colidUsuario";
            this.colidUsuario.Visible = true;
            this.colidUsuario.VisibleIndex = 1;
            this.colidUsuario.Width = 112;
            // 
            // ruleUsuario
            // 
            this.ruleUsuario.AutoHeight = false;
            this.ruleUsuario.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ruleUsuario.DataSource = this.usuarioBindingSource;
            this.ruleUsuario.DisplayMember = "nombre";
            this.ruleUsuario.Name = "ruleUsuario";
            this.ruleUsuario.ValueMember = "idUsuario";
            // 
            // colfecha
            // 
            this.colfecha.Caption = "Fecha";
            this.colfecha.FieldName = "fecha";
            this.colfecha.MinWidth = 30;
            this.colfecha.Name = "colfecha";
            this.colfecha.Visible = true;
            this.colfecha.VisibleIndex = 3;
            this.colfecha.Width = 112;
            // 
            // colsubtotal
            // 
            this.colsubtotal.Caption = "SubTotal";
            this.colsubtotal.FieldName = "subtotal";
            this.colsubtotal.MinWidth = 30;
            this.colsubtotal.Name = "colsubtotal";
            this.colsubtotal.Visible = true;
            this.colsubtotal.VisibleIndex = 4;
            this.colsubtotal.Width = 112;
            // 
            // coldescuento
            // 
            this.coldescuento.Caption = "Descuento";
            this.coldescuento.FieldName = "descuento";
            this.coldescuento.MinWidth = 30;
            this.coldescuento.Name = "coldescuento";
            this.coldescuento.Visible = true;
            this.coldescuento.VisibleIndex = 5;
            this.coldescuento.Width = 112;
            // 
            // coltotal
            // 
            this.coltotal.Caption = "Total";
            this.coltotal.FieldName = "total";
            this.coltotal.MinWidth = 30;
            this.coltotal.Name = "coltotal";
            this.coltotal.Visible = true;
            this.coltotal.VisibleIndex = 6;
            this.coltotal.Width = 112;
            // 
            // colestado
            // 
            this.colestado.Caption = "Estado";
            this.colestado.FieldName = "estado";
            this.colestado.MinWidth = 30;
            this.colestado.Name = "colestado";
            this.colestado.Visible = true;
            this.colestado.VisibleIndex = 8;
            this.colestado.Width = 112;
            // 
            // colcodigo
            // 
            this.colcodigo.FieldName = "codigo";
            this.colcodigo.MinWidth = 30;
            this.colcodigo.Name = "colcodigo";
            this.colcodigo.Width = 112;
            // 
            // colcodigoVenta
            // 
            this.colcodigoVenta.Caption = "Codigo de Venta";
            this.colcodigoVenta.FieldName = "codigoVenta";
            this.colcodigoVenta.MinWidth = 30;
            this.colcodigoVenta.Name = "colcodigoVenta";
            this.colcodigoVenta.Visible = true;
            this.colcodigoVenta.VisibleIndex = 7;
            this.colcodigoVenta.Width = 112;
            // 
            // popupMenuDetalleVenta
            // 
            this.popupMenuDetalleVenta.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDetalleVenta)});
            this.popupMenuDetalleVenta.Manager = this.barManager1;
            this.popupMenuDetalleVenta.Name = "popupMenuDetalleVenta";
            // 
            // btnDetalleVenta
            // 
            this.btnDetalleVenta.Caption = "Ver el Detalle de la Venta";
            this.btnDetalleVenta.Id = 1;
            this.btnDetalleVenta.Name = "btnDetalleVenta";
            this.btnDetalleVenta.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDetalleVenta_ItemClick);
            // 
            // frmVentasC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 689);
            this.Controls.Add(this.gcVentas);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmVentasC";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.frmVentasC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ruleApellido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ruleUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuDetalleVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl gcVentas;
        private System.Windows.Forms.BindingSource ventaBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gvVentas;
        private DevExpress.XtraGrid.Columns.GridColumn colidVenta;
        private DevExpress.XtraGrid.Columns.GridColumn colidUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha;
        private DevExpress.XtraGrid.Columns.GridColumn colsubtotal;
        private DevExpress.XtraGrid.Columns.GridColumn coldescuento;
        private DevExpress.XtraGrid.Columns.GridColumn coltotal;
        private DevExpress.XtraGrid.Columns.GridColumn colestado;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigoVenta;
        private DevExpress.XtraGrid.Columns.GridColumn Apellido;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ruleApellido;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ruleUsuario;
        private DevExpress.XtraBars.BarButtonItem btnDetalleVenta;
        private DevExpress.XtraBars.PopupMenu popupMenuDetalleVenta;
    }
}