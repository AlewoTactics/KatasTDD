using FluentAssertions;

namespace Test;

public class SuperMarketReceiptTest
{
    [Fact]
    public void SI_Agregounapastadedientesalcarrito_Debe_Serelvalortotal099()
    {
        var carrito = new Carrito();
        carrito.Agregar(new PastaDeDientes());
        carrito.ObtenerValorTotal().Should().Be((decimal)0.99);
    }
    
    [Fact]
    public void SI_Agregounamanzanaalcarrito_Debe_Serelvalortotal1_99()
    {
        var carrito = new Carrito();
        carrito.Agregar(new Manzana());
        carrito.ObtenerValorTotal().Should().Be((decimal)1.99);
    }
}



public class Carrito
{
    public void Agregar(PastaDeDientes pastaDeDientes)
    {
        
    }

    public decimal ObtenerValorTotal() => (decimal)0.99;
}

public class PastaDeDientes 
{
  
}
public class Manzana : PastaDeDientes
{
}


