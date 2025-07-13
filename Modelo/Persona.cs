using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public abstract class Persona
    {
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Genero { get; set; }
        public string Telefono { get; set; }
        public string CorreoElectronico { get; set; }

        public Persona(string cedula, string nombre, string apellido, int edad, DateTime fechaNacimiento, string genero, string telefono, string correoElectronico)
        {
            Cedula = cedula;
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            FechaNacimiento = fechaNacimiento;
            Genero = genero;
            Telefono = telefono;
            CorreoElectronico = correoElectronico;
        }
        public override string ToString()
        {
            return "Cedula: " + Cedula + "\nNombre: " + Nombre + "\nApellido: " + Apellido +
           "\nEdad: " + Edad + "\nFecha de Nacimiento: " + FechaNacimiento.ToShortDateString() +
           "\nGenero: " + Genero + "\nTelefono: " + Telefono +
           "\nCorreo Electrónico: " + CorreoElectronico;
        }
    }
}
