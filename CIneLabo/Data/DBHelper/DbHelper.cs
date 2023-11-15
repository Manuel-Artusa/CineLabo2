using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace CIneLabo.Data.DBHelper
{
    public class DbHelper
    {

        private static DbHelper instancia = null;
        private SqlConnection conexion;
        private DbHelper()
        {
            conexion = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=cine5;Integrated Security=True");
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
        public DataTable Consultar(string nombreSP,string param)
        {
            conexion.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = nombreSP;
            comando.Parameters.Add(param);
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            conexion.Close();
            return tabla;
        }
        public DataTable Consultar(string nombreSP, List<Parametro> lParams)
        {
            conexion.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = nombreSP;
            foreach (Parametro p in lParams)
            {
                comando.Parameters.AddWithValue(p.Nombre, p.Valor);
            }
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            conexion.Close();
            return tabla;
        }

        public DataTable ConsultarInformeVentas(string v, DateTime fechaInicio, DateTime fechaFin)
        {
            conexion.Open();

            SqlCommand comando = new SqlCommand();
            DataTable dt = new DataTable();
            comando.Connection = conexion;
            comando.CommandType= CommandType.StoredProcedure;
            comando.CommandText = v;
            comando.Parameters.AddWithValue("@FechaInicio", fechaInicio);
            comando.Parameters.AddWithValue("@FechaFin", fechaFin);
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            adapter.Fill(dt);
            return dt;
        }
    }
}
