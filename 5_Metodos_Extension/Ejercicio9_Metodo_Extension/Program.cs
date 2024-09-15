//Ejercicio 9
using System;
public static class StringExtensions
{
    public static int ContarVocales(this string texto, char vocal)
    {
        texto = texto.ToLower();
        int contador = 0;
        foreach (char c in texto)
        {
            if (c == vocal)
            {
                contador++;
            }
        }
        return contador;
    }
}
class Program
{
    static void Main()
    {
        string texto = "Saludos, este es un ejemplo de un método de extensión";
        int cantidadA = texto.ContarVocales('a');
        int cantidadE = texto.ContarVocales('e');
        int cantidadI = texto.ContarVocales('i');
        int cantidadO = texto.ContarVocales('o');
        int cantidadU = texto.ContarVocales('u');
        

        Console.WriteLine($"La vocal 'a' aparece {cantidadA} veces.");
        Console.WriteLine($"La vocal 'e' aparece {cantidadE} veces.");
        Console.WriteLine($"La vocal 'i' aparece {cantidadI} veces.");
        Console.WriteLine($"La vocal 'o' aparece {cantidadO} veces.");
        Console.WriteLine($"La vocal 'u' aparece {cantidadU} veces.");
    }
}
