namespace GerenciamentoDeFuncionario
{
    partial class FrmTelaInicial
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
            btnSouAdministrador = new Button();
            btnSouFuncionario = new Button();
            SuspendLayout();
            // 
            // btnSouAdministrador
            // 
            btnSouAdministrador.Location = new Point(286, 130);
            btnSouAdministrador.Name = "btnSouAdministrador";
            btnSouAdministrador.Size = new Size(201, 62);
            btnSouAdministrador.TabIndex = 0;
            btnSouAdministrador.Text = "Sou adminstrador";
            btnSouAdministrador.UseVisualStyleBackColor = true;
            btnSouAdministrador.Click += btnSouAdministrador_Click;
            // 
            // btnSouFuncionario
            // 
            btnSouFuncionario.Location = new Point(286, 216);
            btnSouFuncionario.Name = "btnSouFuncionario";
            btnSouFuncionario.Size = new Size(201, 62);
            btnSouFuncionario.TabIndex = 1;
            btnSouFuncionario.Text = "Sou funcionario";
            btnSouFuncionario.UseVisualStyleBackColor = true;
            // 
            // FrmTelaInicial
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSouFuncionario);
            Controls.Add(btnSouAdministrador);
            Name = "FrmTelaInicial";
            Text = "Tela inicial";
            Load += FrmTelaInicial_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnSouAdministrador;
        private Button btnSouFuncionario;
    }
}
