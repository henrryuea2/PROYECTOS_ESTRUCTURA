using System;
using System.Collections.Generic;
using System.Linq;

namespace practica_1
{
    public class Turno
    {
        // Defino qué componentes tiene un turno: un horario, un paciente y el médico
        public DateTime FechaHora { get; set; }
        public Paciente Paciente { get; set; }
        public string Especialidad { get; set; }

        // Configuro cómo se verá el renglón del turno cuando lo imprima en pantalla
        public override string ToString() => 
            $"{FechaHora:dd/MM/yyyy HH:mm} | {Especialidad,-15} | {Paciente}";
    }

    public class AgendaTurnos
    {
        // Declaro una lista privada donde voy a ir guardando todos los turnos que genere
        private List<Turno> _listaTurnos = new List<Turno>();

        public bool Registrar(DateTime fecha, Paciente pac, string esp)
        {
            // Primero verifico si ya existe un turno en ese horario para no chocar
            if (_listaTurnos.Any(t => t.FechaHora == fecha)) return false;

            // Si el horario está libre, creo el objeto turno y lo coloco en mi lista
            _listaTurnos.Add(new Turno { FechaHora = fecha, Paciente = pac, Especialidad = esp });
            
            // Reordeno la lista por fecha para que siempre el turno más cercano salga primero
            _listaTurnos = _listaTurnos.OrderBy(t => t.FechaHora).ToList();
            return true;
        }

        // Simplemente devuelvo la lista completa para que el programa la pueda mostrar
        public List<Turno> Listar() => _listaTurnos;

        public bool Cancelar(string dni)
        {
            // Busco el primer turno que coincida con el DNI que me pasaron
            var item = _listaTurnos.FirstOrDefault(t => t.Paciente.DNI == dni);
            
            // Si lo encuentro, lo quito de mi lista de turnos activos
            if (item != null)
            {
                _listaTurnos.Remove(item);
                return true;
            }
            return false;
        }
    }
}