using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebPerson.Paginas
{
    public partial class Index : System.Web.UI.Page
    {
        Conexion conexion = new Conexion();

        protected void Page_Load(object sender, EventArgs e)
        {
            //DataTable data = conexion.Listar();
            //if(data.Rows.Count > 0)
            //{
            //    gvPersonas.DataSource = data;
            //}
            
        }

        protected void btnNew_Click(object sender, EventArgs e)
        {
            Server.Transfer("~/Paginas/Create.aspx");
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {

        }

        protected void btnBorrar_Click(object sender, EventArgs e)
        {

        }
    }
}