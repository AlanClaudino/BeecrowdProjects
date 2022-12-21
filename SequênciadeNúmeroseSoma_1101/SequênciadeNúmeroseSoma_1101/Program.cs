namespace SequênciadeNúmeroseSoma_1101
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

                if (a <= 0 || b <= 0)
                {
                    return;
                }

                if (a > b)
                {
                    int temp = a;
                    a = b; 
                    b = temp;
                }

                int soma = 0;

                for (int i = a; i <= b; i++)
                {
                    Console.Write($"{i} ");
                    soma += i;
                }
                Console.WriteLine($"Sum={soma}");
            }
        }
    }
}