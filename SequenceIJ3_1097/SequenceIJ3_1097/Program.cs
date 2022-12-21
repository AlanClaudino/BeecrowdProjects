namespace SequenceIJ3_1097
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int jota = 8;
            for (int i = 1; i <= 9; i = i + 2)
            {
                for ( int j = 0; j <3; j++)
                {   
                    jota = jota - 1;
                    Console.WriteLine($"I={i} J={jota}");
                }
                jota = jota + 5;
            }
        }
    }
}