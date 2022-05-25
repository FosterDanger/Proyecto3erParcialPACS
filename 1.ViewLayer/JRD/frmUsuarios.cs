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
    public partial class frmUsuarios : DevExpress.XtraEditors.XtraForm
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            usuarioBindingSource.DataSource = new Usuario().GetAll();
            gvUsuarios.BestFitColumns();
        }

        private void btnAgregar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNMUsuario("Nuevo Usuario").ShowDialog();
            usuarioBindingSource.DataSource = new Usuario().GetAll();
            gvUsuarios.BestFitColumns();
        }

        private void btnEditar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int idUsuario = (int)gvUsuarios.GetFocusedRowCellValue("idUsuario");
            new frmNMUsuario("Modificar Usuario", idUsuario).ShowDialog();
            usuarioBindingSource.DataSource = new Usuario().GetAll();
            gvUsuarios.BestFitColumns();
        }
    }
}