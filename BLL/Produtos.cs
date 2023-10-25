using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using DAL;

//DTO
namespace BLL
{
    public class Produtos
    {
        public int codigo { get; set; }
        public int codpedido { get; set; }
        public string cliente { get; set; }
        public string mesa { get; set; }
        public string status { get; set; }
        public string descricao { get; set; }
        public string tipo { get; set; }
        public int qtde { get; set; }
        public decimal unitario { get; set; }
        public string mensagem { get; set; }
    }

    public class SalvarProdutos
    {
        //Criação do método
        public void InserirDados(Produtos dados)
        {
            try
            {
                //String com o comando Insert do banco
                string sql = "INSERT INTO tb_produtos (PdDescricao, PdTipo, PdQtde, PdUnitario) VALUES (@descricao,@tipo,@qtde,@unitario)";

                //Variável que receberá o resultadoda conexão com o comando Insert
                MySqlCommand cmd = new MySqlCommand(sql, Conexao.obterConexao());

                //Tipo de comando: text ou procedure
                cmd.CommandType = CommandType.Text;

                //Parâmetros que serão substituidos
                cmd.Parameters.Add(new MySqlParameter("@descricao", dados.descricao));
                cmd.Parameters.Add(new MySqlParameter("@tipo", dados.tipo));
                cmd.Parameters.Add(new MySqlParameter("@qtde", dados.qtde));
                cmd.Parameters.Add(new MySqlParameter("@unitario", dados.unitario));

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

    public class ConsultarProdutos
    {
        //Método
        //SELECT
        public DataTable ListarProdutos(Produtos dados)
        {
            //Declaração de uma váriavel que receberá os dados dno formato de tabela
            DataTable tabela = new DataTable();

            try
            {
                //Instrução de comando para o banco de dados
                string sql = "SELECT * FROM tb_produtos";

                //Adaptação dos dados do Banco de dados para o formato de tabela com a execução da Conexão e Select
                MySqlDataAdapter adaptador = new MySqlDataAdapter(sql, Conexao.obterConexao());

                //Preenchimento da variável em formato de tabela - Fill - preencher
                adaptador.Fill(tabela);

                //Fechamento da conexão
                Conexao.fecharConexao();
            }
            catch (MySqlException erro)
            {
                dados.mensagem = "Erro - ConsultarProdutos - ListarProdutos" + erro.Message.ToString();
            }

            //O comando SELECT sempre precisa retornar algum dado
            //Este retorno será no formato de tabela, sendo aplicado ao DataGridView
            return tabela;
        }
        //SELECT com WHERE e LIKE
        public DataTable ListarProdutosFiltro(Produtos dados)
        {

            DataTable tabela = new DataTable();

            try
            {
                string sql = "SELECT * FROM tb_produtos WHERE PdTipo LIKE @tipo";

                MySqlCommand cmd = new MySqlCommand(sql, Conexao.obterConexao());

                cmd.Parameters.Add(new MySqlParameter("@tipo", "%" + dados.descricao + "%"));

                MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);

                adaptador.Fill(tabela);

                Conexao.fecharConexao();
            }
            catch (MySqlException erro)
            {
                dados.mensagem = "Erro - ConsultarProdutos - ListarDadosProdutosFiltro" + erro.Message.ToString();
            }

            return tabela;
        }
    }

    public class AtualizarProdutos
    {
        public void AtualizarDados(Produtos Dados)
        {
            try
            {
                string sql = "UPDATE tb_produtos SET PdCodigo=@cod, PdDescricao=@Descricao, PdTipo=@Tipo, PdQtde=@Qtde, PdUnitario=@Uni WHERE PdCodigo=@cod";

                //
                //Variável que receberá o resultadoda conexão com o comando Insert
                MySqlCommand cmd = new MySqlCommand(sql, Conexao.obterConexao());

                //Tipo de comando: text ou procedure
                cmd.CommandType = CommandType.Text;

                //Parâmetros que serão substituidos
                //cmd.Parameters.Add(new MySqlParameter("@pdCod", Dados.codigo));
                cmd.Parameters.Add(new MySqlParameter("@cod", Dados.codigo));
                cmd.Parameters.Add(new MySqlParameter("@Descricao", Dados.descricao));
                cmd.Parameters.Add(new MySqlParameter("@Tipo", Dados.tipo));
                cmd.Parameters.Add(new MySqlParameter("@Qtde", Dados.qtde));
                cmd.Parameters.Add(new MySqlParameter("@Uni", Dados.unitario));



                //Realiza a contagem de registros inseridos
                int registrosAtualizados = cmd.ExecuteNonQuery();

                if (registrosAtualizados >= 1)
                {
                    Dados.mensagem = "Registro atualizado com Sucesso!";
                }
                else
                {
                    Dados.mensagem = "Falha ao atualizar registro!";
                }

                Conexao.fecharConexao();
            }
            catch (MySqlException erro)
            {
                Dados.mensagem = "Erro - AtualizarDados" + erro.Message;

            }
        }
    }

    public class DeletarProduto
    {
        public void DeletarDados(Produtos dados)
        {
            try
            {
                string sql = "DELETE FROM tb_produtos WHERE PdDescricao = @Descricao";

                MySqlCommand cmd = new MySqlCommand(sql, Conexao.obterConexao());

                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Add(new MySqlParameter("@Descricao", dados.descricao));


                int registrosDeletados = cmd.ExecuteNonQuery();

                if (registrosDeletados >= 1)
                {
                    dados.mensagem = "Registro deletado com Sucesso!";
                }
                else
                {
                    dados.mensagem = "Falha ao deletar registro!";
                }

                Conexao.fecharConexao();
            }
            catch (MySqlException erro)
            {
                dados.mensagem = "Erro - DeletarProdutos - DeletarDados" + erro.Message;

            }
        }
    }
    public class ConsultarPedido
    {
        //Método
        //SELECT
        public DataTable ListarPedido(Produtos dados)
        {
            //Declaração de uma váriavel que receberá os dados dno formato de tabela
            DataTable tabela = new DataTable();

            try
            {
                //Instrução de comando para o banco de dados
                string sql = "SELECT PdCodigo, PdMesa, PdCliente, PdStatus FROM tb_pedido";

                //Adaptação dos dados do Banco de dados para o formato de tabela com a execução da Conexão e Select
                MySqlDataAdapter adaptador = new MySqlDataAdapter(sql, Conexao.obterConexao());

                //Preenchimento da variável em formato de tabela - Fill - preencher
                adaptador.Fill(tabela);

                //Fechamento da conexão
                Conexao.fecharConexao();
            }
            catch (MySqlException erro)
            {
                dados.mensagem = "Erro - ConsultarPedidos - ListarPedidos" + erro.Message.ToString();
            }

            //O comando SELECT sempre precisa retornar algum dado
            //Este retorno será no formato de tabela, sendo aplicado ao DataGridView
            return tabela;
        }






        public DataTable ListarPedidosFiltro(Produtos dados)
        {

            DataTable tabela = new DataTable();

            try
            {
                string sql = "SELECT PdCodigo, PdMesa, PdCliente, PdStatus FROM tb_pedido WHERE PdMesa LIKE @mesa AND PdCliente LIKE @cliente";

                MySqlCommand cmd = new MySqlCommand(sql, Conexao.obterConexao());

                cmd.Parameters.Add(new MySqlParameter("@mesa", "%" + dados.mesa + "%"));
                cmd.Parameters.Add(new MySqlParameter("@cliente", "%" + dados.cliente + "%"));

                MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);

                adaptador.Fill(tabela);

                Conexao.fecharConexao();
            }
            catch (MySqlException erro)
            {
                dados.mensagem = "Erro - ConsultarPedidos - ListarDadosPedidosFiltro" + erro.Message.ToString();
            }

            return tabela;
        }

    }


