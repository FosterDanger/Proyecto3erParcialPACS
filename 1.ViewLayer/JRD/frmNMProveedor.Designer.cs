namespace JRD
{
    partial class frmNMProveedor
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
            this.txtNombreProveedor = new DevExpress.XtraEditors.TextEdit();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.lblTitle = new DevExpress.XtraEditors.LabelControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.btnMinimizar = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.txtNombreContacto = new DevExpress.XtraEditors.TextEdit();
            this.txtCargoContacto = new DevExpress.XtraEditors.TextEdit();
            this.txtCalle = new DevExpress.XtraEditors.TextEdit();
            this.txtColonia = new DevExpress.XtraEditors.TextEdit();
            this.txtCP = new DevExpress.XtraEditors.TextEdit();
            this.txtCiudad = new DevExpress.XtraEditors.TextEdit();
            this.txtTelefono = new DevExpress.XtraEditors.TextEdit();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreProveedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreContacto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCargoContacto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCalle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtColonia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCiudad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombreProveedor
            // 
            this.txtNombreProveedor.Location = new System.Drawing.Point(47, 88);
            this.txtNombreProveedor.Name = "txtNombreProveedor";
            this.txtNombreProveedor.Properties.AdvancedModeOptions.Label = "Nombre del Proveedor";
            this.txtNombreProveedor.Properties.AdvancedModeOptions.LabelAppearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtNombreProveedor.Properties.AdvancedModeOptions.LabelAppearance.Options.UseFont = true;
            this.txtNombreProveedor.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreProveedor.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            this.txtNombreProveedor.Size = new System.Drawing.Size(351, 49);
            this.txtNombreProveedor.TabIndex = 1;
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
            this.panelControl3.Size = new System.Drawing.Size(907, 47);
            this.panelControl3.TabIndex = 13;
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
            this.panelControl4.Location = new System.Drawing.Point(811, 0);
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
            // txtNombreContacto
            // 
            this.txtNombreContacto.Location = new System.Drawing.Point(47, 190);
            this.txtNombreContacto.Name = "txtNombreContacto";
            this.txtNombreContacto.Properties.AdvancedModeOptions.Label = "Nombre del Contacto";
            this.txtNombreContacto.Properties.AdvancedModeOptions.LabelAppearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtNombreContacto.Properties.AdvancedModeOptions.LabelAppearance.Options.UseFont = true;
            this.txtNombreContacto.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreContacto.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            this.txtNombreContacto.Size = new System.Drawing.Size(351, 49);
            this.txtNombreContacto.TabIndex = 2;
            // 
            // txtCargoContacto
            // 
            this.txtCargoContacto.Location = new System.Drawing.Point(47, 295);
            this.txtCargoContacto.Name = "txtCargoContacto";
            this.txtCargoContacto.Properties.AdvancedModeOptions.Label = "Cargo del Contacto";
            this.txtCargoContacto.Properties.AdvancedModeOptions.LabelAppearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtCargoContacto.Properties.AdvancedModeOptions.LabelAppearance.Options.UseFont = true;
            this.txtCargoContacto.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCargoContacto.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            this.txtCargoContacto.Size = new System.Drawing.Size(351, 49);
            this.txtCargoContacto.TabIndex = 3;
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(47, 400);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Properties.AdvancedModeOptions.Label = "Calle";
            this.txtCalle.Properties.AdvancedModeOptions.LabelAppearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtCalle.Properties.AdvancedModeOptions.LabelAppearance.Options.UseFont = true;
            this.txtCalle.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCalle.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            this.txtCalle.Size = new System.Drawing.Size(351, 49);
            this.txtCalle.TabIndex = 4;
            // 
            // txtColonia
            // 
            this.txtColonia.Location = new System.Drawing.Point(47, 505);
            this.txtColonia.Name = "txtColonia";
            this.txtColonia.Properties.AdvancedModeOptions.Label = "Colonia";
            this.txtColonia.Properties.AdvancedModeOptions.LabelAppearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtColonia.Properties.AdvancedModeOptions.LabelAppearance.Options.UseFont = true;
            this.txtColonia.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtColonia.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            this.txtColonia.Size = new System.Drawing.Size(351, 49);
            this.txtColonia.TabIndex = 5;
            // 
            // txtCP
            // 
            this.txtCP.Location = new System.Drawing.Point(508, 88);
            this.txtCP.Name = "txtCP";
            this.txtCP.Properties.AdvancedModeOptions.Label = "Codigo Postal";
            this.txtCP.Properties.AdvancedModeOptions.LabelAppearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtCP.Properties.AdvancedModeOptions.LabelAppearance.Options.UseFont = true;
            this.txtCP.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCP.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.txtCP.Properties.MaskSettings.Set("mask", "\\d+");
            this.txtCP.Properties.MaxLength = 5;
            this.txtCP.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            this.txtCP.Size = new System.Drawing.Size(351, 49);
            this.txtCP.TabIndex = 6;
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(508, 190);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Properties.AdvancedModeOptions.Label = "Ciudad";
            this.txtCiudad.Properties.AdvancedModeOptions.LabelAppearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtCiudad.Properties.AdvancedModeOptions.LabelAppearance.Options.UseFont = true;
            this.txtCiudad.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCiudad.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            this.txtCiudad.Size = new System.Drawing.Size(351, 49);
            this.txtCiudad.TabIndex = 7;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(508, 295);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Properties.AdvancedModeOptions.Label = "Telefono";
            this.txtTelefono.Properties.AdvancedModeOptions.LabelAppearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtTelefono.Properties.AdvancedModeOptions.LabelAppearance.Options.UseFont = true;
            this.txtTelefono.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTelefono.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.SimpleMaskManager));
            this.txtTelefono.Properties.MaskSettings.Set("MaskManagerSignature", "ignoreMaskBlank=True");
            this.txtTelefono.Properties.MaskSettings.Set("mask", "(000) 000-0000");
            this.txtTelefono.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            this.txtTelefono.Size = new System.Drawing.Size(351, 49);
            this.txtTelefono.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(508, 400);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Properties.AdvancedModeOptions.Label = "Email";
            this.txtEmail.Properties.AdvancedModeOptions.LabelAppearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtEmail.Properties.AdvancedModeOptions.LabelAppearance.Options.UseFont = true;
            this.txtEmail.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmail.Properties.MaxLength = 20;
            this.txtEmail.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            this.txtEmail.Size = new System.Drawing.Size(351, 49);
            this.txtEmail.TabIndex = 9;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.btnCancelar.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.Appearance.Options.UseBackColor = true;
            this.btnCancelar.Appearance.Options.UseFont = true;
            this.btnCancelar.Location = new System.Drawing.Point(534, 620);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(202, 53);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(146)))), ((int)(((byte)(139)))));
            this.btnGuardar.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.Appearance.Options.UseBackColor = true;
            this.btnGuardar.Appearance.Options.UseFont = true;
            this.btnGuardar.Location = new System.Drawing.Point(160, 620);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(202, 51);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmNMProveedor
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 715);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtCiudad);
            this.Controls.Add(this.txtCP);
            this.Controls.Add(this.txtColonia);
            this.Controls.Add(this.txtCalle);
            this.Controls.Add(this.txtCargoContacto);
            this.Controls.Add(this.txtNombreContacto);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.txtNombreProveedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmNMProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNMProveedor";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmNMProveedor_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreProveedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreContacto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCargoContacto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCalle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtColonia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCiudad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtNombreProveedor;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.LabelControl lblTitle;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.SimpleButton btnMinimizar;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.TextEdit txtNombreContacto;
        private DevExpress.XtraEditors.TextEdit txtCargoContacto;
        private DevExpress.XtraEditors.TextEdit txtCalle;
        private DevExpress.XtraEditors.TextEdit txtColonia;
        private DevExpress.XtraEditors.TextEdit txtCP;
        private DevExpress.XtraEditors.TextEdit txtCiudad;
        private DevExpress.XtraEditors.TextEdit txtTelefono;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
    }
}