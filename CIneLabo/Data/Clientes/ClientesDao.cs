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
        public List<Cliente> ObtenerPuntajes(List<Parametro> lParams, string nombreSP)
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

        public List<Cliente> ObtenerClientes()
        {
            List<Cliente> listaClientes = new List<Cliente>();
            DataTable tabla = DbHelper.GetInstancia().Consultar("SP_OBTENER_CLIENTES_DETALLADO");

            foreach (DataRow fila in tabla.Rows)
            {
                int idliente = int.Parse(fila["ID_CLIENTE"].ToString());

                string nombre = fila["NOMBRE_CLINTE"].ToString();
                string apellido = fila["APELLIDO_CLIENTE"].ToString();

                Persona persona = new Persona(nombre, apellido);

                int idtipodoc = int.Parse(fila["ID_TIPO_DOC"].ToString());
                string tipodoc = fila["TIPO"].ToString();

                TipoDocumentos tipodocumentos = new TipoDocumentos(idtipodoc, tipodoc);

                int documento = int.Parse(fila["DOCUMENTO"].ToString());

                int telefono = int.Parse(fila["Telefono"].ToString());
                string mail = fila["Mail"].ToString();

                Cliente cliente = new Cliente(idliente, persona, tipodocumentos, documento, telefono, mail);
            }
            return listaClientes;
        }

    }
}
