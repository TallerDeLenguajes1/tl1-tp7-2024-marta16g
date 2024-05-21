using EspacioCalculadora;

bool seguir = true;

Calculadora miCalculadora = new Calculadora();

Console.WriteLine("BIENVENIDO A LA CALCULADORA");
Console.WriteLine("Elija una opción");

do
{
    Console.WriteLine("1) Sumar un numero");
    Console.WriteLine("2) Restar un numero");
    Console.WriteLine("3) Multiplicar por un numero");
    Console.WriteLine("4) Dividir por un numero");

    int pedido;
    bool bandera = int.TryParse(Console.ReadLine(), out pedido);
    if (bandera)
    {
        Console.WriteLine("Ingrese el numero");
        double.TryParse(Console.ReadLine(), out double numerito);

        switch (pedido)
        {
            case 1:
                miCalculadora.Sumar(numerito);
                Console.WriteLine("El resultado de la suma es: " + miCalculadora.resultado);
                break;
            case 2:
                miCalculadora.Restar(numerito);
                Console.WriteLine("El resultado de la resta es: " + miCalculadora.resultado);
                break;
            case 3:
                miCalculadora.Multiplicar(numerito);
                Console.WriteLine("El resultado de la multiplicación es: " + miCalculadora.resultado);
                break;
            case 4:
                miCalculadora.Dividir(numerito);
                Console.WriteLine("El resultado de la división es: " + miCalculadora.resultado);
                break;
            default:
                Console.WriteLine("No se ingresó el número esperado");
                break;
        }

        int operar;
        bool a = false;
        do
        {
            Console.WriteLine("¿Seguir operando? 1 para SI y 0 para NO");
            bool bandera2 = int.TryParse(Console.ReadLine(), out operar);
            if (!bandera2)
            {
                Console.WriteLine("Lo ingresado no es un numero");
                a = false;
            }
            else
            {
                if (operar == 1 || operar == 0)
                {
                    a = true;
                }
                else
                {
                    a = false;
                }
            }
        } while (!a);

        if (operar == 1)
        {
            seguir = true;
        }
        else
        {
            seguir = false;
        }

    }
} while (seguir);

Console.WriteLine("Nos vemos");