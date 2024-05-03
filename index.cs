    internal class Program
    {
        static string CalculoRank(int qtdeVitorias, int qtdeDerrotas)
        {
            int pontosObtidos = qtdeVitorias - qtdeDerrotas;
            string ranking;
            if (pontosObtidos < 10)
            {
                ranking = "Ferro";
                return ranking;
            }
            else if (pontosObtidos < 21)
            {
                ranking = "Bronze";
                return ranking;
            }
            else if (pontosObtidos < 51)
            {
                ranking = "Prata";
                return ranking;
            }
            else if (pontosObtidos < 81)
            {
                ranking = "Ouro";
                return ranking;
            }
            else if (pontosObtidos < 91)
            {
                ranking = "Diamante";
                return ranking;
            }
            else if (pontosObtidos < 101)
            {
                ranking = "Lendário";
                return ranking;
            }
            else
            {
                ranking = "Imortal";
                return ranking;
            }

        }
        static void Main(string[] args)
        {
            
            Console.WriteLine($"Digite o numero de vitórias:");
            int qtdeVitorias = int.Parse(Console.ReadLine());
            Console.WriteLine($"Digite o numero de derrotas:");
            int qtdeDerrotas = int.Parse(Console.ReadLine());
            int saldoVitorias = qtdeVitorias - qtdeDerrotas;
            string nivel = CalculoRank(qtdeVitorias, qtdeDerrotas);

            Console.WriteLine($"O Herói tem de saldo **{saldoVitorias}** está no nível de **{nivel}**");
            Console.ReadLine();
        }
    }
