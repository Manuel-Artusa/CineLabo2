using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CIneLabo.Entidades.Ubicacion;

namespace CIneLabo.Entidades.Cine
{
    public class Cines
    {
        public int IdCines { get; set; }
        public Barrios Barrios { get; set; }

        public string Cine { get; set; }

        public Cines()
        {
            IdCines = 0;
            Barrios = new Barrios();
            Cine = string.Empty;
        }
        public Cines(int id, Barrios bar, string nombre)
        {
            IdCines = id;
            Barrios = bar;
            Cine = nombre;
            
        }
    }
}
