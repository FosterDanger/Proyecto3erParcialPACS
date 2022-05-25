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
    public partial class frmNMPrestamo : DevExpress.XtraEditors.XtraForm
    {
        private int idPrestamo = 0;
        bool mousedown;
        private Point offset;

        public frmNMPrestamo(String text)
        {
            InitializeComponent();
            (new JRD.DropShadow()).ApplyShadows(this);
            lblTitle.Text = text;
            DateTime localDate = DateTime.Now;
            dateFPrestamo.EditValue = localDate;
            estudianteBindingSource.DataSource = new Estudiante().GetAll();
            libroBindingSource.DataSource = new Libro().GetAll();

        }

        public frmNMPrestamo(String text, int idPrestamo)
        {
            InitializeComponent();
            (new JRD.DropShadow()).ApplyShadows(this);
            lblTitle.Text = text;
            this.idPrestamo = idPrestamo;
            estudianteBindingSource.DataSource = new Estudiante().GetAll();
            libroBindingSource.DataSource = new Libro().GetAll();

            Prestamo prestamo = new Prestamo
            {
                idPrestamo = this.idPrestamo,
            }.GetById();
            lookEstudiantes.EditValue = prestamo.idEstudiante;
            lookLibros.EditValue = prestamo.idLibro;
            dateFPrestamo.EditValue = prestamo.fechaPrestamo;
            dateFReingreso.EditValue = prestamo.fechaReingreso;
        }

        private void frmNMPrestamo_Load(object sender, EventArgs e)
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
            if (ValidationsEmptyFields() == true)
            {
                if (idPrestamo > 0)
                {
                    if (new Prestamo
                    {
                        idPrestamo = this.idPrestamo,
                        idEstudiante = (int)lookEstudiantes.EditValue,
                        idLibro = (int)lookLibros.EditValue,
                        fechaPrestamo = (DateTime)dateFPrestamo.EditValue,
                        fechaReingreso = (DateTime)dateFReingreso.EditValue
                    }.Update() > 0)
                    {
                        XtraMessageBox.Show("Prestamo actualizado correctamente", Application.ProductName,
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
                    if (new Prestamo
                    {
                        idEstudiante = (int)lookEstudiantes.EditValue,
                        idLibro = (int)lookLibros.EditValue,
                        fechaPrestamo = (DateTime)dateFPrestamo.EditValue,
                        fechaReingreso = (DateTime)dateFReingreso.EditValue
                    }.Add() > 0)
                    {

                        XtraMessageBox.Show("Prestamo almacenado correctamente", Application.ProductName,
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cleanFields();
                    }
                    else { XtraMessageBox.Show("El registro ya existe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning); cleanFields(); }

                }
            }
        }

        public void cleanFields()
        {
            lookEstudiantes.EditValue = null;
            lookLibros.EditValue = null;
            dateFReingreso.Text = "";

        }

        public bool ValidationsEmptyFields()
        {
            if (lookEstudiantes.EditValue == null)
            {
                XtraMessageBox.Show("¡Selecciona un numero de control!", Application.ProductName,
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                lookEstudiantes.Focus();
                return false;
            }
            else if (lookLibros.EditValue == null)
            {
                XtraMessageBox.Show("¡Selecciona un libro!", Application.ProductName,
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                lookLibros.Focus();
                return false;
            }
            else if (dateFReingreso.Text.Equals(""))
            {
                XtraMessageBox.Show("¡Ingresa una fecha de Reingreso!", Application.ProductName,
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                dateFReingreso.Focus();
                return false;
            }
            else
            {
                return true;
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

        private void frmNMPrestamo_KeyDown(object sender, KeyEventArgs e)
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