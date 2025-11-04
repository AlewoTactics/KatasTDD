namespace Domain;

public class PersonalTaskManager
{
    private TimeSpan _horaActual;
    private List<Tarea> _tareas;

    public PersonalTaskManager(List<Tarea> tareas)
    {
        _tareas = tareas;
    }

    public void AsignarHoraActual(TimeSpan horaACtual) => _horaActual = horaACtual;
    
    public string QueDeboHacerAhora()
    {
        foreach (Tarea tarea in _tareas)
        {
            if (_horaActual >= tarea.horaInicio && _horaActual <= tarea.horaFin)
                return tarea.nombre;
        }
        return "Sin actividad";
    }
}

public record Tarea(string nombre, TimeSpan horaInicio, TimeSpan horaFin);