// Ejercicio 26
using System;
class Recurso : IDisposable
{
    private bool _disposed = false;
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
    protected virtual void Dispose(bool disposing)
    {
        if (!_disposed)
        {
            if (disposing)
            {
                // Liberar recursos administrados
            }

            // Liberar recursos no administrados
            Console.WriteLine("El recurso ha sido liberado.");
            _disposed = true;
        }
    }
    ~Recurso()
    {
        Dispose(false);
    }
}
class Program
{
    static void Main()
    {
        using (Recurso recurso = new Recurso())
        {
            Console.WriteLine("Usando el recurso...");
        }
    }
}

