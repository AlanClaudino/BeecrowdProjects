namespace Grenais_1131
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            int vitoriasInter = 0;
            int vitoriasGremio = 0;
            int empates = 0;

            while (true)
            {
                string[] dados = Console.ReadLine().Split();
                int golsInter = int.Parse(dados[0]);
                int golsGremio = int.Parse(dados[1]);

                numero++;
                if (golsInter == golsGremio) 
                {
                    empates++;
                } else if (golsInter > golsGremio)
                {
                    vitoriasInter++;
                } else
                {
                    vitoriasGremio++;
                }

                while (true)
                {
                    Console.WriteLine("Novo grenal (1-sim 2-nao)");
                    int novoGrenal = int.Parse(Console.ReadLine());

                    if (novoGrenal == 2)
                    {
                        Console.WriteLine($"{numero} grenais");
                        Console.WriteLine($"Inter:{vitoriasInter}");
                        Console.WriteLine($"Gremio:{vitoriasGremio}");
                        Console.WriteLine($"Empates:{empates}");
                        if (vitoriasInter > vitoriasGremio)
                        {
                            Console.WriteLine("Inter venceu mais");
                        }
                        else if (vitoriasGremio > vitoriasInter)
                        {
                            Console.WriteLine("Gremio venceu mais");
                        }
                        else
                        {
                            Console.WriteLine("Nao houve vencedor");
                        }
                        return;
                    } else if (novoGrenal == 1)
                    {
                        break;
                    }
                }

            }
        }
    }
}