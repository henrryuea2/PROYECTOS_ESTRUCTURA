// RegistroEstudiante.cs
using System;

public class RegistroEstudiante
{
    public Estudiante Registrar()
    {
        Estudiante estudiante = new Estudiante(); // Creo un nuevo objeto Estudiante

        Console.Write("Ingrese el ID: ");
        estudiante.ID = int.Parse(Console.ReadLine()); // Leo y asigno el ID

        Console.Write("Ingrese los nombres: ");
        estudiante.Nombres = Console.ReadLine(); // Leo y asigno los nombres

        Console.Write("Ingrese los apellidos: ");
        estudiante.Apellidos = Console.ReadLine(); // Leo y asigno los apellidos

        Console.Write("Ingrese la dirección: ");
        estudiante.Direccion = Console.ReadLine(); // Leo y asigno la dirección

        for (int i = 0; i < estudiante.Telefonos.Length; i++)
        {
            Console.Write($"Ingrese el teléfono {i + 1}: ");
            estudiante.Telefonos[i] = Console.ReadLine(); // Leo y guardo cada teléfono en el array
        }

        return estudiante; // Devuelvo el estudiante con todos los datos cargados
    }
}