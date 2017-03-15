using Clase9.BD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Clase9
{
    public partial class _Default : Page
    {
        Adaptador adaptador = new Adaptador();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void cargar(object sender, EventArgs e)
        {
            String consulta = "select FirstName, LastName, CompanyName, EmailAddress, Phone from SalesLT.Customer where CustomerID between 1 and 50";
            DataTable tabla = adaptador.consultar(consulta);

            grvReporte.DataSource = tabla;
            grvReporte.DataBind();
        }

        public void insertarConsulta(String cedulas, String nombres, String apellidos1, String apellidos2, String edades)
        {

            String consulta = "insert into Persona values("+ cedulas +", @nombre, @apellido1, @apellido2, @edad)";

            SqlCommand comando = new SqlCommand(consulta);

            SqlParameter cedula = new SqlParameter("@cedula", SqlDbType.Int);
            cedula.Value = cedulas;
            SqlParameter nombre = new SqlParameter("@nombre", SqlDbType.VarChar, 20);
            nombre.Value = nombres;
            SqlParameter apellido1 = new SqlParameter("@apellido1", SqlDbType.VarChar, 20);
            apellido1.Value = apellidos1;
            SqlParameter apellido2 = new SqlParameter("@apellido2", SqlDbType.VarChar, 20);
            apellido2.Value = apellidos2;
            SqlParameter edad = new SqlParameter("@edad", SqlDbType.Int, 4);
            edad.Value = edades;
            
            comando.Parameters.Add(cedula);
            comando.Parameters.Add(nombre);
            comando.Parameters.Add(apellido1);
            comando.Parameters.Add(apellido2);
            comando.Parameters.Add(edad);

            adaptador.insertar(comando);
        }
    }
}