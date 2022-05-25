using BML;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
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
    public partial class frmCompras : DevExpress.XtraEditors.XtraForm
    {
        public frmCompras()
        {
            InitializeComponent();
            //this.Load += frmCompras_Load;
            //end-users cannot add rows
            // gvCompras.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
        }

        private void frmCompras_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id Libro", Type.GetType("System.Int32"));
            dt.Columns.Add("Libro", Type.GetType("System.String"));
            dt.Columns.Add("Proveedor", Type.GetType("System.String"));
            dt.Columns.Add("Costo Unitario", Type.GetType("System.Decimal"));
            dt.Columns.Add("Cantidad", Type.GetType("System.Int32"));
            dt.Columns.Add("Importe", Type.GetType("System.Decimal"));
            // DataRow dr = dt.NewRow();
            //dt.Rows.Add(dr);
            BindingSource bs = new BindingSource();
            bs.DataSource = dt;
            gcCompras.DataSource = bs;

            proveedorBindingSource.DataSource = new Proveedor().GetAll();
            // lookUpEditProveedor.EditValue = new Proveedor().GetAll().First().idProveedor;
            gvCompras.BestFitColumns();

            libroBindingSource.DataSource = new Libro().GetAll();
            //lookUpEdit2.EditValue = new Libro().GetAll().First().idLibro;

            txtCodigoCompra.Text = new EntradaCompra().GetProxCod().First();


        }

        public void ActualizarLibroCompras()
        {
            libroBindingSource.DataSource = new Libro().GetAll();

        }

       

        public void ActualizarProveedorCompras()
        {
            proveedorBindingSource.DataSource = new Proveedor().GetAll();

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            popupMenuLibro.ShowPopup(Control.MousePosition);
        }

        private void cmbBuscarPor_EditValueChanged(object sender, EventArgs e)
        {
            if (cmbBuscarPor.EditValue == "Libro")
            {
                lookUpEdit2.Properties.DisplayMember = "nombre";

            }
            else
            {
                lookUpEdit2.Properties.DisplayMember = "codigoLibro";
            }
        }

        private void btnAgregarAutor_Click(object sender, EventArgs e)
        {
            popupMenuProveedor.ShowPopup(Control.MousePosition);
        }

        private void btnAgregarProveedor_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNMProveedor("Nuevo Proveedor").ShowDialog();
            proveedorBindingSource.DataSource = new Proveedor().GetAll();
        }

        private void btnModificarProveedor_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (lookUpEditProveedor.EditValue != null)
            {
                new frmNMProveedor("Nuevo Proveedor", (int)lookUpEditProveedor.EditValue).ShowDialog();
                proveedorBindingSource.DataSource = new Proveedor().GetAll();
            }
            else
            {
                XtraMessageBox.Show("¡Elige un Proveedor!", Application.ProductName,
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                lookUpEditProveedor.Focus();
            }
        }

        private void btnNuevoLibro_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNMLibro("Nuevo Libro").ShowDialog();
            libroBindingSource.DataSource = new Libro().GetAll();
        }

        private void btnModificarLibro_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (lookUpEdit2.EditValue != null)
            {
                new frmNMLibro("Modificar Libro", (int)lookUpEdit2.EditValue).ShowDialog();
                libroBindingSource.DataSource = new Libro().GetAll();
            }
            else
            {
                XtraMessageBox.Show("¡Elige un Libro!", Application.ProductName,
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                lookUpEdit2.Focus();
            }

        }

        private void frmCompras_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = XtraMessageBox.Show("¿Estas segur@ de cerrar la ventana Compras?", "Mensaje", buttons, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
            }
            else
            {
                e.Cancel = true;
            }
        }



        private void btnAgregarEditorial_Click(object sender, EventArgs e)
        {
            if (ValidationsEmptyFields() == true)
            {
                String Libro = new Libro { idLibro = (int)lookUpEdit2.EditValue }.GetById().nombre;
                Decimal importe = Decimal.Parse(txtCostoUnitario.Text) * int.Parse(txtCantidad.Text);
                gvCompras.AddNewRow();
                gvCompras.SetRowCellValue(GridControl.NewItemRowHandle, gvCompras.Columns["Id Libro"], (int)lookUpEdit2.EditValue);
                gvCompras.SetRowCellValue(GridControl.NewItemRowHandle, gvCompras.Columns["Libro"], Libro);
                gvCompras.SetRowCellValue(GridControl.NewItemRowHandle, gvCompras.Columns["Proveedor"], lookUpEditProveedor.Text);
                gvCompras.SetRowCellValue(GridControl.NewItemRowHandle, gvCompras.Columns["Costo Unitario"], txtCostoUnitario.EditValue);
                gvCompras.SetRowCellValue(GridControl.NewItemRowHandle, gvCompras.Columns["Cantidad"], txtCantidad.EditValue);
                gvCompras.SetRowCellValue(GridControl.NewItemRowHandle, gvCompras.Columns["Importe"], importe);
                gvCompras.UpdateCurrentRow();
                gvCompras.BestFitColumns();
                CalcularTotal();
                ClerarFields();
            }
        }

        private void gvCompras_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            int rowhandle = gvCompras.RowCount - 1;
            gvCompras.SetRowCellValue(GridControl.NewItemRowHandle, gvCompras.Columns["Prueba"], "kk");

        }

        public bool ValidationsEmptyFields()
        {
            if (lookUpEditProveedor.EditValue == null)
            {
                XtraMessageBox.Show("¡Elige un Proveedor!", Application.ProductName,
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                lookUpEditProveedor.Focus();
                return false;
            }
            else if (lookUpEdit2.EditValue == null)
            {
                XtraMessageBox.Show("¡Elige un Libro!", Application.ProductName,
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                lookUpEdit2.Focus();
                return false;
            }
            else if (txtCantidad.Text.Equals("") || txtCantidad.EditValue == null)
            {
                XtraMessageBox.Show("¡Ingresa una Cantidad!", Application.ProductName,
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCantidad.Focus();
                return false;
            }
            else if (txtCostoUnitario.Text.Equals("") || txtCostoUnitario.EditValue == null)
            {
                XtraMessageBox.Show("¡Ingresa un Costo Unitario!", Application.ProductName,
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCostoUnitario.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        public void ClerarFields()
        {
            lookUpEditProveedor.EditValue = null;
            lookUpEdit2.EditValue = null;
            txtCantidad.EditValue = null;
            txtCostoUnitario.EditValue = null;
        }

        public void CalcularTotal()
        {
            Decimal Total = 0;
            for (int i = 0; i < gvCompras.DataRowCount; i++)
            {
                Decimal importe = (Decimal)gvCompras.GetRowCellValue(i, "Importe");
                Total += importe;
            }

            txtTotal.Text = Total.ToString();
        }

        public void ClerarTable()
        {
            for (int i = 0; i < gvCompras.RowCount;)
                gvCompras.DeleteRow(i);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (gvCompras.DataRowCount != 0)
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = XtraMessageBox.Show("¿Estas segur@ de continuar con la compra ?", "Mensaje", buttons, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {


                    DateTime localDate = DateTime.Now;
                    EntradaCompra et = new EntradaCompra();

                    et.fecha = localDate;
                    et.total = Decimal.Parse(txtTotal.Text);
                    et.Add();

                    for (int i = 0; i < gvCompras.DataRowCount; i++)
                    {
                        DetalleEntradaCompra et2 = new DetalleEntradaCompra();
                        et2.costoUnitario = (Decimal)gvCompras.GetRowCellValue(i, "Costo Unitario");
                        et2.cantidad = (int)gvCompras.GetRowCellValue(i, "Cantidad");
                        et2.idLibro = (int)gvCompras.GetRowCellValue(i, "Id Libro");
                        et2.idProveedor = new Proveedor { nombreProveedor = "" + gvCompras.GetRowCellValue(i, "Proveedor") }.GetByDescripcion().idProveedor;
                        et2.Add();

                        Inventario inventario = new Inventario();
                        inventario.idProducto = (int)gvCompras.GetRowCellValue(i, "Id Libro");
                        inventario.cantidadDisponible = (int)gvCompras.GetRowCellValue(i, "Cantidad");
                        inventario.Add();
                    }

                    ClerarTable();
                    txtTotal.EditValue = 0;
                    txtCodigoCompra.Text = new EntradaCompra().GetProxCod().First();
                    ActualizarfrmComprasC();
                    XtraMessageBox.Show("¡Compra realizada correctamente!", Application.ProductName,
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else 
            {
                XtraMessageBox.Show("¡Agregue Datos de Compra a la Tabla!", Application.ProductName,
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void ActualizarfrmComprasC()
        {
            if (System.Windows.Forms.Application.OpenForms["frmComprasC"] != null)
            {
                (System.Windows.Forms.Application.OpenForms["frmComprasC"] as frmComprasC).prueba();
            }
            
            if (System.Windows.Forms.Application.OpenForms["frmLibros"] != null)
            {
                (System.Windows.Forms.Application.OpenForms["frmLibros"] as frmLibros).prueba();
            }
        }

        private void btnEliminarFila_Click(object sender, EventArgs e)
        {
            if (gvCompras.DataRowCount != 0)
            { 
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = XtraMessageBox.Show("¿Estas segur@ de eliminar los datos de compra seleccionados ?", "Mensaje", buttons, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    gvCompras.DeleteRow(gvCompras.FocusedRowHandle);
                    CalcularTotal();
                }
            }
        }

        private void btnEliminarTodo_Click(object sender, EventArgs e)
        {
            if (gvCompras.DataRowCount != 0)
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = XtraMessageBox.Show("¿Estas segur@ de eliminar todos los datos de compra ?", "Mensaje", buttons, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    ClerarTable();
                    CalcularTotal();
                }
            }
        }
    }
}
