using System.Formats.Asn1;

namespace Experiments_1094
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int NumberOfExperiments = int.Parse(Console.ReadLine());
            int numberOfCoelhos = 0;
            int numberOfRatos = 0;
            int numberOfSapos = 0;

            for (int i = 1; i <= NumberOfExperiments; i++)
            {
                string[] dados = Console.ReadLine().Split();

                if (dados[1] == "C")
                {
                    numberOfCoelhos += int.Parse(dados[0]);
                } 
                else if (dados[1] == "R")
                {
                    numberOfRatos+= int.Parse(dados[0]);
                }
                else if (dados[1] == "S")
                {
                    numberOfSapos += int.Parse(dados[0]);
                }
            }

            double total = (double) numberOfRatos + numberOfSapos + numberOfCoelhos;

            Console.WriteLine($"Total: {total} cobaias");
            Console.WriteLine($"Total de coelhos: {numberOfCoelhos}");
            Console.WriteLine($"Total de ratos: {numberOfRatos}");
            Console.WriteLine($"Total de sapos: {numberOfSapos}");

            double percCoelhos = (double) (numberOfCoelhos / total) * 100.00;
            double percRatos = (double) (numberOfRatos / total) * 100.00;
            double percSapos = (double) (numberOfSapos / total) * 100.00;

            Console.WriteLine($"Percentual de coelhos: {percCoelhos:F2} %");
            Console.WriteLine($"Percentual de ratos: {percRatos:F2} %");
            Console.WriteLine($"Percentual de sapos: {percSapos:F2} %");

        }
    }
}