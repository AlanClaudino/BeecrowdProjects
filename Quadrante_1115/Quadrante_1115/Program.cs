namespace Quadrante_1115
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] dados = Console.ReadLine().Split();

                int x = int.Parse(dados[0]);
                int y = int.Parse(dados[1]);

                if (x == 0 || y == 0)
                {
                    return;
                }
                

                if(x > 0 && y > 0 )
                {
                    Console.WriteLine("primeiro");
                } else if (x < 0 && y > 0) 
                {
                    Console.WriteLine("segundo");
                } else if (x < 0 && y < 0)
                {
                    Console.WriteLine("terceiro");
                } else
                {
                    Console.WriteLine("quarto");
                }
            }
        }
    }
}