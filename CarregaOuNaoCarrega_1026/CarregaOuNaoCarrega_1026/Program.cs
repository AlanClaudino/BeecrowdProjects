namespace CarregaOuNaoCarrega_1026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            string numberBits1 = Convert.ToString(number1, 2);
            string numberBits2 = Convert.ToString(number2, 2);

            string[] num1 = new string[32];
            string[] num2 = new string[32];
            Console.WriteLine(numberBits2);

            for (int i = 0; i < num1.Length; i++)
            {
                if (i < numberBits1.Length) {
                    num1[i] = numberBits1[i].ToString();
                } else {
                    num1[i] = "0";
                }
            }

            for (int i = 0; i < num2.Length; i++)
            {
                if (i < numberBits2.Length) {
                    num2[i] = numberBits2[i].ToString();
                } else {
                    num2[i] = "0";
                }
            }

            for (int i = 0; i < num1.Length; i++)
            {
                Console.Write(num1[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < num2.Length; i++)
            {
                Console.Write(num2[i]);
            }

            /*foreach(string element in num1)
            {
                Console.WriteLine(element);
            }*/


        }
    }
}