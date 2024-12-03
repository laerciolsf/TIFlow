using ProjectX.controller;
using ProjectX.model;
using ProjectX.view;
using System.Windows.Forms;

namespace ProjectX
{
    public partial class FMenu : Form
    {
        public static Usuario usuario_logado = new Usuario();

        public FMenu()
        {
            InitializeComponent();
            //Chama a tela de login
            FLogin login = new FLogin();
            login.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (usuario_logado == null)
            {
                Application.Exit();
            }
            else if (usuario_logado.nivelAcesso != 1)
            {
                MessageBox.Show($"Usuário logado: {usuario_logado.nome}, Nível de Acesso: {usuario_logado.nivelAcesso}");
                if (usuariosToolStripMenuItem != null)
                {
                    usuariosToolStripMenuItem.Enabled = false;
                }
            }
            else if (usuario_logado.nivelAcesso == 1)
            {
                MessageBox.Show($"Usuário logado: {usuario_logado.nome}, Nível de Acesso: {usuario_logado.nivelAcesso}");
                if (usuariosToolStripMenuItem != null)
                {
                    usuariosToolStripMenuItem.Enabled = true;
                }
            }

            CarregarGrupos();
        }


        private void CarregarGrupos()
        {
            try
            {
                // Instancia o controlador para obter os grupos
                GrupoChamadoController grupoController = new GrupoChamadoController();
                var grupos = grupoController.ObterTodosGrupos(); // Lista de grupos

                if (grupos != null && grupos.Count > 0)
                {
                    dataGridView1.DataSource = grupos; // Atribui os dados à DataGridView
                }
                else
                {
                    MessageBox.Show("Nenhum grupo encontrado.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar grupos: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Se necessário, implementar alguma ação
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Se necessário, implementar alguma ação
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Se necessário, implementar alguma ação
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Se necessário, implementar alguma ação
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // Se necessário, implementar alguma ação
        }

        private void usuarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FUsuario tela = new FUsuario();
            tela.ShowDialog();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Se necessário, implementar alguma ação
        }

        // Método que lida com o clique no botão de adicionar grupo
        private void BAdicionar_Click(object sender, EventArgs e)
        {
            string titulo = textBoxAdicionar.Text;

            if (string.IsNullOrEmpty(titulo))
            {
                MessageBox.Show("O título não pode estar vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            GrupoChamadoController grupoController = new GrupoChamadoController();
            int idGrupoChamado = grupoController.AdicionarGrupo(titulo);

            if (idGrupoChamado > 0)
            {
                MessageBox.Show("Grupo adicionado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxAdicionar.Clear();
                CarregarGrupos(); // Recarrega a lista de grupos
            }
            else
            {
                MessageBox.Show("Erro ao adicionar o grupo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void textBoxAdicionar_TextChanged(object sender, EventArgs e)
        {
            // Se necessário, implementar alguma ação
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int idGrupoChamado = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);

                FGrupoChamado tela = new FGrupoChamado(idGrupoChamado);
                tela.ShowDialog();
                CarregarGrupos(); // Recarrega os grupos após fechar a tela de chamados

            }
        }

    }
}