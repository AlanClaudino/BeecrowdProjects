namespace Snack___1038
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] dados = Console.ReadLine().Split();

            int item = int.Parse(dados[0]);
            int quantity = int.Parse(dados[1]);
            double price;
            double total;

            if (item == 1)
            {
                price = 4.00;
                total= price * quantity;
                Console.WriteLine($"Total: R$ {total:F2}"); ;
            } else if (item == 2) {
                price = 4.50;
                total = price * quantity;
                Console.WriteLine($"Total: R$ {total:F2}");
            } else if (item == 3)
            {
                price = 5.00;
                total = price * quantity;
                Console.WriteLine($"Total: R$ {total:F2}");
            } else if (item == 4)
            {
                price = 2.00;
                total = price * quantity;
                Console.WriteLine($"Total: R$ {total:F2}");
            } else if (item == 5)
            {
                price = 1.50;
                total = price * quantity;
                Console.WriteLine($"Total: R$ {total:F2}");
            }

        }
    }
}