namespace Sphere___1011
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14159;
            int radius = int.Parse(Console.ReadLine());

            double volume = (4 / 3.0) * pi * (Math.Pow(radius, 3));
            string finalVolume = volume.ToString("F3");
            Console.WriteLine($"VOLUME = {finalVolume}");
        }
    }
}