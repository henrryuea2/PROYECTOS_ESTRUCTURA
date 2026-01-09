using System;

namespace practica_1
{
    class Program
    {
        // Instancio mi clase AgendaTurnos para poder usar todas sus funciones
        static AgendaTurnos miAgenda = new AgendaTurnos();

        static void Main(string[] args)
        {
            bool correr = true;
            // Creo un bucle para que el programa no se cierre hasta que yo lo decida
            while (correr)
            {
                Console.Clear();
                Console.WriteLine("=== MI AGENDA MÉDICA ===");
                Console.WriteLine("1. Agendar Turno\n2. Ver Agenda\n3. Cancelar\n4. Salir");
                Console.Write("\nElijo la opción: ");

                // Recibo la opción y decido qué menú disparar
                string opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1": MenuCrear(); break;
                    case "2": MenuVer(); break;
                    case "3": MenuBorrar(); break;
                    case "4": correr = false; break;
                }
            }
        }

        static void MenuCrear()
        {
            // Aquí le pido al usuario que escriba los datos
            Console.Write("Nombre: "); string n = Console.ReadLine();
            Console.Write("DNI: "); string d = Console.ReadLine();
            Console.Write("Especialidad: "); string e = Console.ReadLine();
            Console.Write("Fecha (año-mes-dia hora:min): ");
            
            // Intento convertir lo que escribió el usuario a un formato de fecha real
            if (DateTime.TryParse(Console.ReadLine(), out DateTime f))
            {
                // Si la fecha es válida, creo al paciente y lo mando a registrar a la agenda
                Paciente p = new Paciente { Nombre = n, DNI = d };
                if (miAgenda.Registrar(f, p, e)) Console.WriteLine("✅ ¡Listo! Turno guardado.");
                else Console.WriteLine(" Error: Ese horario ya está ocupado.");
            }
            else Console.WriteLine(" Pusiste mal la fecha.");
            Pausa();
        }

        static void MenuVer()
        {
            // Recorro la lista de turnos y los voy imprimiendo uno por uno
            Console.WriteLine("\nESTO ES LO QUE TENEMOS HOY:");
            foreach (var t in miAgenda.Listar()) Console.WriteLine(t);
            Pausa();
        }

        static void MenuBorrar()
        {
            // Pido el DNI, se lo paso a la lógica y aviso si se pudo borrar o no
            Console.Write("DNI del paciente a quitar: ");
            if (miAgenda.Cancelar(Console.ReadLine())) Console.WriteLine("✅ Turno eliminado.");
            else Console.WriteLine(" No encontré a nadie con ese DNI.");
            Pausa();
        }

        // Un pequeño método para que el programa se detenga y me deje leer lo que pasó
        static void Pausa() { Console.WriteLine("\nPresiona algo para volver..."); Console.ReadKey(); }
    }
}