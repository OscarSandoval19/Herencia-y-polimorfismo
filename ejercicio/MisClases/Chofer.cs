using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ejercicio.MisClases.Interfaces;

namespace ejercicio.MisClases
{
    public class Chofer
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        private string tipoLicencia;

        public string TipoLicencia
        {
            get { return tipoLicencia; }
            set
            {
                if (ValidarLicencia(value, Edad))
                    tipoLicencia = value;
                else
                    throw new ArgumentException("Edad no permitida para este tipo de licencia");
            }
        }

        public Chofer(string nombre, int edad, string tipoLicencia)
        {
            Nombre = nombre;
            Edad = edad;
            TipoLicencia = tipoLicencia;
        }

        private bool ValidarLicencia(string licencia, int edad)
        {
            return (licencia == "A" && edad >= 23) ||
                   (licencia == "B" && edad >= 21) ||
                   (licencia == "C" && edad >= 18) ||
                   (licencia == "M" && edad >= 18);
        }
    

        public void mostrarInformacion()
        {
            Console.WriteLine("El piloto es {0}", Nombre);
            Console.WriteLine("Licencia tipo:{0}", TipoLicencia);
        }
    }

}

