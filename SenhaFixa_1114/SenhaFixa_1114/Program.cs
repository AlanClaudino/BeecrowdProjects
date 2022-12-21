namespace SenhaFixa_1114
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                int senha = int.Parse(Console.ReadLine());

                if ( senha == 2002)
                {
                    Console.WriteLine("Acesso Permitido");
                    return;
                }
                else
                {
                    Console.WriteLine("Senha Invalida");
                }
            }
        }
    }
}