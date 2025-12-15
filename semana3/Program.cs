// Program.cs
using System;

class Program
{
    static void Main()
    {
        RegistroEstudiante registro = new RegistroEstudiante(); // Instancio la clase para registrar estudiantes

        Console.WriteLine("=== Registro de Estudiante ===");
        Estudiante estudiante = registro.Registrar(); // Registro un estudiante pidiendo datos al usuario

        Console.WriteLine("\n--- Datos del Estudiante Registrado ---");
        estudiante.MostrarDatos(); // Muestro los datos ingresados

        Console.WriteLine("\nPresione cualquier tecla para salir...");
        Console.ReadKey(); // Espero que el usuario presione una tecla antes de cerrar
    }
}