using BLL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SoftwareContable_CB.Registros
{
    public partial class RUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                FechaTextbox.Text = DateTime.Now.ToString("yyyy-MM-dd");
            }
          
        }

        public void MostrarMensaje(TiposMensaje tipo, string mensaje)

        {

            ErrorLabel.Text = mensaje;



            if (tipo == TiposMensaje.Success)

                ErrorLabel.CssClass = "alert-success";

            else

                ErrorLabel.CssClass = "alert-danger";

        }

        public Usuarios LlenaClase()

        {
            Usuarios usuario = new Usuarios();

            usuario.UsuarioId = Convert.ToInt32(usuarioid.Text);
            usuario.Fecha = Convert.ToDateTime(FechaTextbox.Text);
            usuario.Nombre = nombreTextbox.Text;
            usuario.Cedula = cedulatextbox.Text;
            usuario.Telefono = Telefonoinput.Text;
            usuario.Celular = celularinput.Text;
            usuario.Usuario = Usuarioinput.Text;
            usuario.Email = email.Text;
            usuario.TipodeAcceso = TipodeAccesodrop.Text;
            usuario.Contraseña = pwd.Text;
            return usuario;

        }

        private void LlenaCampos(Usuarios usuarios)

        {

            usuarioid.Text = usuarios.UsuarioId.ToString();
            FechaTextbox.Text = usuarios.Fecha.ToString("yyyy-MM-dd");
            nombreTextbox.Text = usuarios.Nombre;
            cedulatextbox.Text = usuarios.Cedula;
            Telefonoinput.Text = usuarios.Telefono;
            celularinput.Text = usuarios.Celular; 
            Usuarioinput.Text = usuarios.Usuario;
            email.Text = usuarios.Email;
            TipodeAccesodrop.Text = usuarios.TipodeAcceso;
            pwd.Text = usuarios.Contraseña;

        }

        private void Limpiar()

        {
            usuarioid.Text = "";
            FechaTextbox.Text = DateTime.Now.ToString("yyyy-MM-dd");
            nombreTextbox.Text = "";
            cedulatextbox.Text = "";
            Telefonoinput.Text = "";
            celularinput.Text = "";
            Usuarioinput.Text = "";
            email.Text = "";
            TipodeAccesodrop.SelectedValue = null;
            pwd.Text = "";
            confirmarpwd.Text = "";
        }

        protected void ButtonNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        protected void ButtonBuscar_Click(object sender, EventArgs e)
        {
            Repositorio<Usuarios> repositorio = new Repositorio<Usuarios>();
            Usuarios usuario = repositorio.Buscar(Convert.ToInt32(usuarioid.Text));
            if (usuario != null)
            {
                LlenaCampos(usuario);
            }
            else
            {
                Response.Write("<script>alert('Usuario no encontrado');</script>");

            }
        }

        protected void ButtonGuardar_Click(object sender, EventArgs e)
        {
            Repositorio<Usuarios> repositorio = new Repositorio<Usuarios>();

            Usuarios usuarios = LlenaClase();

            bool paso = false;



            //todo: validaciones adicionales

            if (usuarios.UsuarioId == 0)
            {
                paso = repositorio.Guardar(usuarios);

                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['success']('Guardado');", addScriptTags: true);
            }

            else
            {
                paso = repositorio.Modificar(usuarios);
                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['success']('Modificado');", addScriptTags: true);

            }
                if (paso)

                {
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['success']('Guardado');", addScriptTags: true);
                    MostrarMensaje(TiposMensaje.Success, "Registro Exitoso!");


                }

                else

                {
                    MostrarMensaje(TiposMensaje.Error, "No fue posible Guardar el Registro");
                }
            Limpiar();
        }

        protected void ButtonEliminar_Click(object sender, EventArgs e)
        {
            Repositorio<Usuarios> repositorio = new Repositorio<Usuarios>();

            int id = Convert.ToInt32(usuarioid.Text);



            var usuario = repositorio.Buscar(id);



            if (usuario == null)

                MostrarMensaje(TiposMensaje.Error, "Registro no encontrado");

            else

                repositorio.Eliminar(id);
        }


    }
}