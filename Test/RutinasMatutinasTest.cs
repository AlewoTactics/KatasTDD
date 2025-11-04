using Domain;
using FluentAssertions;

namespace Test;

public class RutinasMatutinasTest
{

    [Fact]
    public void SI_SonEntre6Y6H59mAM_Debe_RetornarHacerEjercicio()
    {
        TimeSpan horaActual = new TimeSpan(6, 0, 0);
        var personalTaskManager = new PersonalTaskManager(horaActual);  
        var tarea = personalTaskManager.QueDeboHacerAhora();
        tarea.Should().Be("Hacer ejercicio");
    }
    
    
    [Fact]
    public void SI_SonEntre7Y7H59mAM_Debe_RetornarLeeryestudiar()
    {
        TimeSpan horaActual = new TimeSpan(7, 0, 0);
        var personalTaskManager = new PersonalTaskManager(horaActual);
        personalTaskManager.QueDeboHacerAhora().Should().Be("Leer y estudiar");
    }
    
    [Fact]
    public void SI_SonEntre8Y8H59mAM_Debe_RetornarDesayunar()
    {
        TimeSpan horaActual = new TimeSpan(8, 0, 0);
        var personalTaskManager = new PersonalTaskManager(horaActual);
        personalTaskManager.QueDeboHacerAhora().Should().Be("Desayunar");
    }

    [Fact]
    public void SI_NoHayTareasASignadasEnHorario_debe_RetornarSinActividad()
    {
        TimeSpan horaActual = new TimeSpan(9, 0, 0);
        var personalTaskManager = new PersonalTaskManager(horaActual);
        personalTaskManager.QueDeboHacerAhora().Should().Be("Sin actividad");
    }

    
    
}