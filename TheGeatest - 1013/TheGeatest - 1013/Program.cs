namespace TheGeatest___1013
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputInfo = Console.ReadLine();
            string[] arrInfo = inputInfo.Split();

            int[] intArrInfo = new int[arrInfo.Length];
            for (int i = 0; i < arrInfo.Length; i++)
            {
                intArrInfo[i] = int.Parse(arrInfo[i]);
            }

            int maior = 0;
            for (int i = 0; i < intArrInfo.Length; i++)
            {
                if (maior < intArrInfo[i])
                {
                    maior = intArrInfo[i];
                }
            }

            Console.WriteLine($"{maior} eh o maior");
        }
    }
}