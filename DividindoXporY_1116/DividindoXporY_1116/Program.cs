namespace DividindoXporY_1116
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = int.Parse(Console.ReadLine());

            for (int i = 0; i < numero; i++)
            {
                string[] dados = Console.ReadLine().Split();
                int a = int.Parse(dados[0]);
                int b = int.Parse(dados[1]);
                double divisao;

                if (b == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    divisao = (double)a / b;
                    Console.WriteLine($"{divisao:F1}");
                }
            }
        }
    }
}