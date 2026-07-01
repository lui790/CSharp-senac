namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int loop = 0;
            
            Console.WriteLine("Bem vindo ao cadastro");
            Console.WriteLine("Insira os dados de funcionario");
            Console.WriteLine("");

            Console.WriteLine("Insira o seu nome");
            String Nome = Console.ReadLine();

            Console.WriteLine("Insira o seu cpf");
            String Cpf = Console.ReadLine();

            Console.WriteLine("Qual é sua classe de trabalho? (clt, terceirizado ou estagiario");
            string Tipo = "";
            while (loop == 0)
            {
                Tipo = Console.ReadLine();
                if (Tipo != "clt" && Tipo != "terceirizado" && Tipo != "estagiario")
                {
                    Console.WriteLine("Por favor escolha uma opção valida!");
                } else { loop ++; }
            }

            if (Tipo == "clt")
            {
                    string salarioBase = "";
                while (loop == 0)
                {
                    try
                    {
                        Console.WriteLine("Qual o seu salario?");
                        salarioBase = Console.ReadLine();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Sem caracteres não permitidos");
                        if (ex == null) { loop++; }
                    }
                }
                    new Clt(
                        Nome,
                        Cpf,
                        Tipo,
                        int.Parse(salarioBase));
            }
        }
    }
}
