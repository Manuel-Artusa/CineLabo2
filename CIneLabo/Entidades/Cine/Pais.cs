using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIneLabo.Entidades.Cine
{
    public class Pais
    {
        public int IdPais { get; set; }
        public string Paises { get; set; }

        public Pais()
        {
            IdPais = 0;
            Paises = string.Empty;
        }

        public Pais(int id, string pais)
        {
            IdPais = id;
            Paises = pais;
             
        }
    }
}
