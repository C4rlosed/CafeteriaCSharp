using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI_Atendimento;

namespace UI_Cafeteria
{
    public partial class frmMenu : Form
    {
        //Definindo um nome para o Form
        private Form frmAtivo;
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        public void AbrirFormulario(Form formfilho)
        {
            FecharFormulario();
            //Define que o formulário passado como parâmetro será
            //Filho do formulário Principal (this)
            frmAtivo = formfilho;
            formfilho.TopLevel = false;
            formfilho.BringToFront();
            pnlForms.Controls.Add(formfilho);
            //formfilho.MdiParent = this;
            //Define a posição iniciar do formulário
            formfilho.StartPosition = FormStartPosition.CenterScreen;
            //Remove a borda do formulário para que não seja movimentado
            formfilho.FormBorderStyle = FormBorderStyle.None;
            //Exibe o formulário para o usuário
            formfilho.Show();
        }

        public void FecharFormulario()
        {
            if (frmAtivo != null)
            {
                frmAtivo.Close();
            }
        }

        public void BotaoPress (Button frmAtivo)
        {
            //Mudar a cor para cada botão(painel) pressionado
            foreach (Control control in pnlPrincipal.Controls)
                control.BackColor = Color.Transparent;
            
            frmAtivo.BackColor = Color.Peru;
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            BotaoPress(btnCadastro);
            FecharFormulario();
            AbrirFormulario(new UICadastro());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            BotaoPress(btnHome);
            FecharFormulario();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            BotaoPress(btnSair);
            //Caixa de dialogo, se deseja sair ou não da aplicação
            DialogResult sair = MessageBox.Show("Deseja sair da aplicação?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //se for sim:
            if (sair == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            BotaoPress(btnPedidos);
            FecharFormulario();
            AbrirFormulario(new frmTelaAtendimento());
        }

        private void btnGePedido_Click(object sender, EventArgs e)
        {
            BotaoPress(btnGePedido);
            FecharFormulario();
            AbrirFormulario(new frmFechamento());
        }
    }
}
