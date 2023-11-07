using Projeto.Modelo;
using Projeto_Controle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototipoRH.Login
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            FormBorderStyle = FormBorderStyle.None;


        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            groupBox_Login.Left = (this.Width - groupBox_Login.Width) / 2;
            groupBox_Login.Top = Convert.ToInt32((this.Height - groupBox_Login.Height) / 2.25);
        }

        private void button_Acessar_Click_1(object sender, EventArgs e)
        {
            mdlLogin login = new mdlLogin();
            login.usuario = textBox_Email.Text;
            login.senha = textBox_Senha.Text;

            if (ctlLogin.VerificarLogin(login, out FrmPrincipal.loginAcessado))
            {
                new FrmPrincipal().Show();
                this.Hide();
            }
        }


        //botões de controle da tela
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

    }
}
