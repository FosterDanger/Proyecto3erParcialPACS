namespace JRD
{
    partial class frmComprasC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmComprasC));
            this.gcComprasC = new DevExpress.XtraGrid.GridControl();
            this.entradaCompraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvComprasC = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidEntrada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colactivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigoCompra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.popupMenuDetalleCompra = new DevExpress.XtraBars.PopupMenu(this.components);
            this.btnDetalleCompra = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.barManager2 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.gcComprasC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entradaCompraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvComprasC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuDetalleCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).BeginInit();
            this.SuspendLayout();
            // 
            // gcComprasC
            // 
            this.gcComprasC.DataSource = this.entradaCompraBindingSource;
            this.gcComprasC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcComprasC.EmbeddedNavigator.Buttons.Append.Enabled = false;
            this.gcComprasC.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcComprasC.EmbeddedNavigator.Buttons.CancelEdit.Enabled = false;
            this.gcComprasC.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcComprasC.EmbeddedNavigator.Buttons.Edit.Enabled = false;
            this.gcComprasC.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcComprasC.EmbeddedNavigator.Buttons.EndEdit.Enabled = false;
            this.gcComprasC.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcComprasC.EmbeddedNavigator.Buttons.Remove.Enabled = false;
            this.gcComprasC.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcComprasC.Location = new System.Drawing.Point(0, 34);
            this.gcComprasC.MainView = this.gvComprasC;
            this.gcComprasC.Name = "gcComprasC";
            this.gcComprasC.Size = new System.Drawing.Size(1458, 637);
            this.gcComprasC.TabIndex = 17;
            this.gcComprasC.UseEmbeddedNavigator = true;
            this.gcComprasC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvComprasC});
            // 
            // entradaCompraBindingSource
            // 
            this.entradaCompraBindingSource.DataSource = typeof(BML.EntradaCompra);
            // 
            // gvComprasC
            // 
            this.gvComprasC.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvComprasC.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvComprasC.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvComprasC.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvComprasC.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gvComprasC.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvComprasC.Appearance.Row.Options.UseTextOptions = true;
            this.gvComprasC.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvComprasC.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidEntrada,
            this.colfecha,
            this.coltotal,
            this.colactivo,
            this.colcodigo,
            this.colcodigoCompra,
            this.colestado});
            this.gvComprasC.GridControl = this.gcComprasC;
            this.gvComprasC.Name = "gvComprasC";
            this.gvComprasC.OptionsBehavior.Editable = false;
            this.gvComprasC.OptionsCustomization.AllowColumnMoving = false;
            this.gvComprasC.OptionsCustomization.AllowFilter = false;
            this.gvComprasC.OptionsCustomization.AllowSort = false;
            this.gvComprasC.OptionsView.ColumnAutoWidth = false;
            this.gvComprasC.OptionsView.ShowAutoFilterRow = true;
            this.gvComprasC.OptionsView.ShowGroupPanel = false;
            this.gvComprasC.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gvComprasC_PopupMenuShowing);
            // 
            // colidEntrada
            // 
            this.colidEntrada.Caption = "Id Compra";
            this.colidEntrada.FieldName = "idEntrada";
            this.colidEntrada.MinWidth = 30;
            this.colidEntrada.Name = "colidEntrada";
            this.colidEntrada.Visible = true;
            this.colidEntrada.VisibleIndex = 0;
            this.colidEntrada.Width = 112;
            // 
            // colfecha
            // 
            this.colfecha.Caption = "Fecha";
            this.colfecha.FieldName = "fecha";
            this.colfecha.MinWidth = 30;
            this.colfecha.Name = "colfecha";
            this.colfecha.Visible = true;
            this.colfecha.VisibleIndex = 1;
            this.colfecha.Width = 112;
            // 
            // coltotal
            // 
            this.coltotal.Caption = "Total";
            this.coltotal.FieldName = "total";
            this.coltotal.MinWidth = 30;
            this.coltotal.Name = "coltotal";
            this.coltotal.OptionsColumn.AllowEdit = false;
            this.coltotal.OptionsColumn.AllowFocus = false;
            this.coltotal.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.coltotal.OptionsFilter.AllowAutoFilter = false;
            this.coltotal.OptionsFilter.AllowFilter = false;
            this.coltotal.OptionsFilter.ImmediateUpdateAutoFilter = false;
            this.coltotal.Visible = true;
            this.coltotal.VisibleIndex = 3;
            this.coltotal.Width = 112;
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
            // colcodigoCompra
            // 
            this.colcodigoCompra.Caption = "Codigo de Compra";
            this.colcodigoCompra.FieldName = "codigoCompra";
            this.colcodigoCompra.MinWidth = 30;
            this.colcodigoCompra.Name = "colcodigoCompra";
            this.colcodigoCompra.Visible = true;
            this.colcodigoCompra.VisibleIndex = 2;
            this.colcodigoCompra.Width = 112;
            // 
            // colestado
            // 
            this.colestado.Caption = "Estado de Compra";
            this.colestado.FieldName = "estado";
            this.colestado.MinWidth = 30;
            this.colestado.Name = "colestado";
            this.colestado.Visible = true;
            this.colestado.VisibleIndex = 4;
            this.colestado.Width = 112;
            // 
            // popupMenuDetalleCompra
            // 
            this.popupMenuDetalleCompra.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDetalleCompra)});
            this.popupMenuDetalleCompra.Manager = this.barManager1;
            this.popupMenuDetalleCompra.Name = "popupMenuDetalleCompra";
            // 
            // btnDetalleCompra
            // 
            this.btnDetalleCompra.Caption = "Ver el detalle de la compra";
            this.btnDetalleCompra.Id = 0;
            this.btnDetalleCompra.Name = "btnDetalleCompra";
            this.btnDetalleCompra.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDetalleCompra_ItemClick);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnDetalleCompra});
            this.barManager1.MaxItemId = 1;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 34);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1458, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 671);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1458, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 34);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 637);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1458, 34);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 637);
            // 
            // barManager2
            // 
            this.barManager2.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager2.DockControls.Add(this.barDockControl1);
            this.barManager2.DockControls.Add(this.barDockControl2);
            this.barManager2.DockControls.Add(this.barDockControl3);
            this.barManager2.DockControls.Add(this.barDockControl4);
            this.barManager2.Form = this;
            this.barManager2.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1});
            this.barManager2.MaxItemId = 1;
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
            this.barButtonItem1.Caption = "Cancelar Compra";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Manager = this.barManager2;
            this.barDockControl1.Size = new System.Drawing.Size(1458, 34);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 671);
            this.barDockControl2.Manager = this.barManager2;
            this.barDockControl2.Size = new System.Drawing.Size(1458, 0);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 34);
            this.barDockControl3.Manager = this.barManager2;
            this.barDockControl3.Size = new System.Drawing.Size(0, 637);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(1458, 34);
            this.barDockControl4.Manager = this.barManager2;
            this.barDockControl4.Size = new System.Drawing.Size(0, 637);
            // 
            // frmComprasC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1458, 671);
            this.Controls.Add(this.gcComprasC);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.Name = "frmComprasC";
            this.Text = "Compras";
            this.Load += new System.EventHandler(this.frmComprasC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcComprasC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entradaCompraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvComprasC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuDetalleCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gcComprasC;
        private System.Windows.Forms.BindingSource entradaCompraBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gvComprasC;
        private DevExpress.XtraGrid.Columns.GridColumn colidEntrada;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha;
        private DevExpress.XtraGrid.Columns.GridColumn coltotal;
        private DevExpress.XtraGrid.Columns.GridColumn colactivo;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigoCompra;
        private DevExpress.XtraGrid.Columns.GridColumn colestado;
        private DevExpress.XtraBars.PopupMenu popupMenuDetalleCompra;
        private DevExpress.XtraBars.BarButtonItem btnDetalleCompra;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarManager barManager2;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
    }
}