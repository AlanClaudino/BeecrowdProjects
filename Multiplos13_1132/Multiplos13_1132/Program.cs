namespace Multiplos13_1132
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int somaTotal = 0;

            if (a > b)
            {
                int temp = a; 
                a = b; 
                b = temp;
            }

            for (int i = a; i <= b; i++)
            {
                if (i%13 != 0)
                {
                    somaTotal = somaTotal + i;
                }
            }

            Console.WriteLine(somaTotal);

        }
    }
}