using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Importar o conteúdo de BLL para o formulário.
using BLL_Atendimento;


namespace UI_Atendimento
{
    public partial class frmTelaAtendimento : Form
    {
        public frmTelaAtendimento()
        {
            InitializeComponent();
        }

        private void frmTelaAtendimento_Load(object sender, EventArgs e)
        {
            tipBotao.SetToolTip(btnBebidas, "Bebidas");
            tipBotao.SetToolTip(btnSalgados, "Salgados");
            tipBotao.SetToolTip(btnSobremesas, "Sobremesas");
        }

        private void btnBebidas_Click(object sender, EventArgs e)
        {
            grpBebidas.Visible = true;
            foreach (Control control in grpBebidas.Controls)
            {
                control.Visible = true;
            }

            foreach (Control control in grpSalgados.Controls)
            {
                control.Visible = false;
            }
            grpSalgados.Visible = false;

            foreach (Control control in grpSobremesas.Controls)
            {
                control.Visible = true;
            }
            grpSobremesas.Visible = false;

            //button1.Visible = true;
        }

        private void btnSalgados_Click(object sender, EventArgs e)
        {

            foreach (Control control in grpSalgados.Controls)
            {
                control.Visible = true;
            }
            grpSalgados.Visible = true;

            foreach (Control control in grpSobremesas.Controls)
            {
                control.Visible = false;
            }
            grpSobremesas.Visible = false;

            foreach (Control control in grpBebidas.Controls)
            {
                control.Visible = false;
            }
            grpBebidas.Visible = false;

        }

        private void btnSobremesas_Click(object sender, EventArgs e)
        {
            grpSobremesas.Visible = true;
            foreach (Control control in grpSobremesas.Controls)
            {
                control.Visible = true;
            }

            foreach (Control control in grpSalgados.Controls)
            {
                control.Visible = false;
            }
            grpSalgados.Visible = false;

            foreach (Control control in grpBebidas.Controls)
            {
                control.Visible = false;
            }
            grpBebidas.Visible = false;
        }

        private void btnExpresso_Click(object sender, EventArgs e)
        {
            ConsultarPedido consultarPedido = new ConsultarPedido();
            PedidoDTO pedido = new PedidoDTO();
            pedido.descricao = btnExpresso.Text;
            pedido.mesa = cboMesa.Text;
            pedido.nome = txtNome.Text;

            consultarPedido.ConsultaUnitario(pedido);

            dgvResumo.Rows.Add("1", "Café Expresso", pedido.unitario, pedido.mesa, pedido.nome);

            CalcularTotalaPagar();
        }

        private void btnCoado_Click(object sender, EventArgs e)
        {
            ConsultarPedido consultarPedido = new ConsultarPedido();
            PedidoDTO pedido = new PedidoDTO();
            pedido.descricao = btnCoado.Text;
            pedido.mesa = cboMesa.Text;
            pedido.nome = txtNome.Text;

            consultarPedido.ConsultaUnitario(pedido);

            dgvResumo.Rows.Add("1", "Café Coado", pedido.unitario, pedido.mesa, pedido.nome);

            CalcularTotalaPagar();
        }

        private void btnCafeLeite_Click(object sender, EventArgs e)
        {
            ConsultarPedido consultarPedido = new ConsultarPedido();
            PedidoDTO pedido = new PedidoDTO();
            pedido.descricao = btnCafeLeite.Text;
            pedido.mesa = cboMesa.Text;
            pedido.nome = txtNome.Text;

            consultarPedido.ConsultaUnitario(pedido);

            dgvResumo.Rows.Add("1", "Café com Leite", pedido.unitario, pedido.mesa, pedido.nome);

            CalcularTotalaPagar();
        }

        private void btnAchocolatado_Click(object sender, EventArgs e)
        {
            ConsultarPedido consultarPedido = new ConsultarPedido();
            PedidoDTO pedido = new PedidoDTO();
            pedido.descricao = btnAchocolatado.Text;
            pedido.mesa = cboMesa.Text;
            pedido.nome = txtNome.Text;

            consultarPedido.ConsultaUnitario(pedido);

            dgvResumo.Rows.Add("1", "Achocolatado", pedido.unitario, pedido.mesa, pedido.nome);

            CalcularTotalaPagar();
        }

        private void btnCappuccino_Click(object sender, EventArgs e)
        {
            ConsultarPedido consultarPedido = new ConsultarPedido();
            PedidoDTO pedido = new PedidoDTO();
            pedido.descricao = btnCappuccino.Text;
            pedido.mesa = cboMesa.Text;
            pedido.nome = txtNome.Text;

            consultarPedido.ConsultaUnitario(pedido);

            dgvResumo.Rows.Add("1", "Cappuccino", pedido.unitario, pedido.mesa, pedido.nome);

            CalcularTotalaPagar();
        }

