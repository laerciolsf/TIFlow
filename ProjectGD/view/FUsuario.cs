using ProjectX.controller;
using ProjectX.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectX.view
{
    public partial class FUsuario : Form
    {
        private string status = "";
        public FUsuario()
        {
            InitializeComponent();
        }
        public void desabilitarCampos()
        {
            txtId.Enabled = false;
            txtNome.Enabled = false;
            txtLogin.Enabled = false;
            txtSenha.Enabled = false;

            //desabilita os botoes
            botaoSalvar.Enabled = false;
            botaoEditar.Enabled = false;
            botaoExcluir.Enabled = false;
        }

        public void habilitarCampos()
        {
            //txtId.Enabled = false;
            txtNome.Enabled = true;
            txtLogin.Enabled = true;
            txtSenha.Enabled = true;


            botaoSalvar.Enabled = true;
        }
        public void limparCampos()
        {
            txtId.Text = String.Empty;
            txtNome.Text = String.Empty;
            txtLogin.Text = String.Empty;
            txtSenha.Text = String.Empty;

            txtNome.Focus();
        }

        private void tabDados_Click(object sender, EventArgs e)
        {

        }

        private void botaoNovo_Click(object sender, EventArgs e)
        {
            habilitarCampos();
            limparCampos();
            status = "inserindo";
            tabControl1.SelectedTab = tabDados;
        }

        private void botaoExcluir_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult =
             MessageBox.Show
             ("Tem certeza que deseja excluir?",
             "Pergunta", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //Faz a exclusão
                Usuario obj = new Usuario();
                obj.id = int.Parse(txtId.Text);

                usuarioController controller = new usuarioController();
                controller.excluirUsuario(obj);
                dataGridView1.DataSource = controller.listarUsuarios();
                limparCampos();
                botaoEditar.Enabled = false;
                botaoExcluir.Enabled = false;
                tabControl1.SelectedTab = tabPesquisa;
            }
        }

        private void botaoSalvar_Click(object sender, EventArgs e)
        {
            Usuario obj = new Usuario();
            obj.nome = txtNome.Text;
            obj.login = txtLogin.Text;
            obj.senha = txtSenha.Text;


            usuarioController controller = new usuarioController();
            if (status == "inserindo")
            {
                controller.cadastrarUsuario(obj);
                status = "";
            }
            else if (status == "alterando")
            {
                obj.id = int.Parse(txtId.Text);
                controller.alterarUsuario(obj);
                status = "";

            }

            limparCampos();
            desabilitarCampos();
            dataGridView1.DataSource = controller.listarUsuarios();

            tabControl1.SelectedTab = tabPesquisa;
        }

        private void botaoEditar_Click(object sender, EventArgs e)
        {
            habilitarCampos();
            status = "alterando";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = "%" + textBox1.Text + "%";

            usuarioController controller = new usuarioController();
            dataGridView1.DataSource = controller.buscaPorNome(nome);

            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum usuário encontrado com este nome");
                dataGridView1.DataSource = controller.listarUsuarios();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if para evitar o bug do botao novo
            if (status == "inserindo")
            {
                desabilitarCampos();
                status = "";
            }

            //Pegar os dados da grid para os campos
            txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtLogin.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtSenha.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();


            //habilita os botões
            botaoEditar.Enabled = true;
            botaoExcluir.Enabled = true;
            //Vai para a aba de dados
            tabControl1.SelectedTab = tabDados;
        }

        private void botaoFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FUsuario_Load(object sender, EventArgs e)
        {
            desabilitarCampos();
        }
    }
}