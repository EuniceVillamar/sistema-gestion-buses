using Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DatosBus
    {
        SqlCommand cmd = null;

        public string RegistrarBus(Bus bus, SqlConnection conexionBus)
        {
            string msj = "";
            string comandoSQL =
                "INSERT INTO Buses (Matricula, Marca, Modelo, Capacidad, NoAsientos, idRuta, idConductor, Estado) " +
                "VALUES (@matricula, @marca, @modelo, @capacidad, @noAsientos, @idRuta, @idConductor, @estado)";

            cmd = new SqlCommand(comandoSQL, conexionBus);
            cmd.Parameters.AddWithValue("@matricula", bus.Matricula);
            cmd.Parameters.AddWithValue("@marca", bus.Marca);
            cmd.Parameters.AddWithValue("@modelo", bus.Modelo);
            cmd.Parameters.AddWithValue("@capacidad", bus.Capacidad);
            cmd.Parameters.AddWithValue("@noAsientos", bus.NoAsientos);
            cmd.Parameters.AddWithValue("@idRuta", bus.Ruta?.IdRuta);
            cmd.Parameters.AddWithValue("@idConductor", bus.Conductor?.IdConductor);
            cmd.Parameters.AddWithValue("@estado", "A");

            try
            {
                cmd.ExecuteNonQuery();
                msj = "1";
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                msj = "0:" + ex.Message;
            }

            return msj;
        }

        public string EliminarBus(string idBus, SqlConnection conexionBus)
        {
            string msj = "";
            string comandoSQL = "UPDATE Buses SET Estado = @estado WHERE idBus = @idBus";

            cmd = new SqlCommand(comandoSQL, conexionBus);
            cmd.Parameters.AddWithValue("@idBus", idBus);
            cmd.Parameters.AddWithValue("@estado", "I");

            try
            {
                cmd.ExecuteNonQuery();
                msj = "1";
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                msj = "0:" + ex.Message;
            }

            return msj;
        }

        public List<Bus> ListarTodosBuses(SqlConnection conexionBus, decimal? capacidadDesde = null, decimal? capacidadHasta = null)
        {
            List<Bus> listaBuses = new List<Bus>();
            string comandoSQL = "SELECT * FROM Buses WHERE Estado != 'I'";

            if (capacidadDesde.HasValue && capacidadHasta.HasValue)
            {
                comandoSQL += " AND Capacidad >= @capacidadDesde AND Capacidad <= @capacidadHasta";
            }

            cmd = new SqlCommand(comandoSQL, conexionBus);

            if (capacidadDesde.HasValue && capacidadHasta.HasValue)
            {
                cmd.Parameters.AddWithValue("@capacidadDesde", capacidadDesde.Value);
                cmd.Parameters.AddWithValue("@capacidadHasta", capacidadHasta.Value);
            }

            try
            {
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Bus bus = new Bus(0, "", "", "", 0, 0);

                    bus.IdBus = Convert.ToInt32(reader["IdBus"]);
                    bus.Matricula = reader["Matricula"].ToString();
                    bus.Marca = reader["Marca"].ToString();
                    bus.Modelo = reader["Modelo"].ToString();
                    bus.Capacidad = Convert.ToDecimal(reader["Capacidad"]);
                    bus.NoAsientos = Convert.ToInt32(reader["NoAsientos"]);

                    listaBuses.Add(bus);
                }

                reader.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            return listaBuses;
        }

        public Bus ObtenerBusPorId(int idBus, SqlConnection conexionBus)
        {
            Bus bus = null;
            string comandoSQL = "SELECT * FROM Buses WHERE idBus = @idBus";

            SqlCommand cmd = new SqlCommand(comandoSQL, conexionBus);
            cmd.Parameters.AddWithValue("@idBus", idBus);

            try
            {
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    bus = new Bus(
                        idBus: Int32.Parse(reader["idBus"].ToString()),
                        matricula: reader["Matricula"].ToString(),
                        marca: reader["Marca"].ToString(),
                        modelo: reader["Modelo"].ToString(),
                        capacidad: Convert.ToDecimal(reader["Capacidad"]),
                        noAsientos: Convert.ToInt32(reader["NoAsientos"])
                    );
                }

                reader.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            return bus;
        }

        public string EditarBus(Bus bus, SqlConnection conexionBus)
        {
            string msj = "";
            string comandoSQL =
                "UPDATE Buses SET Matricula = @matricula, Marca = @marca, Modelo = @modelo, Capacidad = @capacidad, NoAsientos = @noAsientos, idRuta = @idRuta, idConductor = @idConductor, Estado = @estado WHERE IdBus = @idBus";

            cmd = new SqlCommand(comandoSQL, conexionBus);
            cmd.Parameters.AddWithValue("@idBus", bus.IdBus);
            cmd.Parameters.AddWithValue("@matricula", bus.Matricula);
            cmd.Parameters.AddWithValue("@marca", bus.Marca);
            cmd.Parameters.AddWithValue("@modelo", bus.Modelo);
            cmd.Parameters.AddWithValue("@capacidad", bus.Capacidad);
            cmd.Parameters.AddWithValue("@noAsientos", bus.NoAsientos);
            cmd.Parameters.AddWithValue("@idRuta", bus.Ruta?.IdRuta);
            cmd.Parameters.AddWithValue("@idConductor", bus.Conductor?.IdConductor);
            cmd.Parameters.AddWithValue("@estado", "A");

            try
            {
                cmd.ExecuteNonQuery();
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