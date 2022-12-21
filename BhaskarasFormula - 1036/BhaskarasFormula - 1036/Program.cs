namespace BhaskarasFormula___1036
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] dados = Console.ReadLine().Split();

            double a = double.Parse(dados[0]);
            double b = double.Parse(dados[1]);
            double c = double.Parse(dados[2]);

            double delta = Math.Pow(b, 2) - (4 * a * c);

            if (a == 0 || delta < 0)
            {
                Console.WriteLine("Impossivel calcular");
            } else
            {
                double r1 = (-b +  Math.Sqrt(delta)) / (2 * a);
                double r2 = (-b - Math.Sqrt(delta)) / (2 * a);

                Console.WriteLine($"R1 = {r1:F5}");
                Console.WriteLine($"R2 = {r2:F5}");

            }


        }
    }
}