



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
            Console.WriteLine("\n");

            var sq = new Square("Caixa") { NumberOfSides = 4, SideLength = 4 } ;
            sq.Draw();

            // NÃO COMPILA!
            // Console.WriteLine($"{sq.PetName} tem {sq.NumberOfSides} de tamanho {sq.SideLength} e um perimetro de {sq.Perimeter}");
            Console.WriteLine(
                $"{sq.PetName} tem {sq.NumberOfSides} de tamanho {sq.SideLength} e um perimetro de {((IRegularPointy)sq).Perimeter}"
            );
            Console.WriteLine("\n");

            Shape[] myShapes = { new Hexagon(), new Circle(), new Triangle("Joe"), new Circle("JoJo") };
            for(int i = 0; i < myShapes.Length; i++)
            {
                if (myShapes[i] is IDraw3D s)
                {
                    DrawIn3D(s);
                }
            }
        }

        static void DrawIn3D(IDraw3D itf3d)
        {
            Console.WriteLine("==> Desenhando um tipo compativel com IDraw3D");
            itf3d.Draw3D();
        }
    }
}
