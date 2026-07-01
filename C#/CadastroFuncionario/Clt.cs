using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Clt : Funcionario
    {
        public Clt(
            string nome,
            string cpf,
            string tipo,
            double salariobase)
        {
            Nome = nome;
            Cpf = cpf;
            Tipo = tipo;
            SalarioBase = salariobase;

        }

        public double SalarioBase { get; set; }

        public void CalcularSalario()
        {
            Console.WriteLine($"Salario do clt {SalarioBase}");
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome}, Documento: {Cpf}, Salario: {SalarioBase}, Tipo: {Tipo}");
        }
    }
}
