namespace Consumption
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalDistance = int.Parse(Console.ReadLine());
            double fuel = double.Parse(Console.ReadLine());

            double consumption = totalDistance/ fuel;
            string consumptionFinal = consumption.ToString("F3");

            Console.WriteLine($"{consumptionFinal} km/l");
        }
    }
}