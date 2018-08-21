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
            Alumno alumno = new Alumno();
            alumno.Nombre = "Juan Perez";
            alumno.Matricula = "194536";

            Materia matematicas = new Materia();
            matematicas.Nombre = "Matematicas";
            matematicas.Identificador = "MT12358";

            alumno.Materias.Add(new Materia());
            alumno.Materias.Add(matematicas);

            alumno.Materias[0].Nombre = "Historia";
            alumno.Materias[0].Identificador = "HT96465";

            alumno.Materias.Add(new Materia());
            alumno.Materias[2].Nombre = "Español";
            alumno.Materias[2].Identificador = "ES852";

            /*alumno.Materias.RemoveAt(1); // 3. eliminar una materia
            alumno.Materias.RemoveAt(1); // se recorre al siguiente elemento y se borra
            alumno.Materias.Clear(); // 4. eliminar todas las materias */

            Console.WriteLine("Alumno: " + alumno.Nombre);

            /*1.
             * Console.WriteLine("Primera Materia: " + alumno.Materias[0].Nombre);
            Console.WriteLine("Segunda Materia: " + alumno.Materias[1].Nombre); */

            //hasta aqui AGREGAR

            //2. sigue contar las materias y con el ciclo se van a mencionar también

            Console.WriteLine("Numero de materias: " + alumno.Materias.Count);
            /*2. 
             * for(int i = 0; i < alumno.Materias.Count; i++)
            {
                Console.WriteLine("Materia: " + alumno.Materias[i].Nombre);
            }*/


            //5.igual resultado que con el ciclo for
            foreach(Materia materia in alumno.Materias)
            {
                Console.WriteLine("Materia: " + materia.Nombre);
            }

            Console.ReadLine();
        }
    }
}
