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

namespace UI_Cafeteria
{
    public partial class UICadastro : Form
    {
        public UICadastro()
        {
            InitializeComponent();
            btnAtualizar.Visible = false;
            btnExcluir.Visible = false;
        }

        public void LimparCampos()
        {
            txtDescricao.Clear();
            txtTipo.Clear();
            txtQtde.Clear();
            txtUnitario.Clear();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtDescricao.Text == string.Empty || txtTipo.Text == string.Empty)
            {
                MessageBox.Show("Preencha os campos corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            //Instânciar a classe Produtos
            Produtos produtos = new Produtos();
            SalvarProdutos salvarProdutos = new SalvarProdutos();

            produtos.descricao = txtDescricao.Text;
            produtos.tipo = txtTipo.Text;
            produtos.qtde = Convert.ToInt32(txtQtde.Text);
            produtos.unitario = Convert.ToDecimal(txtUnitario.Text);

            //Utilização do método InserirDados
            salvarProdutos.InserirDados(produtos);

            //Texto, Título, Botões, Ícone
            MessageBox.Show(produtos.mensagem, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimparCampos();
            CarregarGrid();
            ConfiguraDataGridView();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void UICadastro_Load(object sender, EventArgs e)
        {
            CarregarGrid();
            ConfiguraDataGridView();
        }

        public void CarregarGrid()
        {
            ConsultarProdutos consultarProdutos = new ConsultarProdutos();
            Produtos produtos = new Produtos();

            //Atribeuição dos registros ao DataGrid
            dgvListar.DataSource = consultarProdutos.ListarProdutos(produtos);
        }

        public void ConfiguraDataGridView()
        {
            
            if (dgvListar.Rows.Count != 0)
            {
                //Título da coluna
                dgvListar.Columns[0].HeaderText = "Código";
                dgvListar.Columns[1].HeaderText = "Descrição";
                dgvListar.Columns[2].HeaderText = "Tipo";
                dgvListar.Columns[3].HeaderText = "Qtde";
                dgvListar.Columns[4].HeaderText = "Unitário R$";

                //Largura da coluna
                dgvListar.Columns[0].Width = 60;
                dgvListar.Columns[1].Width = 195;
                dgvListar.Columns[2].Width = 95;
                dgvListar.Columns[3].Width = 45;
                dgvListar.Columns[4].Width = 95;

                dgvListar.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            ConsultarProdutos consultarProdutos = new ConsultarProdutos();

            //Instânciar da classe ClientsDTO - variáveis
            Produtos produtos = new Produtos();

            //Armazenamento do nome do cliente
            produtos.descricao = txtPesquisar.Text;

            //Chamada do método para a pesquisa e atribuição ao Grid
            dgvListar.DataSource = consultarProdutos.ListarProdutosFiltro(produtos);

            //Formatação do Grid
            ConfiguraDataGridView();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarProdutos atualizarProdutos = new AtualizarProdutos();
            Produtos produtos = new Produtos();
            produtos.codigo = Convert.ToInt32(txtCod.Text);
            produtos.descricao = txtDescricao.Text;
            produtos.tipo = txtTipo.Text;
            produtos.qtde = Convert.ToInt32(txtQtde.Text);
            produtos.unitario = Convert.ToDecimal(txtUnitario.Text);

            atualizarProdutos.AtualizarDados(produtos); //Instância da classe e uso do método
            LimparCampos();
            CarregarGrid();
            ConfiguraDataGridView();
            MessageBox.Show(produtos.mensagem, "Aviso", MessageBoxButtons.OK);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DeletarProduto deletarProduto = new DeletarProduto();
            Produtos produtos = new Produtos();

            produtos.descricao = txtDescricao.Text;

            DialogResult confirmacao = MessageBox.Show("Deseja deletar o registro? Código" + txtDescricao, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            LimparCampos();

            if (confirmacao == DialogResult.Yes)
            {
                deletarProduto.DeletarDados(produtos);
                LimparCampos();
                CarregarGrid();
                ConfiguraDataGridView();
                MessageBox.Show(produtos.mensagem, "Aviso", MessageBoxButtons.OK);
            }
        }

        private void dgvListar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {   //TextBox = DataGridView.LinhaSelecionada.Célula[Posição].ParaTexto
                txtCod.Text = dgvListar.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtDescricao.Text = dgvListar.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtTipo.Text = dgvListar.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtQtde.Text = dgvListar.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtUnitario.Text = dgvListar.Rows[e.RowIndex].Cells[4].Value.ToString();

                btnAtualizar.Visible = true;
                btnExcluir.Visible = true;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
