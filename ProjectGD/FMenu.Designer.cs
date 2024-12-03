namespace ProjectX
{
    partial class FMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            usuariosToolStripMenuItem = new ToolStripMenuItem();
            cadastrarToolStripMenuItem = new ToolStripMenuItem();
            usuarioToolStripMenuItem1 = new ToolStripMenuItem();
            configuraçõesToolStripMenuItem = new ToolStripMenuItem();
            alterarMinhaSenhaToolStripMenuItem = new ToolStripMenuItem();
            ajudaToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            BAdicionar = new Button();
            textBoxAdicionar = new TextBox();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { usuariosToolStripMenuItem, configuraçõesToolStripMenuItem, ajudaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(337, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarToolStripMenuItem });
            usuariosToolStripMenuItem.Enabled = false;
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            usuariosToolStripMenuItem.Size = new Size(64, 20);
            usuariosToolStripMenuItem.Text = "Usuarios";
            usuariosToolStripMenuItem.Click += usuariosToolStripMenuItem_Click;
            // 
            // cadastrarToolStripMenuItem
            // 
            cadastrarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { usuarioToolStripMenuItem1 });
            cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            cadastrarToolStripMenuItem.Size = new Size(124, 22);
            cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // usuarioToolStripMenuItem1
            // 
            usuarioToolStripMenuItem1.Name = "usuarioToolStripMenuItem1";
            usuarioToolStripMenuItem1.Size = new Size(114, 22);
            usuarioToolStripMenuItem1.Text = "Usuario";
            usuarioToolStripMenuItem1.Click += usuarioToolStripMenuItem1_Click;
            // 
            // configuraçõesToolStripMenuItem
            // 
            configuraçõesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { alterarMinhaSenhaToolStripMenuItem });
            configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            configuraçõesToolStripMenuItem.Size = new Size(96, 20);
            configuraçõesToolStripMenuItem.Text = "Configurações";
            // 
            // alterarMinhaSenhaToolStripMenuItem
            // 
            alterarMinhaSenhaToolStripMenuItem.Name = "alterarMinhaSenhaToolStripMenuItem";
            alterarMinhaSenhaToolStripMenuItem.Size = new Size(181, 22);
            alterarMinhaSenhaToolStripMenuItem.Text = "Alterar Minha Senha";
            // 
            // ajudaToolStripMenuItem
            // 
            ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            ajudaToolStripMenuItem.Size = new Size(50, 20);
            ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 24);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(337, 45);
            panel1.TabIndex = 58;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(40, 11);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(253, 24);
            label1.TabIndex = 0;
            label1.Text = "Controle de Atendimentos";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 96);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(293, 497);
            dataGridView1.TabIndex = 59;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // BAdicionar
            // 
            BAdicionar.Location = new Point(201, 617);
            BAdicionar.Name = "BAdicionar";
            BAdicionar.Size = new Size(115, 23);
            BAdicionar.TabIndex = 60;
            BAdicionar.Text = "Adicionar ";
            BAdicionar.UseVisualStyleBackColor = true;
            BAdicionar.Click += BAdicionar_Click;
            // 
            // textBoxAdicionar
            // 
            textBoxAdicionar.Location = new Point(23, 617);
            textBoxAdicionar.Name = "textBoxAdicionar";
            textBoxAdicionar.Size = new Size(153, 23);
            textBoxAdicionar.TabIndex = 62;
            textBoxAdicionar.TextChanged += textBoxAdicionar_TextChanged;
            // 
            // FMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(337, 652);
            Controls.Add(textBoxAdicionar);
            Controls.Add(BAdicionar);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Name = "FMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private Panel panel1;
        private Label label1;
        private ToolStripMenuItem usuariosToolStripMenuItem;
        private ToolStripMenuItem cadastrarToolStripMenuItem;
        private ToolStripMenuItem usuarioToolStripMenuItem1;
        private DataGridView dataGridView1;
        private Button BAdicionar;
        private TextBox textBoxAdicionar;
        private ToolStripMenuItem configuraçõesToolStripMenuItem;
        private ToolStripMenuItem alterarMinhaSenhaToolStripMenuItem;
        private ToolStripMenuItem ajudaToolStripMenuItem;
    }
}