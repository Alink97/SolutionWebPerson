using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebPerson.Paginas
{
    public partial class Create : System.Web.UI.Page
    {
        Conexion conexion = new Conexion();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Server.Transfer("~/Paginas/Index.aspx");
        }

        protected void btnCrearP_Click(object sender, EventArgs e)
        {

            Persona persona = new Persona();
            persona.Nombre = tbName.Text;
            persona.Apellidos = tbSurname.Text;
            persona.Edad = int.Parse(tbAge.Text.Trim());

            conexion.Insert(persona);

            Server.Transfer("~/Paginas/Index.aspx");
        }
    }
}