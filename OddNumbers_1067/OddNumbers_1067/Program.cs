namespace OddNumbers_1067
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                if((i%2) == 1)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}