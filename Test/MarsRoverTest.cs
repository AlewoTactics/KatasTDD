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
    [InlineData("MMMMMMMMMMMM", "0:2:N")]
    public void Si_Ingreso_Movimientos_Desde_El_Origen_Mirando_Al_norte_debe_retornarLaCoordenada(string movimiento,
        string coordenadaEsperada)
    {
        //arrange
        var marsRovers = new MarsRover();
        //act
        marsRovers.EjecutarComandos(movimiento);
        //assert
        marsRovers.ObtenerUbicacion().Should().Be(coordenadaEsperada);
    }

    [Theory]
    [InlineData("L", "0:0:W")]
    [InlineData("LLLL", "0:0:N")]
    [InlineData("RRRRR", "0:0:E")]
    [InlineData("RRR", "0:0:W")]
    [InlineData("LLRR", "0:0:N")]
    [InlineData("R", "0:0:E")]
    [InlineData("RR", "0:0:S")]
    [InlineData("RRR", "0:0:W")]
    public void Debe_mantener_posicion_actual_y_apuntar_correctamente_segun_direccion_de_giros(string comando, string resultado)
    {
        //arrange
        var marsRovers = new MarsRover();
        //act
        marsRovers.EjecutarComandos(comando);
        //assert
        marsRovers.ObtenerUbicacion().Should().Be(resultado);
    }

    
    [Fact]
    public void Si_Ingreso_UnMovimiento_y_un_giroDerecha_debe_retornar_Cero_Uno_Este()
    {
        //arrange
        var marsRovers = new MarsRover();
        //act
        marsRovers.EjecutarComandos("MR");
        //assert
        marsRovers.ObtenerUbicacion().Should().Be("0:1:E");
    }

    [Fact]
    public void Debe_quedarse_en_la_posicion_inicial_cuando_realiza_un_movimiento_dos_girosDerecha_y_movimiento()
    {
        //arrange
        var marsRovers = new MarsRover();
        //act
        marsRovers.EjecutarComandos("MRRM");
        //assert
        marsRovers.ObtenerUbicacion().Should().Be("0:0:S");
    }
    
    


    [Fact]
    public void Debe_moverse_en_el_eje_x_si_se_realiza_un_giro_a_la_derecha()
    {
        //arrange
        var marsRovers = new MarsRover();
        //act
        marsRovers.EjecutarComandos("RM");
        //assert
        marsRovers.ObtenerUbicacion().Should().Be("1:0:E");
    }
    
    [Fact]
    public void Debe_volver_a_la_posicion_inicial_si_pasa_el_limite_derecho()
    {
        //arrange
        var marsRovers = new MarsRover();
        //act
        marsRovers.EjecutarComandos("RMMMMMMMMMM");
        //assert
        marsRovers.ObtenerUbicacion().Should().Be("0:0:E");
    }

    


    [Fact]
    public void Debe_saltar_al_limite_superior_si_pasa_limite_inferior()
    {
        //arrange
        var marsRovers = new MarsRover();
        //act
        marsRovers.EjecutarComandos("LLM");
        //assert
        marsRovers.ObtenerUbicacion().Should().Be("0:9:S");
    }
    
    
    [Fact]
    public void Debe_saltar_al_limite_derecho_si_pasa_limite_izquierdo()
    {
        //arrange
        var marsRovers = new MarsRover();
        //act
        marsRovers.EjecutarComandos("LM");
        //assert
        marsRovers.ObtenerUbicacion().Should().Be("9:0:W");
    }
    
    [Fact]
    public void Debe_moverse_en_el_eje_x_si_se_realiza_un_giro_a_la_izquierda()
    {
        //arrange
        var marsRovers = new MarsRover();
        //act
        marsRovers.EjecutarComandos("RMLLM");
        //assert
        marsRovers.ObtenerUbicacion().Should().Be("0:0:W");
    }

}