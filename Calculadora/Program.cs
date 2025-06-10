// See https://aka.ms/new-console-template for more information
using EspacioCalculadora;
using System.Diagnostics.Contracts;

Calculadora calcu = new Calculadora();

Console.WriteLine("--------------------CALCULADORA------------------");
double n1, n2;
Console.WriteLine("Ingrese primer numero: ");
if (!double.TryParse(Console.ReadLine(), out n1))
{
    Console.WriteLine("El valor que ha ingresado no es un numero");
    return;
}
else
{
    Console.WriteLine("Ingrese segundo numero: ");
    if (!double.TryParse(Console.ReadLine(), out n2))
    {
        Console.WriteLine("El valor que ha ingresado no es un numero");
        return;
    }
    else
    {
        int valor;
        do
        {
            Console.WriteLine("-------¿Que deseas realizar?------");
            Console.WriteLine("(1)Sumar");
            Console.WriteLine("(2)Restar");
            Console.WriteLine("(3)Multiplicar");
            Console.WriteLine("(4)Dividir");
            Console.WriteLine("(5)Nueva operacion");
            Console.WriteLine("(0)Salir");
            Console.WriteLine("Ingresar opcion: ");
            if (!int.TryParse(Console.ReadLine(), out valor))
            {
                Console.WriteLine("El valor que ha ingresado no es un numero");
                return;
            }
            else
            {
                switch (valor)
                {
                    case 1:
                        calcu.Sumar(n1);
                        calcu.Sumar(n2);
                        Console.WriteLine("Resultado de la suma: " + calcu.Resultado);
                        break;
                    case 2:
                        calcu.Restar(n1);
                        calcu.Restar(n2);
                        Console.WriteLine("Resultado de la resta: " + calcu.Resultado);
                        break;
                    case 3:
                        calcu.Multiplicar(n1);
                        calcu.Multiplicar(n2);
                        Console.WriteLine("Resultado de la multiplicacion: " + calcu.Resultado);
                        break;
                    case 4:
                        calcu.Dividir(n1);
                        if (n2 != 0)
                        {
                            calcu.Dividir(n2);
                            Console.WriteLine("Resultado de la division: " + calcu.Resultado);

                        }
                        else
                        {
                            Console.WriteLine("El segundo numero que intenta ingresar es invalido");
                        }
                        break;
                    case 5:
                        calcu.Limpiar();
                        break;
                    default:
                        break;
                }
            }
        } while (valor != 0);

    }

}

