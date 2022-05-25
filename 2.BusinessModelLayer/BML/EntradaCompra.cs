using DALL;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BML
{
    public class EntradaCompra
    {
        private DataAccess dataAccess = DataAccess.Instance();

        public int idEntrada { get; set; }
        public DateTime fecha { get; set; }
        public Decimal total { get; set; }
        public bool activo { get; set; }
        public int codigo { get; set; }
        public String codigoCompra { get; set; }
        public String estado { get; set; }

        public EntradaCompra()
        { 

        }

        public int Add()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@fecha", fecha);
            parameters.Add("total", total);
            return dataAccess.Execute("stp_entradascompras_add", parameters);
        }

        public IEnumerable<EntradaCompra> GetAll()
        {
            return dataAccess.Query<EntradaCompra>("stp_entradascompras_getall");
        }

        public IEnumerable<String> GetProxCod()
        {
            return dataAccess.Query<String>("stp_entradascompras_getProxCod");
        }

        public int CancelarCompra()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idEntrada", idEntrada);
            return dataAccess.Execute("stp_cancelarcompra_add", parameters);
        }
    }
}
