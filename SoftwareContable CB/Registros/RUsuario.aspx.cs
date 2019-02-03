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
                usuarioid.Text = "0";
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
            confirmarpwd.Text = usuarios.Contraseña;

        }

        private void Limpiar()

        {
            usuarioid.Text = "0";
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

            if (string.IsNullOrWhiteSpace(usuarioid.Text))
            {
                usuarioid.Text = "0";
            }
           
                Usuarios usuario = repositorio.Buscar(Convert.ToInt32(usuarioid.Text));
       
            
            if (usuario != null)
            {
                LlenaCampos(usuario);

                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script:
               "toastr.success('Encontrado','Exito',{ 'progressBar': true,'positionClass': 'toast-bottom-right'});", addScriptTags: true);
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script:
             "toastr.info('Numero de Registro de Usuario no Existe','No Existe',{ 'progressBar': true,'positionClass': 'toast-bottom-right'});", addScriptTags: true);
            }
        }

        protected void ButtonGuardar_Click(object sender, EventArgs e)
        {
            Repositorio<Usuarios> repositorio = new Repositorio<Usuarios>();

            Usuarios usuarios = LlenaClase();

            bool paso = false;

            if (Page.IsValid)
            {
                if (usuarioid.Text == "0")
                {
                    paso = repositorio.Guardar(usuarios);

                }

                else
                {
                    var verificar = repositorio.Buscar(util.Toint(usuarioid.Text));

                    if (verificar != null)
                    {
                        paso = repositorio.Modificar(usuarios);
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script:
                     "toastr.error('Usuario No Existe','Exito',{ 'progressBar': true,'positionClass': 'toast-bottom-right'});", addScriptTags: true);
                        return;
                    }
                }

                if (paso)

                {
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script:
                     "toastr.success('Usuario Registrado','Exito',{ 'progressBar': true,'positionClass': 'toast-bottom-right'});", addScriptTags: true);

                }

                else

                {
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script:
                 "toastr.error('No pudo Guardar','Fallo',{ 'progressBar': true,'positionClass': 'toast-bottom-right'});", addScriptTags: true);
                }
                Limpiar();
                return;
            }

        }

        protected void ButtonEliminar_Click(object sender, EventArgs e)
        {
            Repositorio<Usuarios> repositorio = new Repositorio<Usuarios>();


            if (string.IsNullOrWhiteSpace(usuarioid.Text))
            {
                usuarioid.Text = "0";
            }

            int id = Convert.ToInt32(usuarioid.Text);
            var usuario = repositorio.Buscar(id);


            if (usuario == null)
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script:
               "toastr.info('Este Numero de Usuario no Existe','Informacion',{ 'progressBar': true,'positionClass': 'toast-bottom-right'});", addScriptTags: true);
            }
       
            else
            {
                repositorio.Eliminar(id);

             

                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script:
               "toastr.success('Usuario a sido Borrado','Eliminado',{ 'progressBar': true,'positionClass': 'toast-bottom-right'});", addScriptTags: true);
                Limpiar();
            }

        }

      
    }
}