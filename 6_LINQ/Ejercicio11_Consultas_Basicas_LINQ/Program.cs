// Ejercicio 11
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numeros = new List<int> { 10, 23, 5, 8, 12, 3, 19, 7, 45, 18 };
        var numerosImpares = numeros
            .Where(n => n % 2 != 0)     
            .OrderByDescending(n => n)  
            .ToList();                  
        Console.WriteLine("Números impares en orden descendente:");
        foreach (var num in numerosImpares)
        {
            Console.WriteLine(num);
        }
    }
}
