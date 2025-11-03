using Domain;
using FluentAssertions;

namespace Test;

public class RutinasMatutinasTest
{

    [Fact]
    public void SI_SonEntre6Y7AM_Debe_RetornarHacerEjercicio()
    {
        TimeSpan horaActual = new TimeSpan(6, 0, 0);
        var personalTaskManager = new PersonalTaskManager(horaActual);  
        var tarea = personalTaskManager.QueDeboHacerAhora();
        tarea.Should().Be("Hacer ejercicio");
    }
}