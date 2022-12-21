namespace AgeInDays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ageDays = int.Parse(Console.ReadLine());
            int acumulado = 0;
            int years = 0;
            int months = 0;
            int days = 0;


            if ((ageDays - acumulado) >= 365)
            {
                years = (ageDays - acumulado) / 365;
                acumulado += years * 365;
            }

            if ((ageDays - acumulado) >= 30)
            {
                months = (ageDays - acumulado) / 30;
                acumulado += months * 30;
            }

            days = (ageDays - acumulado);

            Console.WriteLine($"{years} ano(s)");
            Console.WriteLine($"{months} mes(es)");
            Console.WriteLine($"{days} dia(s)");
        }
    }
}