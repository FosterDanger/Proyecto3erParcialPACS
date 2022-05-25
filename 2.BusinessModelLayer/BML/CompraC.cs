using DALL;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BML
{
    public class CompraC
    {
        private DataAccess dataAccess = DataAccess.Instance();
        public int idEntrada { get; set; }
        public int cantidadDisponible { get; set; }
        public int cantidad { get; set; }
        public Decimal costoUnitario { get; set; }
        public String codigoCompra { get; set; }
        public String codigoLibro { get; set; }
        public String nombre { get; set; }
        public String estado { get; set; }
        public Decimal total { get; set; }

        public CompraC()
        {

        }

        public IEnumerable<CompraC> GetAll()
        {
            return dataAccess.Query<CompraC>("stp_comprasc_getall");
        }

        public int CancelarCompra()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idEntrada", idEntrada);
            return dataAccess.Execute("stp_cancelarcompra_add", parameters);
        }
    }
}
