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
        TimeSpan horaInicio6 = new TimeSpan(6, 0, 0); 
        TimeSpan horaFin6 = new TimeSpan(6, 59, 0);
        
        TimeSpan horaInicio7 = new TimeSpan(7, 0, 0); 
        TimeSpan horaFin7 = new TimeSpan(7, 59, 0);
        if (_horaActual >= horaInicio6 && _horaActual <= horaFin6)
            return "Hacer ejercicio"; 
        
        if (_horaActual >= horaInicio7 && _horaActual <= horaFin7)
            return "Leer y estudiar";
        
        return "";
    }
}