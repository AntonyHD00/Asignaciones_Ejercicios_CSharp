// Ejercicio 8

using System;
using System.Collections.Generic;
using System.Linq;
class Estudiante
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
}
class Program
{
    static void Main()
    {
        List<Estudiante> estudiantes = new List<Estudiante>
        {
            new Estudiante { Nombre = "James", Edad = 17 },
            new Estudiante { Nombre = "Brown", Edad = 19 },
            new Estudiante { Nombre = "Luis", Edad = 22 },
            new Estudiante { Nombre = "Walker", Edad = 16 },
            new Estudiante { Nombre = "William", Edad = 20 }
        };
        List<Estudiante> mayoresDe18 = FiltrarMayoresDe18(estudiantes);
        Console.WriteLine("Estudiantes mayores de 18 años:");
        foreach (var estudiante in mayoresDe18)
        {
            Console.WriteLine($"Nombre: {estudiante.Nombre}, Edad: {estudiante.Edad}");
        }
    }
    static List<Estudiante> FiltrarMayoresDe18(List<Estudiante> estudiantes)
    {
        return estudiantes.Where(e => e.Edad > 18).ToList();
    }
}