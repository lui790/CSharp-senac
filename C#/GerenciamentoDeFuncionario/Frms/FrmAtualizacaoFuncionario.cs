using GerenciamentoDeFuncionario.Banco.Repositories;
using GerenciamentoDeFuncionario.Modelos;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GerenciamentoDeFuncionario.Frms
{
    public partial class FrmAtualizacaoFuncionario : Form
    {
        public int IdFuncionario { get; set; }

        public FrmAtualizacaoFuncionario(int idFuncionario)
        {
            InitializeComponent();

            this.IdFuncionario = idFuncionario;

            Load += FrmAtualizacaoFuncionario_Load;
        }

        private async void FrmAtualizacaoFuncionario_Load(object? sender, EventArgs e)
        {
            var funcionario = await FuncionarioRepository.ObterPorId(this.IdFuncionario);

            txtNome.Text = funcionario.Nome;
            txtEmail.Text = funcionario.Email;
            txtSalario.Text = funcionario.Salario.ToString();

            switch (funcionario.Sexo)
            {
                case 'M':
                    rbMasculino.Checked = true;
                    break; ;
                case 'F':
                    rbFeminino.Checked = true;
                    break;
            }

            switch (funcionario.TipoDeContrato)
            {
                case "CLT":
                    rbCLT.Checked = true;
                    break;
                case "PJ":
                    rbPJ.Checked = true;
                    break;
                case "Autonomo":
                    rbAutonomo.Checked = true;
                    break;
            }
        }

        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string email = txtEmail.Text;
            char sexo = rbMasculino.Checked ? 'M' : 'F';
            string tipoContrato = rbCLT.Checked ? "CLT" : rbPJ.Checked ? "PJ" : "Autonomo";
            decimal salario = decimal.Parse(txtSalario.Text);
            var dataAtualizacao = DateTime.Now;
            
            var funcionario = new Funcionario(nome, email, sexo, tipoContrato, salario, dataAtualizacao);

            var stringBuilder = new StringBuilder();
            var listaDeErros = new List<ValidationResult>();

            var contexto = new ValidationContext(funcionario);
            Validator.TryValidateObject(funcionario, contexto, listaDeErros, true);
            
            if (listaDeErros.Count > 0 )
            {
                foreach (var erro in listaDeErros)
                {
                    stringBuilder.Append(erro.ErrorMessage + "\n");
                }

                lblErros.Text = stringBuilder.ToString();
            } 
            else
            {
                await FuncionarioRepository.AtualizarFuncionario(funcionario, this.IdFuncionario);

                this.Close();
            }
        }
    }
}
