using CIneLabo.Entidades.Ventas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIneLabo.Data.DBHelper.Ventas
{
    public interface IDaoInformeVentas
    {
        public List<DetalleComprobante> TraerDetalle();
        public List<Comprobantes> TraerComprobantes();

        public DataTable ObtenerDatosInformeVentasPorMes(DateTime fechaInicio, DateTime fechaFin);
    }
}
