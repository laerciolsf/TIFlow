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
        }

        private void FChamado_Load(object sender, EventArgs e)
        {
            // Lógica de carregamento da tela FChamado (se necessário)
        }
    }
}
