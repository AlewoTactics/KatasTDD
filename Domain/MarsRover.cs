namespace Domain;

public enum PuntosCardinales
{
    N = 0,
    E = 1,
    S = 2,
    W = 3
}


public class MarsRover
{
    private int PosicionX { get; set; } = 0;
    private int PosicionY { get; set; } = 0;
    private PuntosCardinales PuntoCardinal { get; set; } = 0;
    
    public string ObtenerUbicacion() =>  $"{PosicionX}:{PosicionY}:{PuntoCardinal}";
    
    public void RealizarMovimientos(string movimiento)
    {
        foreach (var comando in movimiento)
        {
            if (HayUnGiroALaDerecha(comando))
                GirarDerecha();
            else if (HayUnGiroALaIzquierda(comando))
                GirarIzquierda();
            else
                MoverY();
        }
    }

    private void MoverY()
    {
        const int limitePlataforma = 10;
        if (PosicionY >= limitePlataforma)
            PosicionY = 0;
        if(PuntoCardinal.Equals(PuntosCardinales.N))    
            PosicionY++;
        else if (PuntoCardinal.Equals(PuntosCardinales.S))
            PosicionY--;
    }

    private void GirarDerecha()
    {
        int puntoCardinal = ((int)PuntoCardinal + 1) % 4;
        PuntoCardinal = (PuntosCardinales)puntoCardinal;
    }
    
    
    private void GirarIzquierda()
    {
        PuntoCardinal = (PuntosCardinales)3;
    }

    private bool HayUnGiroALaDerecha(char movimientos) => movimientos.Equals('R');
    private bool HayUnGiroALaIzquierda(char movimientos) => movimientos.Equals('L');
}