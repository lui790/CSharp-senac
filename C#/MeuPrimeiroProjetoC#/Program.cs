namespace MeuPrimeiroProjetoC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine("Meu nome é Luis");

            int idade = 19;
            string nome = "Luis";
            string sobrenome = "Kurtz";
            bool ehProfessor = false;
            double altura = 1.70;

            //Console.WriteLine($"Meu nome {nome} {sobrenome}. Tenho {idade} anos de idade");
            //Console.WriteLine($"Sou professor: {ehProfessor}");
            //Console.WriteLine($"Tenho {altura} de altura");

            string nomeCompleto = ObterNomeCompleto(nome, sobrenome);
            Console.WriteLine($"Meu nome é {nomeCompleto}");

            ExibirSeEhProfessorEaltura(ehProfessor, altura);
        }

        static string ObterNomeCompleto(string nome, string sobrenome)
        {
            return $"{nome} {sobrenome}";
        }

        static void ExibirSeEhProfessorEaltura(bool ehProfessor, double altura)
        {
            Console.WriteLine($"Sou professor: {ehProfessor}");
            Console.WriteLine($"Tenho {altura} de altura");
        }
    }
}
