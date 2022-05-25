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
    public partial class frmNMEstudiante : DevExpress.XtraEditors.XtraForm
    {

        private int idEstudiante = 0;
        bool mousedown;
        private Point offset;

        public frmNMEstudiante(String text)
        {
            InitializeComponent();
            (new JRD.DropShadow()).ApplyShadows(this);
            lblTitle.Text = text;
        }

        public frmNMEstudiante(String text, int idEstudiante)
        {
            InitializeComponent();
            (new JRD.DropShadow()).ApplyShadows(this);
            lblTitle.Text = text;
            this.idEstudiante = idEstudiante;

            Estudiante estudiante = new Estudiante
            {
                idEstudiante = this.idEstudiante,
            }.GetById();
            txtNombre.Text = estudiante.nombre;
            txtApellido.Text = estudiante.apellido;
            txtNumControl.Text = estudiante.numControl;
            txtTelefono.Text = estudiante.telefono;
            txtCorreo.Text = estudiante.correoElectronico;
        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
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

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidationsEmptyFields() == true)
            {
                if (idEstudiante > 0)
                {
                    if (new Estudiante
                    {
                        idEstudiante = this.idEstudiante,
                        nombre = txtNombre.Text,
                        apellido = txtApellido.Text,
                        numControl = txtNumControl.Text,
                        telefono = txtTelefono.Text,
                        correoElectronico = txtCorreo.Text
                    }.Update() > 0)
                    {
                        XtraMessageBox.Show("Estudiante actualizado correctamente", Application.ProductName,
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("El registro ya existe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Close();
                    }

                }
                else
                {
                    if (new Estudiante
                    {
                        nombre = txtNombre.Text,
                        apellido = txtApellido.Text,
                        numControl = txtNumControl.Text,
                        telefono = txtTelefono.Text,
                        correoElectronico = txtCorreo.Text
                    }.Add() > 0)
                    {

                        XtraMessageBox.Show("Estudiante almacenado correctamente", Application.ProductName,
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cleanFields();
                    }
                    else { XtraMessageBox.Show("El registro ya existe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning); cleanFields(); }

                }
            }
        }

        public bool ValidationsEmptyFields()
        {
            if (txtNombre.Text.Equals(""))
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
            else if (txtNumControl.Text.Equals(""))
            {
                XtraMessageBox.Show("¡Ingresa un numero de control!", Application.ProductName,
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNumControl.Focus();
                return false;
            }
            else if (txtTelefono.Text.Equals(""))
            {
                XtraMessageBox.Show("¡Ingresa un telefono!", Application.ProductName,
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTelefono.Focus();
                return false;
            }
            else if (txtCorreo.Text.Equals(""))
            {
                XtraMessageBox.Show("¡Ingresa un correo!", Application.ProductName,
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCorreo.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        public void cleanFields()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtNumControl.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
        }

        private void frmNMEstudiante_KeyDown(object sender, KeyEventArgs e)
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

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) 
                && e.KeyChar != (char)44)
            {
                e.Handled = true;
                return;
            }
        }
    }
}