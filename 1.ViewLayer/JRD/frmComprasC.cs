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
    public partial class frmComprasC : DevExpress.XtraEditors.XtraForm
    {
        public frmComprasC()
        {
            InitializeComponent();
        }

        private void frmComprasC_Load(object sender, EventArgs e)
        {
            entradaCompraBindingSource.DataSource = new EntradaCompra().GetAll();
            gvComprasC.BestFitColumns();
        }

        private void btnCancelarCompra_Click(object sender, EventArgs e)
        {
            
            var index = gvComprasC.FocusedRowHandle;
            int valor = (int)gvComprasC.GetRowCellValue(index, gvComprasC.Columns[0]);
            int valorquery = new EntradaCompra { idEntrada = valor }.CancelarCompra();

            if (valorquery > 0)
            {
                 //valorquery = new EntradaCompra { idEntrada = valor}.CancelarCompra();
                XtraMessageBox.Show("¡Compra Cancelada correctamnte!", Application.ProductName,
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
                entradaCompraBindingSource.DataSource = new EntradaCompra().GetAll();
            }
            else 
            {
                XtraMessageBox.Show("¡La compra ya a sido cancelda!", Application.ProductName,
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        public void CancelarCompra()
        {
            var index = gvComprasC.FocusedRowHandle;
            int valor = (int)gvComprasC.GetRowCellValue(index, gvComprasC.Columns[0]);
            int valorquery = new EntradaCompra { idEntrada = valor }.CancelarCompra();

            if (valorquery > 0)
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = XtraMessageBox.Show("¿Estas segur@ de cancelar la compra?", "Mensaje", buttons, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    //valorquery = new EntradaCompra { idEntrada = valor}.CancelarCompra();
                    XtraMessageBox.Show("¡Compra cancelada correctamnte!", Application.ProductName,
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                    entradaCompraBindingSource.DataSource = new EntradaCompra().GetAll();
                }
                
            }
            else
            {
                XtraMessageBox.Show("¡La compra ya fue cancelda!", Application.ProductName,
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void gvComprasC_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (e.HitInfo.HitTest == DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitTest.RowCell)

                
            popupMenuDetalleCompra.ShowPopup(gcComprasC.PointToScreen(e.Point));
        }

        public void prueba()
        {
            entradaCompraBindingSource.DataSource = new EntradaCompra().GetAll();
            gvComprasC.BestFitColumns();

        }

        private void btnDetalleCompra_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var index = gvComprasC.FocusedRowHandle;
            int valor = (int)gvComprasC.GetRowCellValue(index, gvComprasC.Columns[0]);
            new frmDetalleCompra(valor).ShowDialog();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CancelarCompra();
        }
    }
}