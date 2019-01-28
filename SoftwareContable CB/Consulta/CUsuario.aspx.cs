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
            switch (TipodeFiltro.SelectedIndex)
            {
                case 0://ID
                    id = Convert.ToInt32(TextCriterio.Text);
                    if (CheckBoxFecha.Checked == true)
                    {
                        filtro = x => x.UsuarioId == id && (x.Fecha >= Convert.ToDateTime(DesdeTextBox.Text) && x.Fecha <= Convert.ToDateTime(HastaTextBox.Text));
                    }
                    else
                    {
                        filtro = c => c.UsuarioId == id;
                    }
                    break;

                case 1:// Usuario
                    filtro = c => c.Usuario.Contains(TextCriterio.Text);
                    break;

                case 2:// nombre
                    filtro = c => c.Nombre.Contains(TextCriterio.Text);
                    break;

                case 3:// Cedula
                    filtro = c => c.Cedula.Equals(TextCriterio.Text);
                    break;

                case 4:// Telefono
                    filtro = c => c.Telefono.Equals(TextCriterio.Text);
                    break;

                case 5:// Celular
                    filtro = c => c.Celular.Equals(TextCriterio.Text);
                    break;

                case 6:// Email
                    filtro = c => c.Email.Contains(TextCriterio.Text);
                    break;

                case 7:// TipodeAcceso
                    filtro = c => c.TipodeAcceso.Contains(TextCriterio.Text);
                    break;

                case 8:// Contraseña
                    filtro = c => c.Contraseña.Contains(TextCriterio.Text);
                    break;

                case 9:// Todos
                    filtro = x => true;
                    break;

            }

             UsuarioGridView.DataSource = repositorio.GetList(filtro);
                UsuarioGridView.DataBind();
        }
    }
    
}