// Ejercicio 12

using System;
using System.Collections.Generic;
using System.Linq;
public class Producto
{
    public string Nombre { get; set; }
    public decimal Precio { get; set; }
    public string Categoria { get; set; }
}

class Program
{
    static void Main()
    {
        List<Producto> productos = new List<Producto>
        {
            new Producto { Nombre = "Laptop", Precio = 1200.00m, Categoria = "Electrónica" },
            new Producto { Nombre = "Smartphone", Precio = 800.00m, Categoria = "Electrónica" },
            new Producto { Nombre = "Cámara", Precio = 450.00m, Categoria = "Electrónica" },
            new Producto { Nombre = "Silla", Precio = 150.00m, Categoria = "Muebles" },
            new Producto { Nombre = "Mesa", Precio = 300.00m, Categoria = "Muebles" },
            new Producto { Nombre = "Lámpara", Precio = 75.00m, Categoria = "Muebles" },
            new Producto { Nombre = "Chaqueta", Precio = 120.00m, Categoria = "Ropa" },
            new Producto { Nombre = "Pantalones", Precio = 60.00m, Categoria = "Ropa" },
            new Producto { Nombre = "Camisa", Precio = 40.00m, Categoria = "Ropa" }
        };
        var precioPromedioPorCategoria = productos
            .GroupBy(p => p.Categoria)
            .Select(g => new
            {
                Categoria = g.Key,
                PrecioPromedio = g.Average(p => p.Precio)
            })
            .ToList();
        Console.WriteLine("Precio promedio por categoría:");
        foreach (var grupo in precioPromedioPorCategoria)
        {
            Console.WriteLine($"Categoría: {grupo.Categoria}, Precio Promedio: {grupo.PrecioPromedio:C}");
        }
    }
}