    public class DeletarPedido
    {
        public void DeletarPedidos(Produtos dados)
        {
            try
            {
                string sql = "DELETE FROM tb_pedido WHERE PdCodigo = @codpedido";

                MySqlCommand cmd = new MySqlCommand(sql, Conexao.obterConexao());

                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Add(new MySqlParameter("@codpedido", dados.codpedido));


                int registrosDeletados = cmd.ExecuteNonQuery();

                if (registrosDeletados >= 1)
                {
                    dados.mensagem = "Registro deletado com Sucesso!";
                }
                else
                {
                    dados.mensagem = "Falha ao deletar registro!";
                }

                Conexao.fecharConexao();
            }
            catch (MySqlException erro)
            {
                dados.mensagem = "Erro - DeletarPedido - DeletarPedido" + erro.Message;

            }
        }
    }
    public class AtualizarPedido
    {
        public void AtualizarPedidos(Produtos Dados)
        {
            try
            {
                string sql = "UPDATE tb_pedido SET PdMesa=@mesa, PdCliente=@cliente, PdStatus=@status WHERE PdCodigo=@codpedido";

                //
                //Variável que receberá o resultadoda conexão com o comando Insert
                MySqlCommand cmd = new MySqlCommand(sql, Conexao.obterConexao());

                //Tipo de comando: text ou procedure
                cmd.CommandType = CommandType.Text;

                //Parâmetros que serão substituidos
                //cmd.Parameters.Add(new MySqlParameter("@pdCod", Dados.codigo));
                cmd.Parameters.Add(new MySqlParameter("@codpedido", Dados.codpedido));
                cmd.Parameters.Add(new MySqlParameter("@mesa", Dados.mesa));
                cmd.Parameters.Add(new MySqlParameter("@cliente", Dados.cliente));
                cmd.Parameters.Add(new MySqlParameter("@status", Dados.status));



                //Realiza a contagem de registros inseridos
                int registrosAtualizados = cmd.ExecuteNonQuery();

                if (registrosAtualizados >= 1)
                {
                    Dados.mensagem = "Registro atualizado com Sucesso!";
                }
                else
                {
                    Dados.mensagem = "Falha ao atualizar registro!";
                }

                Conexao.fecharConexao();
            }
            catch (MySqlException erro)
            {
                Dados.mensagem = "Erro - AtualizarDados" + erro.Message;

            }
        }
    }
}
