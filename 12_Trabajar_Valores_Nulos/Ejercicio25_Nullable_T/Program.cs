// Ejercicio 25
using System;
class Program
{
    static void Main()
    {
        Console.Write("Introduce tu edad (deja vacío si prefieres no especificarla): ");
        string entrada = Console.ReadLine();
        int? edad = null;
        if (!string.IsNullOrWhiteSpace(entrada))
        {
            if (int.TryParse(entrada, out int edadConvertida))
            {
                edad = edadConvertida;
            }
            else
            {
                Console.WriteLine("La edad introducida no es válida.");
            }
        }
        if (edad.HasValue)
        {
            Console.WriteLine($"Tu edad es: {edad.Value}");
        }
        else
        {
            Console.WriteLine("No se ha especificado la edad.");
        }
    }
}
