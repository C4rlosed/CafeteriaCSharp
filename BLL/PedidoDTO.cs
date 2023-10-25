using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using DAL;


namespace BLL_Atendimento
{
    public class PedidoDTO
    {
        public int quantidade { get; set; }
        public string descricao { get; set; }
        public decimal unitario { get; set; }
        public string mesa { get; set; }
        public string nome { get; set; }
        public string status = "Aberto";
        public string mensagem { get; set; }
        public decimal totalPagar { get; set; }

    }

    public class SalvarPedidos
    {
        //Criação do método
        public void InserirDados(PedidoDTO dados)
        {
            try
            {
                //String com o comando Insert do banco
                string sql = "INSERT INTO tb_pedido (PdQtde, PdDescricao, PdUnitario, PdMesa, PdCliente, PdStatus)" +
                    "VALUES (@qtde, @descricao, @unitario, @mesa, @cliente, @status)";

                //Variável que receberá o resultadoda conexão com o comando Insert
                MySqlCommand cmd = new MySqlCommand(sql, Conexao.obterConexao());

                //Tipo de comando: text ou procedure
                cmd.CommandType = CommandType.Text;

                //Parâmetros que serão substituidos
                cmd.Parameters.Add(new MySqlParameter("@qtde", dados.quantidade));
                cmd.Parameters.Add(new MySqlParameter("@descricao", dados.descricao));
                cmd.Parameters.Add(new MySqlParameter("@unitario", dados.unitario));
                cmd.Parameters.Add(new MySqlParameter("@mesa", dados.mesa));
                cmd.Parameters.Add(new MySqlParameter("@cliente", dados.nome));
                cmd.Parameters.Add(new MySqlParameter("@status", dados.status));

                //Realiza a contagem de registros inseridos
                int registrosInseridos = cmd.ExecuteNonQuery();

                if (registrosInseridos >= 1)
                {
                    dados.mensagem = "Registro inserido com Sucesso!";
                }
                else
                {
                    dados.mensagem = "Falha ao inserir registro!";
                }

                Conexao.fecharConexao();
            }
            catch (MySqlException erro)
            {
                dados.mensagem = "Erro - SalvarProdutos - InserirDados" + erro.Message;
            }
        }
    }

    public class ConsultarPedido
    {
        //Classe

        //SELECT
        public DataTable ListarDadosPedido(PedidoDTO dados)
        {
            //Declaração da variável que receberá os dados n formato de tabela.
            DataTable tabela = new DataTable();
            try
            {
                //Instrução de comando para o Banco de dados
                string sql = "SELECT * from tb_pedido";

                /*
                Adaptação dos dados do Banco de dados para o formato
                de tabela com a execução da Conexão e Select
                */
                MySqlDataAdapter adaptador = new MySqlDataAdapter(sql, Conexao.obterConexao());

                //Preenchimento da variavél em frmato de tabela - Fill = Preencher
                adaptador.Fill(tabela);

                //Fechamento da conexão
                Conexao.fecharConexao();
            }
            catch (MySqlException erro)
            {
                dados.mensagem = "Erro - ConsultarPedido - ListarDadosPedido" +
                    erro.Message.ToString();
            }
            /*
            O comando SELECT sempre pricisa retornar algum dado, este retorno será no
            formato de tabela, sendo aplicado ao DataGridView.
            */
            return tabela;
        }

        //SELECT com WHERE ou LIKE
        public DataTable ListarDadosPedidoFiltro(PedidoDTO dados)
        {
            //Declaração da variável que receberá os dados n formato de tabela.
            DataTable tabela = new DataTable();
            try
            {

                /* Opção 1 - Instrução de comando para o Banco de dados com WHERE
                 string sql = "SELECT * from tb_cliente WHERE ClNome=@nome";

                 MySqlCommand cmd = new MySqlCommand(sql, Conexao.obterConexao());

                 cmd.Parameters.Add(new MySqlParameter("@nome", dados.nome));
                */

                //Opção 2 - Instrução de comando para o Banco de dados com LIKE
                string sql = "SELECT * FROM tb_pedido WHERE PdPedido LIKE @Descricao";

                MySqlCommand cmd = new MySqlCommand(sql, Conexao.obterConexao());

                cmd.Parameters.Add(new MySqlParameter("@Descricao", "%" + dados.descricao + "%"));

                /*
                Adaptação dos dados do Banco de dados para o formato
                de tabela com a execução da Conexão e Select
                */
                MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);

                //Preenchimento da variavél em frmato de tabela - Fill = Preencher
                adaptador.Fill(tabela);

                //Fechamento da conexão
                Conexao.fecharConexao();
            }
            catch (MySqlException erro)
            {
                dados.mensagem = "Erro - ConsultarPedido - ListarDadosPedidoFiltro" +
                    erro.Message.ToString();
            }
            /*
            O comando SELECT sempre pricisa retornar algum dado, este retorno será no
            formato de tabela, sendo aplicado ao DataGridView.
            */
            return tabela;
        }

        public void NovoCodigo(PedidoDTO dados)
        {
            try
            {
                //Instrução de comando para o Banco de dados
                string sql = "SELECT ClCodigo FROM tb_pedido ORDER BY PdQtde DESC LIMIT 1";


                //Variável que receberá o resultado da Conexão com o comando Select
                MySqlCommand cmd = new MySqlCommand(sql, Conexao.obterConexao());

                //Tipo de comando: Text ou Procedure
                cmd.CommandType = CommandType.Text;

                //Realiza a leitura dos dados
                MySqlDataReader dr = cmd.ExecuteReader();

                //Se houver linhas, pode-se recuperar valores individuais
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        dados.quantidade = Convert.ToInt32(dr.GetValue(0).ToString()) + 1;
                    }
                }
                else
                {
                    dados.quantidade = 1;
                }
                Conexao.fecharConexao();
            }
            catch (MySqlException erro)
            {
                dados.mensagem = "Erro - ConsultarPedido - NovoCodigo " + erro.Message;
            }
        }

        public void ConsultaUnitario(PedidoDTO dados)
        {
            try
            {
                //Instrução de comando para o Banco de dados
                string sql = "SELECT PdUnitario FROM tb_produtos WHERE PdDescricao = @descricao";


                //Variável que receberá o resultado da Conexão com o comando Select
                MySqlCommand cmd = new MySqlCommand(sql, Conexao.obterConexao());

                cmd.Parameters.Add(new MySqlParameter("@descricao", dados.descricao));

                //Tipo de comando: Text ou Procedure
                cmd.CommandType = CommandType.Text;

                //Realiza a leitura dos dados
                MySqlDataReader dr = cmd.ExecuteReader();

                //Se houver linhas, pode-se recuperar valores individuais
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        dados.unitario = Convert.ToDecimal(dr.GetValue(0).ToString());
                    }
                }
                Conexao.fecharConexao();
            }
            catch (MySqlException erro)
            {
                dados.mensagem = "Erro - ConsultarPedido - NovoCodigo " + erro.Message;
            }
        }
    }
}
