namespace JRD
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnEntrar = new JRD.CustomSimpleButton();
            this.iblErrorMessage = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.txtUsuario = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft PhagsPa", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(130)))), ((int)(((byte)(122)))));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(77, 248);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(288, 37);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Sign in to Library Bird";
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(130)))), ((int)(((byte)(122)))));
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Location = new System.Drawing.Point(45, 367);
            this.panelControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(357, 4);
            this.panelControl1.TabIndex = 2;
            // 
            // panelControl2
            // 
            this.panelControl2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(130)))), ((int)(((byte)(122)))));
            this.panelControl2.Appearance.Options.UseBackColor = true;
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Location = new System.Drawing.Point(44, 459);
            this.panelControl2.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(355, 4);
            this.panelControl2.TabIndex = 3;
            // 
            // panelControl3
            // 
            this.panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl3.Controls.Add(this.panelControl4);
            this.panelControl3.Location = new System.Drawing.Point(0, 0);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(451, 52);
            this.panelControl3.TabIndex = 6;
            this.panelControl3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDown);
            this.panelControl3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMove);
            this.panelControl3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouseUp);
            // 
            // panelControl4
            // 
            this.panelControl4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(130)))), ((int)(((byte)(122)))));
            this.panelControl4.Appearance.Options.UseBackColor = true;
            this.panelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl4.Controls.Add(this.simpleButton1);
            this.panelControl4.Location = new System.Drawing.Point(355, 0);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(96, 48);
            this.panelControl4.TabIndex = 7;
            // 
            // simpleButton1
            // 
            this.simpleButton1.AllowFocus = false;
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(130)))), ((int)(((byte)(122)))));
            this.simpleButton1.Appearance.BorderColor = System.Drawing.Color.White;
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseBorderColor = true;
            this.simpleButton1.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.simpleButton1.AppearanceHovered.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.simpleButton1.AppearanceHovered.Options.UseBackColor = true;
            this.simpleButton1.ImageOptions.Image = global::JRD.Properties.Resources.close5;
            this.simpleButton1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.simpleButton1.Location = new System.Drawing.Point(48, 0);
            this.simpleButton1.LookAndFeel.SkinName = "Office 2019 Dark Gray";
            this.simpleButton1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.simpleButton1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(48, 48);
            this.simpleButton1.TabIndex = 7;
            this.simpleButton1.Click += new System.EventHandler(this.close);
            // 
            // btnEntrar
            // 
            this.btnEntrar.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(204)))), ((int)(((byte)(172)))));
            this.btnEntrar.Appearance.Font = new System.Drawing.Font("Nirmala UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnEntrar.Appearance.Options.UseBackColor = true;
            this.btnEntrar.Appearance.Options.UseFont = true;
            this.btnEntrar.Appearance.Options.UseForeColor = true;
            this.btnEntrar.Location = new System.Drawing.Point(40, 510);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnEntrar.Size = new System.Drawing.Size(359, 63);
            this.btnEntrar.TabIndex = 3;
            this.btnEntrar.Text = "Sign in";
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // iblErrorMessage
            // 
            this.iblErrorMessage.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.iblErrorMessage.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.iblErrorMessage.Appearance.Options.UseFont = true;
            this.iblErrorMessage.Appearance.Options.UseForeColor = true;
            this.iblErrorMessage.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.iblErrorMessage.ImageOptions.Image = global::JRD.Properties.Resources.error2;
            this.iblErrorMessage.Location = new System.Drawing.Point(45, 485);
            this.iblErrorMessage.Name = "iblErrorMessage";
            this.iblErrorMessage.Size = new System.Drawing.Size(38, 25);
            this.iblErrorMessage.TabIndex = 9;
            this.iblErrorMessage.Text = "Error";
            this.iblErrorMessage.Visible = false;
            // 
            // simpleButton2
            // 
            this.simpleButton2.AllowFocus = false;
            this.simpleButton2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(130)))), ((int)(((byte)(122)))));
            this.simpleButton2.Appearance.BorderColor = System.Drawing.Color.White;
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.Appearance.Options.UseBorderColor = true;
            this.simpleButton2.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(170)))), ((int)(((byte)(146)))));
            this.simpleButton2.AppearanceHovered.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.simpleButton2.AppearanceHovered.Options.UseBackColor = true;
            this.simpleButton2.ImageOptions.Image = global::JRD.Properties.Resources.Minimizar;
            this.simpleButton2.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.BottomCenter;
            this.simpleButton2.Location = new System.Drawing.Point(355, 0);
            this.simpleButton2.LookAndFeel.SkinName = "Office 2019 Dark Gray";
            this.simpleButton2.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.simpleButton2.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(48, 48);
            this.simpleButton2.TabIndex = 8;
            this.simpleButton2.Click += new System.EventHandler(this.minimizar);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(45, 403);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.AdvancedModeOptions.Label = "Password";
            this.txtPassword.Properties.AdvancedModeOptions.LabelAppearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtPassword.Properties.AdvancedModeOptions.LabelAppearance.Options.UseFont = true;
            this.txtPassword.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtPassword.Properties.Appearance.Options.UseBackColor = true;
            this.txtPassword.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtPassword.Properties.ContextImageOptions.Image = global::JRD.Properties.Resources.password;
            this.txtPassword.Properties.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.txtPassword.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            this.txtPassword.Properties.UseSystemPasswordChar = true;
            this.txtPassword.Size = new System.Drawing.Size(358, 47);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtChangedPassword);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(40, 311);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Properties.AdvancedModeOptions.Label = "Username";
            this.txtUsuario.Properties.AdvancedModeOptions.LabelAppearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtUsuario.Properties.AdvancedModeOptions.LabelAppearance.Options.UseFont = true;
            this.txtUsuario.Properties.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.txtUsuario.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtUsuario.Properties.Appearance.Options.UseBackColor = true;
            this.txtUsuario.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtUsuario.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUsuario.Properties.ContextImageOptions.AllowChangeAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.txtUsuario.Properties.ContextImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.txtUsuario.Properties.ContextImageOptions.Image = global::JRD.Properties.Resources.user3;
            this.txtUsuario.Properties.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.txtUsuario.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            this.txtUsuario.Size = new System.Drawing.Size(363, 47);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtChanged);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::JRD.Properties.Resources.Logo;
            this.pictureEdit1.Location = new System.Drawing.Point(136, 65);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.AllowFocused = false;
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(172, 177);
            this.pictureEdit1.TabIndex = 0;
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnEntrar;
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 635);
            this.Controls.Add(this.iblErrorMessage);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.pictureEdit1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmLogin.IconOptions.SvgImage")));
            this.InactiveGlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.KeyPreview = true;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDown);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
       
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.TextEdit txtUsuario;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private CustomSimpleButton btnEntrar;
        private DevExpress.XtraEditors.LabelControl iblErrorMessage;
    }
}