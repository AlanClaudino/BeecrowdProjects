namespace MultiplicationTable_1078
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i<=10; i++)
            {
                int x = i * number; 
                Console.WriteLine($"{i} x {number} = {x}");
            }
        }
    }
}