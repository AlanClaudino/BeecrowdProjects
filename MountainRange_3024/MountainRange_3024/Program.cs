using System.Diagnostics;

namespace MountainRange_3024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] dados1 = Console.ReadLine().Split();

            int n = int.Parse(dados1[0]);
            int maxHeight = int.Parse(dados1[1]);

            string[] dados2 = Console.ReadLine().Split();
            int[] viewPoints = new int[dados2.Length];

            for(int i = 0; i < dados2.Length; i++)
            {
                viewPoints[i] = int.Parse(dados2[i]);
            }

            int maxNum = 1;

            for (int i = 0; i < (n - 1); i++)
            {
                int dist = 0;
                int count = 1;
                int j = i;
                do
                {
                    dist = viewPoints[j + 1] - viewPoints[j];
                    if (dist <= maxHeight)
                    {
                        count += 1;
                    }
                    j = j + 1;
                } while (dist <= maxHeight && j < (n - 1));

                if (count > maxNum) { 
                    maxNum = count;
                }
            }


            Console.WriteLine(maxNum);

        }
    }
}