namespace SalaryWithBonnus___1009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double fixedSalary = double.Parse(Console.ReadLine());
            double totalSales = double.Parse(Console.ReadLine());

            double commission = 0.15 * totalSales;
            double totalSalary = commission + fixedSalary;

            string finalSalary = totalSalary.ToString("F2");

            Console.WriteLine($"TOTAL = R$ {finalSalary}");
        }
    }
}