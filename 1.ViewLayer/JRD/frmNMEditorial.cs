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
    public partial class frmNMEditorial : DevExpress.XtraEditors.XtraForm
    {
        private int idEditorial = 0;
        bool mousedown;
        private Point offset;
        public frmNMEditorial(String text)
        {
            InitializeComponent();
            (new JRD.DropShadow()).ApplyShadows(this);
            lblTitle.Text = text;
        }

        public frmNMEditorial(String text, int idEditorial)
        {
            InitializeComponent();
            (new JRD.DropShadow()).ApplyShadows(this);
            lblTitle.Text = text;
            this.idEditorial = idEditorial;

            Editorial editorial = new Editorial
            {
                idEditorial = this.idEditorial,
            }.GetById();
            txtNombre.Text = editorial.nombre;
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidationsEmptyFields() == true)
            {
                if (idEditorial > 0)
                {
                    if (new Editorial
                    {
                        idEditorial = this.idEditorial,
                        nombre = txtNombre.Text
                    }.Update() > 0)
                    {
                        XtraMessageBox.Show("Editorial actualizada correctamente", Application.ProductName,
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("El registro ya existe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cleanFields();
                    }

                }
                else
                {
                    if (new Editorial
                    {
                        nombre = txtNombre.Text
                    }.Add() > 0)
                    {

                        XtraMessageBox.Show("Editorial almacenada correctamente", Application.ProductName,
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
                XtraMessageBox.Show("¡Ingresa una Editorial!", Application.ProductName,
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNombre.Focus();
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

        private void frmNMEditorial_KeyDown(object sender, KeyEventArgs e)
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