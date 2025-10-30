using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acceso_POO
{
    internal class Animal
    {
        protected string especie { get; set; }

        public Animal(string especie)
        {
            this.especie = especie;
        }

        protected void MostrarEspecie()
        {
            Console.WriteLine($"La especie del animal es {especie}");
        }

        public class Perro : Animal
        {
            public Perro(string especie) : base(especie)
            {
            }

            public void MostrarInfoPerro()
            {
                MostrarEspecie();
            }

        }
    }
}
