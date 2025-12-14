using System;

class Estudiante
{
    public string Id;
    public string Nombres;
    public string Apellidos;
    public string Direccion;

    // Array para los teléfonos
    public string[] Telefonos = new string[3];

    public void MostrarDatos()
    {
        Console.WriteLine("\n--- DATOS DEL ESTUDIANTE ---");
        Console.WriteLine("ID: " + Id);
        Console.WriteLine("Nombres: " + Nombres);
        Console.WriteLine("Apellidos: " + Apellidos);
        Console.WriteLine("Dirección: " + Direccion);
        Console.WriteLine("Teléfonos:");
        for (int i = 0; i < Telefonos.Length; i++)
        {
            Console.WriteLine("  Teléfono " + (i + 1) + ": " + Telefonos[i]);
        }
    }
}

class Program
{
    static void Main()
    {
        Estudiante estudiante = new Estudiante();

        Console.WriteLine("=== REGISTRO DE ESTUDIANTE ===");

        Console.Write("ID: ");
        estudiante.Id = Console.ReadLine();

        Console.Write("Nombres: ");
        estudiante.Nombres = Console.ReadLine();

        Console.Write("Apellidos: ");
        estudiante.Apellidos = Console.ReadLine();

        Console.Write("Dirección: ");
        estudiante.Direccion = Console.ReadLine();

        for (int i = 0; i < estudiante.Telefonos.Length; i++)
        {
            Console.Write("Teléfono " + (i + 1) + ": ");
            estudiante.Telefonos[i] = Console.ReadLine();
        }

        estudiante.MostrarDatos();

        Console.WriteLine("\nPresione ENTER para finalizar...");
        Console.ReadLine();
    }
}