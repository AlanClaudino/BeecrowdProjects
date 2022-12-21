namespace EvenSquare_1073
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1 ; i <= number; i++)
            {
                if ((i%2) == 0)
                {
                    int square = (i * i);
                    Console.WriteLine($"{i}^2 = {square}");
                }
            }
        }
    }
}