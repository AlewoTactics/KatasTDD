namespace Domain;

public class PersonalTaskManager
{
    private TimeSpan _horaActual = DateTime.Now.TimeOfDay;
    private List<Tarea> _tareas;

    public PersonalTaskManager(List<Tarea> tareas)
    {
        _tareas = tareas;
    }

    public void AsignarHoraActual(TimeSpan horaActual) => _horaActual = horaActual;
    
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