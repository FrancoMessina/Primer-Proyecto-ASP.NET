using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
namespace Unidad4
{
    public partial class Default : Page
    {
        private AutoNegocio autoNegocio;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["ListaAutos"] is null)
            {
                this.autoNegocio = new AutoNegocio();
                Session.Add("ListaAutos", this.autoNegocio.Listar());
            }
            this.dgvAutos.DataSource = Session["ListaAutos"];
            this.dgvAutos.DataBind();
        }

        protected void dgvAutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id = dgvAutos.SelectedDataKey.Value;
            Response.Redirect($"AutoForm.aspx/?Id={id}");
        }
    }
}