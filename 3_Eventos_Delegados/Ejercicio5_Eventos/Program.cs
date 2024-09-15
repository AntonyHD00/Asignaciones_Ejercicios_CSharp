//Ejercicio 5

using System;
using System.Threading;

class RelojAlarma
{
    public event EventHandler SonarAlarma;
    private DateTime horaAlarma;
    public void ConfigurarAlarma(DateTime hora)
    {
        horaAlarma = hora;
        Console.WriteLine($"Alarma configurada para las: {horaAlarma.ToString("HH:mm:ss")}");
    }
    public void Iniciar()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine($"Hora actual: {DateTime.Now.ToString("HH:mm:ss")}");
            Console.WriteLine($"Alarma configurada para las: {horaAlarma.ToString("HH:mm:ss")}");
            if (DateTime.Now >= horaAlarma)
            {
                SonarAlarma?.Invoke(this, EventArgs.Empty);
                break;
            }
            Thread.Sleep(1000);
        }
    }
}

class Program
{
    static void Main()
    {
        RelojAlarma alarma = new RelojAlarma();
        alarma.SonarAlarma += Alarmaencendida;
        DateTime horaActual = DateTime.Now;
        DateTime horaAlarma = horaActual.AddSeconds(10); 
        alarma.ConfigurarAlarma(horaAlarma);
        alarma.Iniciar();

    }
    private static void Alarmaencendida(object sender, EventArgs e)
    {
        Console.WriteLine("¡Alarma sonando! Hora de levantarse.");
    }
}
