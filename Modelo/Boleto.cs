using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
// Anthonny Ramírez Benavides
namespace Modelo
{
    public class Boleto
    {
        private Ruta _ruta;
        private Bus _bus;
        private Pasajero _pasajero;
        private string _anden = "027";
        private DateTime _fechaCompra;
        private string _idBoleto;
        private int _cantBoletos;
        private int _asiento;
        private double _total;

        public string _Anden { get; set; }
        public DateTime _FechaCompra { get; set; }
        public string _IdBoleto { get; set; }
        public int _CantBoletos { get; set; }
        public int _Asiento { get; set; }
        public double _Total {  get; set; }

        public Boleto(
            Ruta ruta, Bus bus, Pasajero pasajero,
            DateTime fechaCompra, string idBoleto,
            int cantBoletos, int asiento, double total)
        {
            _ruta = ruta;
            _bus = bus;
            _pasajero = pasajero;
            _fechaCompra = fechaCompra;
            _idBoleto = idBoleto;
            _cantBoletos = cantBoletos;
            _asiento = asiento;
            _total = total;
        }

        public override string ToString()
        {
            return $"\n\tInformación del viaje" +
                   $"\nCod. Viaje.: {_ruta.IdRuta}" +
                   $"\nDestino....: {_ruta.ProvDestino}" +
                   $"\nSalida.....: {_ruta.HoraSalida}" +
                   $"\nBus........: {_bus.IdBus}" +
                   $"\nAnden......: {_anden}" +
                   $"\n\tInformación tributaria" +
                   $"\nFecha......: {_fechaCompra}" +
                   $"\nFactura....: {_idBoleto}" +
                   $"\nCedula.....: {_pasajero.Cedula}" +
                   $"\nPasajero...: {_pasajero.Nombre} {_pasajero.Apellido}" +
                   $"\n\tDetalle de facturación" +
                   $"\nCantidad...: {_cantBoletos}" +
                   $"\nAsiento....: {_asiento}" +
                   $"\nTotal......: {_total}";
        }
    }

}
