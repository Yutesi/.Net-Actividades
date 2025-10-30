using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Aprendiz
    {

        public string Nombre { get; set; }
        public int Edad { get; set; }

        public Aprendiz(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        public void VerificarEdad()
        {
            if (Edad >= 18)
            {
                Console.WriteLine($"{Nombre} es mayor de edad");
            }
            else
            {
                Console.WriteLine($"{Nombre} es menor de edad");
            }
        }
    }
}
