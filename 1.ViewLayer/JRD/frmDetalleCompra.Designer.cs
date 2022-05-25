namespace JRD
{
    partial class frmDetalleCompra
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
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.lblTitle = new DevExpress.XtraEditors.LabelControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.btnMinimizar = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.gcDetalleCompra = new DevExpress.XtraGrid.GridControl();
            this.detalleEntradaCompraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvDetalleCompra = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidDetalleEntrada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcostoUnitario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidEntrada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidLibro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ruleLibro = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.libroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colidProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ruleProveedor = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.proveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDetalleCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleEntradaCompraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDetalleCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ruleLibro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ruleProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl3
            // 
            this.panelControl3.AccessibleDescription = "s";
            this.panelControl3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(130)))), ((int)(((byte)(122)))));
            this.panelControl3.Appearance.Options.UseBackColor = true;
            this.panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl3.Controls.Add(this.lblTitle);
            this.panelControl3.Controls.Add(this.panelControl4);
            this.panelControl3.Location = new System.Drawing.Point(0, 0);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1295, 47);
            this.panelControl3.TabIndex = 10;
            this.panelControl3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelControl3_MouseDown);
            this.panelControl3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelControl3_MouseMove);
            this.panelControl3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelControl3_MouseUp);
            // 
            // lblTitle
            // 
            this.lblTitle.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblTitle.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblTitle.Appearance.Options.UseFont = true;
            this.lblTitle.Appearance.Options.UseForeColor = true;
            this.lblTitle.Location = new System.Drawing.Point(26, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(129, 22);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Nueva Categoria";
            // 
            // panelControl4
            // 
            this.panelControl4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(130)))), ((int)(((byte)(122)))));
            this.panelControl4.Appearance.Options.UseBackColor = true;
            this.panelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl4.Controls.Add(this.btnMinimizar);
            this.panelControl4.Controls.Add(this.btnClose);
            this.panelControl4.Location = new System.Drawing.Point(1199, 0);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(96, 48);
            this.panelControl4.TabIndex = 7;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.AllowFocus = false;
            this.btnMinimizar.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(130)))), ((int)(((byte)(122)))));
            this.btnMinimizar.Appearance.BorderColor = System.Drawing.Color.White;
            this.btnMinimizar.Appearance.Options.UseBackColor = true;
            this.btnMinimizar.Appearance.Options.UseBorderColor = true;
            this.btnMinimizar.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(170)))), ((int)(((byte)(146)))));
            this.btnMinimizar.AppearanceHovered.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.btnMinimizar.AppearanceHovered.Options.UseBackColor = true;
            this.btnMinimizar.ImageOptions.Image = global::JRD.Properties.Resources.Minimizar;
            this.btnMinimizar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.BottomCenter;
            this.btnMinimizar.Location = new System.Drawing.Point(0, 0);
            this.btnMinimizar.LookAndFeel.SkinName = "Office 2019 Dark Gray";
            this.btnMinimizar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.btnMinimizar.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(48, 48);
            this.btnMinimizar.TabIndex = 9;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnClose
            // 
            this.btnClose.AllowFocus = false;
            this.btnClose.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(130)))), ((int)(((byte)(122)))));
            this.btnClose.Appearance.BorderColor = System.Drawing.Color.White;
            this.btnClose.Appearance.Options.UseBackColor = true;
            this.btnClose.Appearance.Options.UseBorderColor = true;
            this.btnClose.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.btnClose.AppearanceHovered.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.btnClose.AppearanceHovered.Options.UseBackColor = true;
            this.btnClose.ImageOptions.Image = global::JRD.Properties.Resources.close5;
            this.btnClose.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnClose.Location = new System.Drawing.Point(48, 0);
            this.btnClose.LookAndFeel.SkinName = "Office 2019 Dark Gray";
            this.btnClose.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.btnClose.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(48, 48);
            this.btnClose.TabIndex = 7;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gcDetalleCompra
            // 
            this.gcDetalleCompra.DataSource = this.detalleEntradaCompraBindingSource;
            this.gcDetalleCompra.EmbeddedNavigator.Buttons.Append.Enabled = false;
            this.gcDetalleCompra.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcDetalleCompra.EmbeddedNavigator.Buttons.CancelEdit.Enabled = false;
            this.gcDetalleCompra.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcDetalleCompra.EmbeddedNavigator.Buttons.Edit.Enabled = false;
            this.gcDetalleCompra.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcDetalleCompra.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcDetalleCompra.EmbeddedNavigator.Buttons.Remove.Enabled = false;
            this.gcDetalleCompra.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcDetalleCompra.Location = new System.Drawing.Point(26, 84);
            this.gcDetalleCompra.MainView = this.gvDetalleCompra;
            this.gcDetalleCompra.Name = "gcDetalleCompra";
            this.gcDetalleCompra.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ruleLibro,
            this.ruleProveedor});
            this.gcDetalleCompra.Size = new System.Drawing.Size(1243, 443);
            this.gcDetalleCompra.TabIndex = 11;
            this.gcDetalleCompra.UseEmbeddedNavigator = true;
            this.gcDetalleCompra.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDetalleCompra});
            // 
            // detalleEntradaCompraBindingSource
            // 
            this.detalleEntradaCompraBindingSource.DataSource = typeof(BML.DetalleEntradaCompra);
            // 
            // gvDetalleCompra
            // 
            this.gvDetalleCompra.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvDetalleCompra.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvDetalleCompra.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvDetalleCompra.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvDetalleCompra.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidDetalleEntrada,
            this.colcostoUnitario,
            this.colcantidad,
            this.colidEntrada,
            this.colidLibro,
            this.colidProveedor});
            this.gvDetalleCompra.GridControl = this.gcDetalleCompra;
            this.gvDetalleCompra.Name = "gvDetalleCompra";
            this.gvDetalleCompra.OptionsBehavior.Editable = false;
            this.gvDetalleCompra.OptionsCustomization.AllowColumnMoving = false;
            this.gvDetalleCompra.OptionsCustomization.AllowFilter = false;
            this.gvDetalleCompra.OptionsCustomization.AllowGroup = false;
            this.gvDetalleCompra.OptionsCustomization.AllowSort = false;
            this.gvDetalleCompra.OptionsView.ColumnAutoWidth = false;
            this.gvDetalleCompra.OptionsView.ShowAutoFilterRow = true;
            this.gvDetalleCompra.OptionsView.ShowGroupPanel = false;
            // 
            // colidDetalleEntrada
            // 
            this.colidDetalleEntrada.Caption = "Id Detalle Compra";
            this.colidDetalleEntrada.FieldName = "idDetalleEntrada";
            this.colidDetalleEntrada.MinWidth = 30;
            this.colidDetalleEntrada.Name = "colidDetalleEntrada";
            this.colidDetalleEntrada.Visible = true;
            this.colidDetalleEntrada.VisibleIndex = 0;
            this.colidDetalleEntrada.Width = 112;
            // 
            // colcostoUnitario
            // 
            this.colcostoUnitario.Caption = "Costo Unitario";
            this.colcostoUnitario.FieldName = "costoUnitario";
            this.colcostoUnitario.MinWidth = 30;
            this.colcostoUnitario.Name = "colcostoUnitario";
            this.colcostoUnitario.Visible = true;
            this.colcostoUnitario.VisibleIndex = 1;
            this.colcostoUnitario.Width = 112;
            // 
            // colcantidad
            // 
            this.colcantidad.Caption = "Cantidad";
            this.colcantidad.FieldName = "cantidad";
            this.colcantidad.MinWidth = 30;
            this.colcantidad.Name = "colcantidad";
            this.colcantidad.Visible = true;
            this.colcantidad.VisibleIndex = 2;
            this.colcantidad.Width = 112;
            // 
            // colidEntrada
            // 
            this.colidEntrada.Caption = "Id Compra";
            this.colidEntrada.FieldName = "idEntrada";
            this.colidEntrada.MinWidth = 30;
            this.colidEntrada.Name = "colidEntrada";
            this.colidEntrada.Visible = true;
            this.colidEntrada.VisibleIndex = 3;
            this.colidEntrada.Width = 112;
            // 
            // colidLibro
            // 
            this.colidLibro.Caption = "Libro";
            this.colidLibro.ColumnEdit = this.ruleLibro;
            this.colidLibro.FieldName = "idLibro";
            this.colidLibro.MinWidth = 30;
            this.colidLibro.Name = "colidLibro";
            this.colidLibro.Visible = true;
            this.colidLibro.VisibleIndex = 4;
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
            // colidProveedor
            // 
            this.colidProveedor.Caption = "Proveedor";
            this.colidProveedor.ColumnEdit = this.ruleProveedor;
            this.colidProveedor.FieldName = "idProveedor";
            this.colidProveedor.MinWidth = 30;
            this.colidProveedor.Name = "colidProveedor";
            this.colidProveedor.Visible = true;
            this.colidProveedor.VisibleIndex = 5;
            this.colidProveedor.Width = 112;
            // 
            // ruleProveedor
            // 
            this.ruleProveedor.AutoHeight = false;
            this.ruleProveedor.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ruleProveedor.DataSource = this.proveedorBindingSource;
            this.ruleProveedor.DisplayMember = "nombreProveedor";
            this.ruleProveedor.Name = "ruleProveedor";
            this.ruleProveedor.ValueMember = "idProveedor";
            // 
            // proveedorBindingSource
            // 
            this.proveedorBindingSource.DataSource = typeof(BML.Proveedor);
            // 
            // frmDetalleCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 557);
            this.Controls.Add(this.gcDetalleCompra);
            this.Controls.Add(this.panelControl3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmDetalleCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDetalleCompra";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDetalleCompra_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDetalleCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleEntradaCompraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDetalleCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ruleLibro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ruleProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.LabelControl lblTitle;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.SimpleButton btnMinimizar;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraGrid.GridControl gcDetalleCompra;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDetalleCompra;
        private System.Windows.Forms.BindingSource detalleEntradaCompraBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colidDetalleEntrada;
        private DevExpress.XtraGrid.Columns.GridColumn colcostoUnitario;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colidEntrada;
        private DevExpress.XtraGrid.Columns.GridColumn colidLibro;
        private DevExpress.XtraGrid.Columns.GridColumn colidProveedor;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ruleLibro;
        private System.Windows.Forms.BindingSource libroBindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ruleProveedor;
        private System.Windows.Forms.BindingSource proveedorBindingSource;
    }
}