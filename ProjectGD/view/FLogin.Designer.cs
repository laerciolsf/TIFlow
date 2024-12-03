namespace ProjectX.view
{
    partial class FLogin
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
            txtLogin = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtSenha = new TextBox();
            ButtonEntrar = new Button();
            SuspendLayout();
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(12, 43);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(174, 23);
            txtLogin.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 1;
            label1.Text = "Usuários";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 70);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 3;
            label2.Text = "Senha";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(12, 88);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(174, 23);
            txtSenha.TabIndex = 2;
            // 
            // ButtonEntrar
            // 
            ButtonEntrar.Location = new Point(12, 129);
            ButtonEntrar.Name = "ButtonEntrar";
            ButtonEntrar.Size = new Size(174, 36);
            ButtonEntrar.TabIndex = 4;
            ButtonEntrar.Text = "Entrar";
            ButtonEntrar.UseVisualStyleBackColor = true;
            ButtonEntrar.Click += ButtonEntrar_Click;
            // 
            // FLogin
            // 
            AcceptButton = ButtonEntrar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(202, 188);
            Controls.Add(ButtonEntrar);
            Controls.Add(label2);
            Controls.Add(txtSenha);
            Controls.Add(label1);
            Controls.Add(txtLogin);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TIFlow";
            Load += FLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLogin;
        private Label label1;
        private Label label2;
        private TextBox txtSenha;
        private Button ButtonEntrar;
    }
}