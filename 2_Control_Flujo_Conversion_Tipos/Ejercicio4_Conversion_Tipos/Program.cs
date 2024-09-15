//Ejercicio 4
using System;
class Conversion
{
    static void Main()
    {
        Console.Write("Ingresa un número entero: ");
        int numeroEntero = Convert.ToInt32(Console.ReadLine());
        decimal numeroDecimal = Convert.ToDecimal(numeroEntero);
        Console.WriteLine($"Número convertido a decimal: {numeroDecimal}");
        int numeroConvertido = Convert.ToInt32(numeroDecimal);
        Console.WriteLine($"Número convertido de nuevo a entero: {numeroConvertido}");
    }

    //Explicación: Este puede ser util para realizar estas conversiones explicitas para
    //tener mejor precision en calculos, control sobre el tipo de datos, compatibilidad
    //entre tipos de datos y optimizacion de recursos. 
}
