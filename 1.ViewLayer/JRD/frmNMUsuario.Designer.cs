namespace JRD
{
    partial class frmNMUsuario
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
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.lblTitle = new DevExpress.XtraEditors.LabelControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.btnMinimizar = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.txtCorreo = new DevExpress.XtraEditors.TextEdit();
            this.txtApellido = new DevExpress.XtraEditors.TextEdit();
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.txtUsuario = new DevExpress.XtraEditors.TextEdit();
            this.cmbTipoUsuario = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCorreo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtApellido.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoUsuario.Properties)).BeginInit();
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
            this.panelControl3.Size = new System.Drawing.Size(578, 47);
            this.panelControl3.TabIndex = 12;
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
            this.panelControl4.Location = new System.Drawing.Point(482, 0);
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
            // btnCancelar
            // 
            this.btnCancelar.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.btnCancelar.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.Appearance.Options.UseBackColor = true;
            this.btnCancelar.Appearance.Options.UseFont = true;
            this.btnCancelar.Location = new System.Drawing.Point(338, 615);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(157, 53);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(146)))), ((int)(((byte)(139)))));
            this.btnGuardar.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.Appearance.Options.UseBackColor = true;
            this.btnGuardar.Appearance.Options.UseFont = true;
            this.btnGuardar.Location = new System.Drawing.Point(75, 617);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(153, 51);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(109, 445);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Properties.AdvancedModeOptions.Label = "Correo";
            this.txtCorreo.Properties.AdvancedModeOptions.LabelAppearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtCorreo.Properties.AdvancedModeOptions.LabelAppearance.Options.UseFont = true;
            this.txtCorreo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCorreo.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            this.txtCorreo.Size = new System.Drawing.Size(351, 49);
            this.txtCorreo.TabIndex = 5;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(109, 356);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Properties.AdvancedModeOptions.Label = "Apellido";
            this.txtApellido.Properties.AdvancedModeOptions.LabelAppearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtApellido.Properties.AdvancedModeOptions.LabelAppearance.Options.UseFont = true;
            this.txtApellido.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellido.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            this.txtApellido.Size = new System.Drawing.Size(351, 49);
            this.txtApellido.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(109, 259);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Properties.AdvancedModeOptions.Label = "Nombre";
            this.txtNombre.Properties.AdvancedModeOptions.LabelAppearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtNombre.Properties.AdvancedModeOptions.LabelAppearance.Options.UseFont = true;
            this.txtNombre.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            this.txtNombre.Size = new System.Drawing.Size(351, 49);
            this.txtNombre.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(109, 165);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.AdvancedModeOptions.Label = "Password";
            this.txtPassword.Properties.AdvancedModeOptions.LabelAppearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtPassword.Properties.AdvancedModeOptions.LabelAppearance.Options.UseFont = true;
            this.txtPassword.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPassword.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            this.txtPassword.Properties.UseSystemPasswordChar = true;
            this.txtPassword.Size = new System.Drawing.Size(351, 49);
            this.txtPassword.TabIndex = 2;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(109, 78);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Properties.AdvancedModeOptions.Label = "Usuario";
            this.txtUsuario.Properties.AdvancedModeOptions.LabelAppearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtUsuario.Properties.AdvancedModeOptions.LabelAppearance.Options.UseFont = true;
            this.txtUsuario.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUsuario.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            this.txtUsuario.Size = new System.Drawing.Size(351, 49);
            this.txtUsuario.TabIndex = 1;
            // 
            // cmbTipoUsuario
            // 
            this.cmbTipoUsuario.Location = new System.Drawing.Point(109, 540);
            this.cmbTipoUsuario.Name = "cmbTipoUsuario";
            this.cmbTipoUsuario.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoUsuario.Properties.Appearance.Options.UseFont = true;
            this.cmbTipoUsuario.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTipoUsuario.Properties.Items.AddRange(new object[] {
            "ADMINISTRADOR",
            "CAJERO",
            "ALMACENISTA"});
            this.cmbTipoUsuario.Properties.NullValuePrompt = "Elige un tipo de Usuario";
            this.cmbTipoUsuario.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbTipoUsuario.Size = new System.Drawing.Size(351, 28);
            this.cmbTipoUsuario.TabIndex = 6;
            // 
            // frmNMUsuario
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 702);
            this.Controls.Add(this.cmbTipoUsuario);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.panelControl3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmNMUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNMUsuario";
            this.Load += new System.EventHandler(this.frmNMUsuario_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmNMUsuario_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtCorreo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtApellido.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoUsuario.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.LabelControl lblTitle;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.SimpleButton btnMinimizar;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private DevExpress.XtraEditors.TextEdit txtCorreo;
        private DevExpress.XtraEditors.TextEdit txtApellido;
        private DevExpress.XtraEditors.TextEdit txtNombre;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.TextEdit txtUsuario;
        private DevExpress.XtraEditors.ComboBoxEdit cmbTipoUsuario;
    }
}