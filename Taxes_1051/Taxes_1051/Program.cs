namespace Taxes_1051
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salary = double.Parse(Console.ReadLine());
            double taxes = 0;

            if (salary <= 2000.00 ) 
            {
                Console.WriteLine("Isento");
                return;
            }
            else if (salary <= 3000.00)
            {
                taxes = (salary - 2000.00) * 0.08;
            }
            else if (salary <= 4500.00)
            {
                taxes = ((salary - 3000.00) * 0.18) + 80.00;
            } 
            else
            {
                taxes = ((salary - 4500.00) * 0.28) + 350;
            }
            Console.WriteLine($"R$ {taxes:F2}");
        }
    }
}