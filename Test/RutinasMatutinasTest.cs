using FluentAssertions;

namespace Test;

public class RutinasMatutinasTest
{
    [Fact]
    public void SI_SonEntre6Y7AM_Debe_RetornarHacerEjercicio()
    {
        var tarea = QueDeboHacerAhora();
        tarea.Should().Be("Hacer ejercicio");
    }

    private string QueDeboHacerAhora()
    {
        throw new NotImplementedException();
    }
}