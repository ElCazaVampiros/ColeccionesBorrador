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

            Alumno alumno = new Alumno();
            alumno.Nombre = "Juan Perez";
            alumno.Matricula = "172543";

            Alumno alumno2 = new Alumno();
            alumno2.Nombre = "Sebas gei";
            alumno2.Matricula = "34642";

            Alumno alumno3 = new Alumno();
            alumno3.Nombre = "Pedro perez";
            alumno3.Matricula = "867453";

            Alumno alumno4 = new Alumno();
            alumno4.Nombre = "sktt1 faker";
            alumno4.Matricula = "343912";


            Materia matematicas = new Materia();
            matematicas.Nombre = "Matematicas";
            matematicas.Identificador = "MT2341";

            alumno.Materias.Add(new Materia());
            alumno.Materias.Add(matematicas);

            alumno.Materias[0].Nombre = "Historia";
            alumno.Materias[0].Identificador = "HT2313";

            alumno.Materias.Add(new Materia());
            alumno.Materias[2].Nombre = "Español";
            alumno.Materias[2].Identificador = "ESP231";

            /*alumno.Materias.Add(new Materia());
            alumno2.Materias[0].Nombre = "Fisica";
            alumno2.Materias[0].Identificador = "FS523";*/

            alumno.Materias.Add(new Materia());
            alumno2.Materias[1].Nombre = "Ingles";
            alumno2.Materias[1].Identificador = "ING234";

            alumno.Materias.Add(new Materia());
            alumno2.Materias[2].Nombre = "Español";
            alumno2.Materias[2].Identificador = "ESP421";

            alumno.Materias.Add(new Materia());
            alumno3.Materias[0].Nombre = "Programacion";
            alumno3.Materias[0].Identificador = "PRO245";

            alumno.Materias.Add(new Materia());
            alumno3.Materias[1].Nombre = "Quimica";
            alumno3.Materias[1].Identificador = "Q245";

            alumno.Materias.Add(new Materia());
            alumno3.Materias[2].Nombre = "Foto";
            alumno3.Materias[2].Identificador = "FT243";

            alumno.Materias.Add(new Materia());
            alumno4.Materias[0].Nombre = "Japones";
            alumno4.Materias[0].Identificador = "JP523";

            alumno.Materias.Add(new Materia());
            alumno4.Materias[1].Nombre = "Energias";
            alumno4.Materias[1].Identificador = "EG363";

            alumno.Materias.Add(new Materia());
            alumno4.Materias[2].Nombre = "Mecatronica";
            alumno4.Materias[2].Identificador = "ME6532";


            // alumno.Materias.RemoveAt(1);
            // alumno.Materias.RemoveAt(1);
            // alumno.Materias.Clear();

            Console.WriteLine("Alumno: " + alumno.Nombre);
            Console.WriteLine("Numero de materias " + alumno.Materias.Count);

            foreach (Materia materia in alumno.Materias)
            {
                Console.WriteLine("Materia: " + materia.Nombre);
            }

            Console.WriteLine("Alumno: " + alumno2.Nombre);
            Console.WriteLine("Numero de materias " + alumno2.Materias.Count);

            foreach (Materia materia in alumno2.Materias)
            {
                Console.WriteLine("Materia: " + materia.Nombre);
            }

            Console.ReadLine();
        }
    }
}
