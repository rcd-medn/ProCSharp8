




namespace CustomInterfaces
{
    public interface IPointy
    {

        // Método implicitamente público e abstrato
        // byte GetNumberOfPoints();

        // interfaces podem possuir propriedades normais, get e set, ou propriedades
        // de somente escrita (set) ou somente leitura (get).
        byte Points { get; }
    }
}
