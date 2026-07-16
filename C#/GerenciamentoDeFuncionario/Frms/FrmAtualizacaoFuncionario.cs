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
    public partial class FrmAtualizacaoFuncionario : Form
    {
        public int IdFuncionario { get; set; }

        public FrmAtualizacaoFuncionario(int idFuncionario)
        {
            InitializeComponent();

            IdFuncionario = idFuncionario;

            Load += FrmAtualizacaoFuncionario_Load;
        }

        private void FrmAtualizacaoFuncionario_Load(object? sender, EventArgs e)
        {
            var funcionario = FuncionarioRepository.ObterPorId(IdFuncionario);
        }
    }
}
