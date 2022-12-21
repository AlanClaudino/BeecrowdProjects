namespace GameTime_1046
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] dados = Console.ReadLine().Split();

            int inicio = int.Parse(dados[0]);
            int fim = int.Parse(dados[1]);

            if (inicio == fim)
            {
                Console.WriteLine("O JOGO DUROU 24 HORA(S)");
            }
            else if (inicio > fim) 
            {
                int time = (24 - inicio) + fim;
                Console.WriteLine($"O JOGO DUROU {time} HORA(S)");
            } 
            else
            {
                int time = fim - inicio;
                Console.WriteLine($"O JOGO DUROU {time} HORA(S)");
            }
        }
    }
}