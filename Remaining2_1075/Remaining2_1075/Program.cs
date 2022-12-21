namespace Remaining2_1075
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10000; i++)
            {
                if ((i%number) == 2)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}