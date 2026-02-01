class Program
{
    static void Main(string[] args)
    {
        Atraccion atraccion = new Atraccion(30); // Se crea la atracción con 30 asientos

        // Se simulan 30 personas en la cola
        for (int i = 1; i <= 30; i++)
        {
            atraccion.AgregarPersona(new Persona("Persona " + i));
        }

        atraccion.AsignarAsientos();     // Se asignan los asientos en orden de llegada
        atraccion.MostrarOrdenSubida();  // Se muestra el orden en que subieron

        Console.WriteLine("\n¡Todos los asientos han sido ocupados!");
    }
}
