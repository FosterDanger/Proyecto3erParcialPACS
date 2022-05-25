using BML;
using DevExpress.XtraEditors;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JRD
{
    public partial class frmImpresoras : DevExpress.XtraEditors.XtraForm
    {
        private static String path = @"C:\Json Sample\Impresora.json";
        private int idLibro = 0;
        bool mousedown;
        private Point offset;
        bool ver = true;

        public frmImpresoras()
        {
            InitializeComponent();
            (new JRD.DropShadow()).ApplyShadows(this);
            PrinterList();
            var impresora = GetImpresoraJsonFile();
            DeserializeJsonFile(impresora);

        }

        public List<ImpresoraJason> GetImpresora()
        {
            
            List<ImpresoraJason> impresora = new List<ImpresoraJason> {

            new ImpresoraJason
            {
                NombreImpresora = cmbeImpresoras.EditValue.ToString() }
            };
            
            return impresora;
        
    
        }

        public static void SerializeJsonFile(List<ImpresoraJason> impresora)
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
            var impresora = JsonConvert.DeserializeObject<List<ImpresoraJason>>(impresoraJsonFile);
            cmbeImpresoras.SelectedIndex = cmbeImpresoras.Properties.Items.IndexOf(impresora[0].NombreImpresora);
        }

        public String DeserializeJsonFile2(String impresoraJsonFile)
        {
            var impresora = JsonConvert.DeserializeObject<List<ImpresoraJason>>(impresoraJsonFile);
            return impresora[0].NombreImpresora;
        }

        private void PrinterList()
        {
            foreach (String sPrinters in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                cmbeImpresoras.Properties.Items.Add(sPrinters);
            }
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

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void frmImpresoras_KeyDown(object sender, KeyEventArgs e)
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

        private void cmbeImpresoras_SelectedIndexChanged(object sender, EventArgs e)
        {
            var impresora = GetImpresora();
            SerializeJsonFile(impresora);
            
            if (ver == false) 

            {
                this.Close();
            }
            ver = false;
        }
    }
}