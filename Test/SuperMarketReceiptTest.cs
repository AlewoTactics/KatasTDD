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

