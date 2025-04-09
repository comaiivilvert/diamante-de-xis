namespace Diamante.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("Vamos desenhar um Diamante!");
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("Para isso, vamos precisar que digite um numero inteiro e ímpar:");
            Console.WriteLine("---------------------------------------------------------------");
           
            int numeroDiamante = Convert.ToInt32(Console.ReadLine());
            int tamanhoDiamante = ValidaSeEhImpar(numeroDiamante);
            
            Console.Clear();
            Console.WriteLine($"Aqui está seu diamante de tamanho: {tamanhoDiamante}");
            DesenhaDiamante(tamanhoDiamante);
            Console.ReadLine();
        }

        static int ValidaSeEhImpar(int numeroDiamante)
        {
           
            while (numeroDiamante % 2 == 0 || numeroDiamante < 2)
            {
                Console.WriteLine("Numero invalido! Digite novo número");
                numeroDiamante = Convert.ToInt32(Console.ReadLine());
            }
            return numeroDiamante;
            
        }

        static void DesenhaDiamante(int tamanhoDiamante)
        {

            int metade = tamanhoDiamante / 2;

            //parte de cima do diamente (incluindo linha central)
            for (int i = 0; i <= metade; i++)
            {
                int espacos = metade - i;
                int asteriscos = i * 2 + 1;

                //imprime os espaços em branco
                for (int j = 0; j < espacos; j++)
                {
                    Console.Write(" ");
                }

                //imprime os asteriscos *
                for (int j = 0; j < asteriscos; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

           


        }
    }
}
    
