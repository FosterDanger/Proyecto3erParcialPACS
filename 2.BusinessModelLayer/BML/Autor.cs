using DALL;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BML
{
    public class Autor
    {
        private DataAccess dataAccess = DataAccess.Instance();

        public int idAutor { get; set; }
        public String nombre { get; set; }
        public String apellido { get; set; }
        public String nacionalidad { get; set; }
        public int activo { get; set; }

        public Autor()
        {

        }

        public int Add()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@nombre", nombre);
            parameters.Add("@nacionalidad", nacionalidad);
            return dataAccess.Execute("stp_autores_add", parameters);
        }

        public int Delete()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idAutor", idAutor);
            return dataAccess.Execute("stp_autores_delete", parameters);
        }

        public IEnumerable<Autor> GetAll()
        {
            return dataAccess.Query<Autor>("stp_autores_getall");
        }

        public Autor GetById()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idAutor", idAutor);
            return dataAccess.QuerySingle<Autor>("stp_autores_getbyid", parameters);
        }

        public int Update()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idAutor", idAutor);
            parameters.Add("@nombre", nombre);
            parameters.Add("@nacionalidad", nacionalidad);
            return dataAccess.Execute("stp_autores_update", parameters);
        }
    }
}
