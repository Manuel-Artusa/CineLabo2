using Cines.Clases.Cines.Cine;
using SistemaCineBack.Acceso_a_Datos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cines.Clases.Cine;
using Cines.Clases.Ventas;
using System.Runtime.Intrinsics.Arm;
using Cines.Clases.Ubicacion;

namespace CinesBack.Acceso_a_Datos.Dao
{
    public class DaoCine
    {
        public bool Crear(Comprobantes comprobante)
        {
            bool resultado = true;
            SqlConnection conexion = HelperDB.GetInstancia().GetConnection();
            SqlTransaction t = null;
            try
            {
                conexion.Open();
                t = conexion.BeginTransaction();
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion;
                comando.Transaction = t;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "SP_INSERTAR_MAESTRO";
                comando.Parameters.AddWithValue("@nombre", comprobante.cliente.persona.Nombre);
                comando.Parameters.AddWithValue("@nombre", comprobante.cliente.persona.Apellido);
                comando.Parameters.AddWithValue("@fecha", comprobante.fecha);


                SqlParameter parametro = new SqlParameter();
                parametro.ParameterName = "@presupuesto_nro";
                parametro.SqlDbType = SqlDbType.Int;
                parametro.Direction = ParameterDirection.Output;
                comando.Parameters.Add(parametro);

                comando.ExecuteNonQuery();

                int presupuestoNro = (int)parametro.Value;
                int detalleNro = 1;
                SqlCommand cmdDetalle;

                foreach (DetalleComprobante dc in comprobante.Detalle)
                {
                    cmdDetalle = new SqlCommand("SP_INSERTAR_DETALLE", conexion, t);
                    cmdDetalle.CommandType = CommandType.StoredProcedure;
                    cmdDetalle.Parameters.AddWithValue("@id_comprobante", comprobante.IdComprobante);
                    cmdDetalle.Parameters.AddWithValue("@id_funcion", dc.funcione.IdFuncion);
                    cmdDetalle.Parameters.AddWithValue("@id_sala", dc.funcione.sala.IdSala);
                    cmdDetalle.Parameters.AddWithValue("@pelicula", dc.funcione.pelicula);                    
                    cmdDetalle.Parameters.AddWithValue("@id_butaca", dc.funcione.butacas);
                    cmdDetalle.Parameters.AddWithValue("@precio", dc.precio);

                    cmdDetalle.ExecuteNonQuery();
                    detalleNro++;
                }
                t.Commit();
            }
            catch
            {
                if (t != null)
                    t.Rollback();
                resultado = false;
            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                    conexion.Close();
            }

            return resultado;
        }

        public List<DetalleComprobante> TraerDetalle()
        {
            List<DetalleComprobante> ldetalles = new List<DetalleComprobante>();
            DataTable dt = HelperDB.GetInstancia().consultar("SP_CONSULTAR_FUNCIONES");
            foreach (DataRow r in dt.Rows)
            {
                DetalleComprobante dc = new DetalleComprobante();
                dc.IdDetalleComprobante = Convert.ToInt32(r["ID_DET_COMPROBANTE"].ToString());                
                dc.funcione.IdFuncion = Convert.ToInt32(r["id_funcion"].ToString());
                dc.butacaXfuncion.IdButacasFuncion = Convert.ToInt32(r["id_butacas_funcion"].ToString());
                dc.formaPago.IdFormaPago = Convert.ToInt32(r["id_forma_pago"].ToString());
                dc.precio = Convert.ToDouble(r["Precio"].ToString());

                ldetalles.Add(dc);
            }
            return ldetalles;
        }

        public List<Comprobantes> TraerComprobantes()
        {
            List<Comprobantes> lcomprobantes = new List<Comprobantes>();
            DataTable dt = HelperDB.GetInstancia().consultar("SP_CONSULTAR_COMPROBANTES");
            foreach (DataRow r in dt.Rows)
            {
                Comprobantes c = new Comprobantes();
                c.IdComprobante = Convert.ToInt32(r["ID"].ToString());
                c.cliente.IdCliente = Convert.ToInt32(r["ID_CLIENTE"].ToString());
                c.empleado.IdEmpleado = Convert.ToInt32(r["ID_EMPLEADO"].ToString());
                c.fecha = Convert.ToDateTime(r["FECHA"].ToString());
                c.cine.IdCines = Convert.ToInt32(r["ID_CINE"].ToString());
                c.forma.IdFormaCompra = Convert.ToInt32(r["ID_FORMA_COMPRA"].ToString());

                lcomprobantes.Add(c);
            }
            return lcomprobantes;
        }

