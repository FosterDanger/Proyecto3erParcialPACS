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
    public partial class frmEstudiantes : DevExpress.XtraEditors.XtraForm
    {
        public frmEstudiantes()
        {
            InitializeComponent();
        }

        private void frmEstudiantes_Load(object sender, EventArgs e)
        {
            estudianteBindingSource.DataSource = new Estudiante().GetAll();
            gvEstudiantes.BestFitColumns();
        }

        private void btnAgregar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNMEstudiante("Nuevo Estudiante").ShowDialog();
            estudianteBindingSource.DataSource = new Estudiante().GetAll();
            gvEstudiantes.BestFitColumns();
        }

        private void btnEditar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int idEstudiante = (int)gvEstudiantes.GetFocusedRowCellValue("idEstudiante");
            new frmNMEstudiante("Modificar Estudiante", idEstudiante).ShowDialog();
            estudianteBindingSource.DataSource = new Estudiante().GetAll();
            gvEstudiantes.BestFitColumns();
        }
    }
}