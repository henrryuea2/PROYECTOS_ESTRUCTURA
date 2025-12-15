// Estudiante.cs
using System;

public class Estudiante
{
    public int ID; // Identificador único del estudiante
    public string Nombres; // Nombres del estudiante
    public string Apellidos; // Apellidos del estudiante
    public string Direccion; // Dirección del estudiante
    public string[] Telefonos = new string[3]; // Array para almacenar tres números de teléfono

    public void MostrarDatos()
    {
        Console.WriteLine($"ID: {ID}");
        Console.WriteLine($"Nombres: {Nombres}");
        Console.WriteLine($"Apellidos: {Apellidos}");
        Console.WriteLine($"Dirección: {Direccion}");
        Console.WriteLine("Teléfonos:");
        for (int i = 0; i < Telefonos.Length; i++)
        {
            Console.WriteLine($"  Teléfono {i + 1}: {Telefonos[i]}"); // Mostrar cada teléfono almacenado
        }
    }
}
