namespace EvenBetweenFiveNum_1065
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int control = 0;
            for (int i = 0; i < 5; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if ((x%2) == 0)
                {
                    control++;
                }
            }

            Console.WriteLine($"{control} valores pares");
        }
    }
}