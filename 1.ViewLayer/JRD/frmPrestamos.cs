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
    public partial class frmPrestamos : DevExpress.XtraEditors.XtraForm
    {
        public frmPrestamos()
        {
            InitializeComponent();
        }

        private void frmPrestamos_Load(object sender, EventArgs e)
        {
            prestamoBindingSource.DataSource = new Prestamo().GetAll();
            estudianteBindingSource.DataSource = new Estudiante().GetAll();
            libroBindingSource.DataSource = new Libro().GetAll();
            gvPrestamos.BestFitColumns();
        }

        private void btnAgregar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNMPrestamo("Nuevo Prestamo").ShowDialog();
            libroBindingSource.DataSource = new Libro().GetAll();
            prestamoBindingSource.DataSource = new Prestamo().GetAll();
            estudianteBindingSource.DataSource = new Estudiante().GetAll();
            gvPrestamos.BestFitColumns();
        }

        private void btnEditar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int idPrestamo = (int)gvPrestamos.GetFocusedRowCellValue("idPrestamo");
            new frmNMPrestamo("Modificar Prestamo", idPrestamo).ShowDialog();
            libroBindingSource.DataSource = new Libro().GetAll();
            prestamoBindingSource.DataSource = new Prestamo().GetAll();
            estudianteBindingSource.DataSource = new Estudiante().GetAll();
            gvPrestamos.BestFitColumns();
        }
    }
}