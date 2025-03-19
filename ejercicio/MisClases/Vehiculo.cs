using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio.MisClases
{
    internal class Vehiculo
    {
        public string Color { get; set; }
        public string Modelo { get; }
        public int Year { get; }

        public int velocidad = 0;



        public Vehiculo(int anio, string elColor, string elModelo)
        {
            this.Color = elColor;   
            this.Modelo = elModelo;
            this.Year = anio;
        }

        public void InformacionVehiculo()
        {
            Console.WriteLine("Color {0}:", this.Color);
            Console.WriteLine("Modelo {0}:", this.Modelo);
            Console.WriteLine("Año {0};", this.Year);
        }
        public virtual void acelerar(int cuanto)
        {
            velocidad += cuanto;
            Console.WriteLine("Vas a {0} KMS / Hora",velocidad);
        }
        public virtual void Frenar()
        {
            Console.WriteLine("El vehiculo está frenando.");
        }
        public virtual void Encender()
        {
            Console.WriteLine("El vehiculo está encendido.");
        }
    }
}
