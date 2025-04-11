using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PryConexionBDLopezBearzi
{
    internal class ClsConexion
    {
        private static string connectionString =
   "Server=PC221;Database=Comercio;Trusted_Connection=True;";

        public static SqlConnection ObtenerConexion()
        {
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();
                MessageBox.Show("✅ Conexión exitosa a la base de datos.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al conectar: " + ex.Message);
            }

            return connection;
        }





    }
}
