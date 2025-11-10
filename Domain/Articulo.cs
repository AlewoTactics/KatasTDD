namespace Domain;

public abstract class Articulo
{
    protected abstract decimal valorUnidad { get; }
    
    public decimal ObtenerValor()
    {
        return valorUnidad;
    }

    public int ObtenerCantidad()
    {
        return 0;
    }
    

}
public class PastaDeDientes: Articulo
{
    protected  override decimal valorUnidad => 0.99m;
}
public class Manzana : Articulo
{
    protected  override decimal valorUnidad => 1.99m;
}

public class Arroz : Articulo
{
    protected  override decimal valorUnidad => 2.49m;
}

public class TomateCherry : Articulo
{
    protected  override decimal valorUnidad => 0.69m;
}