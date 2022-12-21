namespace SequenceIJ4_1098
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (double i = 0; i <= 2; i = i + 0.2)
            {
                for (int j = 1; j <= 3; j++)
                {   
                    double jota = i + j;
                    double test = Math.Round(i, 1);
                    if (test == 0.0 || test == 1.0 || test == 2.0)
                    {
                        Console.WriteLine($"I={i:F0} J={jota:F0}");
                    }
                    else
                    {
                        Console.WriteLine($"I={i:F1} J={jota:F1}");
                    }
                }
            }
        }
    }
}