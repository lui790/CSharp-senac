using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Terceirizado : Funcionario
    {
        public Terceirizado(
            string nome,
            string cpf,
            string tipo,
            double horasTrabalhadas,
            double valorHora)
        {
            Nome = nome;
            Cpf = cpf;
            Tipo = tipo;
            HorasTrabalhadas = horasTrabalhadas;
            ValorHora = valorHora;
        }

        public double HorasTrabalhadas;

        public double ValorHora;

        public void CalcularSalario()
        {
            double salario = HorasTrabalhadas * ValorHora;
            Console.WriteLine($"O salario do terceirizado é de: {salario}");
        }

        public void ExibirDados()
        {
            double salario = HorasTrabalhadas * ValorHora;
            Console.WriteLine($"Nome: {Nome}, Documento: {Cpf}, Salario: {salario}, Tipo: {Tipo}");
        }
    }
}
