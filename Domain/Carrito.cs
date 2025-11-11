namespace Domain;

public class Carrito
{
    public List<Articulo> Articulos { get;private set; } = [];

    public void Agregar(Articulo articulo)
    {
        var articuloExistente = Articulos.FirstOrDefault(art => art.GetType() == articulo.GetType());
        if (articuloExistente == null)
            Articulos.Add(articulo);
        else
            articuloExistente.AgregarCantidad();
    }

    public decimal ObtenerValorTotal()
    {
        decimal valorTotal = 0;
        foreach (var art in Articulos)
        {
            valorTotal += art.ValorUnidad;
        }
        return valorTotal;
    }
}