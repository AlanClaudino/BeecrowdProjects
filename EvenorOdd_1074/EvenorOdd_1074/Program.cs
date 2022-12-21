namespace EvenorOdd_1074
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfValues = int.Parse(Console.ReadLine());
            int[] ints= new int[numberOfValues];

            for (int i = 0; i < numberOfValues; i++)
            {
                ints[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < numberOfValues; i++)
            {
                if (ints[i] == 0)
                {
                    Console.WriteLine("NULL");
                }
                else
                {
                    if ((ints[i] % 2) == 0)
                    {
                        Console.Write("EVEN ");
                    }
                    else
                    {
                        Console.Write("ODD ");
                    }

                    if (ints[i] > 0)
                    {
                        Console.WriteLine("POSITIVE");
                    }
                    else
                    {
                        Console.WriteLine("NEGATIVE");
                    }
                }
            }
        }
    }
}