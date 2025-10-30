using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Producto.ProductoCRUD producto = new Producto.ProductoCRUD();
            Persona.PersonaCRUD persona = new Persona.PersonaCRUD();
            bool salir = false;
            while (!salir)
            {
                Console.Clear();
                ////linea para los productos
                //Console.WriteLine($"Que deseas hacer?:\n1.Agregar producto\n2.Mostrar producto\n3.Actualizar un producto\n4.Eliminar un producto\n5.Salir\n");
                //string opcion = Console.ReadLine();
                //switch (opcion)
                //{
                //    case "1":
                //        producto.AgregarProducto();
                //        Console.ReadKey();
                //        break;
                //    case "2":
                //        producto.MostrarProducto();
                //        Console.ReadKey();
                //        break;
                //    case "3":
                //        producto.ActualizarProducto();
                //        Console.ReadKey();
                //        break;
                //    case "4":
                //        producto.BorrarProducto();
                //        Console.ReadKey();
                //        break;
                //    case "5":
                //        Console.WriteLine("Adios...");
                //        salir = true;
                //        break;
                //    default:
                //        Console.WriteLine("Opcion no Valida, intenta otra vez");
                //        Console.ReadKey();
                //        break;
                //}

                //linea para las personas
                Console.WriteLine($"Que deseas hacer?:\n1.Agregar persona\n2.Mostrar detalles de la persona\n3.Actualizar una persona\n4.Eliminar un persona\n5.Edad en dias de una persona\n6.Salir\n");
                string opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        persona.AgregarPersona();
                        Console.ReadKey();
                        break;
                    case "2":
                        persona.ImprimirDetalles();
                        Console.ReadKey();
                        break;
                    case "3":
                        persona.ActualizarPersona();
                        Console.ReadKey();
                        break;
                    case "4":
                        persona.BorrarPersona();
                        Console.ReadKey();
                        break;
                    case "5":
                        persona.EdadenDias();
                        Console.ReadKey();
                        break;
                    case "6":
                        Console.WriteLine("Adios...");
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opcion no Valida, intenta otra vez");
                        Console.ReadKey();
                        break;
                }
            }

        }
    }
}
