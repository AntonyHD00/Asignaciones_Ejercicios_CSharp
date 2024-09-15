// Ejercicio 19
using System;
using System.Threading.Tasks;
class Program
{
    public static async Task<int> ObtenerNumeroAleatorioAsync()
    {
        await Task.Delay(2000);
        Random random = new Random();
        int numeroAleatorio = random.Next(1, 101);
        return numeroAleatorio;
    }
    static async Task Main()
    {
        try
        {
            Task<int> tarea1 = ObtenerNumeroAleatorioAsync();
            Task<int> tarea2 = ObtenerNumeroAleatorioAsync();

            int resultado1 = await tarea1;
            int resultado2 = await tarea2;

            Console.WriteLine($"Resultado de la primera tarea: {resultado1}");
            Console.WriteLine($"Resultado de la segunda tarea: {resultado2}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Se produjo una excepción: {ex.Message}");
        }
    }
}
