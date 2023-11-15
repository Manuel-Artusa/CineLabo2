using CIneLabo.Entidades.Ventas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIneLabo.Data.DBHelper.Ventas
{
    public class DaoInformeVentas: IDaoInformeVentas
    {
        public List<DetalleComprobante> TraerDetalle()
        {
            List<DetalleComprobante> ldetalles = new List<DetalleComprobante>();
            DataTable dt = DbHelper.GetInstancia().Consultar("SP_CONSULTAR_DETALLES");
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
        public List<Comprobantes> TraerComprobantes()
        {
            List<Comprobantes> lcomprobantes = new List<Comprobantes>();
            DataTable dt = DbHelper.GetInstancia().Consultar("SP_CONSULTAR_COMPROBANTES");
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

        public DataTable ObtenerDatosInformeVentasPorMes(DateTime fechaInicio, DateTime fechaFin)
        {
            DataTable informeVentas = DbHelper.GetInstancia().ConsultarInformeVentas("InformeVentasPorMes",fechaInicio,fechaFin);
            return informeVentas;

            
        }
    }
}
