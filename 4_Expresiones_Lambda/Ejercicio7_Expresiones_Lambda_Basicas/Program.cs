//Ejercicio 7
using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        List<int> numerosPares = numeros.Where(n => n % 2 == 0).ToList();
        Console.WriteLine("Números pares:");
        foreach (int numero in numerosPares)
        {
            Console.WriteLine(numero);
        }
    }
}