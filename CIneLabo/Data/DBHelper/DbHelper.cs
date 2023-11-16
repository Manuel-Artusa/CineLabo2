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
            conexion = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=cine2;Integrated Security=True");
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


        public DataTable Consultar(string nombreSP, string param)
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

        public DataTable ConsultarConParametros(string nombreSP, string Pelicula, string Fecha)
        {
            conexion.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = nombreSP;
            comando.Parameters.AddWithValue("@pelicula", Pelicula);
            comando.Parameters.AddWithValue("@fecha", Fecha);
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            conexion.Close();
            return tabla;
        }

        public DataTable ConsultarConParametrosFunciones(string nombreSP, string Pelicula, string Fecha, int Sala)
        {
            conexion.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = nombreSP;
            comando.Parameters.AddWithValue("@pelicula", Pelicula);
            comando.Parameters.AddWithValue("@fecha", Fecha);
            comando.Parameters.AddWithValue("@sala", Sala);
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            conexion.Close();
            return tabla;
        }

        public DataTable ConsultarConParametrosButacas(string nombreSP, string Pelicula, string Fecha, int Sala, int Funcion)
        {
            conexion.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = nombreSP;
            comando.Parameters.AddWithValue("@pelicula", Pelicula);
            comando.Parameters.AddWithValue("@fecha", Fecha);
            comando.Parameters.AddWithValue("@sala", Sala);
            comando.Parameters.AddWithValue("@funcion", Funcion);
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            conexion.Close();
            return tabla;
        }
        public DataTable ConsultarConFechas(string v, DateTime fechaInicio, DateTime fechaFin/*, string nombreCine*/)
        {
            conexion.Open();

            SqlCommand comando = new SqlCommand();
            DataTable dt = new DataTable();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = v;
            comando.Parameters.AddWithValue("@FechaInicio", fechaInicio);
            comando.Parameters.AddWithValue("@FechaFin", fechaFin);
            //comando.Parameters.AddWithValue("@NombreCine", nombreCine);
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            adapter.Fill(dt);
            conexion.Close();
            return dt;
        }
        public string ConsultarValorSP(string nombreSP)
        {
            string resultado = null;
            conexion.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = nombreSP;
            object valor = comando.ExecuteScalar();
            resultado = valor.ToString();
            conexion.Close();
            return resultado;
        }


    }
}