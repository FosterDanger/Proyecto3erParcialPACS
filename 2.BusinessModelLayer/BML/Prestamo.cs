using DALL;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BML
{
    public class Prestamo
    {
        private DataAccess dataAccess = DataAccess.Instance();
        public int idPrestamo { get; set; }
        public int idEstudiante { get; set; }
        public int idLibro { get; set; }
        public DateTime fechaPrestamo { get; set; }
        public DateTime fechaReingreso { get; set; }

        public Prestamo()
        { 
        
        }

        public int Add()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idEstudiante", idEstudiante);
            parameters.Add("@idLibro", idLibro);
            parameters.Add("@fechaPrestamo", fechaPrestamo);
            parameters.Add("@fechaReingreso", fechaReingreso);
            return dataAccess.Execute("stp_prestamos_add", parameters);
        }

        public int Delete()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idPrestamo", idPrestamo);
            return dataAccess.Execute("stp_prestamos_delete", parameters);
        }

        public IEnumerable<Prestamo> GetAll()
        {
            return dataAccess.Query<Prestamo>("stp_prestamos_getall");
        }

        public Prestamo GetById()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idPrestamo", idPrestamo);
            return dataAccess.QuerySingle<Prestamo>("stp_prestamos_getbyid", parameters);
        }

        public int Update()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idPrestamo", idPrestamo);
            parameters.Add("@idEstudiante", idEstudiante);
            parameters.Add("@idLibro", idLibro);
            parameters.Add("@fechaPrestamo", fechaPrestamo);
            parameters.Add("@fechaReingreso", fechaReingreso);
            return dataAccess.Execute("stp_prestamos_update", parameters);
        }
    }
}
