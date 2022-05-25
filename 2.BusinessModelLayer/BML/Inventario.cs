using DALL;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BML
{
    public class Inventario
    {
        private DataAccess dataAccess = DataAccess.Instance();

        public int idInventario { get; set; }
        public int idProducto { get; set; }
        public int cantidadDisponible { get; set; }

        public Inventario()
        {

        }

        public int Add()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idProducto", idProducto);
            parameters.Add("@cantidad", cantidadDisponible);
            return dataAccess.Execute("stp_inventarios_add", parameters);
        }

        public int AddVenta()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idProducto", idProducto);
            parameters.Add("@cantidad", cantidadDisponible);
            return dataAccess.Execute("stp_inventariosventa_add", parameters);
        }

        public IEnumerable<Inventario> GetAll()
        {
            return dataAccess.Query<Inventario>("stp_inventarios_getall");
        }

        public Inventario GetById()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idProducto", idProducto);
            return dataAccess.QuerySingle<Inventario>("stp_inventarios_getById", parameters);
        }
    }
}
