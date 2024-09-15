// Ejercicio 20

using System;
using System.Diagnostics;
using System.Threading.Tasks;
class Program
{
    public static async Task DescargarArchivoAsync(string archivo, int tiempoSimulacion)
    {
        Console.WriteLine($"Iniciando la descarga del archivo: {archivo}");
        await Task.Delay(tiempoSimulacion);
        Console.WriteLine($"Descarga del archivo {archivo} completada.");
    }

    static async Task Main()
    {
        Stopwatch cronometro = new Stopwatch();
        cronometro.Start();
        Task tarea1 = DescargarArchivoAsync("Archivo1.zip", 6000); // 6 segundos
        Task tarea2 = DescargarArchivoAsync("Archivo2.zip", 5000); // 5 segundos
        Task tarea3 = DescargarArchivoAsync("Archivo3.zip", 8000); // 8 segundos

        await Task.WhenAll(tarea1, tarea2, tarea3);
        cronometro.Stop();
        Console.WriteLine($"Tiempo total de descarga: {cronometro.ElapsedMilliseconds / 1000.0} segundos.");
    }
}

