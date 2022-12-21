namespace Salary___1008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int employeeNum = int.Parse(Console.ReadLine());
            int WorkedHours = int.Parse(Console.ReadLine());
            double salaryHour = double.Parse(Console.ReadLine());

            double salary = WorkedHours * salaryHour;
            string salaryFinal = salary.ToString("F2");

            Console.WriteLine($"NUMBER = {employeeNum}");
            Console.WriteLine($"SALARY = U$ {salaryFinal}");
        }
    }
}