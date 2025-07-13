using Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Datos
{
    public class DatosProgramadores
    {
        public List<Programadores> SeleccionarProgramadores(SqlConnection cn)
        {
            SqlCommand cmd = null;
            List<Programadores> ListaProgramadores = new List<Programadores>();
            Programadores programador = null;
            SqlDataReader tablaVirtual = null;

            string comandoSQL =
                "SELECT idIntegrante, nombreSistema, nombreIntegrante, correoIntegrante, celularIntegrante, fotoLink FROM InformacionIntegrante";

            cmd = new SqlCommand(comandoSQL, cn);
            try
            {
                tablaVirtual = cmd.ExecuteReader();
                while (tablaVirtual.Read())
                {
                    programador = new Programadores("", "", "", "");
                    programador.idIntegrante = Convert.ToInt32(tablaVirtual["idIntegrante"]);
                    programador.nombreSistema = tablaVirtual["nombreSistema"].ToString();
                    programador.nombreIntegrante = tablaVirtual["nombreIntegrante"].ToString();
                    programador.correoIntegrante = tablaVirtual["correoIntegrante"].ToString();
                    programador.celularIntegrante = tablaVirtual["celularIntegrante"].ToString();
                    programador.fotoLink = tablaVirtual["fotoLink"].ToString();

                    ListaProgramadores.Add(programador);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return ListaProgramadores;
        }
    }
}