namespace BanknotesAndCoins___1021
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double value = double.Parse(Console.ReadLine());
            int value100 = (int)(value * 100);
            int acumuluado = 0;
            int[] notes = { 10000, 5000, 2000, 1000, 500, 200, 100, 50, 25, 10, 5, 1 };
            int[] notesNum = new int[notes.Length];
            double noteValue;
            string printNote;

            for (int i = 0; i < notes.Length; i++)
            {

                if ((value100 - acumuluado) >= notes[i])
                {
                    notesNum[i] = (value100 - acumuluado) / notes[i];
                }
                else
                {
                    notesNum[i] = 0;
                }

                acumuluado += notesNum[i] * notes[i];

            }

            for (int i = 0; i < notes.Length; i++)
            {
                if (notes[i] == 10000)
                {
                    Console.WriteLine("NOTAS:");
                }
                else if (notes[i] == 100)
                {
                    Console.WriteLine("MOEDAS:");
                }

                noteValue = notes[i] / 100.0;
                printNote = noteValue.ToString("F2");

                if (noteValue >= 2 )
                {
                    Console.WriteLine($"{notesNum[i]} nota(s) de R$ {printNote}");
                } else
                {
                    Console.WriteLine($"{notesNum[i]} moeda(s) de R$ {printNote}");
                }
            }

        }
    }
}