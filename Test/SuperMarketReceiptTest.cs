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
    
    [Fact]
    public void SI_AgregotomatesCherry_Debe_Serelvalortotal0_69()
    {
        var carrito = new Carrito();
        carrito.Agregar(new TomateCherry());
        carrito.ObtenerValorTotal().Should().Be(0.69m);
    }
    
    
    [Fact]
    public void SI_Agregomanzanayarroz_Debe_Serelvalortotal4_48()
    {
        var carrito = new Carrito();
        carrito.Agregar(new Manzana());
        carrito.Agregar(new Arroz());
        carrito.ObtenerValorTotal().Should().Be(4.48m);
    }
    
      
    [Fact]
    public void SI_AgregodosManzanas_Debe_Existir1ManzanaConCantidad2()
    {
        var carrito = new Carrito();
        carrito.Agregar(new Manzana());
        carrito.Agregar(new Manzana()); 
        carrito.Articulos.Count().Should().Be(1);
        carrito.Articulos.First().Cantidad.Should().Be(2);
    }
    
    [Fact]
    public void SI_AgregoManzana_Debe_launidadDemedidaserKilo()
    {
        var carrito = new Carrito();
        carrito.Agregar(new Manzana());
        carrito.Articulos.First().UnidadDeMedida.Should().Be("Kilo");
    }
    
       
    [Fact]
    public void SI_AgregoArroz_Debe_launidadDemedidaserBolsa()
    {
        var carrito = new Carrito();
        carrito.Agregar(new Arroz());
        carrito.Articulos.First().UnidadDeMedida.Should().Be("Bolsa");
    }
    
}



