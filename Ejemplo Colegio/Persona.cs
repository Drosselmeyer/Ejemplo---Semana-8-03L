using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_Colegio
{
    abstract class Persona
    {
        //Propiedades comunes
        public int Id { set; get; }
        public string Nombre { set; get; }
        public string FechaNac { set; get; }

        //Declaramos el constructor
        public Persona()
        {
            this.Id = 0;
            this.Nombre = "";
            this.FechaNac = "";
        }
    }
}
