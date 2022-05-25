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
    public partial class frmNMProveedor : DevExpress.XtraEditors.XtraForm
    {
        private int idProveedor = 0;
        bool mousedown;
        private Point offset;

        public frmNMProveedor(String text)
        {
            InitializeComponent();
            (new JRD.DropShadow()).ApplyShadows(this);
            lblTitle.Text = text;
            
        }

        public frmNMProveedor(String text, int idProveedor)
        {
            InitializeComponent();
            (new JRD.DropShadow()).ApplyShadows(this);
            lblTitle.Text = text;
            this.idProveedor = idProveedor;

            Proveedor proveedor = new Proveedor
            {
                idProveedor = this.idProveedor,
            }.GetById();
            txtNombreProveedor.EditValue = proveedor.nombreProveedor;
            txtNombreContacto.EditValue = proveedor.nombreContacto;
            txtCargoContacto.EditValue = proveedor.cargoContacto;
            txtCalle.EditValue = proveedor.calle;
            txtColonia.EditValue = proveedor.colonia;
            txtCP.EditValue = proveedor.codigoPostal;
            txtCiudad.EditValue = proveedor.ciudad;
            txtTelefono.EditValue = proveedor.telefono;
            txtEmail.EditValue = proveedor.email;
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
                if (idProveedor > 0)
                {
                    if (new Proveedor
                    {
                        idProveedor = this.idProveedor,
                        nombreProveedor = txtNombreProveedor.EditValue.ToString(),
                        nombreContacto = txtNombreContacto.EditValue.ToString(),
                        cargoContacto = txtCargoContacto.EditValue.ToString(),
                        calle = txtCalle.EditValue.ToString(),
                        colonia = txtColonia.EditValue.ToString(),
                        codigoPostal = txtCP.EditValue.ToString(),
                        ciudad = txtCiudad.EditValue.ToString(),
                        telefono = txtTelefono.EditValue.ToString(),
                        email = txtEmail.EditValue.ToString()
                    }.Update() > 0)
                    {
                        ActualizarLookupProveedores();
                        XtraMessageBox.Show("Proveedor actualizado correctamente", Application.ProductName,
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
                    if (new Proveedor
                    {
                        nombreProveedor = txtNombreProveedor.EditValue.ToString(),
                        nombreContacto = txtNombreContacto.EditValue.ToString(),
                        cargoContacto = txtCargoContacto.EditValue.ToString(),
                        calle = txtCalle.EditValue.ToString(),
                        colonia = txtColonia.EditValue.ToString(),
                        codigoPostal = txtCP.EditValue.ToString(),
                        ciudad = txtCiudad.EditValue.ToString(),
                        telefono = txtTelefono.EditValue.ToString(),
                        email = txtEmail.EditValue.ToString()
                    }.Add() > 0)
                    {
                        ActualizarLookupProveedores();
                        XtraMessageBox.Show("Proveedor almacenado correctamente", Application.ProductName,
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cleanFields();
                    }
                    else { XtraMessageBox.Show("El registro ya existe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning); cleanFields(); }

                }
            }
        }

        public void ActualizarLookupProveedores()
        {
            if (System.Windows.Forms.Application.OpenForms["frmCompras"] != null)
            {
                (System.Windows.Forms.Application.OpenForms["frmCompras"] as frmCompras).ActualizarProveedorCompras();
            }

            if (System.Windows.Forms.Application.OpenForms["frmLibros"] != null)
            {
                (System.Windows.Forms.Application.OpenForms["frmLibros"] as frmLibros).prueba();

            }

            if (System.Windows.Forms.Application.OpenForms["frmLibros"] != null)
            {
                (System.Windows.Forms.Application.OpenForms["frmLibros"] as frmLibros).prueba();
            }

            if (System.Windows.Forms.Application.OpenForms["frmProveedores"] != null)
            {
                (System.Windows.Forms.Application.OpenForms["frmProveedores"] as frmProveedores).AcualizarTabla();
            }

        }

      

        public bool ValidationsEmptyFields()
        {
            if (txtNombreProveedor.Text.Equals("") || txtNombreProveedor.EditValue == null)
            {
                XtraMessageBox.Show("¡Ingresa un nombre de proveedor!", Application.ProductName,
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNombreProveedor.Focus();
                return false;
            }
            else if (txtNombreContacto.Text.Equals("") || txtNombreContacto.EditValue == null)
            {
                XtraMessageBox.Show("¡Ingresa una nombre de contacto!", Application.ProductName,
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNombreContacto.Focus();
                return false;
            }
            else if (txtCargoContacto.Text.Equals("") || txtCargoContacto.EditValue == null)
            {
                XtraMessageBox.Show("¡Ingresa un cardo de contacto!", Application.ProductName,
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCargoContacto.Focus();
                return false;
            }
            else if (txtCalle.Text.Equals("") || txtCalle.EditValue == null)
            {
                XtraMessageBox.Show("¡Ingresa una calle!", Application.ProductName,
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCalle.Focus();
                return false;
            }
            else if (txtColonia.Text.Equals("") || txtColonia.EditValue == null)
            {
                XtraMessageBox.Show("¡Ingresa una colonia!", Application.ProductName,
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtColonia.Focus();
                return false;
            }
            else if (txtCP.Text.Equals("") || txtCP.EditValue == null)
            {
                XtraMessageBox.Show("¡Ingresa un codigo postal!", Application.ProductName,
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCP.Focus();
                return false;
            }
            else if (txtCiudad.Text.Equals("") || txtCiudad.EditValue == null)
            {
                XtraMessageBox.Show("¡Ingresa una ciudad!", Application.ProductName,
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCiudad.Focus();
                return false;
            }
            else if (txtTelefono.Text.Equals("") || txtTelefono.EditValue == null)
            {
                XtraMessageBox.Show("¡Ingresa un telefono!", Application.ProductName,
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTelefono.Focus();
                return false;
            }
            else if (txtEmail.Text.Equals("") || txtEmail.EditValue == null)
            {
                XtraMessageBox.Show("¡Ingresa un Email!", Application.ProductName,
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmail.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        public void cleanFields()
        {
            txtNombreProveedor.EditValue = null;
            txtNombreContacto.EditValue = null;
            txtCargoContacto.EditValue = null;
            txtCalle.EditValue = null;
            txtColonia.EditValue = null;
            txtCP.EditValue = null;
            txtCiudad.EditValue = null;
            txtTelefono.EditValue = null;
            txtEmail.EditValue = null;
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

        private void frmNMProveedor_KeyDown(object sender, KeyEventArgs e)
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