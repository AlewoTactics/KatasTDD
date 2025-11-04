namespace Domain;



public class PersonalTaskManager
{
    private TimeSpan _horaActual;

    public PersonalTaskManager(TimeSpan horaActual)
    {
        _horaActual = horaActual;
    }
    
    public string QueDeboHacerAhora()
    {
        List<Tarea> tareas = [
            new Tarea("Hacer ejercicio", new TimeSpan(6, 0, 0), new TimeSpan(6, 59, 0)),
            new Tarea("Leer y estudiar", new TimeSpan(7, 0, 0), new TimeSpan(7, 59, 0)),
            new Tarea("Desayunar", new TimeSpan(8, 0, 0), new TimeSpan(8, 59, 0))
        ];

        foreach (Tarea tarea in tareas)
        {
            if (_horaActual >= tarea.horaInicio && _horaActual <= tarea.horaFin)
                return tarea.nombre;
        }
        
        return "Sin actividad";
    }
}

public record Tarea(string nombre, TimeSpan horaInicio, TimeSpan horaFin);