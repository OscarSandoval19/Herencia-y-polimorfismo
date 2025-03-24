using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio.MisClases
{
    public class Trailer : Vehiculo{
        public int CapacidadCarga { get; set; } // toneladas
        public int NumeroEjes { get; set; }
        public string TipoLicencia { get; } = "A";

        public Trailer(int año, string color, string marca, int capacidadCarga, int numeroEjes)
            : base(año, color, marca)
        {
            CapacidadCarga = capacidadCarga;
            NumeroEjes = numeroEjes;
            CapacidadTanque = 200;
            ConsumoCombustible = 30;
        }

        public void EngancharRemolque()
        {
            Console.WriteLine("El remolque esta enganchado.");
        }

        public void DesengancharRemolque()
        {
            Console.WriteLine("El remolque esta desenganchado.");
        }
        public void MostrarInformacionTrailer()
        {
            Console.WriteLine($"Capacidad de carga: {CapacidadCarga} toneladas");
            Console.WriteLine($"Numero de ejes: {NumeroEjes}");
            Console.WriteLine($"Capacidad del tanque: {CapacidadTanque} galones");
            Console.WriteLine($"Consumo de combustible: {ConsumoCombustible} galones/km");
        }
    }
}
