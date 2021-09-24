using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_Colegio
{
    class Administrador : Persona
    {
        //Propiedades de administrador
        public string Documento { set; get; }
        public string Usuario { set; get; }
        public string Password { set; get; }

        //Constructor
        public Administrador() : base()
        {
            this.Documento = "";
            this.Usuario = "";
            this.Password = "";
        }
    }
}
