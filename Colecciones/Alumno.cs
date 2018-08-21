using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
    class Alumno
    {
        public string Matricula { get; set; }
        public string Nombre { get; set; }

        public List<Materia> Materias { get; set; }

        //constructor se llama igual que la clase
        //Inicia la lista de materias
        public Alumno() //este es el constructor
        {
            Materias = new List<Materia>();
        }
    }
}
