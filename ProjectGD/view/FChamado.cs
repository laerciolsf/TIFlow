using ProjectX.controller;
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
    public partial class FChamado : Form
    {
        private int idGrupoChamado; // Variável para armazenar o ID do grupo de chamados

        public FChamado(int idGrupoChamado)
        {
            InitializeComponent();
            this.idGrupoChamado = idGrupoChamado; // Inicializa o ID do grupo de chamados
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Lógica do label1 (se necessário)
        }

        // Evento de clique no botão Adicionar Chamado
        private void buttonAddChamado_Click(object sender, EventArgs e)
        {
            // Passa o idGrupoChamado para o formulário FCadastroChamado
            FCadastroChamado tela = new FCadastroChamado(idGrupoChamado);
            tela.ShowDialog(); // Abre a tela de cadastro de chamado
            CarregarChamados(); // Atualiza a DataGridView após adicionar um chamado
        }

        // Evento de carregamento da tela FChamado
        private void FChamado_Load(object sender, EventArgs e)
        {
            CarregarChamados(); // Chama o método para carregar os chamados do grupo
        }

        // Método para carregar os chamados na DataGridView
        private void CarregarChamados()
        {
            ChamadoController chamadoController = new ChamadoController();

            // Recupera os chamados do banco de dados para o grupo específico
            var chamados = chamadoController.ObterChamadosPorGrupo(idGrupoChamado);

            // Verifica se há chamados e preenche a DataGridView
            if (chamados.Count > 0)
            {
                // Atualiza a DataGridView com os dados dos chamados
                dataGridView1.DataSource = chamados;

                // Ajusta os cabeçalhos das colunas
                dataGridView1.Columns["Id"].HeaderText = "ID Chamado";
                dataGridView1.Columns["HoraInicio"].HeaderText = "Hora Início";
                dataGridView1.Columns["HoraFinal"].HeaderText = "Hora Final";
                dataGridView1.Columns["Descricao"].HeaderText = "Descrição";
            }
            else
            {
                // Caso não haja chamados, exibe uma mensagem
                MessageBox.Show("Não há chamados cadastrados para este grupo.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Evento de clique na célula da DataGridView
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se o clique foi na célula de dados (não cabeçalhos)
            if (e.RowIndex >= 0)
            {
                // Pega o ID do chamado da linha clicada
                int idChamado = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);

                // Exemplo: Aqui você pode abrir a tela de edição do chamado ou realizar outras ações
                MessageBox.Show($"Chamado ID: {idChamado} selecionado.");
            }
        }
    }
}
