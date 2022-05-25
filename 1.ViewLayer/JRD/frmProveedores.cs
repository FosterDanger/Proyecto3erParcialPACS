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
    public partial class frmProveedores : DevExpress.XtraEditors.XtraForm
    {
        public frmProveedores()
        {
            InitializeComponent();
        }

        private void frmProveedores_Load(object sender, EventArgs e)
        {
            proveedorBindingSource.DataSource = new Proveedor().GetAll();
            gvProveedores.BestFitColumns();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNMProveedor("Nuevo Proveedor").ShowDialog();
            proveedorBindingSource.DataSource = new Proveedor().GetAll();
            gvProveedores.BestFitColumns();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int idProveedor = (int)gvProveedores.GetFocusedRowCellValue("idProveedor");
            new frmNMProveedor("Modificar Proveedor", idProveedor).ShowDialog();
            proveedorBindingSource.DataSource = new Proveedor().GetAll();
            gvProveedores.BestFitColumns();
        }

        public void AcualizarTabla()
        {
            proveedorBindingSource.DataSource = new Proveedor().GetAll();
            gvProveedores.BestFitColumns();
        }
    }
}