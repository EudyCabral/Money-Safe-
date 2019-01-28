using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
            UsuarioRepositorio repositorio = new UsuarioRepositorio();
                
                repositorio.Verificar(TextBoxenterUsuario.Text, TextBoxcontrasena.Text);
        }
    }
}