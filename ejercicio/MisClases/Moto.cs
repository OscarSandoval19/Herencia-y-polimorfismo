using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio.MisClases
{
    public class Moto : Vehiculo
    {
        public Moto(int anio, string elColor, string elModelo) : base(anio, elColor, elModelo)
        {
            int CapacidadTanque = 10;
            int ConsumoCombustible = 2;
            tiposLicenciaAceptados = new List<string> {"M"};
        }
     
        public void HacerCaballito()
        {
            if (VelocidadActual > 0)
            {
                Console.WriteLine("¡Haciendo un caballito!");
            }
            else
            {
                Console.WriteLine("No se puede hacer un caballito si la moto esta apagada o parada.");
            }
        }
        public void MostrarInformacionMoto()
        {
            Console.WriteLine($"Capacidad del tanque: {CapacidadTanque} galones");
            Console.WriteLine($"Consumo de combustible: {ConsumoCombustible} galones/km");
        }
    }
}
