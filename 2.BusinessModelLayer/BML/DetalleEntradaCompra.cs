using DALL;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BML
{
    public class DetalleEntradaCompra
    {
        private DataAccess dataAccess = DataAccess.Instance();
        public int idDetalleEntrada { get; set; }
        public Decimal costoUnitario { get; set; }
        public int cantidad { get; set; }
        public int idEntrada { get; set; }
        public int idLibro { get; set; }
        public int idProveedor { get; set; }

        public DetalleEntradaCompra()
        { 
        
        }

        public int Add()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@costoUnitario", costoUnitario);
            parameters.Add("cantidad", cantidad);
            parameters.Add("idLibro", idLibro);
            parameters.Add("idProveedor", idProveedor);
            return dataAccess.Execute("stp_detalleentradascompras_add", parameters);
        }

        public IEnumerable<DetalleEntradaCompra> GetAll()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idEntrada", idEntrada);
            return dataAccess.Query<DetalleEntradaCompra>("stp_detalleentradascompras_getall",parameters);
        }
    }
}
