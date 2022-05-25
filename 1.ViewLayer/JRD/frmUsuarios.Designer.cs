namespace JRD
{
    partial class frmUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuarios));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnAgregar = new DevExpress.XtraBars.BarButtonItem();
            this.btnEditar = new DevExpress.XtraBars.BarButtonItem();
            this.btnEliminar = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gcUsuarios = new DevExpress.XtraGrid.GridControl();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvUsuarios = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpassword = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colapellido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcorreo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltipoUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colactivo = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
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
            this.barDockControlTop.Size = new System.Drawing.Size(882, 34);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 588);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(882, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 34);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 554);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(882, 34);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 554);
            // 
            // gcUsuarios
            // 
            this.gcUsuarios.DataSource = this.usuarioBindingSource;
            this.gcUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcUsuarios.EmbeddedNavigator.Buttons.Append.Enabled = false;
            this.gcUsuarios.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcUsuarios.EmbeddedNavigator.Buttons.CancelEdit.Enabled = false;
            this.gcUsuarios.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcUsuarios.EmbeddedNavigator.Buttons.Edit.Enabled = false;
            this.gcUsuarios.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcUsuarios.EmbeddedNavigator.Buttons.EndEdit.Enabled = false;
            this.gcUsuarios.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcUsuarios.EmbeddedNavigator.Buttons.Remove.Enabled = false;
            this.gcUsuarios.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcUsuarios.Location = new System.Drawing.Point(0, 34);
            this.gcUsuarios.MainView = this.gvUsuarios;
            this.gcUsuarios.MenuManager = this.barManager1;
            this.gcUsuarios.Name = "gcUsuarios";
            this.gcUsuarios.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.gcUsuarios.Size = new System.Drawing.Size(882, 554);
            this.gcUsuarios.TabIndex = 9;
            this.gcUsuarios.UseEmbeddedNavigator = true;
            this.gcUsuarios.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvUsuarios});
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(BML.Usuario);
            // 
            // gvUsuarios
            // 
            this.gvUsuarios.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvUsuarios.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvUsuarios.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvUsuarios.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvUsuarios.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gvUsuarios.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvUsuarios.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidUsuario,
            this.colusuario,
            this.colpassword,
            this.colnombre,
            this.colapellido,
            this.colcorreo,
            this.coltipoUsuario,
            this.colactivo});
            this.gvUsuarios.GridControl = this.gcUsuarios;
            this.gvUsuarios.Name = "gvUsuarios";
            this.gvUsuarios.OptionsBehavior.Editable = false;
            this.gvUsuarios.OptionsCustomization.AllowColumnMoving = false;
            this.gvUsuarios.OptionsCustomization.AllowFilter = false;
            this.gvUsuarios.OptionsCustomization.AllowSort = false;
            this.gvUsuarios.OptionsView.ColumnAutoWidth = false;
            this.gvUsuarios.OptionsView.ShowAutoFilterRow = true;
            this.gvUsuarios.OptionsView.ShowGroupPanel = false;
            // 
            // colidUsuario
            // 
            this.colidUsuario.Caption = "Id Usuario";
            this.colidUsuario.FieldName = "idUsuario";
            this.colidUsuario.MinWidth = 30;
            this.colidUsuario.Name = "colidUsuario";
            this.colidUsuario.Visible = true;
            this.colidUsuario.VisibleIndex = 0;
            this.colidUsuario.Width = 112;
            // 
            // colusuario
            // 
            this.colusuario.Caption = "Usuario";
            this.colusuario.FieldName = "usuario";
            this.colusuario.MinWidth = 30;
            this.colusuario.Name = "colusuario";
            this.colusuario.Visible = true;
            this.colusuario.VisibleIndex = 1;
            this.colusuario.Width = 112;
            // 
            // colpassword
            // 
            this.colpassword.Caption = "Contraseña";
            this.colpassword.ColumnEdit = this.repositoryItemTextEdit1;
            this.colpassword.FieldName = "password";
            this.colpassword.MinWidth = 30;
            this.colpassword.Name = "colpassword";
            this.colpassword.Visible = true;
            this.colpassword.VisibleIndex = 2;
            this.colpassword.Width = 112;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            this.repositoryItemTextEdit1.UseSystemPasswordChar = true;
            // 
            // colnombre
            // 
            this.colnombre.Caption = "Nombre";
            this.colnombre.FieldName = "nombre";
            this.colnombre.MinWidth = 30;
            this.colnombre.Name = "colnombre";
            this.colnombre.Visible = true;
            this.colnombre.VisibleIndex = 3;
            this.colnombre.Width = 112;
            // 
            // colapellido
            // 
            this.colapellido.Caption = "Apellido";
            this.colapellido.FieldName = "apellido";
            this.colapellido.MinWidth = 30;
            this.colapellido.Name = "colapellido";
            this.colapellido.Visible = true;
            this.colapellido.VisibleIndex = 4;
            this.colapellido.Width = 112;
            // 
            // colcorreo
            // 
            this.colcorreo.Caption = "Correo Electronico";
            this.colcorreo.FieldName = "correo";
            this.colcorreo.MinWidth = 30;
            this.colcorreo.Name = "colcorreo";
            this.colcorreo.Visible = true;
            this.colcorreo.VisibleIndex = 5;
            this.colcorreo.Width = 112;
            // 
            // coltipoUsuario
            // 
            this.coltipoUsuario.Caption = "Tipo de Usuario";
            this.coltipoUsuario.FieldName = "tipoUsuario";
            this.coltipoUsuario.MinWidth = 30;
            this.coltipoUsuario.Name = "coltipoUsuario";
            this.coltipoUsuario.Visible = true;
            this.coltipoUsuario.VisibleIndex = 6;
            this.coltipoUsuario.Width = 112;
            // 
            // colactivo
            // 
            this.colactivo.FieldName = "activo";
            this.colactivo.MinWidth = 30;
            this.colactivo.Name = "colactivo";
            this.colactivo.Width = 112;
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 588);
            this.Controls.Add(this.gcUsuarios);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmUsuarios";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
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
        private DevExpress.XtraGrid.GridControl gcUsuarios;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gvUsuarios;
        private DevExpress.XtraGrid.Columns.GridColumn colidUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colusuario;
        private DevExpress.XtraGrid.Columns.GridColumn colpassword;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
        private DevExpress.XtraGrid.Columns.GridColumn colapellido;
        private DevExpress.XtraGrid.Columns.GridColumn colcorreo;
        private DevExpress.XtraGrid.Columns.GridColumn coltipoUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colactivo;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
    }
}