namespace HighestandPosition_1080
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int highest = 0;
            int position = 0;

            for (int i = 1; i <= 100; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number > highest)
                {
                    highest = number;
                    position = i;
                }
            }

            Console.WriteLine(highest);
            Console.WriteLine(position);
        }
    }
}