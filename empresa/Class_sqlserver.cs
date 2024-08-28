using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace empresa
{
    internal class Class_sqlserver
    {
        //Generar la cadena de conexión
        SqlConnection conectar;
        public string cadena(string usuario, string clave)
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = "DESKTOP-UAJ0RA0";
            scsb.UserID = usuario;
            scsb.Password = clave;
            return scsb.ConnectionString;
        }
        //Validación de usuario y clave
        public Boolean validar (string usuario, string clave)
        {
            conectar = new SqlConnection (cadena(usuario, clave));
            try
            {
                conectar.Open ();
                return true;
            }
            catch(SqlException error)
            {
                MessageBox.Show(error.Message, "Código: " + error.ErrorCode, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                conectar.Close ();
            }
        }
    }
}
