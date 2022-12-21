namespace Interval2_1070
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfInts = int.Parse(Console.ReadLine());
            int numIn = 0;
            int numOut = 0;

            for (int i = 0; i < numberOfInts; i++) {
                int num = int.Parse(Console.ReadLine());
                if (num >= 10 && num <= 20)
                {
                    numIn++;
                } else
                {
                    numOut++;
                }
            }

            Console.WriteLine($"{numIn} in");
            Console.WriteLine($"{numOut} out");


        }
    }
}