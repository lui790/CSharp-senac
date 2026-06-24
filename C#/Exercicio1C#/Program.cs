namespace Exercicio1C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                double raiz = Math.Sqrt(i);
                Console.WriteLine($"i: {i}, raiz: {raiz:F2}");
            }
        }
    }
}
