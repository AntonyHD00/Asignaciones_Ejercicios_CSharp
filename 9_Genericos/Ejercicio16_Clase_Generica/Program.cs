// Ejercicio 16

using System;
public class Caja<T>
{
    private T _objeto;
    public void Añadir(T objeto)
    {
        _objeto = objeto;
    }
    public T Obtener()
    {
        return _objeto;
    }
}
class Program
{
    static void Main()
    {
        Caja<int> cajaDeEntero = new Caja<int>();
        cajaDeEntero.Añadir(42);
        Console.WriteLine($"Número en la caja: {cajaDeEntero.Obtener()}");
        Caja<string> cajaDeCadena = new Caja<string>();
        cajaDeCadena.Añadir("Dell");
        Console.WriteLine($"Texto en la caja: {cajaDeCadena.Obtener()}");
        Caja<Producto> cajaDeProducto = new Caja<Producto>();
        cajaDeProducto.Añadir(new Producto { Nombre = "Laptop", Precio = 1200.00m });
        Producto producto = cajaDeProducto.Obtener();
        Console.WriteLine($"Producto en la caja: {producto.Nombre} - {producto.Precio:C}");
    }
}
public class Producto
{
    public string Nombre { get; set; }
    public decimal Precio { get; set; }
}
