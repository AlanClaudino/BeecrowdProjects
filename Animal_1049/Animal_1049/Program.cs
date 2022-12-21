namespace Animal_1049
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string vert = Console.ReadLine();
            string tipo = Console.ReadLine();
            string especie = Console.ReadLine();
            string definicao = $"{vert} {tipo} {especie}";

            switch (definicao)
            {
                case "vertebrado ave carnivoro":
                    Console.WriteLine("aguia");
                    break;
                case "vertebrado ave onivoro":
                    Console.WriteLine("pomba");
                    break;
                case "vertebrado mamifero onivoro":
                    Console.WriteLine("homem");
                    break;
                case "vertebrado mamifero herbivoro":
                    Console.WriteLine("vaca");
                    break;
                case "invertebrado inseto hematofago":
                    Console.WriteLine("pulga");
                    break;
                case "invertebrado inseto herbivoro":
                    Console.WriteLine("lagarta");
                    break;
                case "invertebrado anelideo hematofago":
                    Console.WriteLine("sanguessuga");
                    break;
                case "invertebrado anelideo onivoro":
                    Console.WriteLine("minhoca");
                    break;
            }
            
        }
    }
}