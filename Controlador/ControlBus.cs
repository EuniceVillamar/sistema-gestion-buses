using Datos;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace Controlador
{
    public class ControlBus
    {
        private List<Bus> buses;
        private Conexion conexionBus = new Conexion();
        private DatosBus datosBus = new DatosBus();

        public ControlBus()
        {
            buses = new List<Bus>();
        }

        public void AgregarBus(string matricula, string marca, string modelo, decimal capacidad, int noAsientos)
        {
            if (!ValidarMatricula(matricula))
            {
                return;
            }

            Bus nuevoBus = new Bus(0, matricula, marca, modelo, capacidad, noAsientos);

            IngresarBus(nuevoBus);
            MessageBox.Show("Bus registrado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public List<Bus> ObtenerBuses()
        {
            return buses;
        }

        public void LlenarBuses(DataGridView dgvListarBus, Label lblTotal, NumericUpDown nudCapacidadDesde = null, NumericUpDown nudCapacidadHasta = null)
        {
            conexionBus.conectar();

            decimal? capacidadDesde = nudCapacidadDesde?.Value;
            decimal? capacidadHasta = nudCapacidadHasta?.Value;

            buses = datosBus.ListarTodosBuses(conexionBus.Cn, capacidadDesde, capacidadHasta);
            conexionBus.cerrar();

            if (buses == null || buses.Count == 0)
            {
                MessageBox.Show("No hay buses registrados. Por favor, registre al menos uno primero.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblTotal.Text = "0";
                return;
            }
            dgvListarBus.Rows.Clear();

            int indice = 0;
            foreach (Bus bus in buses)
            {
                indice = dgvListarBus.Rows.Add();
                dgvListarBus.Rows[indice].Cells["colNro"].Value = indice + 1;
                dgvListarBus.Rows[indice].Cells["colIdBus"].Value = bus.IdBus;
                dgvListarBus.Rows[indice].Cells["colMatricula"].Value = bus.Matricula;
                dgvListarBus.Rows[indice].Cells["colMarca"].Value = bus.Marca;
                dgvListarBus.Rows[indice].Cells["colModelo"].Value = bus.Modelo;
                dgvListarBus.Rows[indice].Cells["colCapacidad"].Value = bus.Capacidad + " kg";
                dgvListarBus.Rows[indice].Cells["colNoAsientos"].Value = bus.NoAsientos;
                indice++;
            }
            lblTotal.Text = buses.Count.ToString();
        }


        public bool ValidarMatricula(string matricula)
        {
            string m = String.Empty;
            Regex matriculaRgx = new Regex(@"^[A-Z]{2,3}-\d{4}$");

            if (matricula == null)
            {
                return false;
            }

            m = matricula.ToUpper();

            if (matriculaRgx.IsMatch(m.ToString()))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Matrícula incorrecta. Debe tener el formato: AAA-1234", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public void EditarBus(int idBus, string nuevaMatricula, string nuevaMarca, string nuevoModelo, decimal nuevaCapacidad, int nuevoNoAsientos)
        {
            conexionBus.conectar();
            Bus bus = datosBus.ObtenerBusPorId(idBus, conexionBus.Cn);
            conexionBus.cerrar();

            if (bus != null)
            {
                // Actualizar los datos del bus
                bus.Matricula = nuevaMatricula;
                bus.Marca = nuevaMarca;
                bus.Modelo = nuevoModelo;
                bus.Capacidad = nuevaCapacidad;
                bus.NoAsientos = nuevoNoAsientos;

                conexionBus.conectar();
                datosBus.EditarBus(bus, conexionBus.Cn);
                conexionBus.cerrar();

                MessageBox.Show("Bus actualizado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo encontrar el bus para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void EliminarBus(int idBus)
        {
            conexionBus.conectar();
            string resultado = datosBus.EliminarBus(idBus.ToString(), conexionBus.Cn);
            conexionBus.cerrar();

            if (resultado.StartsWith("0"))
            {
                MessageBox.Show("Error al eliminar el bus: " + resultado.Substring(2));
            }
            else
            {
                MessageBox.Show("Bus eliminado correctamente.");
            }
        }

        public void ObtenerBusIndividual(int idBus, TextBox txtMatricula, TextBox txtMarca, TextBox txtModelo, NumericUpDown nudCapacidad, TextBox txtNoAsientos)
        {
            conexionBus.conectar();
            Bus bus = datosBus.ObtenerBusPorId(idBus, conexionBus.Cn);
            conexionBus.cerrar();

            if (bus != null)
            {
                txtMatricula.Text = bus.Matricula;
                txtMarca.Text = bus.Marca;
                txtModelo.Text = bus.Modelo;
                nudCapacidad.Value = bus.Capacidad;
                txtNoAsientos.Text = bus.NoAsientos.ToString();
            }
            else
            {
                MessageBox.Show("Bus no encontrado. Verifique el ID ingresado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void Conectar()
        {
            string msj = conexionBus.conectar();
            if (msj[0] == '1')
            {
                MessageBox.Show("La conexión se realizó correctamente");
                conexionBus.cerrar();
            }
            else if (msj[0] == '0')
            {
                MessageBox.Show("Error al conectar: " + msj);
            }
        }

        private void IngresarBus(Bus bus)
        {
            string msj = conexionBus.conectar();
            string salida = "";

            if (msj[0] == '1')
            {
                salida = datosBus.RegistrarBus(bus, conexionBus.Cn);
                conexionBus.cerrar();
            }
            else if (msj[0] == '0')
            {
                MessageBox.Show("Error al conectar: " + msj);
            }
        }

        public void GenerarPDF(NumericUpDown nudCapacidadDesde = null, NumericUpDown nudCapacidadHasta = null)
        {
            FileStream stream = null;
            Document document = null;
            PdfWriter pdf = null;

            try
            {
                // Obtener la lista actualizada de buses
                conexionBus.conectar();
                decimal? capacidadDesde = nudCapacidadDesde?.Value;
                decimal? capacidadHasta = nudCapacidadHasta?.Value;
                buses = datosBus.ListarTodosBuses(conexionBus.Cn, capacidadDesde, capacidadHasta);
                conexionBus.cerrar();

                if (buses == null || buses.Count == 0)
                {
                    MessageBox.Show("No hay buses para exportar a PDF.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Crear un documento PDF
                stream = new FileStream("ReporteBuses.pdf", FileMode.Create);
                document = new Document(PageSize.A4, 25, 25, 30, 30);
                pdf = PdfWriter.GetInstance(document, stream);

                document.Open();

                // Definir estilos
                Font tituloFont = new Font(Font.FontFamily.HELVETICA, 16, Font.BOLD, BaseColor.DARK_GRAY);
                Font encabezadosFont = new Font(Font.FontFamily.HELVETICA, 12, Font.BOLD, BaseColor.WHITE);
                Font contenidoFont = new Font(Font.FontFamily.HELVETICA, 11, Font.NORMAL, BaseColor.BLACK);

                // Agregar título
                Paragraph titulo = new Paragraph("Reporte de Buses", tituloFont);
                titulo.Alignment = Element.ALIGN_CENTER;
                titulo.SpacingAfter = 20f;
                document.Add(titulo);

                // Crear tabla
                PdfPTable tabla = new PdfPTable(6);
                tabla.WidthPercentage = 100;
                float[] anchos = new float[] { 10f, 15f, 20f, 20f, 15f, 20f };
                tabla.SetWidths(anchos);

                // Agregar encabezados
                BaseColor colorEncabezado = new BaseColor(41, 128, 185); // Azul
                string[] encabezados = { "ID", "Matrícula", "Marca", "Modelo", "Capacidad", "Asientos" };

                foreach (string encabezado in encabezados)
                {
                    PdfPCell celda = new PdfPCell(new Phrase(encabezado, encabezadosFont));
                    celda.BackgroundColor = colorEncabezado;
                    celda.HorizontalAlignment = Element.ALIGN_CENTER;
                    celda.Padding = 8;
                    tabla.AddCell(celda);
                }

                // Agregar datos
                foreach (Bus bus in buses)
                {
                    tabla.AddCell(new PdfPCell(new Phrase(bus.IdBus.ToString(), contenidoFont)));
                    tabla.AddCell(new PdfPCell(new Phrase(bus.Matricula, contenidoFont)));
                    tabla.AddCell(new PdfPCell(new Phrase(bus.Marca, contenidoFont)));
                    tabla.AddCell(new PdfPCell(new Phrase(bus.Modelo, contenidoFont)));
                    tabla.AddCell(new PdfPCell(new Phrase(bus.Capacidad + " kg", contenidoFont)));
                    tabla.AddCell(new PdfPCell(new Phrase(bus.NoAsientos.ToString(), contenidoFont)));
                }

                document.Add(tabla);

                // Agregar pie de página
                Paragraph footer = new Paragraph($"Reporte generado el {DateTime.Now:dd/MM/yyyy HH:mm:ss}", contenidoFont);
                footer.Alignment = Element.ALIGN_RIGHT;
                footer.SpacingBefore = 20f;
                document.Add(footer);

                document.Close();
                pdf.Close();

                MessageBox.Show("Reporte PDF generado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                document?.Close();
                pdf?.Close();
                stream?.Close();
            }
        }

        public void AbrirPDF()
        {
            string pdfPath = "ReporteBuses.pdf";
            if (File.Exists(pdfPath))
            {
                try
                {
                    System.Diagnostics.Process.Start(pdfPath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al abrir el PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("El archivo PDF no existe. Primero debe generar el reporte.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
