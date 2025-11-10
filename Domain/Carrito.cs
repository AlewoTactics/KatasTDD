namespace Domain;

public class Carrito
{
    public List<Articulo> Articulos { get;private set; } = [];

    public void Agregar(Articulo articulo)
    {
        Articulos.Add(articulo);
    }

    public decimal ObtenerValorTotal()
    {
        decimal valorTotal = 0;
        foreach (var art in Articulos)
        {
            valorTotal += art.ObtenerValor();
        }
        return valorTotal;
    }
}