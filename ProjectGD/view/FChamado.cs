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
        public FChamado()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddChamado_Click(object sender, EventArgs e)
        {
            FCadastroChamado tela = new FCadastroChamado();
            tela.ShowDialog();
        }
    }
}
