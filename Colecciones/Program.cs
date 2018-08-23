using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Alumno> alumnos = new List<Alumno>();
            Alumno alumno1 = new Alumno();

            alumno1.Nombre = "Jose Perez";
            alumno1.Materias.Add(new Materia("Historia", "HST741"));
            alumno1.Materias.Add(new Materia("Matematicas", "MTM789"));
            alumno1.Materias.Add(new Materia("Civismo", "CVS756"));

            //los alumnos de arriba se agregaron a la lista ya que estaban guardados en una variable
            alumnos.Add(alumno1);

            foreach(Alumno elemento in alumnos)
            {
                Console.WriteLine("Nombre: " + elemento.Nombre);
                foreach (Materia materia in elemento.Materias)
                {
                    Console.WriteLine("Materia: " + materia.Nombre);
                }
            }
            Console.ReadLine();

        }
    }
}
