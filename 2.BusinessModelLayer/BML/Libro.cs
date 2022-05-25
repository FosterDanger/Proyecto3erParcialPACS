using DALL;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BML
{
    public class Libro
    {
        private DataAccess dataAccess = DataAccess.Instance();

        public int idLibro { get; set; }
        public String nombre { get; set; }
        public int idAutor { get; set; }
        public int idEditorial { get; set; }
        public int idCategoria { get; set; }
        public Decimal precioUnitario { get; set; }
        public DateTime fechaLanzamiento { get; set; }
        public String ventaPrestamo { get; set; }
        public bool activo { get; set; }
        public int codigo { get; set; }
        public String codigoLibro { get; set; }
        public Libro()
        {

        }

        public int Add()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@nombre", nombre);
            parameters.Add("@idAutor", idAutor);
            parameters.Add("@idEditorial", idEditorial);
            parameters.Add("@idCategoria", idCategoria);
            parameters.Add("@precioUnitario", precioUnitario);
            parameters.Add("@fechaLanzamiento", fechaLanzamiento);
            return dataAccess.Execute("stp_libros_add", parameters);
        }

        public int Delete()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idLibro", idLibro);
            return dataAccess.Execute("stp_libros_delete", parameters);
        }

        public IEnumerable<Libro> GetAll()
        {
            return dataAccess.Query<Libro>("stp_libros_getall");
        }

        public IEnumerable<String> GetProxCod()
        {
            return dataAccess.Query<String>("stp_libros_getProxCod");
        }

        public Libro GetById()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idLibro", idLibro);
            return dataAccess.QuerySingle<Libro>("stp_libros_getbyid", parameters);
        }

        public Libro GetByDescripcion()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@nombre", nombre);
            parameters.Add("@idLibro", idLibro);
            return dataAccess.QuerySingle<Libro>("stp_libros_getbydescripcion", parameters);
        }

        public int Update()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idLibro", idLibro);
            parameters.Add("@nombre", nombre);
            parameters.Add("@idAutor", idAutor);
            parameters.Add("@idEditorial", idEditorial);
            parameters.Add("@idCategoria", idCategoria);
            parameters.Add("@precioUnitario", precioUnitario);
            parameters.Add("@fechaLanzamiento", fechaLanzamiento);
            return dataAccess.Execute("stp_libros_update", parameters);
        }
    }
}
