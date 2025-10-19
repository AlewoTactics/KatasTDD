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
        const int limitePlataforma = 9;
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

        switch (PuntoCardinal)
        {
            case PuntosCardinales.E or PuntosCardinales.W:
            {
                if (PosicionX > limitePlataforma  )
                    PosicionX = 0;
                if(PosicionX < 0)
                    PosicionX = limitePlataforma;
                break;
            }
            case PuntosCardinales.N or PuntosCardinales.S:
            {
                if (PosicionY > limitePlataforma)
                    PosicionY = 0;
                if (PosicionY < 0)
                    PosicionY = limitePlataforma;
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

    private bool HayUnGiroALaDerecha(char comando) => comando.Equals('R') || comando.Equals('r');
    private bool HayUnGiroALaIzquierda(char comando) => comando.Equals('L') || comando.Equals('l');
    private bool HayUnMovimiento(char comando) => comando.Equals('M') || comando.Equals('m');
}