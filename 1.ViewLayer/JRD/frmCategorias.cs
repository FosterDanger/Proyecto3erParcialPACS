using BML;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JRD
{
    public partial class frmCategorias : DevExpress.XtraEditors.XtraForm
    {
        public frmCategorias()
        {
            InitializeComponent();
        }

        private void frmCategorias_Load(object sender, EventArgs e)
        {
            categoriaBindingSource.DataSource = new Categoria().GetAll();
            //gvCategorias.BestFitColumns();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNMCategoria("Nueva Categoria").ShowDialog();
            categoriaBindingSource.DataSource = new Categoria().GetAll();
            //gvCategorias.BestFitColumns();
        }

        private void key_Down(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void btnEditar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //int idCategoria = (int)gvCategorias.GetFocusedRowCellValue("idCategoria");
            //new frmNMCategoria("Modificar Categoria", idCategoria).ShowDialog();
            categoriaBindingSource.DataSource = new Categoria().GetAll();
           // gvCategorias.BestFitColumns();
        }
    }
}
