using System;
using System.Collections.Generic;
using System.Linq;

namespace practica_1
{
    public class Turno
    {
        public DateTime FechaHora { get; set; }
        public Paciente Paciente { get; set; }
        public string Especialidad { get; set; }

        public override string ToString() => 
            $"{FechaHora:dd/MM/yyyy HH:mm} | {Especialidad,-15} | {Paciente}";
    }

    public class AgendaTurnos
    {
        private List<Turno> _listaTurnos = new List<Turno>();

        public bool Registrar(DateTime fecha, Paciente pac, string esp)
        {
            if (_listaTurnos.Any(t => t.FechaHora == fecha)) return false;

            _listaTurnos.Add(new Turno { FechaHora = fecha, Paciente = pac, Especialidad = esp });
            _listaTurnos = _listaTurnos.OrderBy(t => t.FechaHora).ToList();
            return true;
        }

        public List<Turno> Listar() => _listaTurnos;

        public bool Cancelar(string dni)
        {
            var item = _listaTurnos.FirstOrDefault(t => t.Paciente.DNI == dni);
            if (item != null)
            {
                _listaTurnos.Remove(item);
                return true;
            }
            return false;
        }
    }
}
