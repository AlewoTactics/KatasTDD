using Domain;
using FluentAssertions;

namespace Test;

public class SuperMarketReceiptTest
{
    [Fact]
    public void SI_Agregounapastadedientesalcarrito_Debe_Serelvalortotal099()
    {
        var carrito = new Carrito();
        carrito.Agregar(new PastaDeDientes());
        carrito.ObtenerValorTotal().Should().Be(0.99m);
    }
    
    [Fact]
    public void SI_Agregounamanzanaalcarrito_Debe_Serelvalortotal1_99()
    {
        var carrito = new Carrito();
        carrito.Agregar(new Manzana());
        carrito.ObtenerValorTotal().Should().Be(1.99m);
    }
    
    [Fact]
    public void SI_Agregoarrozcarrito_Debe_Serelvalortotal2_49()
    {
        var carrito = new Carrito();
        carrito.Agregar(new Arroz());
        carrito.ObtenerValorTotal().Should().Be(2.49m);
    }
}

