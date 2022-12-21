namespace FuelSpent___1017
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int time = int.Parse(Console.ReadLine());
            int speedAvg = int.Parse(Console.ReadLine());

            int distance = time * speedAvg;

            double fuel = distance / 12.0;
            string finalFuel = fuel.ToString("F3");

            Console.WriteLine(finalFuel);
        }
    }
}