namespace SelectionTest1___1035
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] dados = Console.ReadLine().Split();

            int a = int.Parse(dados[0]);
            int b = int.Parse(dados[1]);
            int c = int.Parse(dados[2]);
            int d = int.Parse(dados[3]);

            bool teste1 = (b > c);
            bool teste2 = (d > a);
            bool teste3 = ((a + b) < (c + d));
            bool teste4 = (c > 0 && d > 0);
            bool teste5 = (a % 2 == 0);

            if (teste1 && teste2 && teste3 && teste4 && teste5)
            {
                Console.WriteLine("Valores aceitos");
            }
            else
            {
                Console.WriteLine("Valores nao aceitos");
            }
        }
    }
}