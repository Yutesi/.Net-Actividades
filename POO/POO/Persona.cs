using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Genero { get; set; }

        public Persona(string nombre, int edad, string genero)
        {
            Nombre = nombre;
            Edad = edad;
            Genero = genero;
        }

        public class PersonaCRUD
        {
            public List<Persona> personas = new List<Persona>();
            public void AgregarPersona()
            {
                Console.WriteLine("\nIngrese el nombre de la persona");
                string nombre = Console.ReadLine();

                Console.WriteLine("Ingrese la edad de la persona");
                int edad = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el genero de la persona (F / M)");
                string genero = Console.ReadLine().ToUpper();
                while (genero != "F" && genero != "M")
                {
                    Console.WriteLine("Valor ingersado invalido (F / M)");
                    genero = Console.ReadLine().ToUpper();
                }

                Persona nuevaPersona = new Persona(nombre, edad, genero);
                personas.Add(nuevaPersona);

                Console.WriteLine("\nPersona agregada exitosamente!");
            }

            public void ImprimirDetalles()
            {
                Console.WriteLine("\nIngrese el nombre de la persona para ver sus detalles: ");
                string nombre = Console.ReadLine();

                var persona = personas.Find(p => p.Nombre == nombre);
                if (persona != null)
                {
                    Console.WriteLine($"Nombre: {persona.Nombre}\nEdad: {persona.Edad}\nGenero: {persona.Genero}");
                }
                else
                {
                    Console.WriteLine("Persona no encontrada");
                }
            }

            public void ActualizarPersona()
            {
                Console.WriteLine("\nIngrese el nombre de la persona para actualizarla: ");
                string nombre = Console.ReadLine();

                var persona = personas.Find(p => p.Nombre == nombre);
                if (persona != null)
                {

                    Console.WriteLine("Ingrese la nueva edad de la persona");
                    persona.Edad = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese el genero actualizado de la persona (F / M)");
                    persona.Genero = Console.ReadLine().ToUpper();
                    while (persona.Genero != "F" && persona.Genero != "M")
                    {
                        Console.WriteLine("Valor ingersado invalido (F / M)");
                        persona.Genero = Console.ReadLine().ToUpper();
                    }
                    Console.WriteLine("\nPersona actualizada exitosamente!");
                }
                else
                {
                    Console.WriteLine("Persona no encontrada");
                }
            }

            public void BorrarPersona()
            {
                Console.WriteLine("\nIngrese el nombre de la persona a borrar: ");
                string nombre = Console.ReadLine();

                var persona = personas.Find(p => p.Nombre == nombre);
                if (persona != null)
                {
                    personas.Remove(persona);
                    Console.WriteLine("\nPersona borrada exitosamente!");
                }
                else
                {
                    Console.WriteLine("Persona no encontrada");
                }
            }

            public void EdadenDias()
            {
                Console.WriteLine("\nIngrese el nombre de la persona a calcular su edad en dias: ");
                string nombre = Console.ReadLine();

                var persona = personas.Find(p => p.Nombre == nombre);
                if (persona != null)
                {
                    float dias = persona.Edad * 365.25f;
                    Console.WriteLine($"Edad de {persona.Nombre} en dias: {dias}");
                }
                else
                {
                    Console.WriteLine("Persona no encontrada");
                }
            }
        }
    }
}
