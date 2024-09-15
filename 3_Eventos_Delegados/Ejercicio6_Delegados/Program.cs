//Ejercicio 6

using System;
delegate int OperacionAritmetica(int x, int y);
class Program
{
    static void Main()
    {
        OperacionAritmetica suma = new OperacionAritmetica(Sumar);
        OperacionAritmetica multiplicacion = new OperacionAritmetica(Multiplicar);
        Console.Write("Ingresa el primer número: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingresa el segundo número: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        int resultadoSuma = suma(num1, num2);
        int resultadoMultiplicacion = multiplicacion(num1, num2);
        Console.WriteLine($"La suma de {num1} y {num2} es: {resultadoSuma}");
        Console.WriteLine($"La multiplicación de {num1} y {num2} es: {resultadoMultiplicacion}");
    }
    static int Sumar(int x, int y)
    {
        return x + y;
    }
    static int Multiplicar(int x, int y)
    {
        return x * y;
    }
}
