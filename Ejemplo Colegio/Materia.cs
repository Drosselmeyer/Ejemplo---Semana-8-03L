using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_Colegio
{
    class Materia
    {
        //Propiedades
        public int Id { set; get; }
        public string Nombre { set; get; }
        public double Nota { set; get; }

        //Constructor
        public Materia()
        {
            this.Id = 0;
            this.Nombre = "";
            this.Nota = 0;
        }
    }
}
