namespace JRD
{
    partial class frmProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProveedores));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gcProveedores = new DevExpress.XtraGrid.GridControl();
            this.proveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvProveedores = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombreProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombreContacto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcargoContacto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcalle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcolonia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigoPostal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colciudad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltelefono = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colemail = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcProveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProveedores)).BeginInit();
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
            this.barButtonItem2,
            this.barButtonItem3});
            this.barManager1.MaxItemId = 3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Herramientas";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem2, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem3, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.OptionsBar.DrawBorder = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.Text = "Herramientas";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Agregar";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Editar";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem2.ImageOptions.SvgImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Eliminar";
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem3.ImageOptions.SvgImage")));
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1111, 34);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 622);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1111, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 34);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 588);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1111, 34);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 588);
            // 
            // gcProveedores
            // 
            this.gcProveedores.DataSource = this.proveedorBindingSource;
            this.gcProveedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcProveedores.EmbeddedNavigator.Buttons.Append.Enabled = false;
            this.gcProveedores.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcProveedores.EmbeddedNavigator.Buttons.CancelEdit.Enabled = false;
            this.gcProveedores.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcProveedores.EmbeddedNavigator.Buttons.Edit.Enabled = false;
            this.gcProveedores.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcProveedores.EmbeddedNavigator.Buttons.EndEdit.Enabled = false;
            this.gcProveedores.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcProveedores.EmbeddedNavigator.Buttons.Remove.Enabled = false;
            this.gcProveedores.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcProveedores.Location = new System.Drawing.Point(0, 34);
            this.gcProveedores.MainView = this.gvProveedores;
            this.gcProveedores.MenuManager = this.barManager1;
            this.gcProveedores.Name = "gcProveedores";
            this.gcProveedores.Size = new System.Drawing.Size(1111, 588);
            this.gcProveedores.TabIndex = 4;
            this.gcProveedores.UseEmbeddedNavigator = true;
            this.gcProveedores.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvProveedores});
            // 
            // proveedorBindingSource
            // 
            this.proveedorBindingSource.DataSource = typeof(BML.Proveedor);
            // 
            // gvProveedores
            // 
            this.gvProveedores.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvProveedores.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvProveedores.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvProveedores.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvProveedores.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gvProveedores.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvProveedores.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidProveedor,
            this.colnombreProveedor,
            this.colnombreContacto,
            this.colcargoContacto,
            this.colcalle,
            this.colcolonia,
            this.colcodigoPostal,
            this.colciudad,
            this.coltelefono,
            this.colemail});
            this.gvProveedores.GridControl = this.gcProveedores;
            this.gvProveedores.Name = "gvProveedores";
            this.gvProveedores.OptionsBehavior.Editable = false;
            this.gvProveedores.OptionsCustomization.AllowColumnMoving = false;
            this.gvProveedores.OptionsCustomization.AllowFilter = false;
            this.gvProveedores.OptionsCustomization.AllowGroup = false;
            this.gvProveedores.OptionsCustomization.AllowSort = false;
            this.gvProveedores.OptionsView.ColumnAutoWidth = false;
            this.gvProveedores.OptionsView.ShowAutoFilterRow = true;
            this.gvProveedores.OptionsView.ShowGroupPanel = false;
            // 
            // colidProveedor
            // 
            this.colidProveedor.Caption = "Id Proveedor";
            this.colidProveedor.FieldName = "idProveedor";
            this.colidProveedor.MinWidth = 30;
            this.colidProveedor.Name = "colidProveedor";
            this.colidProveedor.Visible = true;
            this.colidProveedor.VisibleIndex = 0;
            this.colidProveedor.Width = 112;
            // 
            // colnombreProveedor
            // 
            this.colnombreProveedor.Caption = "Nombre del Proveedor";
            this.colnombreProveedor.FieldName = "nombreProveedor";
            this.colnombreProveedor.MinWidth = 30;
            this.colnombreProveedor.Name = "colnombreProveedor";
            this.colnombreProveedor.Visible = true;
            this.colnombreProveedor.VisibleIndex = 1;
            this.colnombreProveedor.Width = 112;
            // 
            // colnombreContacto
            // 
            this.colnombreContacto.Caption = "Nombre del Contacto";
            this.colnombreContacto.FieldName = "nombreContacto";
            this.colnombreContacto.MinWidth = 30;
            this.colnombreContacto.Name = "colnombreContacto";
            this.colnombreContacto.Visible = true;
            this.colnombreContacto.VisibleIndex = 2;
            this.colnombreContacto.Width = 112;
            // 
            // colcargoContacto
            // 
            this.colcargoContacto.Caption = "Cargo del Contacto";
            this.colcargoContacto.FieldName = "cargoContacto";
            this.colcargoContacto.MinWidth = 30;
            this.colcargoContacto.Name = "colcargoContacto";
            this.colcargoContacto.Visible = true;
            this.colcargoContacto.VisibleIndex = 3;
            this.colcargoContacto.Width = 112;
            // 
            // colcalle
            // 
            this.colcalle.Caption = "Calle";
            this.colcalle.FieldName = "calle";
            this.colcalle.MinWidth = 30;
            this.colcalle.Name = "colcalle";
            this.colcalle.Visible = true;
            this.colcalle.VisibleIndex = 4;
            this.colcalle.Width = 112;
            // 
            // colcolonia
            // 
            this.colcolonia.Caption = "Colonia";
            this.colcolonia.FieldName = "colonia";
            this.colcolonia.MinWidth = 30;
            this.colcolonia.Name = "colcolonia";
            this.colcolonia.Visible = true;
            this.colcolonia.VisibleIndex = 5;
            this.colcolonia.Width = 112;
            // 
            // colcodigoPostal
            // 
            this.colcodigoPostal.Caption = "Codigo Postal";
            this.colcodigoPostal.FieldName = "codigoPostal";
            this.colcodigoPostal.MinWidth = 30;
            this.colcodigoPostal.Name = "colcodigoPostal";
            this.colcodigoPostal.Visible = true;
            this.colcodigoPostal.VisibleIndex = 6;
            this.colcodigoPostal.Width = 112;
            // 
            // colciudad
            // 
            this.colciudad.Caption = "Ciudad";
            this.colciudad.FieldName = "ciudad";
            this.colciudad.MinWidth = 30;
            this.colciudad.Name = "colciudad";
            this.colciudad.Visible = true;
            this.colciudad.VisibleIndex = 7;
            this.colciudad.Width = 112;
            // 
            // coltelefono
            // 
            this.coltelefono.Caption = "Telefono";
            this.coltelefono.FieldName = "telefono";
            this.coltelefono.MinWidth = 30;
            this.coltelefono.Name = "coltelefono";
            this.coltelefono.Visible = true;
            this.coltelefono.VisibleIndex = 8;
            this.coltelefono.Width = 112;
            // 
            // colemail
            // 
            this.colemail.Caption = "Email";
            this.colemail.FieldName = "email";
            this.colemail.MinWidth = 30;
            this.colemail.Name = "colemail";
            this.colemail.Visible = true;
            this.colemail.VisibleIndex = 9;
            this.colemail.Width = 112;
            // 
            // frmProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 622);
            this.Controls.Add(this.gcProveedores);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmProveedores";
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.frmProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcProveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProveedores)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraGrid.GridControl gcProveedores;
        private DevExpress.XtraGrid.Views.Grid.GridView gvProveedores;
        private System.Windows.Forms.BindingSource proveedorBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colidProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colnombreProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colnombreContacto;
        private DevExpress.XtraGrid.Columns.GridColumn colcargoContacto;
        private DevExpress.XtraGrid.Columns.GridColumn colcalle;
        private DevExpress.XtraGrid.Columns.GridColumn colcolonia;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigoPostal;
        private DevExpress.XtraGrid.Columns.GridColumn colciudad;
        private DevExpress.XtraGrid.Columns.GridColumn coltelefono;
        private DevExpress.XtraGrid.Columns.GridColumn colemail;
    }
}