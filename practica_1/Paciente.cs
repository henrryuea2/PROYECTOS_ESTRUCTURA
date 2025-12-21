namespace practica_1
{
    public class Paciente
    {
        public string Nombre { get; set; }
        public string DNI { get; set; }
        public string Telefono { get; set; }

        public override string ToString() => $"{Nombre} (DNI: {DNI})";
    }
}

