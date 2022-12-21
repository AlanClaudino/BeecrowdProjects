namespace PositiveNumbers_1060
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int control = 0;
            for (int i = 0; i < 6; i++)
            {
                double x = double.Parse(Console.ReadLine());
                if (x > 0)
                {
                    control++;
                }
            }
            Console.WriteLine($"{control} valores positivos");

        }
    }
}