namespace VariasNotasComValidacao_1118
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            double notas = 0;

            while (true)
            {
                double nota = double.Parse(Console.ReadLine());
                if (nota < 0 || nota > 10)
                {
                    Console.WriteLine("nota invalida");
                }
                else
                {
                    notas += nota;
                    count++;
                }
                if (count == 2)
                {
                    double media = notas / 2.0;
                    Console.WriteLine($"media = {media:F2}");

                    while (true)
                    {
                        Console.WriteLine("novo calculo (1-sim 2-nao)");
                        int novoCalc = int.Parse(Console.ReadLine());

                        if(novoCalc == 2)
                        {
                            return;
                        }
                        else if(novoCalc == 1)
                        {
                            count = 0;
                            notas= 0;
                            break;
                        }
                    }

                }

            }
        }
    }
}