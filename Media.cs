/*
Programa que lea números hasta que se introduzca un cero y escriba la media de los números leídos, sin incluir el 0 en el conteo de números.
Nota: Se deben usar contadores y acumuladores con el bucle while para resolverlo.
*/

using System;

public class Program
{
    public static void Main()
    {
        // Inicializamos variables
        double total = 0;
        int contador = 0;

        // Leemos números hasta que se ingrese un 0
        while (true)
        {
            Console.Write("Introduce un número (0 para terminar): ");
            double numero = Convert.ToDouble(Console.ReadLine());

            if (numero == 0)
            {
                break;
            }

            total += numero;
            contador++;
        }

        // Calculamos la media (evitando la división por cero)
        if (contador > 0)
        {
            double media = total / contador;
            Console.WriteLine($"Media = {media}");
        }
        else
        {
            Console.WriteLine("No se introdujeron números válidos.");
        }
    }
}
