using System;
//Elizabeth Villamar Lascano
namespace Modelo
{
    public class Bus
    {
        public int IdBus { get; set; }
        public string Matricula { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public decimal Capacidad { get; set; }
        public int NoAsientos { get; set; }
        public Ruta Ruta { get; set; }
        public Conductor Conductor { get; set; }

        public Bus(int idBus, string matricula, string marca, string modelo, decimal capacidad, int noAsientos)
        {
            IdBus = idBus;
            Matricula = matricula;
            Marca = marca;
            Modelo = modelo;
            Capacidad = capacidad;
            NoAsientos = noAsientos;

            // Objetos quemados de Conductor y Ruta
            Conductor = new Conductor(
                idConductor: "C001",
                licencia: "123456789",
                categoriaLicencia: "B",
                cedula: "1234567890",
                nombre: "Juan",
                apellido: "Pérez",
                edad: 35,
                fechaNacimiento: new DateTime(1988, 5, 15),
                genero: "M",
                telefono: "0987654321",
                correoElectronico: "juan.perez@email.com"
            );

            Ruta = new Ruta(
                idRuta: "R001",
                provOrigen: "Pichincha",
                provDestino: "Guayas",
                distancia: 420.5,
                duracion: 6.5,
                horaSalida: new DateTime(2024, 12, 1, 8, 0, 0),
                estado: true
            );
        }

        public override string ToString()
        {
            return "*********" +
                   "\nIdBus: " + IdBus +
                   "\nMatricula: " + Matricula +
                   "\nMarca: " + Marca +
                   "\nModelo: " + Modelo +
                   "\nCapacidad (kg): " + Capacidad +
                   "\nNumero de Asientos: " + NoAsientos +
                   "\nRuta: " + Ruta.ToString() +
                   "\nConductor: " + Conductor.ToString() +
                   "\n***********";
        }
    }
}

