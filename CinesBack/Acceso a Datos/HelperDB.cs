using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using SistemaCineBack.Acceso_a_Datos.Parametros;
using Cines.Clases.Cine;
using Cines.Clases.Cines.Cine;
using Cines.Clases.Personas;
using Cines.Clases.Ventas;
using System.Globalization;

namespace SistemaCineBack.Acceso_a_Datos
{
    class HelperDB
    {
        private static HelperDB instancia;
        private SqlConnection cnn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=CineFinal35;Integrated Security=True");
        public static HelperDB obtenerInstancia()
        {
            if (instancia == null)
            { instancia = new HelperDB(); }
            return instancia;
        }
        public SqlConnection GetConnection()
        {
            return cnn;
        }
        public static HelperDB GetInstancia()
        {
            if (instancia == null)
                instancia = new HelperDB();
            return instancia;
        }

        public string ConsultarValorSP(string nombreSP)
        {
            string resultado = null;
            cnn.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = cnn;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = nombreSP;
            object valor = comando.ExecuteScalar();
            resultado = valor.ToString();
            cnn.Close();
            return resultado;
        }

        public DataTable Consultar(string nombreSP)
        {
            cnn.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = cnn;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = nombreSP;
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            cnn.Close();
            return tabla;
        }


        public DataTable Consultar(string nombreSP, string param)
        {
            cnn.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = cnn;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = nombreSP;
            comando.Parameters.Add(param);
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            cnn.Close();
            return tabla;
        }
        public DataTable Consultar(string nombreSP, List<Parametro> lParams)
        {
            cnn.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = cnn;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = nombreSP;
            foreach (Parametro p in lParams)
            {
                comando.Parameters.AddWithValue(p.clave, p.valor);
            }
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            cnn.Close();
            return tabla;
        }

        public DataTable ConsultarConParametros(string nombreSP, int funcion)
        {
            cnn.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = cnn;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = nombreSP;
            comando.Parameters.AddWithValue("@FUNCION", funcion);
           
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            cnn.Close();
            return tabla;
        }

        public DataTable ConsultarConParametrosFunciones(string nombreSP, string Pelicula, string Fecha, int Sala)
        {
            cnn.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = cnn;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = nombreSP;
            comando.Parameters.AddWithValue("@pelicula", Pelicula);
            comando.Parameters.AddWithValue("@fecha", Fecha);
            comando.Parameters.AddWithValue("@sala", Sala);
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            cnn.Close();
            return tabla;
        }

