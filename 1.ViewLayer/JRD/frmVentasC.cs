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
    public partial class frmVentasC : DevExpress.XtraEditors.XtraForm
    {
        public frmVentasC()
        {
            InitializeComponent();
        }

        private void frmVentasC_Load(object sender, EventArgs e)
        {
            ventaBindingSource.DataSource = new Venta().GetAll();
            usuarioBindingSource.DataSource = new Usuario().GetAll();
            gvVentas.BestFitColumns();
        }

        public void CancelarVenta()
        {
            var index = gvVentas.FocusedRowHandle;
            int valor = (int)gvVentas.GetRowCellValue(index, gvVentas.Columns[0]);
            int valorquery = new Venta { idVenta = valor }.CancelarVenta();

            if (valorquery > 0)
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = XtraMessageBox.Show("¿Estas segur@ de cancelar la venta?", "Mensaje", buttons, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    //valorquery = new EntradaCompra { idEntrada = valor}.CancelarCompra();
                    XtraMessageBox.Show("¡Venta cancelada correctamnte!", Application.ProductName,
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ventaBindingSource.DataSource = new Venta().GetAll();
                    usuarioBindingSource.DataSource = new Usuario().GetAll();
                    gvVentas.BestFitColumns();
                }

            }
            else
            {
                XtraMessageBox.Show("¡La venta ya fue cancelda!", Application.ProductName,
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CancelarVenta();
        }

        private void gvVentas_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (e.HitInfo.HitTest == DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitTest.RowCell)


                popupMenuDetalleVenta.ShowPopup(gcVentas.PointToScreen(e.Point));
        }

        private void btnDetalleVenta_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var index = gvVentas.FocusedRowHandle;
            int valor = (int)gvVentas.GetRowCellValue(index, gvVentas.Columns[0]);
            new frmDetalleVentas(valor).ShowDialog();
        }

        public void ActializarfrmVentasC()
        {
            ventaBindingSource.DataSource = new Venta().GetAll();
            usuarioBindingSource.DataSource = new Usuario().GetAll();
            gvVentas.BestFitColumns();

        }
    }
}