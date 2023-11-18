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

namespace SistemaCineBack.Acceso_a_Datos
{
    class HelperDB
    {
        private static HelperDB instancia;
        private SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-72P6KAS\SQLEXPRESS;Initial Catalog=cine2;Integrated Security=True");
        public static HelperDB obtenerInstancia()
        {
            if (instancia == null)
            { instancia = new HelperDB(); }
            return instancia;
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
        public DataTable consultarConParametros(string sp,string pelicula, string fecha)
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
        public bool ejecutarSql(string spMaestro, string spDetalle, Funciones funciones)
        {
            bool aux = true;
            SqlTransaction t = null;
            try
            {
                cnn.Open();
                t = cnn.BeginTransaction();
                SqlCommand cmd = new SqlCommand(spMaestro, cnn, t);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("", "");
                SqlParameter param = new SqlParameter();
                param.ParameterName = "";
                param.SqlDbType = SqlDbType.Int;
                param.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(param);
                int id = (int)param.Value;

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
        public List<Butacas> TraerButacas(string fechaFuncion, string pelicula)
        {
            List<Butacas> lButacas = new List<Butacas>();

            try
            {
               
                
                    cnn.Open();

                    using (SqlCommand cmd = new SqlCommand("ButacasDisponiblesXfuncion", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@FechaFuncion", fechaFuncion));
                        cmd.Parameters.Add(new SqlParameter("@Pelicula", pelicula));
                        //cmd.Parameters.Add(new SqlParameter("@HoraFuncion", Hora.Ticks));
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                if (reader["ID_BUTACA"] != DBNull.Value && reader["NRO_BUTACA"] != DBNull.Value && reader["FILA"] != DBNull.Value)
                                {
                                    int id = (int)reader["ID_BUTACA"];
                                    int nro = (int)reader["NRO_BUTACA"];
                                    int fila = (int)reader["FILA"];
                                    lButacas.Add(new Butacas(id, nro, fila));
                                }
                            }
                        }
                    }
                
            }
            catch (Exception ex)
            {
                // Manejar la excepción 
            }

            return lButacas;
           
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