        private void btnAgua_Click(object sender, EventArgs e)
        {
            ConsultarPedido consultarPedido = new ConsultarPedido();
            PedidoDTO pedido = new PedidoDTO();
            pedido.descricao = btnAgua.Text;
            pedido.mesa = cboMesa.Text;
            pedido.nome = txtNome.Text;

            consultarPedido.ConsultaUnitario(pedido);

            dgvResumo.Rows.Add("1", "Água", pedido.unitario, pedido.mesa, pedido.nome);

            CalcularTotalaPagar();
        }

        private void btnRefrigerante_Click(object sender, EventArgs e)
        {
            ConsultarPedido consultarPedido = new ConsultarPedido();
            PedidoDTO pedido = new PedidoDTO();
            pedido.descricao = btnRefrigerante.Text;
            pedido.mesa = cboMesa.Text;
            pedido.nome = txtNome.Text;

            consultarPedido.ConsultaUnitario(pedido);

            dgvResumo.Rows.Add("1", "Refrigerante", pedido.unitario, pedido.mesa, pedido.nome);

            CalcularTotalaPagar();

        }

        private void btnBatata_Click(object sender, EventArgs e)
        {
            ConsultarPedido consultarPedido = new ConsultarPedido();
            PedidoDTO pedido = new PedidoDTO();
            pedido.descricao = btnBatata.Text;
            pedido.mesa = cboMesa.Text;
            pedido.nome = txtNome.Text;

            consultarPedido.ConsultaUnitario(pedido);

            dgvResumo.Rows.Add("1", "Batata", pedido.unitario, pedido.mesa, pedido.nome);

            CalcularTotalaPagar();
        }

        private void btnFrango_Click(object sender, EventArgs e)
        {
            ConsultarPedido consultarPedido = new ConsultarPedido();
            PedidoDTO pedido = new PedidoDTO();
            pedido.descricao = btnFrango.Text;
            pedido.mesa = cboMesa.Text;
            pedido.nome = txtNome.Text;

            consultarPedido.ConsultaUnitario(pedido);

            dgvResumo.Rows.Add("1", "Frango", pedido.unitario, pedido.mesa, pedido.nome);

            CalcularTotalaPagar();
        }

        private void btnEmpadinha_Click(object sender, EventArgs e)
        {
            ConsultarPedido consultarPedido = new ConsultarPedido();
            PedidoDTO pedido = new PedidoDTO();
            pedido.descricao = btnEmpadinha.Text;
            pedido.mesa = cboMesa.Text;
            pedido.nome = txtNome.Text;

            consultarPedido.ConsultaUnitario(pedido);

            dgvResumo.Rows.Add("1", "Empadinha", pedido.unitario, pedido.mesa, pedido.nome);

            CalcularTotalaPagar();
        }

        private void btnMistoQuente_Click(object sender, EventArgs e)
        {
            ConsultarPedido consultarPedido = new ConsultarPedido();
            PedidoDTO pedido = new PedidoDTO();
            pedido.descricao = btnMistoQuente.Text;
            pedido.mesa = cboMesa.Text;
            pedido.nome = txtNome.Text;

            consultarPedido.ConsultaUnitario(pedido);

            dgvResumo.Rows.Add("1", "Misto Quente", pedido.unitario, pedido.mesa, pedido.nome);

            CalcularTotalaPagar();
        }

        private void btnPaoChapa_Click(object sender, EventArgs e)
        {
            ConsultarPedido consultarPedido = new ConsultarPedido();
            PedidoDTO pedido = new PedidoDTO();
            pedido.descricao = btnPaoChapa.Text;
            pedido.mesa = cboMesa.Text;
            pedido.nome = txtNome.Text;

            consultarPedido.ConsultaUnitario(pedido);

            dgvResumo.Rows.Add("1", "Pão na Chapa", pedido.unitario, pedido.mesa, pedido.nome);

            CalcularTotalaPagar();
        }

        private void btnBoloIndividual_Click(object sender, EventArgs e)
        {
            ConsultarPedido consultarPedido = new ConsultarPedido();
            PedidoDTO pedido = new PedidoDTO();
            pedido.descricao = btnBoloIndividual.Text;
            pedido.mesa = cboMesa.Text;
            pedido.nome = txtNome.Text;

            consultarPedido.ConsultaUnitario(pedido);

            dgvResumo.Rows.Add("1", "Bolo Individual", pedido.unitario, pedido.mesa, pedido.nome);

            CalcularTotalaPagar();
        }

        private void btnBoloInteiro_Click(object sender, EventArgs e)
        {
            ConsultarPedido consultarPedido = new ConsultarPedido();
            PedidoDTO pedido = new PedidoDTO();
            pedido.descricao = btnBoloInteiro.Text;
            pedido.mesa = cboMesa.Text;
            pedido.nome = txtNome.Text;

            consultarPedido.ConsultaUnitario(pedido);

            dgvResumo.Rows.Add("1", "Bolo Inteiro", pedido.unitario, pedido.mesa, pedido.nome);

            CalcularTotalaPagar();
        }

