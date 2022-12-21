namespace SalaryIncrease_1048
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salary = double.Parse(Console.ReadLine());
            double raise;
            double newSalary;
            int percentual;

            if (salary <= 400)
            {
                raise= salary * 0.15;
                newSalary = salary + raise;
                percentual = 15;
            }
            else if (salary <= 800)
            {
                raise = salary * 0.12;
                newSalary = salary + raise;
                percentual = 12;
            }
            else if (salary <= 1200)
            {
                raise = salary * 0.10;
                newSalary = salary + raise;
                percentual = 10;
            }
            else if (salary <= 2000)
            {
                raise = salary * 0.07;
                newSalary = salary + raise;
                percentual = 7;
            }
            else
            {
                raise = salary * 0.04;
                newSalary = salary + raise;
                percentual = 4;
            }

            Console.WriteLine($"Novo salario: {newSalary:F2}");
            Console.WriteLine($"Reajuste ganho: {raise:F2}");
            Console.WriteLine($"Em percentual: {percentual} %");
        }
    }
}