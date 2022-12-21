namespace Average1___1005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());

            double media = ((3.5 * A) + (7.5 * B)) / 11;

            string mediaFinal = media.ToString("F5");

            Console.WriteLine($"MEDIA = {mediaFinal}");
        }
    }
}