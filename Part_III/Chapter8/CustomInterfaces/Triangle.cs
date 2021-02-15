



using System;

namespace CustomInterfaces
{
    public class Triangle : Shape, IPointy
    {
        public Triangle() { }
        public Triangle(string name) :base(name) { }
        
        public override void Draw()
        {
            Console.WriteLine("Desenhando o triangulo {0}", PetName);
        }

        // Implementa a propriedade de somente leitura Points, definida na interface
        public byte Points => 3;
    }
}
