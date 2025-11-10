namespace Test;

public class SuperMarketReceiptTest
{
    [Fact]
    public void SI_Agregounapastadedientesalcarrito_Debe_Serelvalortotal099()
    {
        var carrito = new Carrito();
        carrito.Agregar(new PastaDeDientes());
        carrito.ObtenerValorTotal();
    }
}

public class Carrito
{
    public void Agregar(PastaDeDientes pastaDeDientes)
    {
        throw new NotImplementedException();
    }

    public decimal ObtenerValorTotal()
    {
        throw new NotImplementedException();
    }
}

public class PastaDeDientes 
{
  
}

