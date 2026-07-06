using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeAlunos
{
    internal class Aluno
    {
        public Aluno(
            string nome,
            DateTime dataDeNascimento,
            string cpf)
        {
            Nome = nome;
            DataDeNascimento = dataDeNascimento;
            Cpf = cpf;
        }
        public Guid Matricula {  get; private set; } = Guid.NewGuid();
        public string Nome {get; private set;}

        public DateTime DataDeNascimento {get; private set;}

        public string Cpf { get; private set;}
    }
}
