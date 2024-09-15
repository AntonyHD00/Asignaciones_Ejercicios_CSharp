// Ejercicio 23
using System;
class Program
{
    static void Main()
    {
        int? numero = null;
        int valorPorDefecto = numero ?? 85;
        Console.WriteLine($"El valor de 'numero' es: {(numero.HasValue ? numero.ToString() : "null")}");
        Console.WriteLine($"El valor por defecto es: {valorPorDefecto}");
    }
}