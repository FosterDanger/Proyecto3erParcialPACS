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
    public partial class frmNMCategoria : DevExpress.XtraEditors.XtraForm
    {
        private int idCategoria = 0;
        bool mousedown;
        private Point offset;
        public frmNMCategoria(String text)
        {
            InitializeComponent();
            (new JRD.DropShadow()).ApplyShadows(this);
            lblTitle.Text = text;   
        }

        public frmNMCategoria(String text ,int idCategoria)
        {
            InitializeComponent();
            (new JRD.DropShadow()).ApplyShadows(this);
            lblTitle.Text = text;
            this.idCategoria = idCategoria;
      
            Categoria categoria = new Categoria
            {
                idCategoria = this.idCategoria,
            }.GetById();
            txtDescripcion.Text = categoria.descripcion; 
        }

        private void mouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mousedown = true;
        }

        private void mouseMove(object sender, MouseEventArgs e)
        {
            if (mousedown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);

            }
        }

        private void moseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            if (ValidationsEmptyFields() == true)
            {
                if (idCategoria > 0)
                {
                    if (new Categoria
                    {
                        idCategoria = this.idCategoria,
                        descripcion = txtDescripcion.Text
                    }.Update() > 0)
                    {
                        XtraMessageBox.Show("Categoria actualizada correctamente", Application.ProductName,
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
                    if (new Categoria
                    {
                        descripcion = txtDescripcion.Text
                    }.Add() > 0)
                    {

                        XtraMessageBox.Show("Categoria almacenada correctamente", Application.ProductName,
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cleanFields();
                    }
                    else { XtraMessageBox.Show("El registro ya existe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning); cleanFields(); }

                }
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = XtraMessageBox.Show("¿Estas segur@ de cerrar "  + lblTitle.Text +  " ?", "Mensaje", buttons, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {

            }
        }

        private void frmNMCategoria_KeyDown(object sender, KeyEventArgs e)
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

        public bool ValidationsEmptyFields()
        {
            if (txtDescripcion.Text.Equals(""))
            {
                XtraMessageBox.Show("¡Ingresa una categoria!", Application.ProductName,
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDescripcion.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        public void cleanFields()
        {
            txtDescripcion.Text = "";
        }
    }
}