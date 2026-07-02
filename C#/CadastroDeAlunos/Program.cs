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
                Console.Clear();
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

                    Aluno aluno = new Aluno(
                        nome);

                    lista.Add(aluno);
                }

                if (input == "2")
                {
                    Console.WriteLine("Qual você gostaria de remover?");
                    int i = 0;
                    foreach (var item in lista)
                    {
                        Console.WriteLine($"{item.Nome} {i++}");
                    }
                    string numeroInput = Console.ReadLine();
                    lista.RemoveAt(int.Parse(numeroInput));
                }

                if (input == "3")
                {
                    Console.WriteLine("Aqui estão todos os alunos cadastrados!");
                    foreach (var item in lista)
                    {
                        Console.WriteLine(item.Nome);
                    }
                }

                if (input == "4") { loop = false; break; }



            }



        }



    }



}
