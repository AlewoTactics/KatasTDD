using System.Diagnostics.CodeAnalysis;

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
    private const int LimitePlataforma = 9;
    private int PosicionX { get; set; } = 0;
    private int PosicionY { get; set; } = 0;
    private PuntosCardinales PuntoCardinal { get; set; } = 0;
    
    public string ObtenerUbicacion() =>  $"{PosicionX}:{PosicionY}:{PuntoCardinal}";
    
    public void EjecutarComandos(string comandos)
    {
        foreach (var comando in comandos)
        {
            if (HayUnGiroALaDerecha(comando))
                GirarDerecha();
            else if (HayUnGiroALaIzquierda(comando))
                GirarIzquierda();
            else if(HayUnMovimiento(comando))   
                Desplazamiento();
            else
                throw new Exception($"No es posible procesar el comando {comando}");
        }
    }
    
    private void Desplazamiento()
    {
        switch (PuntoCardinal)
        {
            case PuntosCardinales.E:
                PosicionX++;
                break;
            case PuntosCardinales.W:
                PosicionX--;
                break;
            case PuntosCardinales.N:
                PosicionY++;
                break;
            case PuntosCardinales.S:
                PosicionY--;
                break;
        }
        RestablecerCoordenadas();
    }

    private void RestablecerCoordenadas()
    {
        switch (PuntoCardinal)
        {
            case PuntosCardinales.E or PuntosCardinales.W:
            {
                if (PosicionX > LimitePlataforma  )
                    PosicionX = 0;
                if(PosicionX < 0)
                    PosicionX = LimitePlataforma;
                break;
            }
            case PuntosCardinales.N or PuntosCardinales.S:
            {
                if (PosicionY > LimitePlataforma)
                    PosicionY = 0;
                if (PosicionY < 0)
                    PosicionY = LimitePlataforma;
                break;
            }
        }
    }


    private void GirarDerecha()
    {
        int puntoCardinal = ((int)PuntoCardinal + 1) % 4;
        PuntoCardinal = (PuntosCardinales)puntoCardinal;
    }
    
    private void GirarIzquierda()
    {
        int puntoCardinal = ((int)PuntoCardinal + 3) % 4;
        PuntoCardinal = (PuntosCardinales)puntoCardinal;
    }

    private bool HayUnGiroALaDerecha(char comando) => char.ToUpper(comando) == 'R';
    private bool HayUnGiroALaIzquierda(char comando) => char.ToUpper(comando) == 'L';
    private bool HayUnMovimiento(char comando) => char.ToUpper(comando) == 'M';
}