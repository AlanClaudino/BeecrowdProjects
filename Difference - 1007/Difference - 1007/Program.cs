namespace Difference___1007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int D = int.Parse(Console.ReadLine());

            int E = A * B;
            int F = C * D;

            int G = E - F;

            Console.WriteLine($"DIFERENCA = {G}");
        }
    }
}