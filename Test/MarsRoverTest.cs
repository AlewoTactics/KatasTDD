using System.Runtime.CompilerServices;
using Domain;
using FluentAssertions;

namespace Test;

public class MarsRoverTest
{
    [Theory]
    [InlineData("", "0:0:N")]
    [InlineData("M", "0:1:N")]
    [InlineData("MM", "0:2:N")]
    [InlineData("MMM", "0:3:N")]
    [InlineData("MMMMMMMMMMMMM", "0:3:N")]
    public void Si_Ingreso_Movimientos_Desde_El_Origen_Mirando_Al_norte_debe_retornarLaCoordenada(string movimiento,
        string coordenadaEsperada)
    {
        //arrange
        var marsRovers = new MarsRover();
        //act
        marsRovers.RealizarMovimientos(movimiento);
        //assert
        marsRovers.ObtenerUbicacion().Should().Be(coordenadaEsperada);
    }

    [Fact]
    public void Si_Ingreso_Derecha_Mirando_Al_Norte_Debe_Retornar_La_Coordenada_Cero_Cero_Este()
    {
        //arrange
        var marsRovers = new MarsRover();
        //act
        marsRovers.RealizarMovimientos("R");
        //assert
        marsRovers.ObtenerUbicacion().Should().Be("0:0:E");
    }

    [Fact]
    public void Si_Ingreso_Dos_Giros_A_La_Derecha_Debe_Retornar_La_Coordenada_Cero_Cero_Sur()
    {
        //arrange
        var marsRovers = new MarsRover();
        //act
        marsRovers.RealizarMovimientos("RR");
        //assert
        marsRovers.ObtenerUbicacion().Should().Be("0:0:S");
    }
    
    [Fact]
    public void Si_Ingreso_Tres_Giros_A_La_Derecha_Debe_Retornar_La_Coordenada_Cero_Cero_Oeste()
    {
        //arrange
        var marsRovers = new MarsRover();
        
        //act
        marsRovers.RealizarMovimientos("RRR");
        //assert
        marsRovers.ObtenerUbicacion().Should().Be("0:0:W");
    }
    

    
    [Fact]
    public void Si_Ingreso_UnMovimiento_y_un_giroDerecha_debe_retornar_Cero_Uno_Este()
    {
        //arrange
        var marsRovers = new MarsRover();
        //act
        marsRovers.RealizarMovimientos("MR");
        //assert
        marsRovers.ObtenerUbicacion().Should().Be("0:1:E");
    }

    [Fact]
    public void Debe_quedarse_en_la_posicion_inicial_cuando_realiza_un_movimiento_dos_girosDerecha_y_movimiento()
    {
        //arrange
        var marsRovers = new MarsRover();
        //act
        marsRovers.RealizarMovimientos("MRRM");
        //assert
        marsRovers.ObtenerUbicacion().Should().Be("0:0:S");
    }
    
    

    [Theory]
    [InlineData("L", "0:0:W")]
    [InlineData("LLLL", "0:0:N")]
    [InlineData("RRRRR", "0:0:E")]
    [InlineData("RRR", "0:0:W")]
    [InlineData("LLRR", "0:0:N")]
    public void Debe_mantener_posicion_actual_y_apuntar_correctamente_segun_direccion_de_giros(string comando, string resultado)
    {
        //arrange
        var marsRovers = new MarsRover();
        //act
        marsRovers.RealizarMovimientos(comando);
        //assert
        marsRovers.ObtenerUbicacion().Should().Be(resultado);
    }

    [Fact]
    public void Debe_moverse_en_el_eje_x_si_se_realiza_un_giro_a_la_derecha()
    {
        //arrange
        var marsRovers = new MarsRover();
        //act
        marsRovers.RealizarMovimientos("RM");
        //assert
        marsRovers.ObtenerUbicacion().Should().Be("0:1:E");
    }

}