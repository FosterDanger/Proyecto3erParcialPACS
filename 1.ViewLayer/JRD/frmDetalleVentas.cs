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
    public partial class frmDetalleVentas : DevExpress.XtraEditors.XtraForm
    {
        private int idVenta = 0;
        bool mousedown;
        private Point offset;
        public frmDetalleVentas(int idVenta)
        {
            InitializeComponent();
            (new JRD.DropShadow()).ApplyShadows(this);
            lblTitle.Text = "Detalle Ventas";
            this.idVenta = idVenta;


            detalleVentaBindingSource.DataSource = new DetalleVenta { idVenta = this.idVenta }.GetAll();
            libroBindingSource.DataSource = new Libro().GetAll();
            //proveedorBindingSource.DataSource = new Proveedor().GetAll();
            gvDetalleVenta.BestFitColumns();
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

        private void panelControl3_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mousedown = true;
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

        private void frmDetalleVentas_KeyDown(object sender, KeyEventArgs e)
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