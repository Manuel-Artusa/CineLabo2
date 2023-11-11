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
                decimal puntaje = decimal.Parse(fila["TotalGastado"].ToString());

                Cliente cliente = new Cliente(idliente, persona, tipodocumentos, documento, telefono, mail, puntaje);
            }
            return listaClientes;
        }
        public List<Cliente> ObtenerClientesPuntajeGenero(string genero)
        {
            List<Cliente> clientes = new List<Cliente>();
            string sp = "SP_CONSULTAR_CLIENTES_POR_GENERO_PUNTAJE";

            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@GeneroPelicula", genero));
            DataTable dt = DbHelper.GetInstancia().Consultar(sp, lst);

            foreach (DataRow row in dt.Rows)
            {
                Cliente cliente = new Cliente();
                cliente.IdCliente = int.Parse(row["ID_CLIENTE"].ToString());

                string nombre = row["NOMBRE_CLINTE"].ToString();
                string apellido = row["APELLIDO_CLIENTE"].ToString();

                Persona persona = new Persona(nombre, apellido);
                cliente.Persona = persona;
                int idtipodoc = int.Parse(row["ID_TIPO_DOC"].ToString());
                string tipodoc = row["TIPO"].ToString();

                TipoDocumentos tipodocumentos = new TipoDocumentos(idtipodoc, tipodoc);
                cliente.documento = tipodocumentos;
                cliente.NroDocumento = int.Parse(row["DOCUMENTO"].ToString());

                cliente.Telefono = int.Parse(row["Telefono"].ToString());
                cliente.Mail = row["Mail"].ToString();

                cliente.Puntaje = decimal.Parse(row["TotalGastado"].ToString());

                clientes.Add(cliente);


            }
            return clientes;
        }
    }
}
