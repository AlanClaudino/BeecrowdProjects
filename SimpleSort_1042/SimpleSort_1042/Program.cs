namespace SimpleSort_1042
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] dados = Console.ReadLine().Split();
            int[] numSequence= new int[dados.Length];

            for (int i = 0; i < numSequence.Length; i++)
            {
                numSequence[i] = int.Parse(dados[i]);
            }


            int a = numSequence[0];
            int b = numSequence[1];
            int c = numSequence[2];
            
            for (int i = 0; i < numSequence.Length; i++)
            {
                for (int j = i + 1; j < numSequence.Length; j++)
                {
                    if (numSequence[i] > numSequence[j])
                    {
                        int temp = numSequence[i];
                        numSequence[i] = numSequence[j];
                        numSequence[j] = temp;
                    }
                }
            }

            Console.WriteLine(numSequence[0]);
            Console.WriteLine(numSequence[1]);
            Console.WriteLine(numSequence[2]);
            Console.WriteLine();
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

        }
    }
}