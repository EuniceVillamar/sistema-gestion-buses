using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Silva Alberth Gustavo
namespace Modelo
{
    public class Conductor : Persona
    {
        public string IdConductor { get; set; }
        public string Licencia { get; set; }
        public string CategoriaLicencia { get; set; }


        public Conductor(string idConductor, string licencia, string categoriaLicencia, string cedula, string nombre, string apellido, int edad, DateTime fechaNacimiento, string genero, string telefono, string correoElectronico)
        : base(cedula, nombre, apellido, edad, fechaNacimiento, genero, telefono, correoElectronico)
        {
            IdConductor = idConductor;
            Licencia = licencia;
            CategoriaLicencia = categoriaLicencia;
        }


        public override string ToString()
        {
            return base.ToString() +
                   "\nId del Conductor: " + IdConductor +
                   "\nLicencia: " + Licencia +
                   "\nCategoría de Licencia: " + CategoriaLicencia;
        }
    }

}
