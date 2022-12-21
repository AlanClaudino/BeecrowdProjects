namespace Triangle_1043
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] dados = Console.ReadLine().Split();

            double a = double.Parse(dados[0]);
            double b = double.Parse(dados[1]);
            double c = double.Parse(dados[2]);

            bool d = (a + b) > c;
            bool e = (a + c) > b;
            bool f = (c + b) > a;

            if (d && e && f)
            {
                double perimetro = a + b + c;
                Console.WriteLine($"Perimetro = {perimetro:F1}");
            } else
            {
                double area = ((a + b) * c)/ 2.0;
                Console.WriteLine($"Area = {area:F1}");
            }
        }
    }
}