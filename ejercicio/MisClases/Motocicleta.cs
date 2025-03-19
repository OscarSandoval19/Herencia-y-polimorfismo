using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio.MisClases
{
    internal class Motocicleta : Vehiculo
    {
        private bool casco;
        private int cilindrada;
        private bool encendida;

        public Motocicleta(int anio, string color, string marca, int cilindrada)
            : base(anio, color, marca)
        {
            this.casco = true;
            this.cilindrada = cilindrada;
            this.encendida = false;
        }

        public override void Encender()
        {
            encendida = true;
            Console.WriteLine("La moto esta encendida.!");
        }
    }
}
