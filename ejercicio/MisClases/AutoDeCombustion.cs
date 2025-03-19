using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio.MisClases
{
    internal class AutoDeCombustion : Vehiculo
    {
        private int nivelCombustible;
        private string tipoCombustible;
        private int capacidadTanque;

        public AutoDeCombustion(int anio, string color, string marca, int capacidadTanque, string tipoCombustible)
            : base(anio, color, marca)
        {
            this.capacidadTanque = capacidadTanque;
            this.tipoCombustible = tipoCombustible;
            this.nivelCombustible = capacidadTanque;
        }

        public override void Frenar()
        {
            velocidad -= 15;
            nivelCombustible -= 1;
            Console.WriteLine("El auto ha frenado. Velocidad actual: " + velocidad + ", combustible restante: " + nivelCombustible);
        }
    }

}

