namespace OrientacaoAObjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pessoa1 = new Pessoa(
                "Guilherme",
                new DateTime(2007, 6, 1),
                1.70,
                "09120931213",
                true);

            Console.WriteLine("Informações da Pessoa");
            Console.WriteLine($"Nome {pessoa1.Nome}");
            Console.WriteLine($"Data de Nascimento {pessoa1.DataDeNascimento}");
            Console.WriteLine($"Altura {pessoa1.Altura}");
            Console.WriteLine($"Cpf {pessoa1.Cpf}");
            Console.WriteLine($"Está ativo {pessoa1.IsAtivo}");
            pessoa1.SeComunicar();

            //pessoa1.Nome = "Vitor";
            Console.WriteLine($"Meu novo pessoa 1 {pessoa1.Nome}");

            Console.WriteLine("");


            var pessoa2 = new Pessoa(
                "Douglas",
                new DateTime(2014, 12, 21),
                1.65,
                "2139120931",
                true);

            //Pessoa pessoa2 = new Pessoa();
            //pessoa2.Nome = "Jão";
            //pessoa2.DataDeNascimento = new DateTime(2014, 6, 01);
            //pessoa2.Altura = 1.64;
            //pessoa2.Cpf = "32893298322";
            //pessoa2.IsAtivo = false;

            Console.WriteLine("Informações da Pessoa 2");
            Console.WriteLine($"Nome {pessoa2.Nome}");
            Console.WriteLine($"Data de Nascimento {pessoa2.DataDeNascimento}");
            Console.WriteLine($"Altura {pessoa2.Altura}");
            Console.WriteLine($"Cpf {pessoa2.Cpf}");
            Console.WriteLine($"Está ativo {pessoa2.IsAtivo}");

            pessoa1.SeComunicar();
            Console.WriteLine("");
            Console.WriteLine("------ Pet shop ------");

            var pedido = new Pedido(
                pessoa1,
                DateTime.Now);
            Console.WriteLine($"");

            var zeke = new Cachorro(
                "Zeke",
                new DateTime(2021, 03, 21),
                "Viralata",
                11,
                true);

            Console.WriteLine("Criação do pedido 2");
            var pedido2 = new Pedido(pessoa2, DateTime.Now, 199.90, "Vazia");

            Console.WriteLine("Informações do pedido 2");
            Console.WriteLine($"");
        }
    }
}
