namespace CadastroDeAlunos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool loop = true;
            Console.WriteLine("Cadastro de alunos");
            IList<Aluno> lista = new List<Aluno>();

            while (loop)
            {
                Console.WriteLine("Bem vindo ao sistema de cadastro de alunos");
                Console.WriteLine($"Escolha umas opções:\n" +
                    $"1 - Adicionar aluno\n" +
                    $"2 - Remover um aluno\n" +
                    $"3 - Listar todos os nomes cadastrados\n" +
                    $"4 - Sair do programa");



                string input = Console.ReadLine();

                if (input == "1")
                {
                    Console.WriteLine("Digite o nome do aluno");
                    string nome = Console.ReadLine();

                    Console.WriteLine("Digite a data de nascimento do aluno (dd/mm/aaaa)");
                    string dataDeNascimento = Console.ReadLine();

                    Console.WriteLine("Digite o cpf do aluno");
                    string cpf = Console.ReadLine();

                    Aluno aluno = new Aluno(
                        nome,
                        DateTime.Parse(dataDeNascimento),
                        cpf);

                    lista.Add(aluno);
                    Console.Clear();
                }

                if (input == "2")
                {
                    Console.WriteLine("Qual você gostaria de remover?");
                    Console.WriteLine("Escreva >cpf< para filtar os alunos por cpf");
                    Console.WriteLine("Para voltar digite >voltar<");
                    int i = 0;
                    foreach (var item in lista)
                    {
                        Console.WriteLine($"{i++} - {item.Nome}");
                    }
                    string input2 = Console.ReadLine();
                    if (input2 == "voltar")
                    {
                        Console.Clear();
                    }

                    if (input2 == "cpf")
                    {
                        i = 0;
                        Console.WriteLine("Digite o cpf do aluno");
                        string filtro = Console.ReadLine();
                        string cpfInput;
                        Console.WriteLine("Qual voce gostaria de remover?");
                        foreach (var item in lista)
                        {
                            cpfInput = item.Cpf;
                            if (filtro == cpfInput)
                            {
                                Console.WriteLine($"{i} - {item.Nome}");
                            }
                            i++;
                        }
                        input2 = Console.ReadLine();
                    }

                    lista.RemoveAt(int.Parse(input2));
                    Console.Clear();
                }

                if (input == "3")
                {
                    Console.WriteLine("Aqui estão todos os alunos cadastrados!");
                    Console.WriteLine("Digite >voltar< para voltar");

                    foreach (var item in lista)
                    {
                        int i = 0;
                        int idade;
                        var Data = item.DataDeNascimento;
                        var Ano = Data.Year;
                        var Hoje = global::System.DateTime.Now;
                        idade = Hoje.Year - Ano;
                        Console.WriteLine($"{i++} - Nome: {item.Nome}\n" +
                            $"Idade: {idade}\n" +
                            $"Cpf: {item.Cpf}");
                    }
                    string input3 = Console.ReadLine();

                    if (input3 == "voltar")
                    {
                        Console.Clear();
                    }
                }

                if (input == "4") { loop = false; break; }



            }



        }



    }



}
