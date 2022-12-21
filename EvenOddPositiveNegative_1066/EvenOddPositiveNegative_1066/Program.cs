namespace EvenOddPositiveNegative_1066
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int even = 0;
            int positive = 0;
            int negative = 0;

            for (int i = 0; i < 5; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if ((x % 2) == 0)
                {
                    even++;
                }
                if(x > 0) {
                    positive++;
                } else if (x < 0)
                {
                    negative++;
                }


            }

            Console.WriteLine($"{even} valor(es) par(es)");
            Console.WriteLine($"{(5 - even)} valor(es) impar(es)");
            Console.WriteLine($"{positive} valor(es) positivo(s)");
            Console.WriteLine($"{negative} valor(es) negativo(s)");

        }
    }
}