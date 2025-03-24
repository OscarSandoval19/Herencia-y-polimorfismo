using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio.MisClases
{
    public class Furgoneta : Vehiculo{
        public int CapacidadCarga { get; set; } // kilogramos
        public int NumeroPuertas { get; set; }
        public string TipoLicencia { get; } = "B";

        public Furgoneta(int año, string color, string marca, int capacidadCarga, int numeroPuertas)
            : base(año, color, marca)
        {
            CapacidadCarga = capacidadCarga;
            NumeroPuertas = numeroPuertas;
            CapacidadTanque = 80;
            ConsumoCombustible = 10;
        }

        public void CargarMercancia()
        {
            Console.WriteLine("La mercancia esta cargada en la furgoneta.");
        }

        public void DescargarMercancia()
        {
            Console.WriteLine("La mercancia ya fue descargada de la furgoneta.");
        }

        public void MostrarInformacionFurgoneta()
        {
            Console.WriteLine($"Capacidad de carga: {CapacidadCarga} kg");
            Console.WriteLine($"Número de puertas: {NumeroPuertas}");
            Console.WriteLine($"Capacidad del tanque: {CapacidadTanque} galones");
            Console.WriteLine($"Consumo de combustible: {ConsumoCombustible} galones/km");
        }
    }
}
