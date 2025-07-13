using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// GREGORY MEJIA MENDEZ
namespace Modelo
{
    public class Ruta
    {

        public string IdRuta { get; set; }
        public string ProvOrigen { get; set; }
        public string ProvDestino { get; set; }
        public double Distancia { get; set; }
        public DateTime HoraSalida { get; set; }
        public double Duracion { get; set; }
        public bool Estado { get; set; }

        public Ruta(string idRuta, string provOrigen, string provDestino, double distancia, double duracion, DateTime horaSalida, bool estado)
        {
            IdRuta = idRuta;
            ProvOrigen = provOrigen;
            ProvDestino = provDestino;
            Distancia = distancia;
            Duracion = duracion;
            HoraSalida = horaSalida;
            Estado = estado;
        }
        public override string ToString()
        {
            return "Id de ruta: " + IdRuta + "\nProvincia de origen: " + ProvOrigen + "\nProvincia de destino: " + ProvDestino +
           "\nDistancia: " + Distancia + "\nDuracion: " + Duracion + "\nHora de Salida: " + HoraSalida +
           "\nEstado: " + Estado;
        }
    }
}
