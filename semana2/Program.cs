using System;
// Importamos el namespace donde se encuentran nuestras clases

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("---  Demostración de Encapsulación y Métodos ---");

            // 1. Uso del Círculo 
            // Creamos un nuevo objeto de la clase Circulo
            Circulo miCirculo = new Circulo(6.0);
            
            Console.WriteLine("\n Círculo (Radio: 6.0)");
            // Llamamos a los métodos públicos para obtener los resultados
            Console.WriteLine($"Área: {miCirculo.CalcularArea():F2}");
            Console.WriteLine($"Perímetro: {miCirculo.CalcularPerimetro():F2}");

            Console.WriteLine("-------------------------------------------");

            // 2. Uso del Rectángulo (instancia de Rectangulo.cs)
            // Creamos un nuevo objeto de la clase Rectangulo
            Rectangulo miRectangulo = new Rectangulo(8.5, 4.0);
            
            Console.WriteLine(" Rectángulo (Largo: 8.5, Ancho: 4.0)");
            // Llamamos a los métodos públicos para obtener los resultados
            Console.WriteLine($"Área: {miRectangulo.CalcularArea():F2}");
            Console.WriteLine($"Perímetro: {miRectangulo.CalcularPerimetro():F2}");
        }
    }
//fin