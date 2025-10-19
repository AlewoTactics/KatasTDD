using System.Runtime.CompilerServices;
using Domain;
using FluentAssertions;

namespace Test;

public class MarsRoverTest
{
    
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
    
    [Theory]
    [InlineData("", "0:0:N")]
    [InlineData("M", "0:1:N")]
    [InlineData("MM", "0:2:N")]
    [InlineData("MMM", "0:3:N")]
    public void Debe_desplazarse_correctamente_sobre_el_ejeY(string movimiento,
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
    [InlineData("RM", "1:0:E")]
    [InlineData("RMLLM", "0:0:W")]
    
    public void Debe_desplazarse_correctamente_sobre_el_ejeX(string movimiento,
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
    [InlineData("MR", "0:1:E")]
    [InlineData("MRRM", "0:0:S")]
    [InlineData("MMRMMLML", "2:3:W")]
    public void Debe_ejecutar_correctamente_desplazamientos_y_giros_sin_pasar_por_limites_de_plataforma(string comandos,string resultado)
    {
        //arrange
        var marsRovers = new MarsRover();
        //act
        marsRovers.EjecutarComandos(comandos);
        //assert
        marsRovers.ObtenerUbicacion().Should().Be(resultado);
    }

    [Theory]
    [InlineData("RMMMMMMMMMM", "0:0:E")]
    [InlineData("LLM", "0:9:S")]
    [InlineData("LM", "9:0:W")]
    [InlineData("MMMMMMMMMMMM", "0:2:N")]
    public void Debe_saltar_correctamente_a_la_posicion_indicada_despues_de_un_limite_de_plataforma(string comandos,string resultado)
    {
        //arrange
        var marsRovers = new MarsRover();
        //act
        marsRovers.EjecutarComandos(comandos);
        //assert
        marsRovers.ObtenerUbicacion().Should().Be(resultado); 
    }
    
}