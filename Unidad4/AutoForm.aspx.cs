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
            if (Request.QueryString["Id"] != null)
            {
                var id = int.Parse(Request.QueryString["Id"]);
                Auto selecionado = ((List<Auto>)Session["ListaAutos"]).Find(x => x.Id == id);
                txtId.Text = selecionado.Id.ToString();
                txtDescripcion.Text = selecionado.Descripcion;
                txtModelo.Text = selecionado.Modelo;
                ddlColores.SelectedValue = selecionado.Color;
                txtFecha.Text = selecionado.Fecha.ToString("yyyy-MM-dd");
                bool esImportado = selecionado.Importado ? rdbImportado.Checked = true : rdbNacional.Checked = true;
                bool esUsado = selecionado.Usado ? ckbUsado.Checked = true : ckbUsado.Checked = false;
                txtId.ReadOnly = true;

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
            autoNuevo.Importado = rdbImportado.Checked ? true : false;
            ((List<Auto>)Session["ListaAutos"]).Add(autoNuevo);
            Response.Redirect("Default.aspx");
        }
    }
}