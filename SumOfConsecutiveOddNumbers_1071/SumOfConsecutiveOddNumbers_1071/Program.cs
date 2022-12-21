namespace SumOfConsecutiveOddNumbers_1071
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int Number2  = int.Parse(Console.ReadLine());

            if(number1 < Number2)
            {
                int temp = number1;
                number1 = Number2;
                Number2= temp;
            }

            int sum = 0;

            for (int i = Number2 + 1; i < number1; i++)
            {
                if (Math.Abs((i % 2)) == 1)
                {
                    sum+= i;
                }
            }

            Console.WriteLine(sum);
        }
    }
}