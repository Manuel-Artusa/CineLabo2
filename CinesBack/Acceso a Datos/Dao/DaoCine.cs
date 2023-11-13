using Cines.Clases.Cine;
using Cines.Clases.Cines;
using Cines.Clases.Cines.Cine;
using Cines.Clases.Cines.Cines;
using Cines.Clases.Ventas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCineBack.Acceso_a_Datos.Dao
{
    public class DaoCine : IDao
    {
        public bool borrar(Funciones funcion)
        {
            throw new NotImplementedException();
        }




        public List<Asientos> consultarAsientos()
        {
            throw new NotImplementedException();
        }

        public bool crear(Funciones funcion)
        {
            return HelperDB.obtenerInstancia().ejecutarSql("", "", funcion);
        }

        public int proximoID()
        {
            return HelperDB.obtenerInstancia().obtenerProximoId();
        }

        public List<Butacas> TraerButacas()
        {

            return HelperDB.obtenerInstancia().TraerButacas(DateTime.Now, "", TimeSpan.Zero);

        }

        public List<Butacas> TraerButacas(DateTime fechaSeleccionada, string? peliculaSelccionada, TimeSpan hora)
        {
            return HelperDB.obtenerInstancia().TraerButacas(fechaSeleccionada, peliculaSelccionada, hora);
        }
        //Metodo Para COMPROBANTES
        public List<Comprobantes> TraerComprobantes()
        {
            List<Comprobantes> lcomprobantes = new List<Comprobantes>();
            DataTable dt = HelperDB.obtenerInstancia().consultar("SP_CONSULTAR_COMPROBANTES");
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

        //Metodo Para COMPROBANTES
        public List<DetalleComprobante> TraerDetalle()
        {
            List<DetalleComprobante> ldetalles = new List<DetalleComprobante>();
            DataTable dt = HelperDB.obtenerInstancia().consultar("SP_CONSULTAR_FUNCIONES");
            foreach (DataRow r in dt.Rows)
            {
                DetalleComprobante dc = new DetalleComprobante();
                dc.IdDetalleComprobante = Convert.ToInt32(r["ID_DET_COMPROBANTE"].ToString());
                dc.comprobante.IdComprobante = Convert.ToInt32(r["id_comprobante"].ToString());
                dc.funcione.IdFuncion = Convert.ToInt32(r["id_funcion"].ToString());
                dc.butacaXfuncion.IdButacasFuncion = Convert.ToInt32(r["id_butacas_funcion"].ToString());
                dc.formaPago.IdFormaPago = Convert.ToInt32(r["id_forma_pago"].ToString());
                dc.precio = Convert.ToDouble(r["Precio"].ToString());

                ldetalles.Add(dc);
            }
            return ldetalles;
        }
        public Peliculas TraerPeliculaPorId(int idPelicula)
        {
            List<Peliculas> lpeliculas = TraerPeliculas();
            Peliculas peliculaEncontrada = lpeliculas.FirstOrDefault(p => p.IdPelicula == idPelicula);
            return peliculaEncontrada;

        }
        //Metodo Para Funciones
        public List<Funciones> TraerFunciones(string pelicula, string fechita)
        {
            List<Funciones> lFunciones = new List<Funciones>();

            DataTable funciones = HelperDB.obtenerInstancia().consultarConParametros("SP_CONSULTAR_FUNCIONES",pelicula,fechita);
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

                if (int.TryParse(r["ID_SALA"].ToString(), out int idSala))
                    f.sala.IdSala = idSala;

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
        //Metodo Para Peliculas
        public List<Peliculas> TraerPeliculas()
        {
            List<Peliculas> lpeliculas = new List<Peliculas>();

            DataTable peliculas = HelperDB.obtenerInstancia().consultar("SP_CONSULTAR_PELICULAS");
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

        public DataTable obtenerInformeVentasPorMes(int mes, int anio)
        {
            DataTable dataTable = new DataTable();

            try
            {
                // Obtén la instancia del HelperDB
                HelperDB helper = HelperDB.obtenerInstancia();

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
                HelperDB.obtenerInstancia().Close();
            }

            return dataTable;
        }
    }
}