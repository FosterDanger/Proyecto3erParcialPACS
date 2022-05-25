using DALL;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BML
{
    public class Editorial
    {
        private DataAccess dataAccess = DataAccess.Instance();

        public int idEditorial { get; set; }
        public String nombre { get; set; }

        public Editorial()
        {

        }
        public int Add()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@nombre", nombre);
            return dataAccess.Execute("stp_editoriales_add", parameters);
        }

        public int Delete()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idEditorial", idEditorial);
            return dataAccess.Execute("stp_editoriales_delete", parameters);
        }

        public IEnumerable<Editorial> GetAll()
        {
            return dataAccess.Query<Editorial>("stp_editoriales_getall");
        }

        public Editorial GetById()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idEditorial", idEditorial);
            return dataAccess.QuerySingle<Editorial>("stp_editoriales_getbyid", parameters);
        }

        public int Update()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idEditorial", idEditorial);
            parameters.Add("@nombre", nombre);
            return dataAccess.Execute("stp_editoriales_update", parameters);
        }
    }
}
