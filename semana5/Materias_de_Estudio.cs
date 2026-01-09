using System;
using System.Collections.Generic;

namespace semana5
{
    class Materias_De_Estudio
    {
        private List<string> materias;

        public Materias_De_Estudio()
        {
            materias = new List<string>();
            materias.Add("Matematicas");
            materias.Add("Fisica");
            materias.Add("Quimica");
            materias.Add("Historia");
            materias.Add("Lengua");
        }

        public void MostrarMaterias()
        {
            foreach (string materia in materias)
            {
                Console.WriteLine("Yo estudio " + materia);
            }
        }
    }
}