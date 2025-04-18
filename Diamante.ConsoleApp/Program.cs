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
            
            DesenhaDiamante.DesenhaDiamanteInteiro(tamanhoDiamante);
            
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

    }
}
    
