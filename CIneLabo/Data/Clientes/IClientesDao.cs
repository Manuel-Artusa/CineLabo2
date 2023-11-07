using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CIneLabo.Entidades.Personas;

namespace CIneLabo.Data.Clientes
{
    public interface IClientesDao
    {
        public List<Cliente> ObtenerPuntajes(List<Parametro> lParams, string nombreSP);
    }
}
