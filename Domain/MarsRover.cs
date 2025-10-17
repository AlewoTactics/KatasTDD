namespace Domain;

public class MarsRover
{
    private int PosicionX { get; set; } = 0;
    private int PosicionY { get; set; } = 0;
    private int PuntoCardinal { get; set; } = 0;
    

    private readonly Dictionary<int, char> _puntosCardinales = new ()
    {
        { 0, 'N' },
        { 1, 'E' }, 
        { 2, 'S' },
        { 3, 'W' }
    };
    public string ObtenerUbicacion() =>  $"{PosicionX}:{PosicionY}:{_puntosCardinales[PuntoCardinal]}";
    
    public void RealizarMovimientos(string movimiento)
    {
        foreach (var comando in movimiento)
        {
            if (HayUnGiroALaDerecha(comando))
                GirarDerecha();
            else
                MoverY();
        }
    }

    private void MoverY()
    {
        const int limitePlataforma = 10;
        if (PosicionY >= limitePlataforma)
            PosicionY = 0;
        PosicionY++;
    }

    private void  GirarDerecha() => PuntoCardinal = (PuntoCardinal + 1) % 4;

    private bool HayUnGiroALaDerecha(char movimientos) => movimientos.Equals('R');
}