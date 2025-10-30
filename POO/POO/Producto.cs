using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Producto
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public float Precio { get; set; }

        public Producto(int iD, string nombre, float precio)
        {
            ID = iD;
            Nombre = nombre;
            Precio = precio;
        }

        public class ProductoCRUD
        {
            public List<Producto> productos = new List<Producto>();
            public int siguienteID = 1;

            public void AgregarProducto()
            {
                Console.WriteLine("Ingrese el nombre del producto");
                string nombre = Console.ReadLine();

                Console.WriteLine("Ingrese el precio del producto");
                float precio = float.Parse(Console.ReadLine());

                Producto nuevoProducto = new Producto(siguienteID++, nombre, precio);
                productos.Add(nuevoProducto);

                Console.WriteLine("Producto agregado exitosamente");
            }
            //mostrar productos
            public void MostrarProducto()
            {
                Console.WriteLine("Lista de Productos:");
                foreach (var producto in productos)
                {
                    Console.WriteLine($"\nID: {producto.ID} - Nombre: {producto.Nombre} - Precio: {producto.Precio}$");
                }
            }

            public void ActualizarProducto()
            {
                Console.WriteLine("Ingrese el ID del producto a actualizar");
                int idactulizar = int.Parse(Console.ReadLine());
                var producto = productos.Find(p => p.ID == idactulizar);
                if (producto != null)
                {
                    Console.WriteLine("Ingrese el unevo nombre del producto: ");
                    producto.Nombre = Console.ReadLine();
                    Console.WriteLine("Ingrese el nuevo precio del producto: ");
                    producto.Precio = float.Parse(Console.ReadLine());

                    Console.WriteLine("\nProducto agregado exitosamente");
                }
                else 
                {
                    Console.WriteLine("Producto no encontrado");
                }
            }

            public void BorrarProducto()
            {
                Console.WriteLine("Ingrese el ID del producto a borrar");
                int idborrar = int.Parse(Console.ReadLine());
                var producto = productos.Find(p => p.ID == idborrar);
                if (producto != null)
                {
                    productos.Remove(producto);

                    Console.WriteLine("\nProducto borrado exitosamente");
                }
                else
                {
                    Console.WriteLine("Producto no encontrado");
                }
            }
        }
    }
}