        public DataTable ConsultarConParametrosButacas(string nombreSP, string Pelicula, string Fecha, int Sala, int Funcion)
        {
            cnn.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = cnn;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = nombreSP;
            comando.Parameters.AddWithValue("@pelicula", Pelicula);
            comando.Parameters.AddWithValue("@fecha", Fecha);
            comando.Parameters.AddWithValue("@sala", Sala);
            comando.Parameters.AddWithValue("@funcion", Funcion);
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            cnn.Close();
            return tabla;
        }
        public DataTable ConsultarConFechas(string v, DateTime fechaInicio, DateTime fechaFin/*, string nombreCine*/)
        {
            cnn.Open();

            SqlCommand comando = new SqlCommand();
            DataTable dt = new DataTable();
            comando.Connection = cnn;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = v;
            comando.Parameters.AddWithValue("@FechaInicio", fechaInicio);
            comando.Parameters.AddWithValue("@FechaFin", fechaFin);
            //comando.Parameters.AddWithValue("@NombreCine", nombreCine);
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            adapter.Fill(dt);
            cnn.Close();
            return dt;
        }
        public DataTable consultar(string sp)
        {
            DataTable tabla = new DataTable();
            cnn.Open();
            SqlCommand cmd = new SqlCommand(sp, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            tabla.Load(cmd.ExecuteReader());
            cnn.Close();
            return tabla;
        }
        public DataTable consultarConParametros(string sp, string pelicula, string fecha)
        {
            DataTable tabla = new DataTable();
            cnn.Open();
            SqlCommand cmd = new SqlCommand(sp, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Pelicula", pelicula);
            cmd.Parameters.AddWithValue("@Fecha", fecha);
            tabla.Load(cmd.ExecuteReader());
            cnn.Close();
            return tabla;
        }
        public bool ejecutarSql(string spComprobante, string spCliente, Funciones funciones, Clientes cliente, Comprobantes comprobantes)
        {
            bool aux = true;
            SqlTransaction t = null;
            try
            {
                cnn.Open();
                t = cnn.BeginTransaction();
                SqlCommand cmdComprobante = new SqlCommand(spComprobante, cnn, t);
                cmdComprobante.CommandType = CommandType.StoredProcedure;
                cmdComprobante.Parameters.AddWithValue("@fecha", funciones.Fecha);
                SqlParameter pClienteOut = new SqlParameter();
                pClienteOut.ParameterName = "@idCliente";
                pClienteOut.SqlDbType = SqlDbType.Int;
                pClienteOut.Direction = ParameterDirection.Output;
                cmdComprobante.Parameters.Add(pClienteOut);
                SqlParameter pIdComprobanteOut = new SqlParameter();
                pIdComprobanteOut.ParameterName = "@idComprobante";
                pIdComprobanteOut.SqlDbType = SqlDbType.Int;
                pIdComprobanteOut.Direction = ParameterDirection.Output;
                cmdComprobante.Parameters.Add(pClienteOut);
                int idCliente = (int)pClienteOut.Value;
                int idComprobante = (int)pIdComprobanteOut.Value;

                SqlCommand cmdCliente = new SqlCommand(spCliente, cnn, t);
                cmdCliente.CommandType = CommandType.StoredProcedure;
                cmdCliente.Parameters.AddWithValue("@nombre", cliente.persona.Nombre);
                cmdCliente.Parameters.AddWithValue("@apellido", cliente.persona.Apellido);
                cmdCliente.Parameters.AddWithValue("@tipo_doc", 1);
                cmdCliente.Parameters.AddWithValue("@documento", cliente.NroDocumento);
                cmdCliente.Parameters.AddWithValue("@telefono", cliente.Telefono);
                cmdCliente.Parameters.AddWithValue("@email", cliente.Mail);
                cmdCliente.Parameters.AddWithValue("@idCliente", idCliente);


                SqlCommand cmdDetalle = new SqlCommand("", cnn, t);
                cmdDetalle.CommandType = CommandType.StoredProcedure;
                cmdDetalle.Parameters.AddWithValue("", "");
            }
            catch (Exception)
            {
                aux = false;
                t.Rollback();
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
            t.Commit();
            return aux;
        }
        public int obtenerProximoId()
        {
            SqlCommand cmd = new SqlCommand();
            cnn.Open();
            cmd.Connection = cnn;
            cmd.CommandText = "SP_PROXIMO_ID";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter pOut = new SqlParameter();
            pOut.ParameterName = "@next";
            pOut.DbType = DbType.Int32;
            pOut.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(pOut);
            cmd.ExecuteNonQuery();
            cnn.Close();
            return (int)pOut.Value;
        }
        //Metodo Traer Butacas
        public DataTable obtenerBut(string fechaFuncion, string pelicula, int Sala, string Hora)
        {
            cnn.Open();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("ObtenerButacasDisponiblesConInfo", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@FechaFuncion", fechaFuncion));
            cmd.Parameters.Add(new SqlParameter("@Titulo", pelicula));
            cmd.Parameters.Add(new SqlParameter("@HoraFuncion", Hora));
            cmd.Parameters.Add(new SqlParameter("@id_Sala", Sala));
            dt.Load(cmd.ExecuteReader());
            cnn.Close();
            return dt;


        }
        public void Open()
        {
            if (cnn.State != ConnectionState.Open)
                cnn.Open();
        }

        public void Close()
        {
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
        }


    }
}

   
