//Ejercicio 2

using System;

class Calculadora
{
    static void Main()
    {
        double numero1, numero2, resultado;
        char operacion;

        Console.Write("Ingresa el primer número: ");
        numero1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingresa la operación (+, -, *, /): ");
        operacion = Convert.ToChar(Console.ReadLine());
        Console.Write("Ingresa el segundo número: ");
        numero2 = Convert.ToDouble(Console.ReadLine());

        try
        {
            // Realizar la operación
            switch (operacion)
            {
                case '+':
                    resultado = numero1 + numero2;
                    Console.WriteLine($"El resultado de {numero1} + {numero2} es: {resultado}");
                    break;
                case '-':
                    resultado = numero1 - numero2;
                    Console.WriteLine($"El resultado de {numero1} - {numero2} es: {resultado}");
                    break;
                case '*':
                    resultado = numero1 * numero2;
                    Console.WriteLine($"El resultado de {numero1} * {numero2} es: {resultado}");
                    break;
                case '/':
                    if (numero2 == 0)
                    {
                        throw new DivideByZeroException("Error: No se puede dividir entre cero.");
                    }
                    resultado = numero1 / numero2;
                    Console.WriteLine($"El resultado de {numero1} / {numero2} es: {resultado}");
                    break;
                default:
                    Console.WriteLine("Operación no válida.");
                    break;
            }
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (FormatException e)
        {
            Console.WriteLine("Error: Formato de número no válido.");
        }
    }
}

