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
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();
            FMenu.usuario_logado = null;
        }

        private void FLogin_Load(object sender, EventArgs e)
        {

        }

        private void ButtonEntrar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtLogin.Text))
            {
                usuarioController user = new usuarioController();
                FMenu.usuario_logado = user.buscaLogin(txtLogin.Text, txtSenha.Text);
                if (FMenu.usuario_logado == null)
                {
                    MessageBox.Show("Usuário ou senha inválidos!");
                    txtSenha.Clear();
                    txtLogin.Focus();
                    txtLogin.SelectAll();
                }
                else
                {
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Digite o login!");
                txtLogin.Focus();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
