namespace Area___1012
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputInfo = Console.ReadLine();
            string[] infoArr = inputInfo.Split();

            double A = double.Parse(infoArr[0]);
            double B = double.Parse(infoArr[1]);
            double C = double.Parse(infoArr[2]);

            double areaTriangle = (A * C) / 2.0;
            double areaCircle = 3.14159 * Math.Pow(C, 2);
            double areaTrap = ((A + B) / 2.0) * C;
            double areaSquare = B * B;
            double areaRetang = A * B;

            Console.WriteLine($"TRIANGULO: {areaTriangle.ToString("F3")}");
            Console.WriteLine($"CIRCULO: {areaCircle.ToString("F3")}");
            Console.WriteLine($"TRAPEZIO: {areaTrap.ToString("F3")}");
            Console.WriteLine($"QUADRADO: {areaSquare.ToString("F3")}");
            Console.WriteLine($"RETANGULO: {areaRetang.ToString("F3")}");

        }
    }
}