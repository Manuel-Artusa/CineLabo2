using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIneLabo.Entidades.Ubicacion
{
    public class Barrios : Localidades
    {
        public int idBarrio { get; set; }
        public string barrio { get; set; }

        public Localidades Localidad { get; set; }

        public Barrios()
        {
            idBarrio = 0;
            barrio = string.Empty;
            Localidad = new Localidades();
        }
        public Barrios(int id,string bar, Localidades loc )
        {
             idBarrio = id;
            barrio = bar;
            Localidad = loc;
        }

    }
}
