using DALL;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BML
{
    public class Estudiante
    {
        private DataAccess dataAccess = DataAccess.Instance();
        
        public int idEstudiante { get; set; }
        public String correoElectronico { get; set; }
        public String telefono { get; set; }
        public String numControl { get; set; }
        public String nombre { get; set; }
        public String apellido { get; set; }
        public int activo { get; set; }

        public Estudiante()
        { 
        
        }

        public int Add()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@correoElectronico", correoElectronico);
            parameters.Add("@telefono", telefono);
            parameters.Add("@numControl", numControl);
            parameters.Add("@nombre", nombre);
            parameters.Add("@apellido", apellido);
            return dataAccess.Execute("stp_estudiantes_add", parameters);
        }

        public int Delete()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idEstudiante", idEstudiante);
            return dataAccess.Execute("stp_estudiantes_delete", parameters);
        }

        public IEnumerable<Estudiante> GetAll()
        {
            return dataAccess.Query<Estudiante>("stp_estudiantes_getall");
        }

        public Estudiante GetById()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idEstudiante", idEstudiante);
            return dataAccess.QuerySingle<Estudiante>("stp_estudiantes_getbyid", parameters);
        }

        public int Update()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idEstudiante", idEstudiante);
            parameters.Add("@correoElectronico", correoElectronico);
            parameters.Add("@telefono", telefono);
            parameters.Add("@numControl", numControl);
            parameters.Add("@nombre", nombre);
            parameters.Add("@apellido", apellido);
            return dataAccess.Execute("stp_estudiantes_update", parameters);
        }
    }
}
