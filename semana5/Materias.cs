using System;
using System.Collections.Generic;

namespace semana5
{
    /// <summary>
    /// Clase que representa un conjunto de asignaturas
    /// </summary>
    public class Materias
    {
        private List<string> asignaturas; // Lista de materias

        // Constructor: inicializo la lista y agrego las materias
        public Materias()
        {
            asignaturas = new List<string>
            {
                "Matemáticas",
                "Física",
                "Química",
                "Historia",
                "Lengua"
            };
        }

        // Método que muestra las asignaturas por consola
        public void MostrarAsignaturas()
        {
            Console.WriteLine("Asignaturas del curso:");
            foreach (string materia in asignaturas)
            {
                Console.WriteLine("- " + materia);
            }
        }
    }
}
