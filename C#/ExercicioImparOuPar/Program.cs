namespace ExercicioImparOuPar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao sistema");
            Console.WriteLine("Digite um número para começar");
            Console.WriteLine("Digite >stop< para terminar");
            string numero1 = "";
            int loop = 0;

            while (loop == 0)
            {
                numero1 = Console.ReadLine();
                if (numero1 == "stop") { loop++; break; }

                if (int.TryParse(numero1, out int numero2))
                {
                    if (numero2 == 0)
                    {
                        Console.WriteLine($"O número {numero2} é par");
                    }
                    else { Console.WriteLine($"O número {numero2} é impar"); }
                }
                else { Console.WriteLine("Por favor insira um número valido!"); }
            }
            // caso fizesse normalmente (teria que todo o codigo ficar dentro do try)
            try
            {
                int numero2 = int.Parse(numero1);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); // poderia ser oq quiser dentro do cw
            }                                  // ex:"Por favor insira um número valido!"
        }
    }
}
