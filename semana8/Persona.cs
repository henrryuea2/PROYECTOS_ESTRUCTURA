public class Persona
{
    public string Nombre { get; set; }   // Nombre de la persona en la fila

    public Persona(string nombre)
    {
        Nombre = nombre;                 // Se guarda el nombre al crear la persona
    }

    public override string ToString()
    {
        return Nombre;                   // Cuando se imprime, muestra solo el nombre
    }
}
