using GerenciamentoDeFuncionario.Banco.Repositories;
using GerenciamentoDeFuncionario.Modelos;
using System.ComponentModel;

namespace GerenciamentoDeFuncionario.Frms
{
    public partial class FrmTelaPrincipal : Form
    {
        public FrmTelaPrincipal()
        {
            InitializeComponent();

            Load += FrmTelaPrincipal_Load;
        }

        private async void FrmTelaPrincipal_Load(object? sender, EventArgs e)
        {
            var funcionarios = await FuncionarioRepository.ObterTodos();

            dgvFuncionarios.DataSource = new BindingList<Funcionario>(funcionarios.ToList());
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            new FrmCadastroFuncionario().ShowDialog();
        }
    }
}
