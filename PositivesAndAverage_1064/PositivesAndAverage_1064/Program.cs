namespace PositivesAndAverage_1064
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int control = 0;
            double totalSum = 0;
            for (int i = 0; i < 6; i++)
            {
                double x = double.Parse(Console.ReadLine());
                if (x > 0)
                {
                    control++;
                    totalSum += x;
                }
            }

            double average = totalSum/ control;
            Console.WriteLine($"{control} valores positivos");
            Console.WriteLine($"{average:F1}");
        }
    }
}