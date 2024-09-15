// Ejercicio 24

using System;
class Persona
{
    public string Apellido { get; set; }
}
class Program
{
    static void Main()
    {
        Persona personaConApellidoNull = new Persona();
        Persona personaConApellido = new Persona { Apellido = "Gómez" };
        string apellidoPersonaConNull = personaConApellidoNull.Apellido?.ToString() ?? "No tiene apellido";
        string apellidoPersonaConValor = personaConApellido.Apellido?.ToString() ?? "No tiene apellido";
        Console.WriteLine($"Apellido de persona con apellido null: {apellidoPersonaConNull}");
        Console.WriteLine($"Apellido de persona con apellido definido: {apellidoPersonaConValor}");
    }
}
