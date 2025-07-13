using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Datos
{
    public class Conexion
    {
        private static string cadena = ConfigurationManager.ConnectionStrings["Conexion-Elizabeth"].ConnectionString;
        private SqlConnection cn = null;
        public SqlConnection Cn { get => cn; set => cn = value; }
        public string conectar()
        {
            string msj = "";
            try
            {
                cn = new SqlConnection();
                cn.ConnectionString = cadena;
                cn.Open();
                msj = "1";
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                msj = "0" + ex.Message;
            }

            return msj;
        }

        public string cerrar()
        {
            string msj = "";
            try
            {
                cn.Close();
                msj = "1";
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                msj = "0:" + ex.Message;
            }
            return msj;
        }


    }
}
