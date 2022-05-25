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
using BML;

namespace JRD
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        public event EventHandler SettingsApplied;
        String Usuario;
        String Password;
        public frmMain(String Usuario, String Password)
        {
            InitializeComponent();
            this.Usuario = Usuario;
            this.Password = Password;
            
            Usuario usuario = new Usuario()
            {
                usuario = this.Usuario,
                password = this.Password
            }.GetUsuario();

            if (usuario.tipoUsuario == "CAJERO") 
            {
                btnCompras.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnAlmacen.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnAccesos.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnConsultas.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
        }

        public void NotifySettingsApplied(EventArgs e)
        {
            if (SettingsApplied != null)
            { 
                SettingsApplied(this, e);
            }
        }

        

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)

                if (form.GetType() == typeof(frmCategorias))
                {
                    form.Activate();
                    return;
                }
            new frmCategorias() { MdiParent = this }.Show();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem3_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)

                if (form.GetType() == typeof(frmCategorias))
                {
                    form.Activate();
                    return;
                }
            new frmCategorias() { MdiParent = this }.Show();
        }

        private void frmClosing(object sender, FormClosingEventArgs e)
        {
          
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = XtraMessageBox.Show("¿Estas segur@ de cerrar la ventana Main?", "Mensaje", buttons, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
            }
            else
            {
                e.Cancel = true; 
            }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
           this.Close();
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.X)
            {
                this.Close();
            }
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)

                if (form.GetType() == typeof(frmLibros))
                {
                    form.Activate();
                    return;
                }
            new frmLibros() { MdiParent = this }.Show();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)

                if (form.GetType() == typeof(frmPrestamos))
                {
                    form.Activate();
                    return;
                }
            new frmPrestamos() { MdiParent = this }.Show();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)

                if (form.GetType() == typeof(frmUsuarios))
                {
                    form.Activate();
                    return;
                }
            new frmUsuarios() { MdiParent = this }.Show();
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            foreach (Form form in Application.OpenForms)

                if (form.GetType() == typeof(frmEstudiantes))
                {
                    form.Activate();
                    return;
                }
            new frmEstudiantes() { MdiParent = this }.Show();
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)

                if (form.GetType() == typeof(frmProveedores))
                {
                    form.Activate();
                    return;
                }
            new frmProveedores() { MdiParent = this }.Show();
        }

        private void barWorkspaceMenuItem1_ListItemClick(object sender, DevExpress.XtraBars.ListItemClickEventArgs e)
        {

        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)

                if (form.GetType() == typeof(frmCompras))
                {
                    form.Activate();
                    return;
                }
            new frmCompras() { MdiParent = this }.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario()
            {
                usuario = this.Usuario,
                password = this.Password
            }.GetUsuario();

            if (usuario.tipoUsuario == "CAJERO")
            {
                btnCompras.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnAlmacen.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnAccesos.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnConsultas.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            else if (usuario.tipoUsuario == "ALMACENISTA")
            {
                btnAccesos.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnConsultas.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnVentas.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;

            }
        }

        private void btnComprasC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)

                if (form.GetType() == typeof(frmComprasC))
                {
                    form.Activate();
                    return;
                }
            new frmComprasC() { MdiParent = this }.Show();
        }

        private void xtraTabbedMdiManager1_SelectedPageChanged(object sender, EventArgs e)
        {
            //entradaCompraBindingSource.DataSource = new EntradaCompra().GetAll();
            
        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)

                if (form.GetType() == typeof(frmNVenta))
                {
                    form.Activate();
                    return;
                }
            new frmNVenta(this.Usuario,this.Password) { MdiParent = this }.Show();
        }

        private void barButtonItem17_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)

                if (form.GetType() == typeof(frmVentasC))
                {
                    form.Activate();
                    return;
                }
            new frmVentasC() { MdiParent = this }.Show();
        }
    }
}