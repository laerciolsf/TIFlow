using ProjectX.controller;
using System;
using System.Windows.Forms;

namespace ProjectX.view
{
    public partial class FCadastroChamado : Form
    {
        private int idGrupoChamado; // ID do grupo de chamados recebido

        // Construtor que recebe o ID do grupo de chamados
        public FCadastroChamado(int idGrupoChamado)
        {
            InitializeComponent();
            this.idGrupoChamado = idGrupoChamado; // Armazena o ID do grupo
        }

        // Evento de clique no botão Excluir (implementação futura, se necessário)
        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            // Aqui você pode implementar a lógica para excluir o chamado, se necessário
        }

        // Evento de clique no botão Editar (implementação futura, se necessário)
        private void buttonEditar_Click(object sender, EventArgs e)
        {
            // Aqui você pode implementar a lógica para editar um chamado, se necessário
        }

        // Evento de clique no botão Salvar para adicionar um novo chamado
        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                // Captura os valores dos campos
                TimeSpan horaInicio = TimeSpan.Parse(textBox1.Text); // hora_inicio
                TimeSpan horaFinal = TimeSpan.Parse(textBox2.Text);  // hora_final
                string descricao = textBox3.Text;                   // descricao

                // Valida se o campo de descrição está preenchido
                if (string.IsNullOrEmpty(descricao))
                {
                    MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Chama o controlador para salvar o chamado
                ChamadoController chamadoController = new ChamadoController();
                bool sucesso = chamadoController.AdicionarChamado(horaInicio, horaFinal, descricao, idGrupoChamado);

                if (sucesso)
                {
                    MessageBox.Show("Chamado adicionado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Fecha a tela de cadastro após o sucesso
                }
                else
                {
                    MessageBox.Show("Erro ao adicionar o chamado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento de alteração na caixa de texto de hora_inicio (se necessário)
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Lógica para hora_inicio (se necessário)
        }

        // Evento de alteração na caixa de texto de hora_final (se necessário)
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Lógica para hora_final (se necessário)
        }

        // Evento de alteração na caixa de texto de descrição (se necessário)
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            // Lógica para descrição (se necessário)
        }

        // Evento de carregamento do formulário (se necessário)
        private void FCadastroChamado_Load(object sender, EventArgs e)
        {
            // Lógica de carregamento (se necessário)
        }
    }
}