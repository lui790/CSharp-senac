namespace Calculadora
{
    partial class Calculadora
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
            btnSoma = new Button();
            btnVezes = new Button();
            btnSub = new Button();
            btnDivisao = new Button();
            btnIgual = new Button();
            txtHud = new TextBox();
            btn3 = new Button();
            btn2 = new Button();
            btn5 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btn4 = new Button();
            btn1 = new Button();
            btn9 = new Button();
            btn6 = new Button();
            btn0 = new Button();
            btnClear = new Button();
            txtHud2 = new TextBox();
            SuspendLayout();
            // 
            // btnSoma
            // 
            btnSoma.Font = new Font("Segoe UI", 15F);
            btnSoma.Location = new Point(403, 448);
            btnSoma.Name = "btnSoma";
            btnSoma.Size = new Size(112, 88);
            btnSoma.TabIndex = 3;
            btnSoma.Text = "+";
            btnSoma.UseVisualStyleBackColor = true;
            btnSoma.Click += btnSoma_Click;
            // 
            // btnVezes
            // 
            btnVezes.Font = new Font("Segoe UI", 10F);
            btnVezes.Location = new Point(403, 260);
            btnVezes.Name = "btnVezes";
            btnVezes.Size = new Size(112, 88);
            btnVezes.TabIndex = 4;
            btnVezes.Text = "X";
            btnVezes.UseVisualStyleBackColor = true;
            btnVezes.Click += btnVezes_Click;
            // 
            // btnSub
            // 
            btnSub.Font = new Font("Segoe UI", 20F);
            btnSub.Location = new Point(403, 354);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(112, 88);
            btnSub.TabIndex = 5;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = true;
            btnSub.Click += btnSub_Click;
            // 
            // btnDivisao
            // 
            btnDivisao.Font = new Font("Segoe UI", 16F);
            btnDivisao.Location = new Point(403, 166);
            btnDivisao.Name = "btnDivisao";
            btnDivisao.Size = new Size(112, 88);
            btnDivisao.TabIndex = 6;
            btnDivisao.Text = "÷";
            btnDivisao.UseVisualStyleBackColor = true;
            btnDivisao.Click += btnDivisao_Click;
            // 
            // btnIgual
            // 
            btnIgual.Font = new Font("Segoe UI", 16F);
            btnIgual.Location = new Point(403, 542);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(112, 88);
            btnIgual.TabIndex = 7;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = true;
            btnIgual.Click += button1_Click;
            // 
            // txtHud
            // 
            txtHud.Enabled = false;
            txtHud.Font = new Font("Segoe UI", 30F);
            txtHud.Location = new Point(12, 60);
            txtHud.Name = "txtHud";
            txtHud.Size = new Size(503, 87);
            txtHud.TabIndex = 8;
            txtHud.Text = "0";
            txtHud.TextAlign = HorizontalAlignment.Right;
            txtHud.TextChanged += txtHud_TextChanged;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 16F);
            btn3.Location = new Point(248, 262);
            btn3.Name = "btn3";
            btn3.Size = new Size(112, 88);
            btn3.TabIndex = 9;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 16F);
            btn2.Location = new Point(130, 262);
            btn2.Name = "btn2";
            btn2.Size = new Size(112, 88);
            btn2.TabIndex = 10;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI", 16F);
            btn5.Location = new Point(130, 356);
            btn5.Name = "btn5";
            btn5.Size = new Size(112, 88);
            btn5.TabIndex = 11;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 16F);
            btn8.Location = new Point(130, 447);
            btn8.Name = "btn8";
            btn8.Size = new Size(112, 88);
            btn8.TabIndex = 12;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI", 16F);
            btn7.Location = new Point(12, 447);
            btn7.Name = "btn7";
            btn7.Size = new Size(112, 88);
            btn7.TabIndex = 13;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 16F);
            btn4.Location = new Point(12, 354);
            btn4.Name = "btn4";
            btn4.Size = new Size(112, 88);
            btn4.TabIndex = 14;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 16F);
            btn1.Location = new Point(12, 260);
            btn1.Name = "btn1";
            btn1.Size = new Size(112, 88);
            btn1.TabIndex = 15;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 16F);
            btn9.Location = new Point(248, 447);
            btn9.Name = "btn9";
            btn9.Size = new Size(112, 88);
            btn9.TabIndex = 16;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 16F);
            btn6.Location = new Point(248, 356);
            btn6.Name = "btn6";
            btn6.Size = new Size(112, 88);
            btn6.TabIndex = 17;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn0
            // 
            btn0.Font = new Font("Segoe UI", 16F);
            btn0.Location = new Point(130, 542);
            btn0.Name = "btn0";
            btn0.Size = new Size(112, 88);
            btn0.TabIndex = 18;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 16F);
            btnClear.Location = new Point(248, 166);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 88);
            btnClear.TabIndex = 19;
            btnClear.Text = "CE";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // txtHud2
            // 
            txtHud2.Enabled = false;
            txtHud2.Font = new Font("Segoe UI", 14F);
            txtHud2.Location = new Point(12, 9);
            txtHud2.Name = "txtHud2";
            txtHud2.Size = new Size(503, 45);
            txtHud2.TabIndex = 20;
            txtHud2.TextAlign = HorizontalAlignment.Right;
            // 
            // Calculadora
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 637);
            Controls.Add(txtHud2);
            Controls.Add(btnClear);
            Controls.Add(btn0);
            Controls.Add(btn6);
            Controls.Add(btn9);
            Controls.Add(btn1);
            Controls.Add(btn4);
            Controls.Add(btn7);
            Controls.Add(btn8);
            Controls.Add(btn5);
            Controls.Add(btn2);
            Controls.Add(btn3);
            Controls.Add(txtHud);
            Controls.Add(btnIgual);
            Controls.Add(btnDivisao);
            Controls.Add(btnSub);
            Controls.Add(btnVezes);
            Controls.Add(btnSoma);
            Name = "Calculadora";
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSoma;
        private Button btnVezes;
        private Button btnSub;
        private Button btnDivisao;
        private Button btnIgual;
        private TextBox txtHud;
        private Button btn3;
        private Button btn2;
        private Button btn5;
        private Button btn8;
        private Button btn7;
        private Button btn4;
        private Button btn1;
        private Button btn9;
        private Button btn6;
        private Button btn0;
        private Button btnClear;
        private TextBox txtHud2;
    }
}