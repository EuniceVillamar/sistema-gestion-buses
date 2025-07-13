using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Xavier Soledispa Paula
namespace Modelo
{
    public class Pasajero : Persona
    {
        public string IdPasajero { get; set; }

        public Pasajero(string idPasajero, string cedula, string nombre, string apellido, int edad, DateTime fechaNacimiento, string genero, string telefono, string correoElectronico)
        : base(cedula, nombre, apellido, edad, fechaNacimiento, genero, telefono, correoElectronico)
        {
            IdPasajero = idPasajero;
        }
    }
}
