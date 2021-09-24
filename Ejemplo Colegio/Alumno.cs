using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_Colegio
{
    class Alumno : Persona
    {
        //Propiedades solo del alumno
        public string Grado { set; get; }
        public string Seccion { set; get; }

        //Constructor
        public Alumno()
        {
            this.Id = 0;
            this.Nombre = "";
            this.FechaNac = "";
            this.Grado = "";
            this.Seccion = "";
        }
    }
}
