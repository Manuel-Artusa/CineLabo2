using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CIneLabo.Entidades.Personas;.

namespace CIneLabo.Entidades.Personas;.Data.Clientes
{
    internal interface IClientesDao
    {
        public List<Clientes> ObtenerComponentes();
    }
}
