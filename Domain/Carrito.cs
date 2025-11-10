namespace Domain;

public class Carrito
{
    private Articulo _articulo;
    
    public void Agregar(Articulo articulo)
    {
        _articulo = articulo;
    }

    public decimal ObtenerValorTotal()
    {
        return _articulo.ObtenerValor();
    }
}