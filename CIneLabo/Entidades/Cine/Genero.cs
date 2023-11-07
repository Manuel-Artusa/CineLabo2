using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIneLabo.Entidades.Cine
{
    public class Genero
    {
        private int IdGenero { get; set; }
        private string genero { get; set; }

        public Genero()
        {
            IdGenero = 0;
            genero = string.Empty;
        }

        public Genero(int id, string gen)
        {
            IdGenero = id;
            genero = gen;
             
        }
    }
}
