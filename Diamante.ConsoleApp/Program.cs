namespace Diamante.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vamos desenhar um Diamante!");
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("Para isso, vamos precisar que digite um numero inteiro e ímpar:");
            
            int numeroDiamante = int.Parse(Console.ReadLine());

            while(true)
            {
                if (numeroDiamante % 2 != 0)
                {
                    Console.WriteLine("OK!! Número ímpar!!");

                }
                else
                {
                    Console.WriteLine("Numero invalido!! Digite um novo número ímpar: ");
                    numeroDiamante = int.Parse(Console.ReadLine());
                }
                
                Console.ReadLine();

            }

        }
    }
}
