using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIneLabo.Entidades.Cine
{
    public class Butacas
    {
        public int IdButaca { get; set; }
        public int NroButaca { get; set; }
        public int Fila { get; set; }

        public Salas sala { get; set; }


        public Butacas()
        {
            IdButaca = 0;
            NroButaca = 0;
            Fila = 0;
            Sala = new Salas();

        }
        public Butacas(int Id, int Nro,int fila, Salas sala)
        {
            IdButaca = Id;
            NroButaca = Nro;
            Fila = fila;
            Sala = sala;
        }
    }
}
