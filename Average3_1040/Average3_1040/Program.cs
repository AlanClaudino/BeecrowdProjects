namespace Average3_1040
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] notasDados = Console.ReadLine().Split();

            double[] notas = new double[notasDados.Length];

            for (int i = 0; i < notasDados.Length; i++)
            {
                notas[i] = double.Parse(notasDados[i]);
            }

            double media = ((notas[0] * 2) + (notas[1] * 3) + (notas[2] * 4) + (notas[3] * 1)) / 10.0;

            double mediaFinal = Math.Round(media,1);
            Console.WriteLine($"Media: {mediaFinal:F1}");

            if (media >= 7.0)
            {
                Console.WriteLine("Aluno aprovado.");
            } else if (media < 5.0)
            {
                Console.WriteLine("Aluno reprovado.");
            } else
            {
                Console.WriteLine("Aluno em exame.");
                double notaRec = Double.Parse(Console.ReadLine());
                Console.WriteLine($"Nota do exame: {notaRec:F1}");

                double mediaRec = (media + notaRec) / 2.0;
                double mediaRecFinal = Math.Round(mediaRec, 1);

                if (mediaRec >= 5.0)
                {
                    Console.WriteLine("Aluno aprovado.");
                    Console.WriteLine($"Media final: {mediaRecFinal:F1}");
                } else
                {
                    Console.WriteLine("Aluno reprovado.");
                    Console.WriteLine($"Media final: {mediaRecFinal:F1}");
                }
            }




        }
    }
}