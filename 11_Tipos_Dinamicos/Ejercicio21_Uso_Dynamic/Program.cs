// Ejercicio 21

using Microsoft.CSharp.RuntimeBinder;
using System;
class Program
{
    static void Main()
    {
        dynamic objeto = 10;
        Console.WriteLine($"Valor entero: {objeto}");
        Console.WriteLine($"Valor entero + 5: {objeto + 5}");
        objeto = "DELL";
        Console.WriteLine($"Cadena: {objeto}");
        Console.WriteLine($"Longitud de la cadena: {objeto.Length}");
        objeto = new Producto { Nombre = "Laptop", Precio = 1200.00m };
        Console.WriteLine($"Producto: {objeto.Nombre}");
        Console.WriteLine($"Precio: {objeto.Precio:C}");

        try
        {
            objeto.MetodoNoExistente();
        }
        catch (RuntimeBinderException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
public class Producto
{
    public string Nombre { get; set; }
    public decimal Precio { get; set; }
}
