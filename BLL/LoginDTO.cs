using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using MySql.Data.MySqlClient;
using System.Data;

namespace BLL
{
   public class LoginDTO
    {

        public int codigo { get; set; }
        

        public string usuario { get; set; }

        public string senha { get; set; }

        public string mensagem { get; set; }

        public int logado { get; set; }

    }
    public class AcessarLogin
    {
        public void Acessar(LoginDTO dados)
        {
            try
            {
                //Instrução de comando para o Banco de dados
                string sql = "SELECT userLogin FROM tb_usuario WHERE " +
                    "userLogin = @usuario AND userSenha = @senha";

                //Variável que receberá o resultado da Conexão com o comando Select
                MySqlCommand cmd = new MySqlCommand(sql, Conexao.obterConexao());

                //Tipo de comando: Text ou Procedure
                cmd.CommandType = CommandType.Text;

                //Parâmetros a serem atribuído na string sql
                cmd.Parameters.Add(new MySqlParameter("@usuario", dados.usuario));
                cmd.Parameters.Add(new MySqlParameter("@senha", dados.senha));

                //Realiza a leitura dos dados
                MySqlDataReader dr = cmd.ExecuteReader();

                //Se houver linhas, pode-se recuperar valores individuais
                if (dr.HasRows)
                {
                    dados.mensagem = "Bem vindo!";
                    dados.logado = 1;
                    while (dr.Read())
                    {
                        dados.usuario = dr.GetValue(0).ToString();
                    }
                }
                else
                {
                    dados.mensagem = "Erro- Usuário ou Senha inválido!";
                    dados.logado = 0;
                }
                Conexao.fecharConexao();
            }
            catch (MySqlException erro)
            {
                dados.mensagem = "Erro - AcessoLogin - Acessar " +
                erro.Message;
            }
        }
        public string VerificarLogado(LoginDTO dados)
        {
            try
            {
                //Instrução de comando para o Banco de dados
                string sql = "SELECT userLogin FROM tb_usuario WHERE userLogado = 1";

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
                        dados.usuario = dr.GetValue(0).ToString();
                    }
                }
                else
                {
                    dados.mensagem = "Erro ao buscar usuário logado!";
                }
                Conexao.fecharConexao();
            }
            catch (MySqlException erro)
            {
                dados.mensagem = "Erro - AcessoLogin - VerificarLogado " +
                erro.Message;
            }

            return dados.usuario;
        }


    }
    public class AtualizarLogon
    {
        public void AtualizarLogado(LoginDTO dados)
        {
            try
            {
                //String com o comando Insert do Banco
                string sql = "UPDATE tb_usuario SET userLogado = @logado " +
                    "WHERE userLogin = @usuario";
                MySqlCommand cmd = new MySqlCommand(sql, Conexao.obterConexao());
                //Tipo de comando: Text ou Procedure
                cmd.CommandType = CommandType.Text;

                //Parâmetros que serão substiruídos
                cmd.Parameters.Add(new MySqlParameter("@logado", dados.logado));
                cmd.Parameters.Add(new MySqlParameter("@usuario", dados.usuario));

                int registrosAtualizados = cmd.ExecuteNonQuery();  
                if (registrosAtualizados >= 1)
                {
                    dados.mensagem = "Registro atualizado com Sucesso!";
                }
                else
                {
                    dados.mensagem = "Falha ao atualizar registro!";
                }
                Conexao.fecharConexao();
            }
            catch (MySqlException erro)
            {

                dados.mensagem = "ERRO - AtualizaLogon - AtualizarLogado: " +
                erro.Message.ToString();
            }
        }
    }


}
