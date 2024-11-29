namespace ProjectX.view
{
    partial class FCadastroChamado
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            buttonEditar = new Button();
            buttonExcluir = new Button();
            buttonSalvar = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 34);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(170, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(210, 34);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(163, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(11, 82);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(362, 23);
            textBox3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 16);
            label1.Name = "label1";
            label1.Size = new Size(171, 15);
            label1.TabIndex = 3;
            label1.Text = "Hora de Inicio do Atendimento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(210, 16);
            label2.Name = "label2";
            label2.Size = new Size(163, 15);
            label2.TabIndex = 4;
            label2.Text = "Hora do Fim do Atendimento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 64);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 5;
            label3.Text = "Descrição";
            // 
            // buttonEditar
            // 
            buttonEditar.Location = new Point(144, 120);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(106, 23);
            buttonEditar.TabIndex = 6;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = true;
            // 
            // buttonExcluir
            // 
            buttonExcluir.Location = new Point(12, 120);
            buttonExcluir.Name = "buttonExcluir";
            buttonExcluir.Size = new Size(106, 23);
            buttonExcluir.TabIndex = 7;
            buttonExcluir.Text = "Excluir";
            buttonExcluir.UseVisualStyleBackColor = true;
            // 
            // buttonSalvar
            // 
            buttonSalvar.Location = new Point(267, 120);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(106, 23);
            buttonSalvar.TabIndex = 8;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.UseVisualStyleBackColor = true;
            // 
            // FCadastroChamado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 162);
            Controls.Add(buttonSalvar);
            Controls.Add(buttonExcluir);
            Controls.Add(buttonEditar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "FCadastroChamado";
            Text = "FCadastroChamado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button buttonEditar;
        private Button buttonExcluir;
        private Button buttonSalvar;
    }
}