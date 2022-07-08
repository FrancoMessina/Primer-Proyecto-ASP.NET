using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
namespace Unidad4
{
    public partial class AutoForm : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.ddlColores.DataSource = Enum.GetNames(typeof(EColores));
                this.ddlColores.DataBind();
            }
            
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            Auto autoNuevo = new Auto();
            autoNuevo.Id = int.Parse(txtId.Text);
            autoNuevo.Modelo = txtModelo.Text;
            autoNuevo.Descripcion = txtDescripcion.Text;
            autoNuevo.Color = ddlColores.SelectedValue;
            autoNuevo.Fecha = DateTime.Parse(txtFecha.Text);
            autoNuevo.Usado = ckbUsado.Checked;
            ((List<Auto>)Session["ListaAutos"]).Add(autoNuevo);
            Response.Redirect("Default.aspx");
        }

        protected void rdbImportado_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void rdbNacional_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}