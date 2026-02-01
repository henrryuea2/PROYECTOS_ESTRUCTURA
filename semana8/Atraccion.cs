public class Atraccion
{
    private List<Asiento> asientos;      // Lista de los 30 asientos
    private Queue<Persona> cola;         // Cola para simular orden de llegada
    private Stack<Persona> pilaSubida;   // Pila para registrar orden de subida

    public Atraccion(int cantidadAsientos)
    {
        asientos = new List<Asiento>();  // Inicializa la lista de asientos
        cola = new Queue<Persona>();     // Inicializa la cola de espera
        pilaSubida = new Stack<Persona>(); // Inicializa la pila de subida

        // Se crean los asientos numerados del 1 al total
        for (int i = 1; i <= cantidadAsientos; i++)
        {
            asientos.Add(new Asiento(i));
        }
    }

    public void AgregarPersona(Persona persona)
    {
        cola.Enqueue(persona);           // Agrega persona a la cola (orden de llegada)
    }

    public void AsignarAsientos()
    {
        int i = 0;
        // Mientras haya personas en la cola y asientos disponibles
        while (cola.Count > 0 && i < asientos.Count)
        {
            Persona persona = cola.Dequeue(); // Saca la primera persona de la cola
            asientos[i].Ocupado = true;       // Marca el asiento como ocupado
            pilaSubida.Push(persona);         // Registra la persona en la pila
            Console.WriteLine($"{persona.Nombre} ocupa el {asientos[i]}");
            i++;
        }
    }

    public void MostrarOrdenSubida()
    {
        Console.WriteLine("\nOrden en que subieron (último en la pila arriba):");
        // Recorre la pila mostrando el orden de subida
        foreach (var persona in pilaSubida)
        {
            Console.WriteLine(persona);
        }
    }
}
