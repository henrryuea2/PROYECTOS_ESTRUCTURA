using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Random rand = new Random();

        // Crear un conjunto ficticio de 500 ciudadanos (Ciudadano 1, Ciudadano 2, ..., Ciudadano 500)
        var totalCiudadanos = new HashSet<string>();
        for (int i = 1; i <= 500; i++)
        {
            totalCiudadanos.Add($"Ciudadano {i}");
        }

        // Crear un conjunto ficticio de 75 ciudadanos vacunados con Pfizer
        var vacunadosPfizer = new HashSet<string>();
        while (vacunadosPfizer.Count < 75)
        {
            int id = rand.Next(1, 501);
            vacunadosPfizer.Add($"Ciudadano {id}");
        }

        // Crear un conjunto ficticio de 75 ciudadanos vacunados con AstraZeneca
        var vacunadosAstrazeneca = new HashSet<string>();
        while (vacunadosAstrazeneca.Count < 75)
        {
            int id = rand.Next(1, 501);
            vacunadosAstrazeneca.Add($"Ciudadano {id}");
        }

        // Calcular ciudadanos que no se han vacunado
        var noVacunados = totalCiudadanos.Except(vacunadosPfizer).Except(vacunadosAstrazeneca).ToList();

        // Calcular ciudadanos que han recibido ambas dosis
        var vacunadosAmbas = vacunadosPfizer.Intersect(vacunadosAstrazeneca).ToList();

        // Calcular ciudadanos que solo han recibido Pfizer
        var soloPfizer = vacunadosPfizer.Except(vacunadosAstrazeneca).ToList();

        // Calcular ciudadanos que solo han recibido AstraZeneca
        var soloAstrazeneca = vacunadosAstrazeneca.Except(vacunadosPfizer).ToList();

        // Mostrar resultados
        Console.WriteLine("=== CAMPAÑA DE VACUNACIÓN COVID-19 ===\n");
        Console.WriteLine($"Total de ciudadanos: {totalCiudadanos.Count}");
        Console.WriteLine($"No vacunados: {noVacunados.Count}");
        Console.WriteLine($"Vacunados con ambas dosis: {vacunadosAmbas.Count}");
        Console.WriteLine($"Vacunados solo con Pfizer: {soloPfizer.Count}");
        Console.WriteLine($"Vacunados solo con AstraZeneca: {soloAstrazeneca.Count}\n");

        // Mostrar ejemplos (primeros 10 de cada categoría)
        Console.WriteLine("Ejemplos de ciudadanos no vacunados: " + string.Join(", ", noVacunados.Take(10)));
        Console.WriteLine("Ejemplos de ciudadanos con ambas dosis: " + string.Join(", ", vacunadosAmbas.Take(10)));
        Console.WriteLine("Ejemplos de ciudadanos solo con Pfizer: " + string.Join(", ", soloPfizer.Take(10)));
        Console.WriteLine("Ejemplos de ciudadanos solo con AstraZeneca: " + string.Join(", ", soloAstrazeneca.Take(10)));
    }
}
