namespace JRD
{
    partial class frmDetalleVentas
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
            this.gcDetalleVenta = new DevExpress.XtraGrid.GridControl();
            this.detalleVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvDetalleVenta = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidDetalleVenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidVenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidLibro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ruleLibro = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.libroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colcantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colimporte = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDetalleVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleVentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDetalleVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ruleLibro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libroBindingSource)).BeginInit();
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
            this.panelControl3.TabIndex = 11;
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
            // gcDetalleVenta
            // 
            this.gcDetalleVenta.DataSource = this.detalleVentaBindingSource;
            this.gcDetalleVenta.EmbeddedNavigator.Buttons.Append.Enabled = false;
            this.gcDetalleVenta.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcDetalleVenta.EmbeddedNavigator.Buttons.CancelEdit.Enabled = false;
            this.gcDetalleVenta.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcDetalleVenta.EmbeddedNavigator.Buttons.Edit.Enabled = false;
            this.gcDetalleVenta.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcDetalleVenta.EmbeddedNavigator.Buttons.EndEdit.Enabled = false;
            this.gcDetalleVenta.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcDetalleVenta.EmbeddedNavigator.Buttons.Remove.Enabled = false;
            this.gcDetalleVenta.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcDetalleVenta.Location = new System.Drawing.Point(26, 79);
            this.gcDetalleVenta.MainView = this.gvDetalleVenta;
            this.gcDetalleVenta.Name = "gcDetalleVenta";
            this.gcDetalleVenta.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ruleLibro});
            this.gcDetalleVenta.Size = new System.Drawing.Size(1255, 407);
            this.gcDetalleVenta.TabIndex = 12;
            this.gcDetalleVenta.UseEmbeddedNavigator = true;
            this.gcDetalleVenta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDetalleVenta});
            // 
            // detalleVentaBindingSource
            // 
            this.detalleVentaBindingSource.DataSource = typeof(BML.DetalleVenta);
            // 
            // gvDetalleVenta
            // 
            this.gvDetalleVenta.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvDetalleVenta.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvDetalleVenta.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvDetalleVenta.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvDetalleVenta.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gvDetalleVenta.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvDetalleVenta.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidDetalleVenta,
            this.colidVenta,
            this.colidLibro,
            this.colcantidad,
            this.colprecio,
            this.colimporte});
            this.gvDetalleVenta.GridControl = this.gcDetalleVenta;
            this.gvDetalleVenta.Name = "gvDetalleVenta";
            this.gvDetalleVenta.OptionsBehavior.Editable = false;
            this.gvDetalleVenta.OptionsCustomization.AllowColumnMoving = false;
            this.gvDetalleVenta.OptionsCustomization.AllowFilter = false;
            this.gvDetalleVenta.OptionsCustomization.AllowGroup = false;
            this.gvDetalleVenta.OptionsCustomization.AllowRowSizing = true;
            this.gvDetalleVenta.OptionsCustomization.AllowSort = false;
            this.gvDetalleVenta.OptionsView.ColumnAutoWidth = false;
            this.gvDetalleVenta.OptionsView.ShowAutoFilterRow = true;
            this.gvDetalleVenta.OptionsView.ShowGroupPanel = false;
            // 
            // colidDetalleVenta
            // 
            this.colidDetalleVenta.Caption = "Id Detalle Venta";
            this.colidDetalleVenta.FieldName = "idDetalleVenta";
            this.colidDetalleVenta.MinWidth = 30;
            this.colidDetalleVenta.Name = "colidDetalleVenta";
            this.colidDetalleVenta.Visible = true;
            this.colidDetalleVenta.VisibleIndex = 0;
            this.colidDetalleVenta.Width = 112;
            // 
            // colidVenta
            // 
            this.colidVenta.Caption = "Id Venta";
            this.colidVenta.FieldName = "idVenta";
            this.colidVenta.MinWidth = 30;
            this.colidVenta.Name = "colidVenta";
            this.colidVenta.Visible = true;
            this.colidVenta.VisibleIndex = 1;
            this.colidVenta.Width = 112;
            // 
            // colidLibro
            // 
            this.colidLibro.Caption = "Libro";
            this.colidLibro.ColumnEdit = this.ruleLibro;
            this.colidLibro.FieldName = "idLibro";
            this.colidLibro.MinWidth = 30;
            this.colidLibro.Name = "colidLibro";
            this.colidLibro.Visible = true;
            this.colidLibro.VisibleIndex = 2;
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
            // colcantidad
            // 
            this.colcantidad.Caption = "Cantidad";
            this.colcantidad.FieldName = "cantidad";
            this.colcantidad.MinWidth = 30;
            this.colcantidad.Name = "colcantidad";
            this.colcantidad.Visible = true;
            this.colcantidad.VisibleIndex = 3;
            this.colcantidad.Width = 112;
            // 
            // colprecio
            // 
            this.colprecio.Caption = "Precio";
            this.colprecio.FieldName = "precio";
            this.colprecio.MinWidth = 30;
            this.colprecio.Name = "colprecio";
            this.colprecio.Visible = true;
            this.colprecio.VisibleIndex = 4;
            this.colprecio.Width = 112;
            // 
            // colimporte
            // 
            this.colimporte.Caption = "Importe";
            this.colimporte.FieldName = "importe";
            this.colimporte.MinWidth = 30;
            this.colimporte.Name = "colimporte";
            this.colimporte.Visible = true;
            this.colimporte.VisibleIndex = 5;
            this.colimporte.Width = 112;
            // 
            // frmDetalleVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 510);
            this.Controls.Add(this.gcDetalleVenta);
            this.Controls.Add(this.panelControl3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmDetalleVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDetalleVentas";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDetalleVentas_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDetalleVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleVentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDetalleVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ruleLibro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libroBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.LabelControl lblTitle;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.SimpleButton btnMinimizar;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraGrid.GridControl gcDetalleVenta;
        private System.Windows.Forms.BindingSource detalleVentaBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDetalleVenta;
        private DevExpress.XtraGrid.Columns.GridColumn colidDetalleVenta;
        private DevExpress.XtraGrid.Columns.GridColumn colidVenta;
        private DevExpress.XtraGrid.Columns.GridColumn colidLibro;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colprecio;
        private DevExpress.XtraGrid.Columns.GridColumn colimporte;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ruleLibro;
        private System.Windows.Forms.BindingSource libroBindingSource;
    }
}