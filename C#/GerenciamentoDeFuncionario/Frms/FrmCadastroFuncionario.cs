using GerenciamentoDeFuncionario.Banco.Repositories;
using GerenciamentoDeFuncionario.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciamentoDeFuncionario.Frms
{
    public partial class FrmCadastroFuncionario : Form
    {
        public FrmCadastroFuncionario()
        {
            InitializeComponent();
        }

        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string email = txtEmail.Text;
            char sexo = rbMasculino.Checked ? 'M' : 'F'; //A
            string tipoContrato = rbCLT.Checked ? "CLT" : rbPJ.Checked ? "PJ" : "Autonomo";
            decimal salario = decimal.Parse(txtSalario.Text);
            var dataCadastro = DateTime.Now;

            var funcionario = new Funcionario(nome, email, sexo, tipoContrato, salario, dataCadastro);

            await FuncionarioRepository.Adicionar(funcionario);
        }
    }
}
//A: mesma coisa se fizesse um if:
//if (rbMasculino.Checked)
//{sexo = 'M'}
//else 
//{sexo = 'F'}
