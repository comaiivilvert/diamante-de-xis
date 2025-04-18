namespace Diamante.ConsoleApp
{
    internal class DesenhaDiamante
    {
        public static void DesenhaDiamanteInteiro(int tamanhoDiamante)
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

            //parte de baixo do diamante
            for (int i = metade - 1; i >= 0; i--)
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
