





namespace MiInterfaceHierarchy
{
    public class Square : IShape
    {
        void IPrintable.Draw()
        {
            // Faz algo
        }

        void IDrawable.Draw()
        {
            // Faz algo
        }

        public void Print()
        {
            // Faz algo
        }

        public int GetNumberOfSides() => 4;
    }
}
