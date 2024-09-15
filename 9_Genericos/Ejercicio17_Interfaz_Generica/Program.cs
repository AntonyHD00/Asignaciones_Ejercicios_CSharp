// Ejercicio 17

using System;
public interface IContenedor<T>
{
    void Agregar(T elemento);
    T Obtener();
}
public class Caja<T> : IContenedor<T>
{
    private T _objeto;
    public void Agregar(T elemento)
    {
        _objeto = elemento;
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
        IContenedor<int> cajaDeEntero = new Caja<int>();
        cajaDeEntero.Agregar(42);
        Console.WriteLine($"Número en la caja: {cajaDeEntero.Obtener()}");

        IContenedor<string> cajaDeCadena = new Caja<string>();
        cajaDeCadena.Agregar("Hola, Mundo!");
        Console.WriteLine($"Texto en la caja: {cajaDeCadena.Obtener()}");

        IContenedor<Producto> cajaDeProducto = new Caja<Producto>();
        cajaDeProducto.Agregar(new Producto { Nombre = "Laptop", Precio = 1200.00m });
        Producto producto = cajaDeProducto.Obtener();
        Console.WriteLine($"Producto en la caja: {producto.Nombre} - {producto.Precio:C}");
    }
}
public class Producto
{
    public string Nombre { get; set; }
    public decimal Precio { get; set; }
}
