



using System;

namespace CustomInterfaces
{
    public class Shape
    {
        public string PetName { get; set; }

        public Shape() { }
        public Shape(string name)
        {
            this.PetName = name;
        }

        public virtual void Draw()
        {
            Console.WriteLine("Dentro de Draw() em Shape");
        }
    }
}
