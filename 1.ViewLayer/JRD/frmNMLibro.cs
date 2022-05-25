using BML;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JRD
{
    public partial class frmNMLibro : DevExpress.XtraEditors.XtraForm
    {
        private int idLibro = 0;
        bool mousedown;
        private Point offset;

       

        public frmNMLibro(String text)
        {
            InitializeComponent();
            (new JRD.DropShadow()).ApplyShadows(this);
            lblTitle.Text = text;
            DateTime localDate = DateTime.Now;
            dateEdit.EditValue = localDate;
            autorBindingSource.DataSource = new Autor().GetAll();
            editorialBindingSource.DataSource = new Editorial().GetAll();
            categoriaBindingSource.DataSource = new Categoria().GetAll();
            // editorialBindingSource.DataSource = new Editorial().GetAll();
            //categoriaBindingSource.DataSource = new Categoria().GetAll();
            /*lookCategorias.Properties.DataSource = new Categoria().GetAll();
            lookCategorias.Properties.DisplayMember = "descripcion";
            lookCategorias.Properties.ValueMember = "idCategoria";*/
            if (new Categoria().GetAll() != null && new Categoria().GetAll().GetEnumerator().MoveNext())
            {
                lookCategorias.EditValue = new Categoria().GetAll().First().idCategoria;
            }

            



            /* lookAutores.Properties.DataSource = new Autor().GetAll();
             lookAutores.Properties.DisplayMember = "nombre";
             lookAutores.Properties.ValueMember = "idAutor";*/
            if (new Autor().GetAll() != null && new Autor().GetAll().GetEnumerator().MoveNext())
            {
                lookAutores.EditValue = new Autor().GetAll().First().idAutor;

            }

            

            /* lookEditoriales.Properties.DataSource = new Editorial().GetAll();
             lookEditoriales.Properties.DisplayMember = "nombre";*/
            if (new Editorial().GetAll() != null && new Editorial().GetAll().GetEnumerator().MoveNext())
            {
                lookEditoriales.EditValue = new Editorial().GetAll().First().idEditorial;
            }

          
            txtCodigo.EditValue = new Libro().GetProxCod().First();
            generateCodQR();


        }

        public void generateCodQR()
        {
            QrEncoder qrEncoder = new QrEncoder(ErrorCorrectionLevel.H);
            QrCode qrCode = new QrCode();
            qrEncoder.TryEncode(txtCodigo.Text.Trim(), out qrCode);

            GraphicsRenderer renderer = new GraphicsRenderer(new FixedCodeSize(560, QuietZoneModules.Zero), Brushes.Black, Brushes.White);
            MemoryStream ms = new MemoryStream();
            renderer.WriteToStream(qrCode.Matrix, ImageFormat.Png, ms);
            var imageTemporal = new Bitmap(ms);
            var image = new Bitmap(imageTemporal, new Size(new Point(280, 280)));

           // pictureQR.BackgroundImage = image;
            pictureQR.Image = image;
            //image.Save("image.png", ImageFormat.Png);
        }

        public Image generateimageCodQR()
        {
            QrEncoder qrEncoder = new QrEncoder(ErrorCorrectionLevel.H);
            QrCode qrCode = new QrCode();
            qrEncoder.TryEncode(txtCodigo.Text.Trim(), out qrCode);

            GraphicsRenderer renderer = new GraphicsRenderer(new FixedCodeSize(560, QuietZoneModules.Zero), Brushes.Black, Brushes.White);
            MemoryStream ms = new MemoryStream();
            renderer.WriteToStream(qrCode.Matrix, ImageFormat.Png, ms);
            var imageTemporal = new Bitmap(ms);
            var image = new Bitmap(imageTemporal, new Size(new Point(280, 280)));

            // pictureQR.BackgroundImage = image;
            pictureQR.Image = image;
            return image;
            //image.Save("image.png", ImageFormat.Png);
        }

        public frmNMLibro(String text, int idLibro)
        {
            InitializeComponent();
            (new JRD.DropShadow()).ApplyShadows(this);
            lblTitle.Text = text;
            this.idLibro = idLibro;
            autorBindingSource.DataSource = new Autor().GetAll();
            editorialBindingSource.DataSource = new Editorial().GetAll();
            categoriaBindingSource.DataSource = new Categoria().GetAll();

            Libro libro = new Libro
            {
                idLibro = this.idLibro,
            }.GetById();
            txtNombre.Text = libro.nombre;
            lookAutores.EditValue = libro.idAutor;
            lookEditoriales.EditValue = libro.idEditorial;
            lookCategorias.EditValue = libro.idCategoria;
            dateEdit.EditValue = libro.fechaLanzamiento;
            cmbeVentasPrestamos.EditValue = libro.ventaPrestamo;
            txtPrecioU.EditValue = libro.precioUnitario;
            txtCodigo.EditValue = libro.codigoLibro;
            generateCodQR();
            cmbImprimir.SelectedIndex = 2;
        }

        private void panelControl3_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mousedown = true;
        }

        private void panelControl3_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);

            }
        }

        private void panelControl3_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = XtraMessageBox.Show("¿Estas segur@ de cerrar " + lblTitle.Text + " ?", "Mensaje", buttons, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (ValidationsEmptyFields() == true)
            {
                if (idLibro > 0)
                {
                    if (new Libro
                    {
                        idLibro = this.idLibro,
                        nombre = txtNombre.EditValue.ToString(),
                        idAutor = (int)lookAutores.EditValue,
                        idEditorial = (int)lookEditoriales.EditValue,
                        idCategoria = (int)lookCategorias.EditValue,
                        precioUnitario = Decimal.Parse(txtPrecioU.EditValue.ToString()),
                        fechaLanzamiento = (DateTime)dateEdit.EditValue,
                        ventaPrestamo = cmbeVentasPrestamos.EditValue.ToString()
                    }.Update() > 0)
                    {
                        ActualizarLookupLibros();
                        XtraMessageBox.Show("Libro actualizado correctamente", Application.ProductName,
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (cmbImprimir.SelectedIndex == 0)
                        {
                            splashScreenManager1.ShowWaitForm();
                            Thread.Sleep(2000);
                            splashScreenManager1.CloseWaitForm();
                            imprimir();
                            this.Close();
                        }
                        else {
                            this.Close();
                        }
                    }
                    else
                    {
                       
                        XtraMessageBox.Show("El registro ya existe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        if (cmbImprimir.SelectedIndex == 0)
                        {
                            splashScreenManager1.ShowWaitForm();
                            Thread.Sleep(2000);
                            splashScreenManager1.CloseWaitForm();
                            imprimir();
                            this.Close();
                        }
                        else 
                        {
                            this.Close();
                        }
                       
                    }

                }
                else
                {
                    if (new Libro
                    {
                        nombre = txtNombre.Text,
                        idAutor = (int)lookAutores.EditValue,
                        idEditorial = (int)lookEditoriales.EditValue,
                        idCategoria = (int)lookCategorias.EditValue,
                        precioUnitario = Decimal.Parse(txtPrecioU.EditValue.ToString()),
                        fechaLanzamiento = (DateTime)dateEdit.EditValue,
                        ventaPrestamo = cmbeVentasPrestamos.EditValue.ToString()
                    }.Add() > 0)
                    {
                        ActualizarLookupLibros();
                        XtraMessageBox.Show("Libro almacenado correctamente", Application.ProductName,
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (cmbImprimir.SelectedIndex == 0)
                        {
                            imprimir();
                        }
                        cleanFields();
                        txtCodigo.EditValue = new Libro().GetProxCod().First();
                        generateCodQR();
                    }
                    else { XtraMessageBox.Show("El registro ya existe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning); cleanFields(); }

                }
            }
        }


        public void ActualizarLookupLibros()
        {
            if (System.Windows.Forms.Application.OpenForms["frmCompras"] != null)
            {
                (System.Windows.Forms.Application.OpenForms["frmCompras"] as frmCompras).ActualizarLibroCompras();
            }

            if (System.Windows.Forms.Application.OpenForms["frmVentasC"] != null)
            {
                (System.Windows.Forms.Application.OpenForms["frmVentasC"] as frmVentasC).ActializarfrmVentasC();
            }

            if (System.Windows.Forms.Application.OpenForms["frmNVenta"] != null)
            {
                (System.Windows.Forms.Application.OpenForms["frmNVenta"] as frmNVenta).ActializarfrmNMVentas();
            }

            if (System.Windows.Forms.Application.OpenForms["frmCompras"] != null)
            {
                (System.Windows.Forms.Application.OpenForms["frmCompras"] as frmCompras).ActualizarLibroCompras();
            }

            if (System.Windows.Forms.Application.OpenForms["frmCompras"] != null)
            {
                (System.Windows.Forms.Application.OpenForms["frmCompras"] as frmCompras).ActualizarProveedorCompras();

                if (System.Windows.Forms.Application.OpenForms["frmLibros"] != null)
                {
                    (System.Windows.Forms.Application.OpenForms["frmLibros"] as frmLibros).prueba();
                }
            }
        }

       

        public void cleanFields()
        {
            DateTime localDate = DateTime.Now;
            txtNombre.Text = "";
            lookCategorias.EditValue = new Categoria().GetAll().First().idCategoria;
            lookAutores.EditValue = new Autor().GetAll().First().idAutor;
            lookEditoriales.EditValue = new Editorial().GetAll().First().idEditorial;
            txtPrecioU.EditValue = null;
            cmbeVentasPrestamos.EditValue = null;
            dateEdit.EditValue = localDate;
            txtCodigo.EditValue = null;
            pictureQR.Image = null;

        }

        public bool ValidationsEmptyFields()
        {
            if (txtNombre.Text.Equals(""))
            {
                XtraMessageBox.Show("¡Ingresa un Libro!", Application.ProductName,
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNombre.Focus();
                return false;
            }
            else if (dateEdit.Text.Equals(""))
            {
                XtraMessageBox.Show("¡Ingresa una fecha de lanzamiento!", Application.ProductName,
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                dateEdit.Focus();
                return false;
            }
            else if (txtPrecioU.Text.Equals("") || txtPrecioU.EditValue == null)
            {
                XtraMessageBox.Show("¡Ingresa un Precio Unitario!", Application.ProductName,
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPrecioU.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnAgregarAutor_Click(object sender, EventArgs e)
        {
            popupMenu2.ShowPopup(Control.MousePosition);
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNMAutor("Nuevo Autor").ShowDialog();
            autorBindingSource.DataSource = new Autor().GetAll();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            new frmNMAutor("Modificar Autor", (int)lookAutores.EditValue).ShowDialog();
            autorBindingSource.DataSource = new Autor().GetAll();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNMEditorial("Nueva Editorial").ShowDialog();
            editorialBindingSource.DataSource = new Editorial().GetAll();
        }

        private void btnAgregarEditorial_Click(object sender, EventArgs e)
        {
            popupMenu1.ShowPopup(Control.MousePosition);
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNMEditorial("Modificar Editorial", (int)lookEditoriales.EditValue).ShowDialog();
            editorialBindingSource.DataSource = new Editorial().GetAll();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNMCategoria("Nueva Categoria").ShowDialog();
            categoriaBindingSource.DataSource = new Categoria().GetAll();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNMCategoria("Modificar Categoria", (int)lookCategorias.EditValue).ShowDialog();
            categoriaBindingSource.DataSource = new Categoria().GetAll();
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            popupMenu3.ShowPopup(Control.MousePosition);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = XtraMessageBox.Show("¿Estas segur@ de cerrar " + lblTitle.Text + " ?", "Mensaje", buttons, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                XtraMessageBox.Show("¡Elige una opcion entre Venta y Prestamo!", Application.ProductName,
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbeVentasPrestamos.Focus();
            }
        }

        private void frmNMLibro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = XtraMessageBox.Show("¿Estas segur@ de cerrar " + lblTitle.Text + " ?", "Mensaje", buttons, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    this.Close();
                }
                else
                {

                }
            }
        }

        public void imprimir()
        {
            ClassFunciones.ClassFunciones.CreaTicket Ticket1 = new ClassFunciones.ClassFunciones.CreaTicket(generateimageCodQR(),txtNombre.Text);
            Ticket1.TextoIzquierda(txtNombre.EditValue.ToString()); //imprime una linea de descripcion
            /*Ticket1.TextoCentro("**********************************");

            Ticket1.TextoIzquierda("Dirc: xxxx");
            Ticket1.TextoIzquierda("Tel:xxxx ");
            Ticket1.TextoIzquierda("Rnc: xxxx");
            Ticket1.TextoIzquierda("");
            Ticket1.TextoCentro("Factura de Venta"); //imprime una linea de descripcion
            Ticket1.TextoIzquierda("No Fac:");//+ ClassBT.clsDetallesVenta.IdVentafk.ToString());
            Ticket1.TextoIzquierda("Fecha:" + DateTime.Now.ToShortDateString() + " Hora:" + DateTime.Now.ToShortTimeString());
            Ticket1.TextoIzquierda("Le Atendio: xxxx");
            Ticket1.TextoIzquierda("");
            ClassFunciones.ClassFunciones.CreaTicket.LineasGuion();//-------------------------

            ClassFunciones.ClassFunciones.CreaTicket.EncabezadoVenta();
            ClassFunciones.ClassFunciones.CreaTicket.LineasGuion();
            //Detalle de la factura
            /*foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                // Articulo                     //Precio                                    cantidad                            Subtotal
                Ticket1.AgregaArticulo(r.Cells[1].Value.ToString(), double.Parse(r.Cells[2].Value.ToString()), int.Parse(r.Cells[3].Value.ToString()), double.Parse(r.Cells[4].Value.ToString())); //imprime una linea de descripcion
            }*/


            /*ClassFunciones.ClassFunciones.CreaTicket.LineasGuion();
            Ticket1.AgregaTotales("Sub-Total", double.Parse("000")); // imprime linea con Subtotal
            Ticket1.AgregaTotales("Menos Descuento", double.Parse("000")); // imprime linea con decuento total
            Ticket1.AgregaTotales("Mas ITBIS", double.Parse("000")); // imprime linea con ITBis total
            Ticket1.TextoIzquierda(" ");
            Ticket1.AgregaTotales("Total", double.Parse("12")); // imprime linea con total
            Ticket1.TextoIzquierda(" ");
            Ticket1.AgregaTotales("Efectivo Entregado:", double.Parse("12"));
            Ticket1.AgregaTotales("Efectivo Devuelto:", double.Parse("12"));


            // Ticket1.LineasTotales(); // imprime linea 

            Ticket1.TextoIzquierda(" ");
            Ticket1.TextoCentro("**********************************");
            Ticket1.TextoCentro("*     Gracias por preferirnos    *");
            Ticket1.TextoCentro("**********************************");
            Ticket1.TextoIzquierda(" ");*/

            Ticket1.ImprimirTiket(DeserializeJsonFile2(GetImpresoraJsonFile())); ; //Imprimir
        }

        public static String GetImpresoraJsonFile()
        {
            String ImpresoraJasonFromFile;
            using (var reader = new StreamReader(@"C:\Json Sample\Impresora.json"))
            {
                ImpresoraJasonFromFile = reader.ReadToEnd();
            }
            return ImpresoraJasonFromFile;
        }

        public String DeserializeJsonFile2(String impresoraJsonFile)
        {
            var impresora = JsonConvert.DeserializeObject<List<ImpresoraJason>>(impresoraJsonFile);
            return impresora[0].NombreImpresora;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void dateEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void panelControl3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            new frmImpresoras().ShowDialog();
           
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = XtraMessageBox.Show("¿Estas segur@ de eliminar el autor " + lookAutores.Text + " ?", "Mensaje", buttons, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                new Autor
                {
                    idAutor = (int)lookAutores.EditValue
                }.Delete();
                autorBindingSource.DataSource = new Autor().GetAll();
                lookAutores.EditValue = new Autor().GetAll().First().idAutor;
                XtraMessageBox.Show("¡Autor eliminado correctamente!", Application.ProductName,
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            { 
            
            }
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnEliminarCategoria_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}