using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Estagiario : Funcionario
    {
        public Estagiario(
            string nome,
            string cpf,
            string tipo,
            double bolsaAuxilio,
            double valeTranspote)
        {
            Nome = nome;
            Cpf = cpf;
            Tipo = tipo;
            BolsaAuxilio = bolsaAuxilio;
            ValeTransporte = valeTranspote;
        }

        public double BolsaAuxilio;

        public double ValeTransporte;

        public void CalcularSalario()
        {
            double Salario = BolsaAuxilio + ValeTransporte;
            Console.WriteLine($"Salario de estagiario: {Salario}");
        }

        public void ExibirDados()
        {
            double Salario = BolsaAuxilio + ValeTransporte;
            Console.WriteLine($"{Nome}, {Cpf}, {Salario}, {Tipo}");
        }
    }
}
