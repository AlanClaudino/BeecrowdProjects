namespace TriangleTypes_1045
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] dados = Console.ReadLine().Split();
            double[] numSequence = new double[dados.Length];

            for (int i = 0; i < numSequence.Length; i++)
            {
                numSequence[i] = double.Parse(dados[i]);
            }

            for (int i = 0; i < numSequence.Length; i++)
            {
                for (int j = i + 1; j < numSequence.Length; j++)
                {
                    if (numSequence[i] < numSequence[j])
                    {
                        double temp = numSequence[i];
                        numSequence[i] = numSequence[j];
                        numSequence[j] = temp;
                    }
                }
            }

            if (numSequence[0] >= numSequence[1] + numSequence[2])
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            } else
            {
                double a = numSequence[0] * numSequence[0];
                double b = numSequence[1] * numSequence[1];
                double c = numSequence[2] * numSequence[2];

                if (a == b + c)
                {
                    Console.WriteLine("TRIANGULO RETANGULO");
                } 
                else if (a > b + c)
                {
                    Console.WriteLine("TRIANGULO OBTUSANGULO");

                } 
                else if (a < b + c)
                {
                    Console.WriteLine("TRIANGULO ACUTANGULO");
                }

                if (numSequence[0] == numSequence[1] && numSequence[1] == numSequence[2])
                {
                    Console.WriteLine("TRIANGULO EQUILATERO");
                }
                else if (numSequence[0] == numSequence[1] || numSequence[0] == numSequence[2]|| numSequence[1] == numSequence[2])
                {
                    Console.WriteLine("TRIANGULO ISOSCELES");
                }

            }
        }
    }
}