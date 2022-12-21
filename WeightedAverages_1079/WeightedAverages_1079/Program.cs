using System.Runtime.CompilerServices;

namespace WeightedAverages_1079
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCases = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCases; i++)
            {
                string[] dados = Console.ReadLine().Split();

                double a = double.Parse(dados[0]);
                double b = double.Parse(dados[1]);
                double c = double.Parse(dados[2]);

                double media = (a * 2 + b * 3 + c * 5) / 10.0;
                double mediaFinal = Math.Round(media, 1);

                Console.WriteLine($"{mediaFinal:F1}");

            }
        }
    }
}