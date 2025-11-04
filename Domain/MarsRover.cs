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
            ProcesarComando(char.ToUpper(comando));
        }
    }

    private void ProcesarComando(char comando)
    {
        switch (comando)
        {
            case 'R':
                GirarDerecha();
                break;
            case 'L':
                GirarIzquierda();
                break;
            case 'M':
                Desplazamiento();
                break;
            default:
                throw new Exception("No es posible procesar el comando ya que se encontraron acciones no validas.");
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
                PosicionX = NormalizarCoordenada(PosicionX);
                break;
            case PuntosCardinales.N or PuntosCardinales.S:
                PosicionY = NormalizarCoordenada(PosicionY);
                break;
        }
    }

    private int NormalizarCoordenada(int coordenada)
    {
        if (coordenada > LimitePlataforma)
            return 0;
        if (coordenada < 0)
            return LimitePlataforma;
        return coordenada;
    }


    private void GirarDerecha() => Girar(1);

    private void GirarIzquierda() => Girar(-1);

    private void Girar(int direccion)
    {
        int puntoCardinal = ((int)PuntoCardinal + direccion + 4) % 4;
        PuntoCardinal = (PuntosCardinales)puntoCardinal;
    }
}