using BML;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using Gma.QrCodeNet.Encoding;
using Gma.QrCodeNet.Encoding.Windows.Render;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace JRD
{
    public partial class frmNVenta : DevExpress.XtraEditors.XtraForm
    {
        String Usuario;
        String Password;
        private static String path = @"C:\Json Sample\ImpresoraVentas.json";
        bool val = false;
        

        public frmNVenta(String Usuario, String Password)
        {
            InitializeComponent();
            this.Usuario = Usuario;
            this.Password = Password;

            Usuario usuario = new Usuario()
            {
                usuario = this.Usuario,
                password = this.Password
            }.GetUsuario();

            txtUsuario.Text = "( Id: " + usuario.idUsuario + " ) " + usuario.nombre
                + " " + usuario.apellido;

            PrinterList();
            var impresora = GetImpresoraJsonFile();
            if (impresora != null)
            {
                DeserializeJsonFile(impresora);

                DataTable dt = new DataTable();
                dt.Columns.Add("Id Libro", Type.GetType("System.Int32"));
                dt.Columns.Add("Libro", Type.GetType("System.String"));
                dt.Columns.Add("Precio", Type.GetType("System.Decimal"));
                dt.Columns.Add("Cantidad", Type.GetType("System.Int32"));
                dt.Columns.Add("Importe", Type.GetType("System.Decimal"));
                // DataRow dr = dt.NewRow();
                //dt.Rows.Add(dr);
                BindingSource bs = new BindingSource();
                bs.DataSource = dt;
                gcVentas.DataSource = bs;
            }

            BarEditItem item = cmbImprimir as BarEditItem;
            item.EditValue = "IMPRIMIR TICKET";

            BarEditItem item2 = cmbBuscarPor as BarEditItem;
            item2.EditValue = "Codigo";


            //ComboBoxEdit editor = cmbImpresora.Ac as ComboBoxEdit;
            //  editor.SelectedIndex = 1;
            // (cmbImpresora.EditValue as DevExpress.XtraEditors.ComboBox).SelectedIndex = 0;



        }

        public void generateCodQR()
        {
            QrEncoder qrEncoder = new QrEncoder(ErrorCorrectionLevel.H);
            QrCode qrCode = new QrCode();
            qrEncoder.TryEncode(txtCodigoVenta.Text.Trim(), out qrCode);

            GraphicsRenderer renderer = new GraphicsRenderer(new FixedCodeSize(560, QuietZoneModules.Zero), Brushes.Black, Brushes.White);
            MemoryStream ms = new MemoryStream();
            renderer.WriteToStream(qrCode.Matrix, ImageFormat.Png, ms);
            var imageTemporal = new Bitmap(ms);
            var image = new Bitmap(imageTemporal, new Size(new Point(280, 280)));

            // pictureQR.BackgroundImage = image;
            //pictureQR. = image;
            //image.Save("image.png", ImageFormat.Png);
        }

        public Image generateimageCodQR()
        {
            QrEncoder qrEncoder = new QrEncoder(ErrorCorrectionLevel.H);
            QrCode qrCode = new QrCode();
            qrEncoder.TryEncode(txtCodigoVenta.Text.Trim(), out qrCode);

            GraphicsRenderer renderer = new GraphicsRenderer(new FixedCodeSize(560, QuietZoneModules.Zero), Brushes.Black, Brushes.White);
            MemoryStream ms = new MemoryStream();
            renderer.WriteToStream(qrCode.Matrix, ImageFormat.Png, ms);
            var imageTemporal = new Bitmap(ms);
            var image = new Bitmap(imageTemporal, new Size(new Point(280, 280)));

            // pictureQR.BackgroundImage = image;
            //pictureQR.Image = image;
            return image;
            //image.Save("image.png", ImageFormat.Png);
        }

        private void txtCostoUnitario_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void frmNVenta_Load(object sender, EventArgs e)
        {
            txtCodigoVenta.EditValue = new Venta().GetProxCod().First();
            libroBindingSource.DataSource = new Libro().GetAll();
            this.spinEdit1.Properties.Mask.EditMask = "####;";

            //this.spinEdit1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;


        }



        private void txtCodigoVenta_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void PrinterList()
        {
            foreach (String sPrinters in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                /*BarEditItem item = new BarEditItem(barManager1);
                item.Edit = barManager1.RepositoryItems.Add("SpinEdit");
                bar1.AddItem(item);*/

                (cmbImpresora.Edit as RepositoryItemComboBox).Items.Add(sPrinters);

            }
        }

        private void cmbImpresora_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // cmbeImpresoras.SelectedIndex = cmbeImpresoras.Properties.Items.IndexOf(impresora[0].NombreImpresora);

            // (cmbImpresora.Edit as RepositoryItemComboBox).Items.IndexOf("PDF CREATOR");


            // (cmbImpresora.EditValue as ComboBoxEdit).SelectedIndex = 1;


        }

        private void barManager1_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        public List<ImpresoraJasonVenta> GetImpresora()
        {
            BarEditItem item = cmbImpresora as BarEditItem;
            List<ImpresoraJasonVenta> impresora = new List<ImpresoraJasonVenta> {

            new ImpresoraJasonVenta
            {
                 NombreImpresoraVenta = item.EditValue.ToString() }
            };

            return impresora;


        }

        public static void SerializeJsonFile(List<ImpresoraJasonVenta> impresora)
        {
            String impresoraJson = JsonConvert.SerializeObject(impresora.ToArray(), Formatting.Indented);
            File.WriteAllText(path, impresoraJson);
        }

        public static String GetImpresoraJsonFile()
        {
            String ImpresoraJasonFromFile;
            using (var reader = new StreamReader(path))
            {
                ImpresoraJasonFromFile = reader.ReadToEnd();
            }
            return ImpresoraJasonFromFile;
        }

        public void DeserializeJsonFile(String impresoraJsonFile)
        {
            var impresora = JsonConvert.DeserializeObject<List<ImpresoraJasonVenta>>(impresoraJsonFile);
            BarEditItem item = cmbImpresora as BarEditItem;
            item.EditValue = impresora[0].NombreImpresoraVenta;
        }

        public String DeserializeJsonFile2(String impresoraJsonFile)
        {
            var impresora = JsonConvert.DeserializeObject<List<ImpresoraJasonVenta>>(impresoraJsonFile);
            return impresora[0].NombreImpresoraVenta;
        }

        private void cmbImpresora_EditValueChanged(object sender, EventArgs e)
        {
            var impresora = GetImpresora();
            SerializeJsonFile(impresora);

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            popupMenuLibro.ShowPopup(Control.MousePosition);
        }

        private void cmbBuscarPor_EditValueChanged(object sender, EventArgs e)
        {

            if (cmbBuscarPor.EditValue == "Libro")
            {
                lookUpLibro.Properties.DisplayMember = "nombre";
            }
            else
            {
                lookUpLibro.Properties.DisplayMember = "codigoLibro";

            }

            if (val == true)
            {
                if (lookUpLibro.EditValue != null)
                {
                    txtPrecio.EditValue = new Libro() { idLibro = (int)lookUpLibro.EditValue }.GetById().precioUnitario;
                }
             }

            val = true;

        }

        private void lookUpLibro_EditValueChanged(object sender, EventArgs e)
        {
            txtPrecio.EditValue = new Libro() { idLibro = (int)lookUpLibro.EditValue }.GetById().precioUnitario;

        }

        private void btnAgregarEditorial_Click(object sender, EventArgs e)
        {
            if (lookUpLibro.EditValue != null)
            {
                AgregarDatosCompra();
            }
            else
            {
                XtraMessageBox.Show("Elige un libro", Application.ProductName,
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                lookUpLibro.Focus();
            }
        }

        public void AgregarDatosCompra()
        {
            try
            {

                int idLibro = new Inventario { idProducto = (int)lookUpLibro.EditValue }.GetById().cantidadDisponible;

                if (SumarTotaCantidadID((int)lookUpLibro.EditValue, idLibro, int.Parse(spinEdit1.Text)) == true)
                {
                    String Libro = new Libro { idLibro = (int)lookUpLibro.EditValue }.GetById().nombre;
                    Decimal importe = Decimal.Parse(txtPrecio.Text) * int.Parse(spinEdit1.Text);
                    gvVenta.AddNewRow();
                    gvVenta.SetRowCellValue(GridControl.NewItemRowHandle, gvVenta.Columns["Id Libro"], (int)lookUpLibro.EditValue);
                    gvVenta.SetRowCellValue(GridControl.NewItemRowHandle, gvVenta.Columns["Libro"], Libro);
                    gvVenta.SetRowCellValue(GridControl.NewItemRowHandle, gvVenta.Columns["Precio"], txtPrecio.Text);
                    gvVenta.SetRowCellValue(GridControl.NewItemRowHandle, gvVenta.Columns["Cantidad"], spinEdit1.EditValue);
                    gvVenta.SetRowCellValue(GridControl.NewItemRowHandle, gvVenta.Columns["Importe"], importe);
                    gvVenta.UpdateCurrentRow();
                    gvVenta.BestFitColumns();
                    CalcularTotal();
                    //ClerarFields();
                    if (gvVenta.DataRowCount != 0)
                    {
                        txtEfectivo.Enabled = true;
                    }
                    txtEfectivo.EditValue = null;
                }

            }
            catch (InvalidOperationException ex)
            {
                XtraMessageBox.Show("¡No hay libros en el inventario, realiza una compra de este libro!", Application.ProductName,
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            
           
        }

        public bool SumarTotaCantidadID(int ID, int cantidadBD, int nuevaCantidad)
        {
            int totalCantidad = 0;
            for (int i = 0; i < gvVenta.DataRowCount; i++)
            {
                int id = (int)gvVenta.GetRowCellValue(i, "Id Libro");
                if (id == ID)
                {
                    int cantidad = (int)gvVenta.GetRowCellValue(i, "Cantidad");
                    totalCantidad += cantidad;
                }
            }

            if ((totalCantidad + nuevaCantidad) > cantidadBD)
            {
                XtraMessageBox.Show("¡La cantidad de producto en el inventario es menor a la ingresada!, quedan \n"
                    + (cantidadBD - totalCantidad) + " libros en Inventario con ese numero de ID.", Application.ProductName,
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                return true;
            }

        }

        public void CalcularTotal()
        {
            Decimal Total = 0;
            for (int i = 0; i < gvVenta.DataRowCount; i++)
            {
                Decimal importe = (Decimal)gvVenta.GetRowCellValue(i, "Importe");
                Total += importe;
            }



            txtSubTotal.Text = Total.ToString();
            if (Total > 1500)
            {
                txtDecuento.Text = "7 %";
                txtTotal.Text = (Total - (Total * (Decimal)0.07)).ToString();
            }
            else if (Total < 1500)
            {
                txtDecuento.Text = "0 %";
                txtTotal.Text = Total.ToString();
            }
        }

        public Decimal CalcularDescuento()
        {
            Decimal subTotal = Decimal.Parse(txtSubTotal.Text);
            if (subTotal > 1500)
            {
                return ((subTotal * (Decimal)0.07));
            }
            else if (subTotal < 1500)
            {
                return 0;
            }
            else
            {
                return 0;
            }
        }



        private void lookUpLibro_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AgregarDatosCompra();
            }
        }

        private void spinEdit1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                spinEdit1.EditValue = 1;
            }
        }

        private void btnEliminarFila_Click(object sender, EventArgs e)
        {
            if (gvVenta.DataRowCount != 0)
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = XtraMessageBox.Show("¿Estas segur@ de eliminar los datos de venta seleccionados ?", "Mensaje", buttons, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    gvVenta.DeleteRow(gvVenta.FocusedRowHandle);
                    if (gvVenta.DataRowCount == 0)
                    { 
                        txtEfectivo.Enabled = false;
                    }
                    CalcularTotal();
                    txtEfectivo.EditValue = null;
                }
            }
        }

        private void btnEliminarTodo_Click(object sender, EventArgs e)
        {
            if (gvVenta.DataRowCount != 0)
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = XtraMessageBox.Show("¿Estas segur@ de eliminar todos los datos de venta?", "Mensaje", buttons, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    ClerarTable();
                    CalcularTotal();
                    txtEfectivo.Enabled = false;
                    txtEfectivo.EditValue = null;
                    cleanFields();
                }
            }
        }

        public void ClerarTable()
        {
            for (int i = 0; i < gvVenta.RowCount;)
                gvVenta.DeleteRow(i);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (gvVenta.DataRowCount != 0)
            {
                if (txtEfectivo.EditValue != null )
                {
                    if (double.Parse(txtEfectivo.Text) >= double.Parse(txtTotal.Text)) 
                    {

                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result = XtraMessageBox.Show("¿Estas segur@ de continuar con la venta?", "Mensaje", buttons, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {



                            Usuario usuario = new Usuario()
                            {
                                usuario = this.Usuario,
                                password = this.Password
                            }.GetUsuario();
                            Venta v = new Venta();

                            v.idUsuario = usuario.idUsuario;
                            v.subtotal = Decimal.Parse(txtSubTotal.Text);
                            v.descuento = CalcularDescuento();
                            v.total = Decimal.Parse(txtTotal.Text);
                            v.Add();

                            for (int i = 0; i < gvVenta.DataRowCount; i++)
                            {
                                DetalleVenta dv = new DetalleVenta();
                                dv.idLibro = (int)gvVenta.GetRowCellValue(i, "Id Libro");
                                dv.cantidad = (int)gvVenta.GetRowCellValue(i, "Cantidad");
                                dv.precio = (Decimal)gvVenta.GetRowCellValue(i, "Precio");
                                dv.importe = (Decimal)gvVenta.GetRowCellValue(i, "Importe");
                                dv.Add();

                                Inventario inventario = new Inventario();
                                inventario.idProducto = (int)gvVenta.GetRowCellValue(i, "Id Libro");
                                inventario.cantidadDisponible = (int)gvVenta.GetRowCellValue(i, "Cantidad");
                                inventario.AddVenta();
                            }

                            if (cmbImprimir.EditValue == "IMPRIMIR TICKET")
                            {
                                imprimir();
                            }

                            ActualizarLibro();
                            ClerarTable();
                            cleanFields();
                            txtTotal.EditValue = 0;
                            txtSubTotal.EditValue = 0;
                            txtDecuento.EditValue = null;
                            txtCodigoVenta.Text = new Venta().GetProxCod().First();
                            txtEfectivo.Enabled = false;
                            txtEfectivo.EditValue = null;
                            //ActualizarfrmComprasC();
                            XtraMessageBox.Show("¡Venta realizada correctamente!", Application.ProductName,
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    } else
                    {
                        XtraMessageBox.Show("¡Ingrese una cantidad en efectivo mayor al total!", Application.ProductName,
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtEfectivo.Focus();
                    }
                }
                else
                {
                    XtraMessageBox.Show("¡Ingrese una cantidad en efectivo!", Application.ProductName,
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtEfectivo.Focus();
                }
            }
            else 
            {

                XtraMessageBox.Show("¡Agregue Datos de Venta a la Tabla!", Application.ProductName,
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void ActualizarLibro()
        {
            if (System.Windows.Forms.Application.OpenForms["frmVentasC"] != null)
            {
                (System.Windows.Forms.Application.OpenForms["frmVentasC"] as frmVentasC).ActializarfrmVentasC();
            }

            if (System.Windows.Forms.Application.OpenForms["frmLibros"] != null)
            {
                (System.Windows.Forms.Application.OpenForms["frmLibros"] as frmLibros).prueba();
            }
        }


        public void ActializarfrmNMVentas()
        {
            txtCodigoVenta.EditValue = new Venta().GetProxCod().First();
            libroBindingSource.DataSource = new Libro().GetAll();
            this.spinEdit1.Properties.Mask.EditMask = "####;";

        }
        public void cleanFields()
        {
            //lookUpLibro.EditValue = 0;
            //txtPrecio.EditValue = null;
        }

        public void imprimir()
        {
            Usuario usuario = new Usuario()
            {
                usuario = this.Usuario,
                password = this.Password
            }.GetUsuario();

            String Usuario = usuario.nombre
                + " " + usuario.apellido;
            ClassFunciones.ClassFuncionesTicket.CreaTicket Ticket1 = new ClassFunciones.ClassFuncionesTicket.CreaTicket(generateimageCodQR());
            //Ticket1.TextoIzquierda(txtNombre.EditValue.ToString()); //imprime una linea de descripcion
            Ticket1.TextoCentro("LIBRARY BIRD");
            Ticket1.TextoCentro("**********************************");
            Ticket1.TextoIzquierda("Dirección:");
            Ticket1.TextoIzquierda("Bulevar Doctores #507");
            Ticket1.TextoIzquierda("Purisima del Rincon, GTO");
            Ticket1.TextoIzquierda("Tel: 476135672");
            //Ticket1.TextoIzquierda("Rnc: xxxx");
            Ticket1.TextoIzquierda("");
            Ticket1.TextoCentro("Factura de Venta"); //imprime una linea de descripcion
            Ticket1.TextoIzquierda("No Fac: " + txtCodigoVenta.Text);//+ ClassBT.clsDetallesVenta.IdVentafk.ToString());
            Ticket1.TextoIzquierda("Fecha:" + DateTime.Now.ToShortDateString() + " Hora:" + DateTime.Now.ToShortTimeString());
            Ticket1.TextoIzquierda("Le Atendio:");
            Ticket1.TextoIzquierda( Usuario);
            Ticket1.TextoIzquierda("");
            ClassFunciones.ClassFuncionesTicket.CreaTicket.LineasGuion();//-------------------------

            ClassFunciones.ClassFuncionesTicket.CreaTicket.EncabezadoVenta();
            ClassFunciones.ClassFuncionesTicket.CreaTicket.LineasGuion();

            for (int i = 0; i < gvVenta.DataRowCount; i++)
            {
             
                Ticket1.AgregaArticulo(gvVenta.GetRowCellValue(i, "Id Libro").ToString(),double.Parse(gvVenta.GetRowCellValue(i, "Precio").ToString()),(int)gvVenta.GetRowCellValue(i, "Cantidad"), double.Parse(gvVenta.GetRowCellValue(i, "Importe").ToString())); //imprime una linea de descripcion
            }
            //Detalle de la factura
            /*foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                // Articulo                     //Precio                                    cantidad                            Subtotal
                Ticket1.AgregaArticulo(r.Cells[1].Value.ToString(), double.Parse(r.Cells[2].Value.ToString()), int.Parse(r.Cells[3].Value.ToString()), double.Parse(r.Cells[4].Value.ToString())); //imprime una linea de descripcion
            }*/


            ClassFunciones.ClassFuncionesTicket.CreaTicket.LineasGuion();
            Ticket1.TextoIzquierda(" ");
            Ticket1.AgregaTotales("Sub-Total", double.Parse(txtSubTotal.Text)); // imprime linea con Subtotal
            if (double.Parse(txtSubTotal.Text) > 1500)
            {
                Ticket1.AgregaTotales("Menos Descuento", double.Parse((double.Parse(txtSubTotal.Text) * .07).ToString())); // imprime linea con decuento total
            }
            else
            {
                Ticket1.AgregaTotales("Menos Descuento", double.Parse("0"));
            }
            
            //Ticket1.AgregaTotales("Mas ITBIS", double.Parse("000")); // imprime linea con ITBis total
            //Ticket1.TextoIzquierda(" ");
            Ticket1.AgregaTotales("Total", double.Parse(txtTotal.Text)); // imprime linea con total
           // Ticket1.TextoIzquierda(" ");
            Ticket1.AgregaTotales("Efectivo Entregado:", double.Parse(txtEfectivo.Text));
            Ticket1.AgregaTotales("Efectivo Devuelto:", double.Parse(txtCambio.Text));


            // Ticket1.LineasTotales(); // imprime linea 

            //Ticket1.TextoIzquierda(" ");
            Ticket1.TextoCentro("**********************************");
            Ticket1.TextoCentro("*     Gracias por preferirnos    *");
            Ticket1.TextoCentro("**********************************");
           // Ticket1.TextoIzquierda(" ");

            Ticket1.ImprimirTiket(DeserializeJsonFile2(GetImpresoraJsonFile())); ; //Imprimir
        }

        private void txtPrecioU_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtEfectivo_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txtEfectivo_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void txtEfectivo_EditValueChanged(object sender, EventArgs e)
        {

            if (txtEfectivo.Text != "" && double.Parse(txtEfectivo.Text) >= double.Parse(txtTotal.Text))
            {
                txtCambio.EditValue = double.Parse(txtEfectivo.Text) - double.Parse(txtTotal.Text);
            }
            else
            {
                txtCambio.Text = "";
            }
           
        }

        private void frmNVenta_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = XtraMessageBox.Show("¿Estas segur@ de cerrar nueva venta?", "Mensaje", buttons, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
            }
            else
            {
                e.Cancel = true;
            }

        }
    }
    }