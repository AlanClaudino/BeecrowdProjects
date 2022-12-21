namespace SomadeÍmparesConsecutivosII_1099
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine()); 
            
            for (int i = 0; i < number; i++)
            {
                string[] dados = Console.ReadLine().Split();

                int x = int.Parse(dados[0]);
                int y = int.Parse(dados[1]);

                if (x> y)
                {
                    int temp = x; 
                    x = y;
                    y = temp;
                }

                int soma = 0;

                for(int j = x + 1; j < y; j++)
                {
                    if (j%2 != 0)
                    {
                        soma += j;
                    } 
                }

                Console.WriteLine(soma);
            }
        }
    }
}