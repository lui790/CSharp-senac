using GerenciamentoDeFuncionario.Banco.Repositories;
using GerenciamentoDeFuncionario.Modelos;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

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

            var stringBuilder = new StringBuilder();
            var listaDeErros = new List<ValidationResult>();

            var contexto = new ValidationContext(funcionario);
            Validator.TryValidateObject(funcionario, contexto, listaDeErros, true);

            if (listaDeErros.Count > 0)
            {
                // adiciona os erros no stringBuilder e exibe na tela
                foreach (var erro in listaDeErros)
                {
                    stringBuilder.Append(erro.ErrorMessage + "\n");
                    // ele vai pegar o 'ErrorMessage' do Funcionario.cs
                }

                lblErros.Text = stringBuilder.ToString();
            }
            else
            {
                await FuncionarioRepository.Adicionar(funcionario);
                this.Close();
            }


        }

        private void txtSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            if (e.KeyChar == ',' && ((TextBox)sender).Text.Contains(","))
            {
                e.Handled = true;
            }

            if (e.KeyChar == ',' && ((TextBox)sender).Text == string.Empty)
            {
                e.Handled = true;
            }
        }
    }
}
//A: mesma coisa se fizesse um if:
//if (rbMasculino.Checked)
//{sexo = 'M'}
//else 
//{sexo = 'F'}
