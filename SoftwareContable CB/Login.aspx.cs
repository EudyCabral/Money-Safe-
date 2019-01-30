using BLL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SoftwareContable_CB
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonLogin_Click(object sender, EventArgs e)
        {
            var usuario = new Usuarios();
            UsuarioRepositorio repositorio = new UsuarioRepositorio();

            Expression<Func<Usuarios, bool>> filtrar = x => true;
            

            Usuarios user = new Usuarios();
            


            if (TextBoxcontrasena.Text != "" && TextBoxenterUsuario.Text !="")
            {
                if (repositorio.Verificar(TextBoxenterUsuario.Text, TextBoxcontrasena.Text))
                {

                    FormsAuthentication.RedirectFromLoginPage(user.Usuario, true);

                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script:
               "toastr.error('Usuario y/o Contraseña Incorrectas','Fallido',{ 'progressBar': true,'positionClass': 'toast-bottom-right'});", addScriptTags: true);
                }

            }
            else
            {

                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script:
              "toastr.error('Favor de llenar Casilla Usuario y contraseña','Fallido',{ 'progressBar': true,'positionClass': 'toast-bottom-right'});", addScriptTags: true);
            }

        }

  

    }
}