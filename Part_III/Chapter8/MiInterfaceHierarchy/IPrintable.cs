





namespace MiInterfaceHierarchy
{
    public interface IPrintable
    {
         void Print();
         void Draw();   // <-- Possível colisão de de nomes de membros!
    }
}
