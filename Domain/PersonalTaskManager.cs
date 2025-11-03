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
        TimeSpan horaInicio = new TimeSpan(6, 0, 0); 
        TimeSpan horaFin = new TimeSpan(7, 0, 0);
        if (_horaActual >= horaInicio && _horaActual <= horaFin)
            return "Hacer ejercicio";
        return "";
    }
}