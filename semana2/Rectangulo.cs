using System;
    public class Rectangulo
    {
        // Encapsulación de los datos primitivos 'double' para las dimensiones
        private double largo;
        private double ancho;

        // Constructor para inicializar el largo y el ancho
        public Rectangulo(double largo, double ancho)
        {
            this.largo = largo;
            this.ancho = ancho;
        }

        // CalcularArea es una función que devuelve un valor double.
 
        public double CalcularArea()
        {
            return largo * ancho;
        }

        // CalcularPerimetro es una función que devuelve un valor double.
     
        public double CalcularPerimetro()
        {
            return 2 * (largo + ancho);
        }
    }
