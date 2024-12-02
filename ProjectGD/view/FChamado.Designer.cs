namespace ProjectX.view
{
    partial class FChamado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            buttonAddChamado = new Button();
            textBoxTempo = new TextBox();
            textBoxQtdeChamados = new TextBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 57);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 381);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // buttonAddChamado
            // 
            buttonAddChamado.Location = new Point(12, 26);
            buttonAddChamado.Name = "buttonAddChamado";
            buttonAddChamado.Size = new Size(136, 23);
            buttonAddChamado.TabIndex = 1;
            buttonAddChamado.Text = "Novo Chamado";
            buttonAddChamado.UseVisualStyleBackColor = true;
            buttonAddChamado.Click += buttonAddChamado_Click;
            // 
            // textBoxTempo
            // 
            textBoxTempo.Location = new Point(177, 26);
            textBoxTempo.Name = "textBoxTempo";
            textBoxTempo.Size = new Size(100, 23);
            textBoxTempo.TabIndex = 2;
            // 
            // textBoxQtdeChamados
            // 
            textBoxQtdeChamados.Location = new Point(310, 27);
            textBoxQtdeChamados.Name = "textBoxQtdeChamados";
            textBoxQtdeChamados.Size = new Size(98, 23);
            textBoxQtdeChamados.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(177, 8);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 4;
            label1.Text = "Horas Trabalhadas";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(294, 9);
            label2.Name = "label2";
            label2.Size = new Size(125, 15);
            label2.TabIndex = 5;
            label2.Text = "Chamados Finalizados";
            // 
            // FChamado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxQtdeChamados);
            Controls.Add(textBoxTempo);
            Controls.Add(buttonAddChamado);
            Controls.Add(dataGridView1);
            Name = "FChamado";
            Text = "FChamado";
            Load += FChamado_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonAddChamado;
        private TextBox textBoxTempo;
        private TextBox textBoxQtdeChamados;
        private Label label1;
        private Label label2;
    }
}