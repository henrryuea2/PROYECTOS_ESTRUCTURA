using System;


    public class Circulo
    {
        // Encapsulación del dato primitivo 'double' para el radio
        private double radio;

        // Constructor para inicializar el radio
        public Circulo(double radio)
        {
            this.radio = radio;
        }

        // CalcularArea es una función que devuelve un valor double.
       
        public double CalcularArea()
        {
            return Math.PI * radio * radio;
        }

        // CalcularPerimetro es una función que devuelve un valor double.
        // Se utiliza para calcular la circunferencia.
       
        public double CalcularPerimetro()
        {
            return 2 * Math.PI * radio;
        }
    }
