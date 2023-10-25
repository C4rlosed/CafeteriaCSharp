using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using MySql.Data.MySqlClient;
using UI_Cafeteria;
using UI_Atendimento;

namespace Engenharia
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            LoginDTO login = new LoginDTO();
            AcessarLogin acessarLogin = new AcessarLogin();
            login.usuario = txtUsuario.Text;
            login.senha = txtSenha.Text;
            acessarLogin.Acessar(login);
            if (login.logado == 1)
            {
                MessageBox.Show(login.mensagem, "Aviso");
                AtualizarLogon atualizarLogon = new AtualizarLogon();
                atualizarLogon.AtualizarLogado(login);
                frmMenu menu = new frmMenu();
                menu.Show();
                this.Hide();
                menu.FecharFormulario();
            }
            else
            {
                MessageBox.Show(login.mensagem, "Usuário ou Senha incorretos");
                /*txtSenha.Clear();
                txtUsuario.Clear();
                txtUsuario.Focus();*/
            }
            
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Ação a ser feita
                LoginDTO login = new LoginDTO();
                AcessarLogin acessarLogin = new AcessarLogin();
                login.usuario = txtUsuario.Text;
                login.senha = txtSenha.Text;
                acessarLogin.Acessar(login);
                if (login.logado == 1)
                {
                    MessageBox.Show(login.mensagem, "Aviso");
                    AtualizarLogon atualizarLogon = new AtualizarLogon();
                    atualizarLogon.AtualizarLogado(login);
                    frmMenu menu = new frmMenu();
                    menu.Show();
                    this.Hide();
                    menu.FecharFormulario();
                }
                else
                {
                    MessageBox.Show(login.mensagem, "Usuário ou Senha incorretos");
                    /*txtSenha.Clear();
                    txtUsuario.Clear();
                    txtUsuario.Focus();*/
                }
            }
        }
    }
}
