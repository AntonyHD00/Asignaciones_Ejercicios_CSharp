// Ejercicio 15

using System;
using System.Collections.Generic;
public abstract class Animal
{
    public abstract void Hablar();
}
public class Perro : Animal
{
    public override void Hablar()
    {
        Console.WriteLine("El perro dice: ¡Guau!");
    }
}
public class Gato : Animal
{
    public override void Hablar()
    {
        Console.WriteLine("El gato dice: ¡Miau!");
    }
}
class Program
{
    static void Main()
    {
        List<Animal> animales = new List<Animal>
        {
            new Perro(),
            new Gato(),
            new Perro(),
            new Gato()
        };
        foreach (var animal in animales)
        {
            animal.Hablar(); 
        }
    }
}
