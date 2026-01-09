namespace practica_1
{
    public class Paciente
    {
        // Aquí defino qué datos básicos quiero guardar de cada persona
        public string Nombre { get; set; }
        public string DNI { get; set; }
        public string Telefono { get; set; }

        // Sobrescribo este método para que, cuando quiera mostrar al paciente,
        // aparezca su nombre en mayúsculas y su DNI al lado automáticamente
        public override string ToString() => $"{Nombre.ToUpper()} (DNI: {DNI})";
    }
}
