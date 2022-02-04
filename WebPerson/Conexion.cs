using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebPerson
{
    public class Conexion
    {
        protected SqlConnection con;

        public void Insert(Persona persona)
        {
            string name = persona.Nombre;
            string sur = persona.Apellidos;
            int edad = persona.Edad;
            string query = "INSERT INTO Personas VALUES(@Name, @Sur, @Age)";
            using (con)
            {
                using (SqlCommand cmd = new SqlCommand(query))
                {
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Sur", sur);
                    cmd.Parameters.AddWithValue("@Age", edad);
                    cmd.Connection = con;
                    Conectar();
                    cmd.ExecuteNonQuery();
                    Desconectar();
                }
            }
        }

        public DataTable Listar()
        {
            Conectar();
            SqlCommand command = new SqlCommand("SELECT * FROM Personas;", con);
            SqlDataReader reader = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("nombre");
            dataTable.Columns.Add("apellidos");
            dataTable.Columns.Add("edad");

            while (reader.Read())
            {
                DataRow row = dataTable.NewRow();
                row["nombre"] = reader["nombre"];
                row["apellidos"] = reader["apellidos"];
                row["edad"] = reader["edad"];
                dataTable.Rows.Add(row);
            }
            reader.Close();
            Desconectar();
            return dataTable;
        }

        private void Conectar()
        {
            try
            {
                con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                con.Open();
            }catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        private void Desconectar()
        {
            try
            {
                con.Close();
                con.Dispose();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}