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
                string salarioInput = "";
                loop = 0;
                while (loop == 0)
                {
                    try
                    {
                        Console.WriteLine("Qual o seu salario?");
                        salarioInput = Console.ReadLine();
                        if (double.TryParse(salarioInput, out double salarioBase))
                        {
                    new Clt(
                        Nome,
                        Cpf,
                        Tipo,
                        salarioBase);
                        }
                        loop ++;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Sem caracteres não permitidos");
                    }

                }

            }

            if (Tipo == "terceirizado")
            {
                string horasInput = "";
                string valorInput = "";

                loop = 0;
                while (loop == 0)
                {
                    try
                    {
                        Console.WriteLine("Horas trabalhadas");
                        horasInput = Console.ReadLine();
                        if (double.TryParse(horasInput, out double horasTrabalhadas))
                        {
                            Console.WriteLine("Qual o valor de sua hora?");
                            valorInput = Console.ReadLine();
                            if (double.TryParse(valorInput, out double valorHora))
                            {
                                new Terceirizado(
                                    Nome,
                                    Cpf,
                                    Tipo,
                                    horasTrabalhadas,
                                    valorHora);
                            }
                        } else { return; }

                    } catch (Exception ex) { Console.WriteLine("Erros na quantidade de valor ou horas"); }
                }
            }

            //usar "Listas" para criar os funcionarios


        }
    }
}
