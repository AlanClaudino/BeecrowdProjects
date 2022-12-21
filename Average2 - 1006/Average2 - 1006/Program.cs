namespace Average2___1006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());
            double C = double.Parse(Console.ReadLine());

            double media = ((A * 2) + (B * 3) + (C * 5)) / 10;

            string mediaFinal = media.ToString("F1");

            Console.WriteLine($"MEDIA = {mediaFinal}");
        }
    }
}