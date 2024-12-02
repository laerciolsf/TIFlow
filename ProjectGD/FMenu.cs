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
                MessageBox.Show($"Usu�rio logado: {usuario_logado.nome}, N�vel de Acesso: {usuario_logado.nivelAcesso}");
                // Oculta menus administrativos para gerenciar usuarios
                if (usuariosToolStripMenuItem != null)
                {
                    usuariosToolStripMenuItem.Enabled = false;
                }

            }
            else if (usuario_logado.nivelAcesso == 1)
            {
                MessageBox.Show($"Usu�rio logado: {usuario_logado.nome}, N�vel de Acesso: {usuario_logado.nivelAcesso}");
                // Exibe menus administrativos para gerenciar usuarios
                if (usuariosToolStripMenuItem != null)
                {
                    usuariosToolStripMenuItem.Enabled = true;
                }
            }
        }

        private void rToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Se necess�rio, implementar alguma a��o
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Se necess�rio, implementar alguma a��o
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Se necess�rio, implementar alguma a��o
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Se necess�rio, implementar alguma a��o
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // Se necess�rio, implementar alguma a��o
        }

        private void usuarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FUsuario tela = new FUsuario();
            tela.ShowDialog();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Se necess�rio, implementar alguma a��o
        }

        // M�todo que lida com o clique no bot�o de adicionar grupo
        private void BAdicionar_Click(object sender, EventArgs e)
        {
            // Captura o texto da caixa de texto para o t�tulo do grupo
            string titulo = textBoxAdicionar.Text;

            if (string.IsNullOrEmpty(titulo))
            {
                MessageBox.Show("O t�tulo n�o pode estar vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Chama o controlador para salvar o t�tulo no banco e retorna o ID do grupo
            GrupoChamadoController grupoController = new GrupoChamadoController();
            int idGrupoChamado = grupoController.AdicionarGrupo(titulo);

            if (idGrupoChamado > 0)
            {
                MessageBox.Show("Grupo adicionado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxAdicionar.Clear(); // Limpa a caixa de texto

                // Abre o formul�rio FChamado passando o ID do grupo
                FChamado tela = new FChamado(idGrupoChamado);
                tela.ShowDialog();
            }
            else
            {
                MessageBox.Show("Erro ao adicionar o grupo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxAdicionar_TextChanged(object sender, EventArgs e)
        {
            // Se necess�rio, implementar alguma a��o
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Se necess�rio, implementar alguma a��o
        }
    }
}