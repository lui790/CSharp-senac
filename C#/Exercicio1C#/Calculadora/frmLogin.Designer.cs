namespace Calculadora
{
    partial class frmLogin
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
            lblUsuario = new Label();
            txtUsuario = new TextBox();
            lblSenha = new Label();
            txtSenha = new TextBox();
            btnEnviar = new Button();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 15F);
            lblUsuario.Location = new Point(327, 28);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(119, 41);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuário";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(306, 91);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(150, 31);
            txtUsuario.TabIndex = 1;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Segoe UI", 15F);
            lblSenha.Location = new Point(327, 169);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(99, 41);
            lblSenha.TabIndex = 2;
            lblSenha.Text = "Senha";
            lblSenha.Click += lblSenha_Click;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(306, 245);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(150, 31);
            txtSenha.TabIndex = 3;
            // 
            // btnEnviar
            // 
            btnEnviar.Font = new Font("Segoe UI", 20F);
            btnEnviar.Location = new Point(248, 326);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(276, 98);
            btnEnviar.TabIndex = 4;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEnviar);
            Controls.Add(txtSenha);
            Controls.Add(lblSenha);
            Controls.Add(txtUsuario);
            Controls.Add(lblUsuario);
            Name = "frmLogin";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuario;
        private TextBox txtUsuario;
        private Label lblSenha;
        private TextBox txtSenha;
        private Button btnEnviar;
    }
}
