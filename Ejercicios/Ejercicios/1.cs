using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Ejercicio 1
            //Console.WriteLine("Cual es tu salario?");
            //float salario = float.Parse(Console.ReadLine());

            //Console.WriteLine("Ahorro mensual programado?");
            //float ahorro = float.Parse(Console.ReadLine());

            //float eps = salario * 0.125f;
            //float pension = salario * 0.16f;
            //float total = salario - ahorro - eps - pension;

            //Console.WriteLine($"\nSalario: {salario}$\nValor de Ahorro Mensual Programado: {ahorro}$\nEPS: {eps}$\nFondo de Pensiones: {pension}$\nTotal a Recibir: {total}$");

            ////Ejercicio 2
            //Console.WriteLine("Cual es el valor de tu Matricula?");
            //float matricula = float.Parse(Console.ReadLine());

            //Console.WriteLine($"\nPrimera cuota: {matricula*0.4f}$\nSegunda cuota: {matricula*0.25f}$\nTercera cuota: {matricula * 0.2f}$\nCuarta cuota: {matricula * 0.15f}$\n");

            ////Ejercicio 3
            //Console.WriteLine("En que año naciste?");
            //int año = int.Parse(Console.ReadLine());
            //while (año>2025 || año<0) {
            //    Console.WriteLine("No parece ser un año valido...");
            //    año = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("Cual es tu nombre?");
            //string nombre = Console.ReadLine();

            //Console.WriteLine("Cual es tu direción?");
            //string direccion = Console.ReadLine();

            //int edad = Math.Abs(año - 2025);

            //Console.WriteLine($"Hola {nombre}!, vives en {direccion} y tienes {edad} años de edad");

            //Ejercicio 4
            //Console.WriteLine("Teniendo en cuenta que este tarro de 1 litro se llena en 1 hora y media, mis otros 2 tarros de 5 litro y de 3 litros se llenaran en:");
            //float tlitros = (90f * 3f) / 60f;
            //float clitros = (90f * 5f) / 60f;

            //Console.WriteLine($"Tarro de 3 litros: {(int)tlitros} horas y {60 * (tlitros - (int)tlitros)} minutos");
            //Console.WriteLine($"Tarro de 5 litros: {(int)clitros} horas y {60 * (clitros - (int)clitros)} minutos");

            //Ejercicio 5
            //float altura = 1;
            //float relacion = 5f / 7f;
            //Console.WriteLine("Subamos la montaña! cuanto subiras en metros? (Ingresa 0 para salir)");
            //while (altura != 0)
            //{
            //    altura = float.Parse(Console.ReadLine());
            //    if (altura < 0)
            //    {
            //        Console.WriteLine("Acaso eres un topo? no creo que puedas ir debajo de la montaña\n");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Te tardaras {relacion * altura} horas\n");
            //    }
            //}

        }
    }
}
