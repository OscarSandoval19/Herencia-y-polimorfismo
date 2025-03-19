using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio.MisClases
{
    internal class Camion : Vehiculo
    {
        private int capacidadCarga;
        private int pesoActual;
        private string tipoCarga;

        public Camion(int anio, string color, string marca, int capacidadCarga, string tipoCarga)
            : base(anio, color, marca)
        {
            this.capacidadCarga = capacidadCarga;
            this.tipoCarga = tipoCarga;
            this.pesoActual = 0;
        }

        public override void Frenar()
        {
            velocidad -= 5;
            Console.WriteLine("El camion ha frenado. Velocidad actual: " + velocidad);
        }
    }
}
