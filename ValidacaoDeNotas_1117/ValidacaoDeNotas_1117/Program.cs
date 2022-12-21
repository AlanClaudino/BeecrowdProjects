namespace ValidacaoDeNotas_1117
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
                } else
                {
                    notas += nota;
                    count++;
                }

                if (count == 2)
                {
                    double media = notas / 2.0;
                    Console.WriteLine($"media = {media:F2}");
                    return;
                }


            }
        }
    }
}