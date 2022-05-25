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
    public partial class frmNMAutor : DevExpress.XtraEditors.XtraForm
    {
        private int idAutor = 0;
        bool mousedown;
        private Point offset;
        public frmNMAutor(String text)
        {
            InitializeComponent();
            (new JRD.DropShadow()).ApplyShadows(this);
            lblTitle.Text = text;
        }

        public frmNMAutor(String text, int idAutor)
        {
            InitializeComponent();
            (new JRD.DropShadow()).ApplyShadows(this);
            lblTitle.Text = text;
            this.idAutor = idAutor;
            Autor autor = new Autor
            {
                idAutor = this.idAutor,
            }.GetById();
            txtNombre.Text = autor.nombre;
            txtNacionalidad.Text = autor.nacionalidad;
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

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }
        public void cleanFields()
        {
            txtNombre.Text = "";
            txtNacionalidad.Text = "";
        }

        public bool ValidationsEmptyFields()
        {
            if (txtNombre.Text.Equals(""))
            {
                XtraMessageBox.Show("¡Ingresa una Nombre!", Application.ProductName,
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNombre.Focus();
                return false;
            }
            else if (txtNacionalidad.Text.Equals(""))
            {
                XtraMessageBox.Show("¡Ingresa una Nacionalidad!", Application.ProductName,
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNacionalidad.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (ValidationsEmptyFields() == true)
            {
                if (idAutor > 0)
                {
                    if (new Autor
                    {
                        idAutor = this.idAutor,
                        nombre = txtNombre.Text,
                        nacionalidad = txtNacionalidad.Text
                    }.Update() > 0)
                    {
                        XtraMessageBox.Show("Autor actualizado correctamente", Application.ProductName,
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
                    if (new Autor
                    {
                        nombre = txtNombre.Text,
                        nacionalidad = txtNacionalidad.Text
                    }.Add() > 0)
                    {

                        XtraMessageBox.Show("Autor almacenado correctamente", Application.ProductName,
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cleanFields();
                    }
                    else { XtraMessageBox.Show("El registro ya existe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning); cleanFields(); }

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

        private void frmNMAutor_KeyDown(object sender, KeyEventArgs e)
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
    }
}