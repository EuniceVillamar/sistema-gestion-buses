using Datos;
using Modelo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controlador
{
    public class ControlProgramadores
    {
        private const string baseRutaFoto = "https://eunice-ug.s3.us-east-1.amazonaws.com/";

        private static List<Programadores> programadores = new List<Programadores>();

        public static List<Programadores> Programadores
        {
            get => programadores;
            set => programadores = value;
        }

        Conexion conexionProgramadores = new Conexion();
        DatosProgramadores datosProgramadores = new DatosProgramadores();

        public void LlenarProgramadores(int filas, DataGridView dgvProgramadores)
        {
            int indice = 0;

            if (Programadores.Count == 0)
            {
                Programadores = SeleccionarProgramadores();
            }

            if (Programadores.Count > 0)
            {
                dgvProgramadores.Rows.Clear();
                foreach (Programadores p in Programadores)
                {
                    indice = dgvProgramadores.Rows.Add();
                    dgvProgramadores.Rows[indice].Cells["NroProgramadores"].Value = indice + 1;
                    dgvProgramadores.Rows[indice].Cells["nombreSistema"].Value = p.nombreSistema;
                    dgvProgramadores.Rows[indice].Cells["nombreIntegrante"].Value = p.nombreIntegrante;
                    dgvProgramadores.Rows[indice].Cells["correoIntegrante"].Value = p.correoIntegrante;
                    dgvProgramadores.Rows[indice].Cells["celularIntegrante"].Value = p.celularIntegrante;

                    try
                    {
                        string imageUrl = baseRutaFoto + p.fotoLink;
                        using (WebClient webClient = new WebClient())
                        {
                            byte[] imageBytes = webClient.DownloadData(imageUrl);
                            using (var ms = new System.IO.MemoryStream(imageBytes))
                            {
                                dgvProgramadores.Rows[indice].Cells["fotoLink"].Value = Image.FromStream(ms);
                            }
                        }
                    }
                    catch
                    {
                        // If image loading fails, we'll leave the cell empty
                        dgvProgramadores.Rows[indice].Cells["fotoLink"].Value = null;
                    }

                    indice++;

                    if (indice == filas)
                    {
                        break;
                    }
                }
            }
        }

        private List<Programadores> SeleccionarProgramadores()
        {
            List<Programadores> Lista = null;
            string msj = conexionProgramadores.conectar();
            string salida = "";
            if (msj[0] == '1')
            {
                Lista = datosProgramadores.SeleccionarProgramadores(conexionProgramadores.Cn);
                conexionProgramadores.cerrar();
            }
            else if (msj[0] == '0')
            {
                MessageBox.Show("Error ", msj);
            }

            return Lista;
        }
    }
}