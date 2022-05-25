using DALL;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BML
{
    public class DetalleVenta
    {
        private DataAccess dataAccess = DataAccess.Instance();

        public int idDetalleVenta { get; set; }
        public int idVenta { get; set; }
        public int idLibro { get; set; }
        public int cantidad { get; set; }
        public Decimal precio { get; set; }
        public Decimal importe { get; set; }

        public DetalleVenta()
        { 
        
        }

        public int Add()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idLibro", idLibro);
            parameters.Add("cantidad", cantidad);
            parameters.Add("precio", precio);
            parameters.Add("importe", importe);
            return dataAccess.Execute("stp_detalleventas_add", parameters);
        }

        public IEnumerable<DetalleVenta> GetAll()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idVenta", idVenta);
            return dataAccess.Query<DetalleVenta>("stp_detalleventas_getall", parameters);
        }
    }
}
