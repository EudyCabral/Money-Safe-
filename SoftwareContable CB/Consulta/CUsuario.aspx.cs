using BLL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SoftwareContable_CB.Consulta
{
    public partial class CUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                DesdeTextBox.Text = DateTime.Now.ToString("yyyy-MM-dd");
                HastaTextBox.Text = DateTime.Now.ToString("yyyy-MM-dd");

            }
            
        }

        protected void ButtonBuscar_Click(object sender, EventArgs e)
        {
            Expression<Func<Usuarios, bool>> filtro = x => true;
            Repositorio<Usuarios> repositorio = new Repositorio<Usuarios>();

            int id;

            DateTime desde = Convert.ToDateTime(DesdeTextBox.Text);
            DateTime hasta = Convert.ToDateTime(HastaTextBox.Text);

            switch (TipodeFiltro.SelectedIndex)
            {
                case 0://ID
                    id = Convert.ToInt32(TextCriterio.Text);
                    if (CheckBoxFecha.Checked == true)
                    {
                        filtro = x => x.UsuarioId == id && (x.Fecha >= desde && x.Fecha <= hasta);
                    }
                    else
                    {
                        filtro = c => c.UsuarioId == id;
                    }

                    if (repositorio.GetList(filtro).Count() == 0)
                    {
                        ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script:
              "toastr.info('ID no Existe','Informacion',{ 'progressBar': true,'positionClass': 'toast-bottom-right'});", addScriptTags: true);
                        return;
                    }

                    break;

                case 1:// Usuario
                    if (CheckBoxFecha.Checked == true)
                    {
                        filtro = x => x.Usuario.Contains(TextCriterio.Text) && (x.Fecha >= desde && x.Fecha <= hasta);
                    }
                    else
                    {
                        filtro = c => c.Usuario.Contains(TextCriterio.Text);
                    }

                    if (repositorio.GetList(filtro).Count() == 0)
                    {
                        ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script:
              "toastr.info('Usuario no Existe','Informacion',{ 'progressBar': true,'positionClass': 'toast-bottom-right'});", addScriptTags: true);
                        return;
                    }

                    break;

                 

                case 2:// nombre

                    if (CheckBoxFecha.Checked == true)
                    {
                        filtro = x => x.Nombre.Contains(TextCriterio.Text) && (x.Fecha >= desde && x.Fecha <= hasta);
                    }
                    else
                    {
                        filtro = c => c.Nombre.Contains(TextCriterio.Text);
                    }
                    if (repositorio.GetList(filtro).Count() == 0)
                    {
                        ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script:
              "toastr.info('Nombre no Existe','Informacion',{ 'progressBar': true,'positionClass': 'toast-bottom-right'});", addScriptTags: true);
                        return;
                    }
                    break;

                case 3:// Cedula
                    if (CheckBoxFecha.Checked == true)
                    {
                        filtro = x => x.Cedula.Equals(TextCriterio.Text) && (x.Fecha >= desde && x.Fecha <= hasta);
                    }
                    else
                    {
                        filtro = c => c.Cedula.Equals(TextCriterio.Text);
                    }

                    if (repositorio.GetList(filtro).Count() == 0)
                    {
                        ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script:
              "toastr.info('Cedula no Existe','Informacion',{ 'progressBar': true,'positionClass': 'toast-bottom-right'});", addScriptTags: true);
                        return;
                    }
                    break;

                case 4:// Telefono
                    if (CheckBoxFecha.Checked == true)
                    {
                        filtro = x => x.Telefono.Equals(TextCriterio.Text) && (x.Fecha >= desde && x.Fecha <= hasta);
                    }
                    else
                    {
                        filtro = c => c.Telefono.Equals(TextCriterio.Text);
                    }

                    if (repositorio.GetList(filtro).Count() == 0)
                    {
                        ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script:
              "toastr.info('Telefono no Existe','Informacion',{ 'progressBar': true,'positionClass': 'toast-bottom-right'});", addScriptTags: true);
                        return;
                    }

                    break;

                case 5:// Celular
                    if (CheckBoxFecha.Checked == true)
                    {
                        filtro = x => x.Celular.Equals(TextCriterio.Text) && (x.Fecha >= desde && x.Fecha <= hasta);
                    }
                    else
                    {
                        filtro = c => c.Celular.Equals(TextCriterio.Text);
                    }
                    if (repositorio.GetList(filtro).Count() == 0)
                    {
                        ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script:
              "toastr.info('Celular no Existe','Informacion',{ 'progressBar': true,'positionClass': 'toast-bottom-right'});", addScriptTags: true);
                        return;
                    }
                    break;

                case 6:// Email
                    if (CheckBoxFecha.Checked == true)
                    {
                        filtro = x => x.Email.Contains(TextCriterio.Text) && (x.Fecha >= desde && x.Fecha <= hasta);
                    }
                    else
                    {
                        filtro = c => c.Email.Contains(TextCriterio.Text);
                    }

                    if (repositorio.GetList(filtro).Count() == 0)
                    {
                        ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script:
              "toastr.info('Email no Existe','Informacion',{ 'progressBar': true,'positionClass': 'toast-bottom-right'});", addScriptTags: true);
                        return;
                    }
                    break;

                case 7:// TipodeAcceso
                    if (CheckBoxFecha.Checked == true)
                    {
                        filtro = x => x.TipodeAcceso.Contains(TextCriterio.Text) && (x.Fecha >= desde && x.Fecha <= hasta);
                    }
                    else
                    {
                        filtro = c => c.TipodeAcceso.Contains(TextCriterio.Text);
                    }

                    if (repositorio.GetList(filtro).Count() == 0)
                    {
                        ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script:
              "toastr.info('Tipo de Acceso no Existe','Informacion',{ 'progressBar': true,'positionClass': 'toast-bottom-right'});", addScriptTags: true);
                        return;
                    }
                    break;

                case 8:// Contraseña
                    if (CheckBoxFecha.Checked == true)
                    {
                        filtro = x => x.Contraseña.Contains(TextCriterio.Text) && (x.Fecha >= desde && x.Fecha <= hasta);
                    }
                    else
                    {
                        filtro = c => c.Contraseña.Contains(TextCriterio.Text);
                    }

                    if (repositorio.GetList(filtro).Count() == 0)
                    {
                        ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script:
              "toastr.info('Contraseña no Existe','Informacion',{ 'progressBar': true,'positionClass': 'toast-bottom-right'});", addScriptTags: true);
                        return;
                    }
                    break;

                case 9:// Todos
                    filtro = x => true;
                    if (repositorio.GetList(filtro).Count() == 0)
                    {
                        ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script:
              "toastr.info('No Existe Ningun Usuario','Informacion',{ 'progressBar': true,'positionClass': 'toast-bottom-right'});", addScriptTags: true);
                        return;
                    }
                    break;

            }

             UsuarioGridView.DataSource = repositorio.GetList(filtro);
                UsuarioGridView.DataBind();
        }
    }
    
}