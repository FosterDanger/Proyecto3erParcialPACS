using DALL;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BML
{
    public class Usuario
    {
        private DataAccess dataAccess = DataAccess.Instance();

        public int idUsuario { get; set; }
        public String usuario { get; set; }
        public String password { get; set; }
        public String nombre { get; set; }
        public String apellido { get; set; }
        public String correo { get; set; }
        public String tipoUsuario { get; set; }
        public bool activo { get; set; }


        public Usuario()
        {

        }

        public int Add()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@usuario", usuario);
            parameters.Add("@password", password);
            parameters.Add("@nombre", nombre);
            parameters.Add("@apellido", apellido);
            parameters.Add("@correo", correo);
            parameters.Add("@tipoUsuario", tipoUsuario);
            return dataAccess.Execute("stp_usuarios_add", parameters);
        }

        public int Delete()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idUsuario", idUsuario);
            return dataAccess.Execute("stp_usuarios_delete", parameters);
        }

        public IEnumerable<Usuario> GetAll()
        {
            return dataAccess.Query<Usuario>("stp_usuarios_getall");
        }

        public Usuario GetUsuario()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@usuario", usuario);
            parameters.Add("@password",password);
            return dataAccess.QuerySingle<Usuario>("stp_usuariosmostrat_getall", parameters);
        }

        public Usuario GetById()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idUsuario", idUsuario);
            return dataAccess.QuerySingle<Usuario>("stp_usuarios_getbyid", parameters);
        }

        public Usuario Login()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@usuario", usuario);
            parameters.Add("@password", password);
            return dataAccess.QuerySingleOrDefault<Usuario>("stp_usuarios_login", parameters);
        }

        public int Update()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idUsuario", idUsuario);
            parameters.Add("@usuario", usuario);
            parameters.Add("@password", password);
            parameters.Add("@nombre", nombre);
            parameters.Add("@apellido", apellido);
            parameters.Add("@correo", correo);
            parameters.Add("@tipoUsuario", tipoUsuario);
            return dataAccess.Execute("stp_usuarios_update", parameters);
        }



    }
}
