using System;
using semana5;  // Importo el namespace donde están todas las clases

namespace semana5
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Palíndromo
            Palindromo p = new Palindromo();
            p.PedirPalabra();
            p.VerificarPalindromo();

            Console.WriteLine();

            // 2. Materias de estudio
            Materias_De_Estudio cursoEstudio = new Materias_De_Estudio();
            cursoEstudio.MostrarMaterias();

            Console.WriteLine();

            // 3. Precios
            Precios precios = new Precios();
            precios.MostrarMayorYMenor();

            Console.WriteLine();

            // 4. Números inversos
            NumeroInverso lista = new NumeroInverso();
            lista.MostrarInverso();

            Console.WriteLine();

            // 5. Materias fijas
            Materias asignaturasFijas = new Materias();
            asignaturasFijas.MostrarAsignaturas();

            Console.WriteLine("\nPrograma finalizado.");
        }
    }
}
