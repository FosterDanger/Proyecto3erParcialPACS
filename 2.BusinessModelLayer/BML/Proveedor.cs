using DALL;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BML
{
    public class Proveedor
    {
        private DataAccess dataAccess = DataAccess.Instance();

        public int idProveedor { get; set; }
        public String nombreProveedor { get; set; }
        public String nombreContacto { get; set; }
        public String cargoContacto { get; set; }
        public String calle { get; set; }
        public String colonia { get; set; }
        public String codigoPostal { get; set; }
        public String ciudad { get; set; }
        public String telefono { get; set; }
        public String email { get; set; }

        public Proveedor()
        { 

        }

        public int Add()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@nombreProveedor", nombreProveedor);
            parameters.Add("@nombreContacto", nombreContacto);
            parameters.Add("@cargoContacto", cargoContacto);
            parameters.Add("@calle", calle);
            parameters.Add("@colonia", colonia);
            parameters.Add("@codigoPostal", codigoPostal);
            parameters.Add("@ciudad", ciudad);
            parameters.Add("@telefono", telefono);
            parameters.Add("@email", email);
            return dataAccess.Execute("stp_proveedores_add", parameters);
        }

        public int Delete()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idProveedor", idProveedor);
            return dataAccess.Execute("stp_proveedores_delete", parameters);
        }

        public IEnumerable<Proveedor> GetAll()
        {
            return dataAccess.Query<Proveedor>("stp_proveedores_getall");
        }

        public Proveedor GetById()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idProveedor", idProveedor);
            return dataAccess.QuerySingle<Proveedor>("stp_proveedores_getbyid", parameters);
        }

        public Proveedor GetByDescripcion()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@nombreProveedor", nombreProveedor);
            return dataAccess.QuerySingle<Proveedor>("stp_proveedores_getbydescripcion", parameters);
        }

        public int Update()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idProveedor", idProveedor);
            parameters.Add("@nombreProveedor", nombreProveedor);
            parameters.Add("@nombreContacto", nombreContacto);
            parameters.Add("@cargoContacto", cargoContacto);
            parameters.Add("@calle", calle);
            parameters.Add("@colonia", colonia);
            parameters.Add("@codigoPostal", codigoPostal);
            parameters.Add("@ciudad", ciudad);
            parameters.Add("@telefono", telefono);
            parameters.Add("@email", email);
            return dataAccess.Execute("stp_proveedores_update", parameters);
        }
    }
}
