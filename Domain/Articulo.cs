namespace Domain;

public abstract class Articulo
{
    public abstract decimal ValorUnidad { get; }
    public abstract string UnidadDeMedida  { get; }
    public int Cantidad { get; private set; } = 1;
    
    public void AgregarCantidad()
    {
        Cantidad++;
    }
}
public class PastaDeDientes: Articulo
{
    public  override decimal ValorUnidad => 0.99m;
    public  override string UnidadDeMedida => string.Empty;
}
public class Manzana : Articulo
{
    public  override decimal ValorUnidad => 1.99m;
    public  override string UnidadDeMedida => "Kilo";
}

public class Arroz : Articulo
{
    public  override decimal ValorUnidad => 2.49m;
    public  override string UnidadDeMedida => "Bolsa";
}

public class TomateCherry : Articulo
{
    public  override decimal ValorUnidad => 0.69m;
    public  override string UnidadDeMedida => string.Empty;
}