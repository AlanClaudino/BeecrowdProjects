namespace SimpleCalculate___1010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string prod1 = Console.ReadLine();
            string prod2 = Console.ReadLine();

            string[] infoProd1 = prod1.Split();
            string[] infoProd2 = prod2.Split();

            int unitProd1 = int.Parse(infoProd1[1]);
            int unitProd2 = int.Parse(infoProd2[1]);

            double priceProd1 = double.Parse(infoProd1[2]);
            double priceProd2 = double.Parse(infoProd2[2]);

            double totalValue = (unitProd1 * priceProd1) + (unitProd2 * priceProd2);
            string finalValue = totalValue.ToString("F2");

            Console.WriteLine($"VALOR A PAGAR: R$ {finalValue}");

        }
    }
}