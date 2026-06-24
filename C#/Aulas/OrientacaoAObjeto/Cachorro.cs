namespace OrientacaoAObjeto
{
    public class Cachorro
    {
        public Cachorro(
            string nome,
            DateTime dataDeNascimento,
            string raca,
            double peso,
            bool isVacinado)
        {
            Nome = nome;
            DataDeNascimento = dataDeNascimento;
            Raca = raca;
            Peso = peso;
            IsVacinado = isVacinado;
        }

        public string Nome { get; private set; }

        public DateTime DataDeNascimento { get; private set; }

        public string Raca { get; private set; }

        public double Peso { get; set; }

        public bool IsVacinado { get; set; }

        public void SeComunicar()
        {
            Console.WriteLine($"Au, au");
        }

        public void Caminhar()
        {
            Console.WriteLine("Cachorro caminhando...");
        }

        public void FazerTruque(string truque)
        {
            Console.WriteLine($"Truque: {truque}");
        }
    }
}
