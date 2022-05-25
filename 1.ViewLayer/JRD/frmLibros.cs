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
    public partial class frmLibros : DevExpress.XtraEditors.XtraForm
    {
        public frmLibros()
        {
            InitializeComponent();
        }

        private void frmLibros_Load(object sender, EventArgs e)
        {
            libroBindingSource.DataSource = new Libro().GetAll();
            autorBindingSource.DataSource = new Autor().GetAll();
            editorialBindingSource.DataSource = new Editorial().GetAll();
            categoriaBindingSource.DataSource = new Categoria().GetAll();
            inventarioBindingSource.DataSource = new Inventario().GetAll();

            gvLibros.BestFitColumns();
        }

        private void btnAgregar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNMLibro("Nuevo Libro").ShowDialog();
            libroBindingSource.DataSource = new Libro().GetAll();
            autorBindingSource.DataSource = new Autor().GetAll();
            editorialBindingSource.DataSource = new Editorial().GetAll();
            categoriaBindingSource.DataSource = new Categoria().GetAll();
            inventarioBindingSource.DataSource = new Inventario().GetAll();

            gvLibros.BestFitColumns();
        }

        private void btnEditar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int idLibro = (int)gvLibros.GetFocusedRowCellValue("idLibro");
            new frmNMLibro("Modificar Libro", idLibro).ShowDialog();
            libroBindingSource.DataSource = new Libro().GetAll();
            autorBindingSource.DataSource = new Autor().GetAll();
            editorialBindingSource.DataSource = new Editorial().GetAll();
            categoriaBindingSource.DataSource = new Categoria().GetAll();
            inventarioBindingSource.DataSource = new Inventario().GetAll();

            gvLibros.BestFitColumns();
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        public void prueba()
        {
            libroBindingSource.DataSource = new Libro().GetAll();
            autorBindingSource.DataSource = new Autor().GetAll();
            editorialBindingSource.DataSource = new Editorial().GetAll();
            categoriaBindingSource.DataSource = new Categoria().GetAll();
            inventarioBindingSource.DataSource = new Inventario().GetAll();
            gvLibros.BestFitColumns();

        }
    }
}