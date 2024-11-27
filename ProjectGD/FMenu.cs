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
                // Oculta menus administrativos para gerenciar usuarios
                if (usuariosToolStripMenuItem != null)
                {
                    usuariosToolStripMenuItem.Enabled = false;
                }

            }
            else if (usuario_logado.nivelAcesso == 1)
            {
                MessageBox.Show($"Usuário logado: {usuario_logado.nome}, Nível de Acesso: {usuario_logado.nivelAcesso}");
                // Exibe menus administrativos para gerenciar usuarios
                if (usuariosToolStripMenuItem != null)
                {
                    usuariosToolStripMenuItem.Enabled = true;
                }
            }
        }

        private void rToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }



        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }




        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }







        private void usuarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FUsuario tela = new FUsuario();
            tela.ShowDialog();
        }



        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //aba usuarios
        }

        private void BAdicionar_Click(object sender, EventArgs e)
        {
            // Botão adicionar
        }

        private void textBoxAdicionar_TextChanged(object sender, EventArgs e)
        {
            // Caixa de texto
        }
    }

}