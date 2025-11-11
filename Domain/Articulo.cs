namespace Domain;

public abstract class Articulo
{
    protected abstract decimal valorUnidad { get; }
    public object UnidadDeMedida { get; set; }

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

    public string ObtenerUnidadMedida()
    {
        throw new NotImplementedException();
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