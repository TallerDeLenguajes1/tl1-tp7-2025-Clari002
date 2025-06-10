namespace EspacioCalculadora;

public class Calculadora
{
    private double dato;


    public void Sumar(double termino)
    {
        if (dato == 0)
        {
            dato = termino;
        }
        else
        {
            dato += termino;
        }

    }

    public void Restar(double termino)
    {
        if (dato == 0)
        {
            dato = termino;
        }
        else
        {
            dato -= termino;
        }

    }

    public void Multiplicar(double termino)
    {
        if (dato == 0)
        {
            dato = termino;
        }
        else
        {
            dato *= termino;
        }

    }

    public void Dividir(double termino)
    {
        if (dato == 0)
        {
            dato = termino;
        }
        else
        {
            if (termino != 0)
            {
            dato = dato / termino;
                
            }
        }

    }

    public void Limpiar()
    {
        dato = 0;
    }
    public double Resultado
    {
        get => dato;
    }

}