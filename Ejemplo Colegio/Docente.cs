using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_Colegio
{
    class Docente : Persona
    {
        //Propiedades de docente
        public string Documento { set; get; }
        public string Materia { set; get; }
        public string Nivel { set; get; }

        //Constructor
        public Docente() : base()
        {
            this.Documento = "";
            this.Materia = "";
            this.Nivel = "";
        }
    }
}
