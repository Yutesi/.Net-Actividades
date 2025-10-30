using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acceso_POO
{
    internal class Persona
    {
        public string nombre { get; set; }
        private int edad { get; set; }

        public Persona(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        private void MostrarEdad()
        {
            Console.WriteLine($"La edad de {nombre} es {edad}");
        }

        public void MonstrarInformacion()
        {
            MostrarEdad();
        }
    }
}
