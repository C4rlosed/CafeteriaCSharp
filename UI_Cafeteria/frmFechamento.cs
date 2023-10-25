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
    public partial class frmFechamento : Form
    {
        public frmFechamento()
        {
            InitializeComponent();
            btnAtualizarPed.Visible = false;
            btnExcluirPed.Visible = false;
        }

        public void LimparCampos()
        {
            txtMesa.Clear();
            txtCliente.Clear();
            txtCodPed.Clear();
            txtStatus.Clear();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void frmFechamento_Load(object sender, EventArgs e)
        {
            CarregarGrid();
            ConfiguraDataGridView();
        }

        public void CarregarGrid()
        {
            ConsultarPedido consultarPedido = new ConsultarPedido();
            Produtos produtos = new Produtos();

            //Atribeuição dos registros ao DataGrid
            dgvListar.DataSource = consultarPedido.ListarPedido(produtos);
        }

        public void ConfiguraDataGridView()
        {

            if (dgvListar.Rows.Count != 0)
            {
                //Título da coluna
                dgvListar.Columns[0].HeaderText = "Cód Pedido";
                dgvListar.Columns[1].HeaderText = "Mesa";
                dgvListar.Columns[2].HeaderText = "Cliente";
                dgvListar.Columns[3].HeaderText = "Status";

                //Largura da coluna
                dgvListar.Columns[0].Width = 117;
                dgvListar.Columns[1].Width = 60;
                dgvListar.Columns[2].Width = 150;
                dgvListar.Columns[3].Width = 80;

                dgvListar.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void btnAtualizarPed_Click(object sender, EventArgs e)
        {
            AtualizarPedido atualizarPedido = new AtualizarPedido();
            Produtos produtos = new Produtos();
            produtos.codpedido = Convert.ToInt32(txtCodPed.Text);
            produtos.mesa = txtMesa.Text;
            produtos.cliente = txtCliente.Text;
            produtos.status = txtStatus.Text;

            atualizarPedido.AtualizarPedidos(produtos); //Instância da classe e uso do método
            LimparCampos();
            CarregarGrid();
            ConfiguraDataGridView();
            MessageBox.Show(produtos.mensagem, "Aviso", MessageBoxButtons.OK);
        }

        private void btnExcluirPed_Click(object sender, EventArgs e)
        {
            DeletarPedido deletarPedido = new DeletarPedido();
            Produtos produtos = new Produtos();

            produtos.codpedido = Convert.ToInt32(txtCodPed.Text);

            DialogResult confirmacao = MessageBox.Show("Deseja deletar o registro? Código" + txtCodPed, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            LimparCampos();

            if (confirmacao == DialogResult.Yes)
            {
                deletarPedido.DeletarPedidos(produtos);
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
                txtCodPed.Text = dgvListar.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtMesa.Text = dgvListar.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtCliente.Text = dgvListar.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtStatus.Text = dgvListar.Rows[e.RowIndex].Cells[3].Value.ToString();

                btnAtualizarPed.Visible = true;
                btnExcluirPed.Visible = true;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtPesquisaMesa_TextChanged(object sender, EventArgs e)
        {
            ConsultarPedido consultarPedido = new ConsultarPedido();

            //Instânciar da classe ClientsDTO - variáveis
            Produtos produtos = new Produtos();

            //Armazenamento do nome do cliente
            produtos.mesa = txtPesquisaMesa.Text;

            //Chamada do método para a pesquisa e atribuição ao Grid
            dgvListar.DataSource = consultarPedido.ListarPedidosFiltro(produtos);

            //Formatação do Grid
            ConfiguraDataGridView();
        }

        private void txtPesquisaCliente_TextChanged(object sender, EventArgs e)
        {
            ConsultarPedido consultarPedido = new ConsultarPedido();

            //Instânciar da classe ClientsDTO - variáveis
            Produtos produtos = new Produtos();

            //Armazenamento do nome do cliente
            produtos.cliente = txtPesquisaCliente.Text;

            //Chamada do método para a pesquisa e atribuição ao Grid
            dgvListar.DataSource = consultarPedido.ListarPedidosFiltro(produtos);

            //Formatação do Grid
            ConfiguraDataGridView();
        }

    }
}
