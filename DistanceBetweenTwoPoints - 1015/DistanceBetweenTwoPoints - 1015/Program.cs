namespace DistanceBetweenTwoPoints___1015
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] point1 = Console.ReadLine().Split();
            string[] point2 = Console.ReadLine().Split();

            double x1 = double.Parse(point1[0]);
            double y1 = double.Parse(point1[1]);


            double x2 = double.Parse(point2[0]);
            double y2 = double.Parse(point2[1]);

            double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));

            Console.WriteLine(distance.ToString("F4"));


        }
    }
}