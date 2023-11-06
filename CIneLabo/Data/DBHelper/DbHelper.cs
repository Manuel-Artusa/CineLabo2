using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIneLabo.Entidades.Personas;.Data.DBHelper
{
    public class DbHelper
    {

        private static DbHelper instancia = null;
        private SqlConnection conexion;
        private DbHelper()
        {
            conexion = new SqlConnection();
        }

        public SqlConnection GetConnection()
        {
            return conexion;
        }
        public static DbHelper GetInstancia()
        {
            if (instancia == null)
                instancia = new DbHelper();
            return instancia;
        }


        public DataTable Consultar(string nombreSP)
        {
            conexion.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = nombreSP;
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            conexion.Close();
            return tabla;
        }

    }
}
