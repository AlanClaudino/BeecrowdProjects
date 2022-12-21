namespace SixOddNumbers_1070
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < 6; i++)
            {
                if ((number % 2) == 1)
                {
                    Console.WriteLine((i*2) + number);
                }
                else
                {
                    Console.WriteLine((i * 2) + number + 1);
                }
            }
        }

    }
}