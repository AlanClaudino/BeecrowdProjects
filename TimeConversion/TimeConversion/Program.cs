namespace TimeConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int time = int.Parse(Console.ReadLine());
            int acumulado = 0;
            int hours = 0;
            int min = 0;
            int sec = 0;


            if ((time - acumulado) >= 3600)
            {
                hours = (time - acumulado) / 3600;
                acumulado += hours * 3600;
            }

            if ((time - acumulado) >= 60)
            {
                min = (time - acumulado) / 60;
                acumulado += min * 60;
            }

            sec = (time - acumulado);

            Console.WriteLine($"{hours}:{min}:{sec}");
        }
    }
}