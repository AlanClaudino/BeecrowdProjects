namespace CrescenteDecrescente_1113
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] dados = Console.ReadLine().Split();
                int a = int.Parse(dados[0]);
                int b = int.Parse(dados[1]);

                if (a == b)
                {
                    return;
                }

                if(a > b)
                {
                    Console.WriteLine("Decrescente");
                }
                else
                {
                    Console.WriteLine("Crescente");
                }
                
            }
        }
    }
}