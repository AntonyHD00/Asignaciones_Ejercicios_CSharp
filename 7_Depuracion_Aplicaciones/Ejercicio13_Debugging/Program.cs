// Ejercicio 13

using System;
class Program
{
    static void Main()
    {
        Random random = new Random();
        int count = 0;
        while (count < 10)
        {
            int numeroAleatorio = random.Next(1, 101);
            Console.WriteLine($"Número generado: {numeroAleatorio}");
            count++;
            Console.WriteLine($"Conteo actual: {count}");
        }
    }
}