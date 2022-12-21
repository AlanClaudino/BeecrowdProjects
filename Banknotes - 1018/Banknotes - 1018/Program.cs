namespace Banknotes___1018
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int value = int.Parse(Console.ReadLine());
            int acumuluado = 0;
            int[] notes = { 100, 50, 20, 10, 5, 2, 1 };
            int notesNum = 0;
            
            for (int i = 0; i < notes.Length; i++)
            {
                if ((value - acumuluado) >= notes[i])
                {
                    notesNum = (value - acumuluado) / notes[i];
                }

                Console.WriteLine($"{notesNum} nota(s) de R$ {notes[i]},00");
                acumuluado += notesNum * notes[i];
                notesNum = 0;
            }

        }
    }
}