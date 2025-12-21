using System;

namespace practica_1
{
    class Program
    {
        static AgendaTurnos miAgenda = new AgendaTurnos();

        static void Main(string[] args)
        {
            bool correr = true;
            while (correr)
            {
                Console.Clear();
                Console.WriteLine("=== AGENDA CLÍNICA: PRACTICA_1 ===");
                Console.WriteLine("1. Agendar Turno");
                Console.WriteLine("2. Ver Agenda");
                Console.WriteLine("3. Cancelar Turno");
                Console.WriteLine("4. Salir");
                Console.Write("\nSeleccione una opción: ");

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
            Console.Write("Nombre: "); string n = Console.ReadLine();
            Console.Write("DNI: "); string d = Console.ReadLine();
            Console.Write("Especialidad: "); string e = Console.ReadLine();
            Console.Write("Fecha (yyyy-MM-dd HH:mm): ");
            
            if (DateTime.TryParse(Console.ReadLine(), out DateTime f))
            {
                Paciente p = new Paciente { Nombre = n, DNI = d };
                if (miAgenda.Registrar(f, p, e)) Console.WriteLine("✅ Turno agendado.");
                else Console.WriteLine("❌ Horario no disponible.");
            }
            else Console.WriteLine("❌ Fecha incorrecta.");
            Pausa();
        }

        static void MenuVer()
        {
            Console.WriteLine("\nTURNOS PROGRAMADOS:");
            foreach (var t in miAgenda.Listar()) Console.WriteLine(t);
            Pausa();
        }

        static void MenuBorrar()
        {
            Console.Write("Ingrese DNI para cancelar: ");
            if (miAgenda.Cancelar(Console.ReadLine())) Console.WriteLine("✅ Cancelado.");
            else Console.WriteLine("❌ No encontrado.");
            Pausa();
        }

        static void Pausa() { Console.WriteLine("\nPresione una tecla..."); Console.ReadKey(); }
    }
}