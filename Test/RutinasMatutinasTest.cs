using Domain;
using FluentAssertions;

namespace Test;

public class RutinasMatutinasTest
{
    private List<Tarea> _tareas;
    private PersonalTaskManager  _personalTaskManager;
    public RutinasMatutinasTest()
    {
        _tareas = [
            new Tarea("Hacer ejercicio", new TimeSpan(6, 0, 0), new TimeSpan(6, 59, 0)),
            new Tarea("Leer y estudiar", new TimeSpan(7, 0, 0), new TimeSpan(7, 59, 0)),
            new Tarea("Desayunar", new TimeSpan(8, 0, 0), new TimeSpan(8, 59, 0))
        ];
        _personalTaskManager = new PersonalTaskManager(_tareas);     
    }
    
    
    [Fact]
    public void SI_SonEntre6Y6H59mAM_Debe_RetornarHacerEjercicio()
    {
        TimeSpan horaActual = new TimeSpan(6, 0, 0);
        _personalTaskManager.AsignarHoraActual(horaActual);
        var tarea = _personalTaskManager.QueDeboHacerAhora();
        tarea.Should().Be("Hacer ejercicio");
    }
    
    
    [Fact]
    public void SI_SonEntre7Y7H59mAM_Debe_RetornarLeeryestudiar()
    {
        TimeSpan horaActual = new TimeSpan(7, 0, 0);
        _personalTaskManager.AsignarHoraActual(horaActual);
        _personalTaskManager.QueDeboHacerAhora().Should().Be("Leer y estudiar");
    }
    
    [Fact]
    public void SI_SonEntre8Y8H59mAM_Debe_RetornarDesayunar()
    {
        TimeSpan horaActual = new TimeSpan(8, 0, 0);
        _personalTaskManager.AsignarHoraActual(horaActual);
        _personalTaskManager.QueDeboHacerAhora().Should().Be("Desayunar");
    }

    [Fact]
    public void SI_NoHayTareasASignadasEnHorario_debe_RetornarSinActividad()
    {
        TimeSpan horaActual = new TimeSpan(9, 0, 0);
        _personalTaskManager.AsignarHoraActual(horaActual);
        _personalTaskManager.QueDeboHacerAhora().Should().Be("Sin actividad");
    }

    
    
}