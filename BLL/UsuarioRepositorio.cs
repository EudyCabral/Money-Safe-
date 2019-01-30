using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;

namespace BLL
{
    public class UsuarioRepositorio : Repositorio<Usuarios>
    {
        public void Verificar(string usuario, string contrasena)
        {
             Repositorio<Usuarios> BLL = new Repositorio<Usuarios>();
            Expression<Func<Usuarios, bool>> filtrar = x => true;

            Usuarios user = new Usuarios();

            filtrar = t => t.Usuario.Equals(usuario) && t.Contraseña.Equals(contrasena);

            if (BLL.GetList(filtrar).Count() != 0)
                FormsAuthentication.RedirectFromLoginPage(user.Usuario, true);
            else
            {
               
                return;
            }
        }
    }
}
