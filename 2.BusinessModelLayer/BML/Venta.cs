using DALL;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BML
{
    public class Venta
    {
        private DataAccess dataAccess = DataAccess.Instance();
        public int idVenta { get; set; }
        public int idUsuario { get; set; }
        public DateTime fecha { get; set; }
        public Decimal subtotal { get; set; }
        public Decimal descuento { get; set; }
        public Decimal total { get; set; }
        public String estado { get; set; }
        public int codigo { get; set; }
        public String codigoVenta { get; set; }

        public Venta()
        { 
        
        }
        public int Add()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idUsuario", idUsuario);
            parameters.Add("@subtotal", subtotal);
            parameters.Add("descuento", descuento);
            parameters.Add("total", total);
            return dataAccess.Execute("stp_ventas_add", parameters);
        }

        public IEnumerable<Venta> GetAll()
        {
            return dataAccess.Query<Venta>("stp_ventas_getall");
        }

        public IEnumerable<String> GetProxCod()
        {
            return dataAccess.Query<String>("stp_ventas_getProxCod");
        }

        public int CancelarVenta()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idVenta", idVenta);
            return dataAccess.Execute("stp_cancelarventa_add", parameters);
        }

    }
}
