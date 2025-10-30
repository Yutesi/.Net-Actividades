using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Banco_de_Problemas_2
{
    internal class Libro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Editorial { get; set; }
        public int AñoPublicacion { get; set; }

        public Libro(string titulo, string autor, string editorial, int añoPublicacion)
        {
            Titulo = titulo;
            Autor = autor;
            Editorial = editorial;
            AñoPublicacion = añoPublicacion;
        }

        public class Biblioteca
        {
            public List<Libro>Libros = new List<Libro>();

            public void AgregarLibro()
            {
                Console.WriteLine("Dame el nombre del libro nuevo: ");
                string nombre = Console.ReadLine();

                Console.WriteLine("Dame el nombre del autor del libro: ");
                string autor = Console.ReadLine();

                Console.WriteLine("Dame el nombre de la editorial del libro; ");
                string editorial = Console.ReadLine();

                Console.WriteLine("Dame el año de la publicacion del libro: ");
                int publicacion = int.Parse(Console.ReadLine());

                Libro libro = new Libro(nombre, autor, editorial, publicacion);
                Libros.Add(libro);
                Console.WriteLine("\nLibro Agregado correctamente!");
            }

            public void ListarLibros()
            {
                Console.WriteLine("Libros: ");
                foreach(var libro in Libros)
                {
                    Console.WriteLine(libro.Titulo);
                }
                Console.WriteLine("\n");
            }

            public void BuscarLibro()
            {
                Console.WriteLine("Dame el nomber del libro que quieres buscar: ");
                string nombre = Console.ReadLine();

                var libro = Libros.Find(p => p.Titulo == nombre);
                if (libro != null)
                {
                    Console.WriteLine($"\nTitulo: {libro.Titulo}\nAutor: {libro.Autor}\nEditorial: {libro.Editorial}\nAño de publicacion: {libro.AñoPublicacion}");
                }
                else
                {
                    Console.WriteLine("Libro no encontrado");
                }
            }
        }
    }
}
