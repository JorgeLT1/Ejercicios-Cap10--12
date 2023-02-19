using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Capitulo_10
{
   public class Estudiante
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public int Grado { get; set; }

        public override string ToString()
        {
            return $"{Nombre}, {Edad}, {Grado}";
        }
    }

    public class Escuela
    {
        private List<Estudiante> estudiantes;

        public Escuela()
        {
            estudiantes = new List<Estudiante>();
        }

        public void AgregarEstudiante(Estudiante estudiante)
        {
            estudiantes.Add(estudiante);
        }

        public Estudiante BuscarEstudiante(string nombre)
        {
            return estudiantes.Find(e => e.Nombre == nombre);
        }
    }

}