        public int proximoID()
        {
            return HelperDB.GetInstancia().obtenerProximoId();
        }

        
        public List<Funciones> TraerFunciones(string pelicula, string fechita)
        {
            List<Funciones> lFunciones = new List<Funciones>();

            DataTable funciones = HelperDB.GetInstancia().ConsultarFuncionConParametros("SP_CONSULTAR_FUNCIONES", pelicula, fechita);
            foreach (DataRow r in funciones.Rows)
            {
                Funciones f = new Funciones();
                //Los IF son para que no me acpete valores Nulos

                if (int.TryParse(r["ID_FUNCION"].ToString(), out int idFuncion))
                    f.IdFuncion = idFuncion;

                if (TimeSpan.TryParse(r["HORA"].ToString(), out TimeSpan hora))
                    f.Hora = hora;

                if (DateTime.TryParse(r["FECHA"].ToString(), out DateTime fecha))
                    f.Fecha = fecha;

                if (int.TryParse(r["ID_PELICULA"].ToString(), out int idPelicula))
                {
                    f.pelicula = TraerPeliculaPorId(idPelicula); // Agregar este método
                    f.pelicula.IdPelicula = idPelicula;
                }


                if (double.TryParse(r["PRECIO_ACTUAL"].ToString(), out double precio))
                    f.Precio = precio;

                lFunciones.Add(f);
            }

            return lFunciones;
        }
        
        public DataTable obtenerInformeVentasPorMes(int mes, int anio)
        {
            DataTable dataTable = new DataTable();

            try
            {
                // Obtén la instancia del HelperDB
                HelperDB helper = HelperDB.GetInstancia();

                // Abre la conexión
                helper.Open();

                // Crea un nuevo SqlCommand con la conexión del HelperDB
                SqlCommand cmd = new SqlCommand("InformeVentasPorMes");
                cmd.CommandType = CommandType.StoredProcedure;

                // Agrega los parámetros
                cmd.Parameters.AddWithValue("@Mes", mes);
                cmd.Parameters.AddWithValue("@Anio", anio);

                // Crea un SqlDataAdapter y llena el DataTable
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener informe de ventas: " + ex.ToString());
            }
            finally
            {
                // Cierra la conexión en el bloque finally para asegurarse de que se cierre incluso si hay una excepción.
                HelperDB.GetInstancia().Close();
            }

            return dataTable;
        }
        public List<Peliculas> TraerPeliculas()
        {
            List<Peliculas> lpeliculas = new List<Peliculas>();

            DataTable peliculas = HelperDB.GetInstancia().consultar("SP_CONSULTAR_PELICULAS");
            foreach (DataRow r in peliculas.Rows)
            {
                Peliculas p = new Peliculas();
                //Los IF son para que no me acpete valores Nulos

                if (int.TryParse(r["ID_PELICULA"].ToString(), out int id))
                    p.IdPelicula = id;

                p.Titulo = r["TITULO"].ToString();

                if (int.TryParse(r["ID_GENERO"].ToString(), out int idGenero))
                    p.Genero.IdGenero = idGenero;

                if (TimeSpan.TryParse(r["DURACION"].ToString(), out TimeSpan duracion))
                    p.Duracion = duracion;

                if (int.TryParse(r["ID_CLASIFICACION"].ToString(), out int idClasificacion))
                    p.clasificacion.Id_clasificacion = idClasificacion;

                if (int.TryParse(r["ID_IDIOMA"].ToString(), out int idIdioma))
                    p.Idioma.Id_Idioma = idIdioma;

                if (int.TryParse(r["ID_PAIS_ORIGEN"].ToString(), out int idPais))
                    p.Pais.IdPais = idPais;

                lpeliculas.Add(p);
            }

            return lpeliculas;
        }
        public List<Peliculas> ObtenerPeliculas()
        {
            List<Peliculas> lPeliculas = new List<Peliculas>();
            DataTable table = HelperDB.GetInstancia().Consultar("SP_CONSULTAR_PELICULAS_DETALLADO2");

            foreach (DataRow fila in table.Rows)
            {
                int idPeli = int.Parse(fila["ID_PELICULA"].ToString());
                string titulo = fila["TITULO"].ToString();
                TimeSpan duracion = TimeSpan.Parse(fila["Duracion"].ToString());

                int idGenero = int.Parse(fila["id_genero"].ToString());
                string nombreGenero = fila["NombreGenero"].ToString();
                Genero genero = new Genero(idGenero, nombreGenero);

                int idClasificacion = int.Parse(fila["id_clasificacion"].ToString());
                string descripcion = fila["DescripcionClasificacion"].ToString();
                Clasificacion clasificacion = new Clasificacion(idClasificacion, descripcion);

                int idIdioma = int.Parse(fila["id_idioma"].ToString());
                string lenguaje = fila["Lenguaje"].ToString();
                Idioma idioma = new Idioma(idIdioma, lenguaje);

                DateTime fecEstreno = DateTime.Parse(fila["Fec_Estreno"].ToString());
                ;
                int idPais = int.Parse(fila["ID_PAIS_ORIGEN"].ToString());
                string pais = fila["pais"].ToString();
                PaisOrigen paises = new PaisOrigen(idPais, pais);

                Peliculas pelicula = new Peliculas(idPeli, titulo, duracion, genero, clasificacion, idioma, fecEstreno, paises);
                lPeliculas.Add(pelicula);
            }
            return lPeliculas;
        }

        public Peliculas TraerPeliculaPorId(int idPelicula)
        {
            List<Peliculas> lpeliculas = TraerPeliculas();
            Peliculas peliculaEncontrada = lpeliculas.FirstOrDefault(p => p.IdPelicula == idPelicula);
            return peliculaEncontrada;

        }
    }
}
