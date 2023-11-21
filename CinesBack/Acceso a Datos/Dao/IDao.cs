using Cines.Clases.Cine;
using Cines.Clases.Cines;
using Cines.Clases.Cines.Cine;
using Cines.Clases.Cines.Cines;
using Cines.Clases.Ventas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCineBack.Acceso_a_Datos.Dao
{
   public  interface IDao
    {
        bool crear(Funciones funcion);
        bool borrar(Funciones funcion);
        int proximoID();
        List<DetalleComprobante> TraerDetalle();
        List<Comprobantes> TraerComprobantes();
        DataTable obtenerInformeVentasPorMes(int Mes, int Anio);
        List<Peliculas> TraerPeliculas();
        List<Butacas> TraerButacas(string fechaSeleccionada, string? peliculaSelccionada);
        List<Funciones> TraerFunciones(string pelicula, string fechita);
        public Peliculas TraerPeliculaPorId(int idPelicula);
        public List<Comprobantes> obtenerComprobantesParametros(int nroDoc, string apellido);
    }
}
