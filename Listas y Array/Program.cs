using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_y_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //arrays
            //tipo[] nombrearray = new tipo[longitud] o {valores1, valores2. valores3...};

            //int[] numeros2 = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            //List<tipo> nombre = new list<tipo>(); declarar listas vacias o inicializadas (valores en los parentesis)
            //NombreDeLista.add(valor); agrega un valor
            //NombreDeLista.insert(posicion, valor); agrega un valor en una posicion


            //foreach (variable in nombredelalista): recorre lista

            //int[] numeros = new int[10];
            //int suma = 0;
            //Console.WriteLine("Dame 10 numeros");
            //for (int i = 0; i < numeros.Length; i++)
            //{
            //    Console.WriteLine($"numero {i + 1}:");
            //    numeros[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("\nNumeros ingresados:");
            //foreach (int e in numeros)
            //{
            //    Console.WriteLine(e);
            //    suma += e; 
            //}
            //Console.WriteLine($"Suma total: {suma}");


            //List<int> numeros = new List<int>();
            //for (int i = 1; i <= 10; i++) {
            //    numeros.Add(i);
            //}
            //Console.WriteLine("Numeros en lista:");
            //foreach (var numero in numeros)
            //{
            //    Console.WriteLine(numero);
            //}
            //Console.WriteLine($"\nNumero en posición 3: {numeros[2]}");
            //Console.WriteLine($"Ahora ese numero lo modificamos a {numeros[2] = 11}, y ahora es {numeros[2]}");
            //numeros.Insert(2, 2);
            //Console.WriteLine($"E insertamos un numero en esa posición (perdimos el 2): {numeros[2]}");
            //numeros.RemoveAt(9);
            //Console.WriteLine($"No me gusta el ultimo numero, borremoslo {numeros[9]}, (ya no es 10 el ultimo)");
            //numeros.Remove(1);
            //Console.WriteLine($"No me gustó el 1, quitemoslo");

            int opcion = 0;
            Dictionary<string, float> productos = new Dictionary<string, float>();
            while (opcion != 4) {
                Console.Clear();
                Console.WriteLine($"Que deseas hacer?:\n1.Agregar producto\n2.Actualizar un producto\n3.Eliminar un producto\n4.Salir\n");
                Console.WriteLine($"Producto     |     Precio");
                foreach (KeyValuePair<string, float> producto in productos)
                {
                    Console.WriteLine($"{producto.Key} | {producto.Value}");
                }
                Console.WriteLine($"\n\nTu opción:");
                opcion = int.Parse(Console.ReadLine());

                if (opcion == 1)
                {
                    Console.WriteLine($"\n\nDame el nombre del producto:");
                    string nombrep = Console.ReadLine();
                    Console.WriteLine("\nDame el Precio del producto:");
                    float preciop = float.Parse(Console.ReadLine());
                    productos.Add(nombrep, preciop);
                    Console.WriteLine("\nProducto agregado!");
                    Console.ReadKey();
                }
                else if (opcion == 2)
                {
                    Console.WriteLine($"\n\nDame el nombre del producto a actualizar el precio:");
                    string nombrep = Console.ReadLine();
                    while (!productos.ContainsKey(nombrep))
                    {
                        Console.WriteLine($"Producto no existe");
                        nombrep = Console.ReadLine();
                    }
                    Console.WriteLine($"Dame el nuevo precio del producto:");
                    float preciopn = float.Parse(Console.ReadLine());
                    productos[nombrep] = preciopn;
                    Console.WriteLine("\nProducto actualizado!");
                    Console.ReadKey();
                }
                else if (opcion == 3)
                {
                    Console.WriteLine($"\n\nDame el nombre del producto a eliminar:");
                    string nombrep = Console.ReadLine();
                    while (!productos.ContainsKey(nombrep))
                    {
                        Console.WriteLine($"Producto no existe");
                        nombrep = Console.ReadLine();
                    }
                    productos.Remove(nombrep);
                    Console.WriteLine("\nProducto borrado!");
                    Console.ReadKey();
                }
                else if (opcion == 4)
                {
                    Console.WriteLine("Adios...");
                }
                else
                {
                    Console.WriteLine("Opcion no Valida");
                    Console.ReadKey();
                }
            }
        }
    }
}
