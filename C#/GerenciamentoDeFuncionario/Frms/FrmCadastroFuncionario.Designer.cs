namespace GerenciamentoDeFuncionario.Frms
{
    partial class FrmCadastroFuncionario
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
            label1 = new Label();
            txtNome = new TextBox();
            label2 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            txtSalario = new TextBox();
            groupBox1 = new GroupBox();
            rbFeminino = new RadioButton();
            rbMasculino = new RadioButton();
            groupBox2 = new GroupBox();
            rbAutonomo = new RadioButton();
            rbPJ = new RadioButton();
            rbCLT = new RadioButton();
            btnSalvar = new Button();
            lblErros = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(69, 50);
            label1.Name = "label1";
            label1.Size = new Size(80, 32);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(69, 89);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "João da Silva";
            txtNome.Size = new Size(315, 31);
            txtNome.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(69, 144);
            label2.Name = "label2";
            label2.Size = new Size(81, 32);
            label2.TabIndex = 2;
            label2.Text = "E-mail";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(69, 179);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "joaosilvadetodosnos@gmail.com";
            txtEmail.Size = new Size(315, 31);
            txtEmail.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(69, 239);
            label3.Name = "label3";
            label3.Size = new Size(85, 32);
            label3.TabIndex = 4;
            label3.Text = "Salario";
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(69, 274);
            txtSalario.Name = "txtSalario";
            txtSalario.PlaceholderText = "2000 (somente valores numericos)";
            txtSalario.Size = new Size(315, 31);
            txtSalario.TabIndex = 5;
            txtSalario.KeyPress += txtSalario_KeyPress;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbFeminino);
            groupBox1.Controls.Add(rbMasculino);
            groupBox1.Location = new Point(446, 50);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(318, 70);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sexo";
            // 
            // rbFeminino
            // 
            rbFeminino.AutoSize = true;
            rbFeminino.Location = new Point(129, 30);
            rbFeminino.Name = "rbFeminino";
            rbFeminino.Size = new Size(110, 29);
            rbFeminino.TabIndex = 1;
            rbFeminino.Text = "Feminino";
            rbFeminino.UseVisualStyleBackColor = true;
            // 
            // rbMasculino
            // 
            rbMasculino.AutoSize = true;
            rbMasculino.Checked = true;
            rbMasculino.Location = new Point(6, 30);
            rbMasculino.Name = "rbMasculino";
            rbMasculino.Size = new Size(117, 29);
            rbMasculino.TabIndex = 0;
            rbMasculino.TabStop = true;
            rbMasculino.Text = "Masculino";
            rbMasculino.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbAutonomo);
            groupBox2.Controls.Add(rbPJ);
            groupBox2.Controls.Add(rbCLT);
            groupBox2.Location = new Point(446, 126);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(318, 67);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tipo de contrato";
            // 
            // rbAutonomo
            // 
            rbAutonomo.AutoSize = true;
            rbAutonomo.Location = new Point(134, 32);
            rbAutonomo.Name = "rbAutonomo";
            rbAutonomo.Size = new Size(124, 29);
            rbAutonomo.TabIndex = 2;
            rbAutonomo.Text = "Autônomo";
            rbAutonomo.UseVisualStyleBackColor = true;
            // 
            // rbPJ
            // 
            rbPJ.AutoSize = true;
            rbPJ.Location = new Point(76, 32);
            rbPJ.Name = "rbPJ";
            rbPJ.Size = new Size(52, 29);
            rbPJ.TabIndex = 1;
            rbPJ.Text = "PJ";
            rbPJ.UseVisualStyleBackColor = true;
            // 
            // rbCLT
            // 
            rbCLT.AutoSize = true;
            rbCLT.Checked = true;
            rbCLT.Location = new Point(6, 32);
            rbCLT.Name = "rbCLT";
            rbCLT.Size = new Size(64, 29);
            rbCLT.TabIndex = 0;
            rbCLT.TabStop = true;
            rbCLT.Text = "CLT";
            rbCLT.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Segoe UI", 12F);
            btnSalvar.Location = new Point(617, 346);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(147, 72);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // lblErros
            // 
            lblErros.AutoSize = true;
            lblErros.ForeColor = Color.Red;
            lblErros.Location = new Point(69, 346);
            lblErros.Name = "lblErros";
            lblErros.Size = new Size(0, 25);
            lblErros.TabIndex = 9;
            // 
            // FrmCadastroFuncionario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblErros);
            Controls.Add(btnSalvar);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(txtSalario);
            Controls.Add(label3);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Name = "FrmCadastroFuncionario";
            Text = "Cadastro funcionario";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNome;
        private Label label2;
        private TextBox txtEmail;
        private Label label3;
        private TextBox txtSalario;
        private GroupBox groupBox1;
        private RadioButton rbFeminino;
        private RadioButton rbMasculino;
        private GroupBox groupBox2;
        private RadioButton rbAutonomo;
        private RadioButton rbPJ;
        private RadioButton rbCLT;
        private Button btnSalvar;
        private Label lblErros;
    }
}