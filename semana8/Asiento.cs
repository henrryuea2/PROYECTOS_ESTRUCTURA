public class Asiento
{
    public int Numero { get; set; }   // Número identificador del asiento
    public bool Ocupado { get; set; } // Estado: si está ocupado o libre

    public Asiento(int numero)
    {
        Numero = numero;              // Se asigna el número al asiento
        Ocupado = false;              // Por defecto, el asiento inicia libre
    }

    public override string ToString()
    {
        // Representación textual del asiento (ej: "Asiento 5 - Libre")
        return $"Asiento {Numero} - {(Ocupado ? "Ocupado" : "Libre")}";
    }
}
