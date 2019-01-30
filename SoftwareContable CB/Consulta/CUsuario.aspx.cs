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
            if (paso)
            {
              
                return;
            }
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

        private bool Validar(int error)
        {
            bool paso = false;
            int num = 0;

            if (error == 1 && string.IsNullOrEmpty(TextCriterio.Text))
            {
              
                paso = true;
            }
            if (error == 2 && int.TryParse(TextCriterio.Text, out num) == false)
            {
          
                paso = true;
            }

            if (error == 3 && int.TryParse(TextCriterio.Text, out num) == true)
            {
               
                paso = true;
            }

            return paso;
        }

        bool paso = false;

        protected void CustomValidator_ServerValidate(object source, ServerValidateEventArgs args)
        {

            int ejem = 0;
            if (string.IsNullOrEmpty(TextCriterio.Text))
            {
                paso = true;
                args.IsValid = true;
                CustomValidator.ErrorMessage = "Debe introducir un numero en el criterio";
                return;
            }

        
            if (TipodeFiltro.SelectedIndex.Equals(1) && int.TryParse(TextCriterio.Text, out ejem) == true || string.IsNullOrEmpty(TextCriterio.Text))
            {
                paso = true;
                args.IsValid = true;
                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script:
                  "toastr.error('Favor de Introducir nombre de Usuario','Error',{ 'progressBar': true,'positionClass': 'toast-bottom-right'});", addScriptTags: true);
                return;
            }

            if (TipodeFiltro.SelectedIndex.Equals(2) && int.TryParse(TextCriterio.Text, out ejem) == true)
            {
                paso = true;
                args.IsValid = true;
                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script:
                  "toastr.error('Favor de Introducir Nombre','Error',{ 'progressBar': true,'positionClass': 'toast-bottom-right'});", addScriptTags: true);
                return;
            }

            else
                args.IsValid = false;


        }
    }
    
}