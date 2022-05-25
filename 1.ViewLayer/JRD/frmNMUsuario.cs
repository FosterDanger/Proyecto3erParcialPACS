using BML;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JRD
{
    public partial class frmNMUsuario : DevExpress.XtraEditors.XtraForm
    {
        private int idUsuario = 0;
        bool mousedown;
        private Point offset;
        public frmNMUsuario(String text)
        {
            InitializeComponent();
            (new JRD.DropShadow()).ApplyShadows(this);
            lblTitle.Text = text;
        }

        public frmNMUsuario(String text, int idUsuario)
        {
            InitializeComponent();
            (new JRD.DropShadow()).ApplyShadows(this);
            lblTitle.Text = text;
            this.idUsuario = idUsuario;

            Usuario usuario = new Usuario
            {
                idUsuario = this.idUsuario,
            }.GetById();
            txtUsuario.Text = usuario.usuario;
            txtPassword.Text = usuario.password;
            txtNombre.Text = usuario.nombre;
            txtApellido.Text = usuario.apellido;
            txtCorreo.Text = usuario.correo;
            cmbTipoUsuario.Text = usuario.tipoUsuario;
        }
        private void frmNMUsuario_Load(object sender, EventArgs e)
        {

        }

        private void panelControl3_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mousedown = true;
        }

        private void panelControl3_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);

            }
        }

        private void panelControl3_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;
        }

        private void frmNMUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = XtraMessageBox.Show("¿Estas segur@ de cerrar " + lblTitle.Text + " ?", "Mensaje", buttons, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    this.Close();
                }
                else
                {

                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = XtraMessageBox.Show("¿Estas segur@ de cerrar " + lblTitle.Text + " ?", "Mensaje", buttons, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = XtraMessageBox.Show("¿Estas segur@ de cerrar " + lblTitle.Text + " ?", "Mensaje", buttons, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {

            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidationsEmptyFields() == true)
            {
                if (idUsuario > 0)
                {
                    if (new Usuario
                    {
                        idUsuario = this.idUsuario,
                        usuario = txtUsuario.Text,
                        password = txtPassword.Text,
                        nombre = txtNombre.Text,
                        apellido = txtApellido.Text,
                        correo = txtCorreo.Text,
                        tipoUsuario = cmbTipoUsuario.Text
                    }.Update() > 0)
                    {
                        XtraMessageBox.Show("Usuario actualizado correctamente", Application.ProductName,
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("El usuario ya existe, ingresa uno diferente ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Close();
                    }

                }
                else
                {
                    if (new Usuario
                    {
                        usuario = txtUsuario.Text,
                        password = txtPassword.Text,
                        nombre = txtNombre.Text,
                        apellido = txtApellido.Text,
                        correo = txtCorreo.Text,
                        tipoUsuario = cmbTipoUsuario.Text
                    }.Add() > 0)
                    {

                        XtraMessageBox.Show("Usuario almacenado correctamente", Application.ProductName,
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cleanFields();
                    }
                    else { XtraMessageBox.Show("El usuario ya existe, ingresa uno diferente ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning); cleanFields(); }

                }
            }
        }

        public bool ValidationsEmptyFields()
        {
            if (txtUsuario.Text.Equals(""))
            {
                XtraMessageBox.Show("¡Ingresa un usuario!", Application.ProductName,
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsuario.Focus();
                return false;
            }
            else if (txtPassword.Text.Equals(""))
            {
                XtraMessageBox.Show("¡Ingresa un password!", Application.ProductName,
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPassword.Focus();
                return false;
            }
            else if (txtNombre.Text.Equals(""))
            {
                XtraMessageBox.Show("¡Ingresa un nombre!", Application.ProductName,
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNombre.Focus();
                return false;
            }
            else if (txtApellido.Text.Equals(""))
            {
                XtraMessageBox.Show("¡Ingresa un apellido!", Application.ProductName,
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtApellido.Focus();
                return false;
            }
            else if (txtCorreo.Text.Equals(""))
            {
                XtraMessageBox.Show("¡Ingresa un correo!", Application.ProductName,
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCorreo.Focus();
                return false;
            }
            else if (cmbTipoUsuario.EditValue == null)
            {
                XtraMessageBox.Show("¡Elige un tipo de Usuario!", Application.ProductName,
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbTipoUsuario.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        public void cleanFields()
        {
            txtUsuario.Text = "";
            txtPassword.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtCorreo.Text = "";
            cmbTipoUsuario.EditValue = null;
        }
    }
}