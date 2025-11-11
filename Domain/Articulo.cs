namespace Domain;

public abstract class Articulo
{
    protected abstract decimal valorUnidad { get; }
    public abstract string UnidadDeMedida  { get; }

    private int cantidad = 1;
    public decimal ObtenerValor()
    {
        return valorUnidad;
    }

    public int ObtenerCantidad()
    {
        return cantidad;
    }
    
    public void AgregarCantidad()
    {
        cantidad++;
    }
}
public class PastaDeDientes: Articulo
{
    protected  override decimal valorUnidad => 0.99m;
    public  override string UnidadDeMedida => string.Empty;
}
public class Manzana : Articulo
{
    protected  override decimal valorUnidad => 1.99m;
    public  override string UnidadDeMedida => "Kilo";
}

public class Arroz : Articulo
{
    protected  override decimal valorUnidad => 2.49m;
    public  override string UnidadDeMedida => string.Empty;
}

public class TomateCherry : Articulo
{
    protected  override decimal valorUnidad => 0.69m;
    public  override string UnidadDeMedida => string.Empty;
}