using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ProjectX.model;

namespace ProjectX.controller
{
    public class usuarioController
    {
        private MySqlConnection conexao;

        public usuarioController()
        {
            this.conexao = new conn().GetConnection();
        }

        public void cadastrarUsuario(Usuario obj)
        {
            try
            {
                string sql = @"INSERT INTO usuarios 
                               (nomeCompleto, login, senha, nivelAcesso) 
                               VALUES 
                               (@nome, @login, MD5(@senha), @nivelAcesso);";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@login", obj.login);
                executacmd.Parameters.AddWithValue("@senha", obj.senha);
                executacmd.Parameters.AddWithValue("@nivelAcesso", obj.nivelAcesso); // Novo campo

                conexao.Open();
                executacmd.ExecuteNonQuery();
                MessageBox.Show("Usuário cadastrado com sucesso");
                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar: " + ex.Message);
            }
        }

        public DataTable listarUsuarios()
        {
            try
            {
                DataTable tabela = new DataTable();
                string sql = "SELECT id, nomeCompleto, login, nivelAcesso FROM usuarios;";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabela);

                conexao.Close();
                return tabela;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar: " + ex.Message);
                return null;
            }
        }

        public DataTable buscaPorNome(string nome)
        {
            try
            {
                DataTable tabela = new DataTable();
                string sql = "SELECT * FROM usuarios WHERE nomeCompleto LIKE @nome;";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", nome);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabela);

                conexao.Close();
                return tabela;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar: " + ex.Message);
                return null;
            }
        }

        public void alterarUsuario(Usuario obj)
        {
            try
            {
                string sql = @"UPDATE usuarios 
                               SET nomeCompleto = @nome,
                                   login = @login,                
                                   senha = MD5(@senha),
                                   nivelAcesso = @nivelAcesso
                               WHERE id = @idusuario;";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@login", obj.login);
                executacmd.Parameters.AddWithValue("@senha", obj.senha);
                executacmd.Parameters.AddWithValue("@nivelAcesso", obj.nivelAcesso); // Novo campo
                executacmd.Parameters.AddWithValue("@idusuario", obj.id);

                conexao.Open();
                executacmd.ExecuteNonQuery();
                MessageBox.Show("Usuário alterado com sucesso");
                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar: " + ex.Message);
            }
        }

        public void excluirUsuario(Usuario obj)
        {
            try
            {
                string sql = "DELETE FROM usuarios WHERE id = @idusuario;";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@idusuario", obj.id);

                conexao.Open();
                executacmd.ExecuteNonQuery();
                MessageBox.Show("Usuário excluído com sucesso!");
                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Aconteceu um erro: " + ex.Message);
            }
        }

        public Usuario buscaLogin(string login, string senha)
        {
            try
            {
                string sql = "select * from usuarios where login = @login and senha = MD5(@senha)";
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@login", login);
                executacmd.Parameters.AddWithValue("@senha", senha);

                conexao.Open();

                MySqlDataReader resultado = executacmd.ExecuteReader();

                Usuario u = new Usuario();

                if (resultado.HasRows)
                {
                    if (resultado.Read())
                    {
                        u.id = resultado.GetInt16("id");
                        u.nome = resultado.GetString("nomeCompleto");
                        u.login = resultado.GetString("login");
                        u.senha = resultado.GetString("senha");

                        // Certifique-se de que o campo nivelAcesso existe na tabela
                        u.nivelAcesso = resultado.GetInt16("nivelAcesso");
                    }

                    resultado.Close();
                    conexao.Close();
                    return u;
                }
                else
                {
                    resultado.Close();
                    conexao.Close();
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar: " + ex.Message);
                return null;
            }
        }

    }
}
