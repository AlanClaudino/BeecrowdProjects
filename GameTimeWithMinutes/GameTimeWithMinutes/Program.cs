namespace GameTimeWithMinutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] dados = Console.ReadLine().Split();

            int inicioHora = int.Parse(dados[0]);
            int inicioMin = int.Parse(dados[1]);
            int fimHora = int.Parse(dados[2]);
            int fimMin = int.Parse(dados[3]);


            if (inicioHora == fimHora && inicioMin == fimMin)
            {
                Console.WriteLine("O JOGO DUROU 24 HORA(S) E 0 MINUTO(S)");
            }
            else if (inicioHora == fimHora && fimMin > inicioMin)
            {
                int min = fimMin - inicioMin;
                Console.WriteLine($"O JOGO DUROU 0 HORA(S) E {min} MINUTO(S)");
            }
            else if (inicioHora == fimHora && fimMin < inicioMin)
            {
                int min = 60 - (inicioMin - fimMin);
                Console.WriteLine($"O JOGO DUROU 23 HORA(S) E {min} MINUTO(S)");
            }
            else if (inicioHora > fimHora)
            {
                int time = ((24 - inicioHora) + fimHora) * 60 + (fimMin - inicioMin);
                int hora = time/ 60;
                int min = time%60;
                Console.WriteLine($"O JOGO DUROU {hora} HORA(S) E {min} MINUTO(S)");
            }
            else
            {
                int time = (fimHora - inicioHora)*60 + (fimMin - inicioMin);
                int hora = time/ 60;
                int min = time%60;
                Console.WriteLine($"O JOGO DUROU {hora} HORA(S) E {min} MINUTO(S)");
            }
        }
    }
}