        private void btnBrownie_Click(object sender, EventArgs e)
        {
            ConsultarPedido consultarPedido = new ConsultarPedido();
            PedidoDTO pedido = new PedidoDTO();
            pedido.descricao = btnBrownie.Text;
            pedido.mesa = cboMesa.Text;
            pedido.nome = txtNome.Text;

            consultarPedido.ConsultaUnitario(pedido);

            dgvResumo.Rows.Add("1", "Brownie", pedido.unitario, pedido.mesa, pedido.nome);

            CalcularTotalaPagar();
        }

        private void btnAcai_Click(object sender, EventArgs e)
        {
            ConsultarPedido consultarPedido = new ConsultarPedido();
            PedidoDTO pedido = new PedidoDTO();
            pedido.descricao = btnAcai.Text;
            pedido.mesa = cboMesa.Text;
            pedido.nome = txtNome.Text;

            consultarPedido.ConsultaUnitario(pedido);

            dgvResumo.Rows.Add("1", "Açaí", pedido.unitario, pedido.mesa, pedido.nome);

            CalcularTotalaPagar();
        }

        public void CarregarGrid()
        {
            //Instância da classe ConsultarPedidos e PedidosDTO
            ConsultarPedido consultarPedido = new ConsultarPedido();
            PedidoDTO pedido = new PedidoDTO();

            //Atribuição dos registros ao DataGridView
            dgvResumo.DataSource = consultarPedido.ListarDadosPedido(pedido);

            //Procedimnto para alterar os títulos e propriedades das colunas
            //ConfiguraDataGridView();

            //Verificar se houve erro na estrutura da tabela
            if (!string.IsNullOrEmpty(pedido.mensagem))
            {
                MessageBox.Show(pedido.mensagem);
            }
        }

        private void dgvResumo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnExcluir.Visible = true;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            dgvResumo.Rows.RemoveAt(dgvResumo.CurrentRow.Index);
        }

        /*public void CalcularTotalaPagar()
        {
            //Instância: armazenando a classe Produtos em uma variável
            Produtos produtos = new Produtos();

            //foreach - para cada - somar cada Total Geral dos Produtos
            foreach (DataGridViewRow linha in dgvResumo.Rows)
            {
                //+= adicionar um valor ao que já tem
                produtos.totalPagar += Convert.ToDecimal(
                    linha.Cells["TotalGeral"].Value);
            }
            lblTotalPagar.Text = produtos.totalPagar.ToString("F");
            //F é 0,00 e o C é R$ 0,00
        }*/


        public void LimparCampos()
        {
            dgvResumo.Rows.Clear();
        }

        public void CalcularTotalaPagar()
        {
            //Instância: armazenando a classe Produtos em uma variável
            PedidoDTO pedido = new PedidoDTO();

            //foreach - para cada - somar cada Total Geral dos Produtos
            foreach (DataGridViewRow linha in dgvResumo.Rows)
            {
                //+= adicionar um valor ao que já tem
                pedido.totalPagar += Convert.ToDecimal(
                    linha.Cells["Unitario"].Value);
            }
            txtTotalPagar.Text = pedido.totalPagar.ToString("C");
            //F é 0,00 e o C é R$ 0,00
        }

        private void txtTotalPagar_TextChanged(object sender, EventArgs e)
        {
            CalcularTotalaPagar();
        }

        private void dgvResumo_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            CalcularTotalaPagar();
        }

        private void btnFinalizar_Click_1(object sender, EventArgs e)
        {
            if (dgvResumo.Rows.Count == 0)
            {
                MessageBox.Show("Selecione o pedido desejado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;

            }
            else
            {
                MessageBox.Show("Pedido realizado com sucesso!", "Concluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            //Instânciar a classe PedidosDTO
            PedidoDTO pedidos = new PedidoDTO();
            SalvarPedidos salvarPedidos = new SalvarPedidos();

            for (int i = 0; i < dgvResumo.Rows.Count; i++)
            {
                pedidos.quantidade = Convert.ToInt32(dgvResumo.Rows[i].Cells[0].Value.ToString());
                pedidos.descricao = dgvResumo.Rows[i].Cells[1].Value.ToString();
                pedidos.unitario = Convert.ToDecimal(dgvResumo.Rows[i].Cells[2].Value.ToString());
                pedidos.mesa = dgvResumo.Rows[i].Cells[3].Value.ToString();
                pedidos.nome = dgvResumo.Rows[i].Cells[4].Value.ToString();

                salvarPedidos.InserirDados(pedidos);
            }

            //Utilização do método InserirDados
            //salvarPedidos.InserirDados(pedidos);

            //Texto, Título, Botões, Ícone
            MessageBox.Show(pedidos.mensagem, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimparCampos();
        }
    }
}
