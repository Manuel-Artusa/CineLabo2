using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CIneLabo.Entidades.Personas;
using CIneLabo.Data.DBHelper;
using System.Data.SqlClient;

namespace CIneLabo.Data.Clientes
{
    internal class ClientesDao : IClientesDao
    {
        public List<Cliente> ObtenerPuntajes(List<Parametro> lParams,string nombreSP)
        {
            List<Cliente> lstClientes = new List<Cliente>();

            DataTable tabla = DbHelper.GetInstancia().Consultar(nombreSP, lParams);

            foreach (DataRow r in tabla.Rows)
            {
                string nombre = r["NOMBRE_CLIENTE"].ToString();
                string apellido = r["APELLIDO_CLIENTE"].ToString();
                double puntaje = Convert.ToDouble(r["Puntaje"].ToString());
                lstClientes.Add(new Cliente());
            }

            return lstClientes;
        }
    }
}
