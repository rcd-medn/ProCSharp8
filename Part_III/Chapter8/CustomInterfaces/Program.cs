



using System;

namespace CustomInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("Entendendo os tipo interfaces");

            // Exemplo 1 de como descobrir se um objeto implementa uma determinada interface
            // e assim, podemos invocar os membros correspondentes da interface.
            
            Hexagon hex = new Hexagon("Hexagono");
            IPointy itfPt2 = hex as IPointy;
            if (itfPt2 != null)
            {
                Console.WriteLine("Pontos de hex: {0}", hex.Points);
            }
            else
            {
                Console.WriteLine("Ooops! Não possui pontos!");
            }

            // Exemplo 2 de como descobrir se um objeto implementa uma determinada interface
            // e assim, podemos invocar os membros correspondentes da interface.
            Hexagon hex2 = new Hexagon("Hexagono 2");
            if (hex2 is IPointy itfPt3)
            {
                Console.WriteLine("Pontos: {0}", hex2.Points);
            }
            else
            {
                Console.WriteLine("Ooops! Não possui pontos!");
            }
        }
    }
}
