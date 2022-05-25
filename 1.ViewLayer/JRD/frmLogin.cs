using BML;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
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
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        bool mousedown;
        private Point offset;
        private CustomSimpleButton customSimpleButton = new CustomSimpleButton();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void mouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mousedown = true;
        }

        private void mouseMove(object sender, MouseEventArgs e)
        {
            if (mousedown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);

            }
        }

        private void mouseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;
        }

        private void close(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
           DialogResult result = XtraMessageBox.Show("¿Estas segur@ de cerrar la Aplicación?", "Mensaje", buttons, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                
            }
            
        }

        private void minimizar(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (ValidationsEmptyFields() == true) {
                if (new Usuario { usuario = txtUsuario.Text, password = txtPassword.Text }.Login() != null)
                {
                    foreach (Form form in Application.OpenForms)
                        if (form.GetType() == typeof(frmMain))
                        {
                            form.Activate();

                        }
                    SplashScreenManager.ShowDefaultWaitForm("Por favor espere", "Abriendo Aplicación...");
                    frmMain frmMain = new frmMain(txtUsuario.Text,txtPassword.Text);
                    frmMain.Show();
                    frmMain.FormClosed += Logout;
                    this.Hide();
                    txtUsuario.Text = "";
                    txtPassword.Text = "";
                    SplashScreenManager.CloseDefaultWaitForm();

                }
                else
                {
                    XtraMessageBox.Show("¡Usuario o contraseña incorrectos!", Application.ProductName,
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
        }

        public void mostrarUsuario()
        { 
            
        }

        public bool ValidationsEmptyFields()
        {
            if (txtUsuario.Text.Equals(""))
            {
                msgError("Ingresa un usuario.");
                txtUsuario.Focus();
                return false;
            }
            else if(txtPassword.Text.Equals(""))
            {
                msgError("Ingresa un password.");
                txtPassword.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        private void msgError(String msg)
        { 
            iblErrorMessage.Text = "      " + msg;
            iblErrorMessage.Visible = true;
            btnEntrar.Location = new Point(40, 537);
        }

        private void Logout(object sender, FormClosedEventArgs e)
        {
            this.Show();
            txtUsuario.Focus();
        }

        private void keyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) 
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = XtraMessageBox.Show("¿Estas segur@ de cerrar la Aplicación?", "Mensaje", buttons, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {

                }
            }

        }

        private void txtChanged(object sender, EventArgs e)
        {
            iblErrorMessage.Visible = false;
            btnEntrar.Location = new Point(40, 510);
        }

        private void txtChangedPassword(object sender, EventArgs e)
        {
            iblErrorMessage.Visible = false;
            btnEntrar.Location = new Point(40, 510);
        }
    }
}