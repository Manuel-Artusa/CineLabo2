using Cines.Clases.Cine;
using Cines.Clases.Cines.Cine;
using Cines.Clases.Ventas;
using CinesBack.Fachada;
using Microsoft.AspNetCore.Mvc;

namespace CinesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
      public class CineController : ControllerBase
        {
            private IDataApi dataApi;
            public CineController()
            {
                dataApi = new DataApi();
            }
            [HttpGet("/Peliculas")]
            public ActionResult getPeliculas()
            {
                try
                {
                    List<Peliculas> lstPeliculas = dataApi.TraerPeliculas();
                    return Ok(lstPeliculas);
                }
                catch (Exception)
                {

                    return StatusCode(500, "Error Interno, Intente mas Tarde");
                }
            }
            [HttpGet("/Comprobantes")]
            public ActionResult getComprobantes()
            {
                try
                {
                    List<Comprobantes> lstComprobantes = dataApi.obtenerComprobantes();
                    return Ok(lstComprobantes);
                }
                catch (Exception)
                {

                    return StatusCode(500, "Error Interno, Intente mas Tarde");
                }
            }
            [HttpGet("/DetalleComprobante")]
            public ActionResult getDetalle()
            {
                try
                {
                    List<DetalleComprobante> lstDetalle = dataApi.obtenerDetalleComprobantes();
                    return Ok(lstDetalle);
                }
                catch (Exception)
                {

                    return StatusCode(500, "Error Interno, Intente mas Tarde");
                }
            }
            [HttpGet("/Butacas")]
            public ActionResult getButacas(string fecha, string pelicula)
            {
                try
                {
                    List<Butacas> lstButacas = dataApi.TraerButacas(fecha, pelicula);
                    return Ok(lstButacas);
                }
                catch (Exception)
                {

                    return StatusCode(500, "Error Interno, Intente mas Tarde");
                }
            }
            [HttpGet("/Funciones")]
            public ActionResult getFunciones(string pelicula, string fechita)
            {
                try
                {
                    List<Funciones> funciones = dataApi.TraerFunciones(pelicula, fechita);
                    return Ok(funciones);
                }
                catch (Exception)
                {

                    return StatusCode(500, "Error Interno, Intente mas Tarde");
                }
            }
            [HttpGet("/Peliculas ID")]
            public ActionResult obtenerPeliculasID(int id)
            {
                try
                {
                    Peliculas p = dataApi.traerPeliculasId(id);
                    return Ok(p);
                }
                catch (Exception)
                {

                    throw;
                }
            }
            [HttpGet("/Informe")]
            public ActionResult obtenerInformes(int mes, int año)
            {
                return Ok(dataApi.obtenerInformeVentasPorMes(mes, año));
            }
            [HttpPost("/Funciones")]
            public IActionResult postFunciones()
            {
                try
                {
                    return Ok();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
}