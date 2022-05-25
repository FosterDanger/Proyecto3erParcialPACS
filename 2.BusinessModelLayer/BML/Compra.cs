using DALL;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BML
{
    public class Compra
    {
        private DataAccess dataAccess = DataAccess.Instance();
        public int idDetalleCompra { get; set; }
        public Decimal costoUnitario { get; set; }
        public int cantidad { get; set; }
        public int idEntrada { get; set; }
        public int idLibro { get; set; }
        public int idProveedor { get; set; }
        public DateTime fecha { get; set; }
        public Decimal total { get; set; }
        public String codigoCompra { get; set; }
        public bool activo { get; set; }
        public int codigo { get; set; }

        public Compra()
        { 
        
        }

        public int Add()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@fecha", fecha);
            parameters.Add("@total", total);
            parameters.Add("@costoUnitario", costoUnitario);
            parameters.Add("@cantidad", cantidad);
            parameters.Add("@idLibro", idLibro);
            parameters.Add("@idProveedor", idProveedor);
            return dataAccess.Execute("stp_compras_add", parameters);
        }
    }
}
