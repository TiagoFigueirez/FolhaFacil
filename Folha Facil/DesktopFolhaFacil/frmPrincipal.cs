using PrototipoRH.Empresas;
using PrototipoRH.Funcionarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrototipoRH.Folha_de_Pagamento;
using PrototipoRH.Ferias;
using PrototipoRH.Usuarios;
using Projeto.Modelo;
using PrototipoRH.Apontamento_de_Horas;

namespace PrototipoRH
{
    public partial class FrmPrincipal : Form
    {

        public static mdlLogin loginAcessado = new mdlLogin();

        //objetos e variavéis 
        private Form frmActive;
        public FrmPrincipal()
        {
            InitializeComponent();

            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            Color CustomColor1 = Color.FromArgb(18, 104, 129);
            PanelTitleBar.BackColor = CustomColor1;
            BtnHome.BackColor = Color.FromArgb(18, 104, 129);
        }

        //metodos do front

        private void ActiveFormClose()
        {
            if (frmActive != null)
            {
                frmActive.Close();
            }
        }

        

        private void FormShow(Form ChildForm)
        {
            ActiveFormClose();
            frmActive = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            PanelDesktop.Controls.Add(ChildForm);
            ChildForm.BringToFront();
            ChildForm.Show();
            LblTitle.Text = ChildForm.Text;
        }

        private void ActiveButton(Button FrmAtivo)
        {
            foreach (Control ctrl in PanelMenu.Controls)
                ctrl.BackColor = Color.FromArgb(51, 51, 76);
            FrmAtivo.BackColor = PanelTitleBar.BackColor;
        }

        //eventos dos botões do menu
        private void BtnHome_Click(object sender, EventArgs e)
        {
            LblTitle.Text = $"BEM VINDO, {loginAcessado.usuario.ToUpper()} ";
            ActiveButton(BtnHome);
            Color panelLogo = Color.FromArgb(13, 80, 99);
            PaneLogo.BackColor = panelLogo;
            ActiveFormClose();
        }

        private void BtnFolhaPagamento_Click(object sender, EventArgs e)
        {
            ActiveFormClose();
            ActiveButton(BtnFolhaPagamento);
            Color panelLogo = Color.FromArgb(13, 80, 99);
            PaneLogo.BackColor = panelLogo;
            FormShow(new frmFolhaPagamento());
        }

        private void btnFerias_Click(object sender, EventArgs e)
        {

            ActiveFormClose();
            ActiveButton(btnFerias);
            Color panelLogo = Color.FromArgb(13, 80, 99);
            PaneLogo.BackColor = panelLogo;
            FormShow(new frmFerias());
        }

        private void BtnFuncionario_Click(object sender, EventArgs e)
        {
            ActiveFormClose();
            ActiveButton(BtnFuncionario);
            Color panelLogo = Color.FromArgb(13, 80, 99);
            PaneLogo.BackColor = panelLogo;
            FormShow(new frmFuncionario());
        }

        private void BtnEmpresa_Click(object sender, EventArgs e)
        {
            ActiveFormClose();
            ActiveButton(BtnEmpresa);
            Color panelLogo = Color.FromArgb(13, 80, 99);
            PaneLogo.BackColor = panelLogo;
            FormShow(new frmEmpresa());
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            if (!FrmPrincipal.loginAcessado.administrador)
            {
                MessageBox.Show("O seu nível de login é insuficiente para usar este módulo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ActiveFormClose();
            ActiveButton(btnUsuario);
            Color panelLogo = Color.FromArgb(13, 80, 99);
            PaneLogo.BackColor = panelLogo;
            FormShow(new frmUsuario());
        }

        //botôes do topo da barra de controle
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMaximize_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
                this.WindowState= FormWindowState.Maximized;
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

        private void PanelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            LblTitle.Text = $"BEM VINDO, {loginAcessado.usuario.ToUpper()}! ";
        }

        private void btnApontamentoHoras_Click(object sender, EventArgs e)
        {
            ActiveFormClose();
            ActiveButton(btnApontamentoHoras);
            Color panelLogo = Color.FromArgb(13, 80, 99);
            PaneLogo.BackColor = panelLogo;
            FormShow(new frmApontamentoHoras());
        }
    }

}  

