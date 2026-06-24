namespace SistemaDeLogin
{
    partial class FrmLogin
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
            label2 = new Label();
            txtUsuario = new TextBox();
            label3 = new Label();
            txtSenha = new TextBox();
            btnEnviar = new Button();
            txtNome = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(119, 41);
            label2.TabIndex = 1;
            label2.Text = "Usuário";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(12, 53);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(150, 31);
            txtUsuario.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(12, 100);
            label3.Name = "label3";
            label3.Size = new Size(99, 41);
            label3.TabIndex = 3;
            label3.Text = "Senha";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(12, 144);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(150, 31);
            txtSenha.TabIndex = 4;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(12, 193);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(150, 54);
            btnEnviar.TabIndex = 5;
            btnEnviar.Text = "Entrar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(192, 53);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(301, 31);
            txtNome.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(192, 9);
            label4.Name = "label4";
            label4.Size = new Size(301, 41);
            label4.TabIndex = 7;
            label4.Text = "Nome a ser chamado";
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(txtNome);
            Controls.Add(btnEnviar);
            Controls.Add(txtSenha);
            Controls.Add(label3);
            Controls.Add(txtUsuario);
            Controls.Add(label2);
            Name = "FrmLogin";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox txtUsuario;
        private Label label3;
        private TextBox txtSenha;
        private Button btnEnviar;
        private TextBox txtNome;
        private Label label4;
    }
}
