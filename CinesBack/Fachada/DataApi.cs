using Cines.Clases.Cine;
using Cines.Clases.Cines.Cine;
using Cines.Clases.Ventas;
using SistemaCineBack.Acceso_a_Datos.Dao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinesBack.Fachada
{
    public class DataApi : IDataApi
    {
        IDao dao;
        public DataApi()
        {
            dao = new DaoCine();
        }
        public List<Comprobantes> obtenerComprobantes()
        {
            return dao.TraerComprobantes();
        }

        public List<DetalleComprobante> obtenerDetalleComprobantes()
        {
            return dao.TraerDetalle();
        }

        public DataTable obtenerInformeVentasPorMes(int mes, int anio)
        {
            return dao.obtenerInformeVentasPorMes(mes, anio);
        }

        public List<Butacas> TraerButacas(string Fecha, string pelicula, int sala, string hora)
        {
            return dao.TraerButacas(Fecha, pelicula,sala,hora);
        }
    

        public List<Funciones> TraerFunciones(string pelicula, string fechita)
        {
            return dao.TraerFunciones(pelicula, fechita);
        }

        public List<Peliculas> TraerPeliculas()
        {
            return dao.TraerPeliculas(); 
        }

        public Peliculas traerPeliculasId(int id)
        {
            return dao.TraerPeliculaPorId(id);
        }
    }
}
