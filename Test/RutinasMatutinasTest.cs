using FluentAssertions;

namespace Test;

public class RutinasMatutinasTest
{
    [Fact]
    public void SI_SonEntre6Y7AM_Debe_RetornarHacerEjercicio()
    {
        decimal horaActual = 6;
        var tarea = QueDeboHacerAhora(horaActual);
        tarea.Should().Be("Hacer ejercicio");
        return;

        string QueDeboHacerAhora(decimal horaActual1)
        {
        
            throw new NotImplementedException();
        }
    }
}