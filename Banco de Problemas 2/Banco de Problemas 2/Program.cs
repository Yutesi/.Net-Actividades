using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_de_Problemas_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Punto 1 en banco de problemas 1
            //Punto 2 en banco de problemas 2
            //Punto 3 en el archivo "POO"

            ////Punto 4
            //Libro.Biblioteca libro =  new Libro.Biblioteca();
            //bool salir = false;
            //while (!salir)
            //{
            //    Console.Clear();
            //    Console.WriteLine($"Que deseas hacer?:\n1.Agregar libro\n2.Listar libros\n3.Buscar Libro\n4.Salir\n");
            //    string opcion = Console.ReadLine();
            //    switch (opcion)
            //    {
            //        case "1":
            //            libro.AgregarLibro();
            //            Console.ReadKey();
            //            break;
            //        case "2":
            //            libro.ListarLibros();
            //            Console.ReadKey();
            //            break;
            //        case "3":
            //            libro.BuscarLibro();
            //            Console.ReadKey();
            //            break;
            //        case "4":
            //            Console.WriteLine("Adios...");
            //            salir = true;
            //            break;
            //        default:
            //            Console.WriteLine("Opcion no Valida, intenta otra vez");
            //            Console.ReadKey();
            //            break;
            //    }
            //}

            ////Punto 5
            //int creditos;
            //int valorCredito;
            //int descuento;
            //float totalabs = 0;
            //float total;
            //float descuentoabs = 0;
            //float creditosabs = 0;
            //float descuentod; 
            //List<int> inscritos = new List<int> { 0, 0, 0, 0, 0 };

            //Console.WriteLine("Cuantos estudiantes se matricularan a la universidad?");
            //int cant = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= cant; i++)
            //{
            //    Console.WriteLine($"\nEstudiante {i}:\n");
            //    Console.WriteLine("Cual programa academico se matriculara?\n1.Ingeniería de sistemas\n2.Psicología\n3.Economía\n4.Comunicación Social\n5.Administración de Empresas");
            //    string programa = Console.ReadLine();
            //    while (programa != "1" && programa != "2" && programa != "3" && programa != "4" && programa != "5")
            //    {
            //        Console.WriteLine("\nOpcion invalida, recuerda colocar el numero de la opción");
            //        programa = Console.ReadLine();
            //    }
            //    Console.WriteLine("\nPagara la matricula en Efectivo (E) o en Linea (L)?");
            //    string pago = Console.ReadLine();
            //    pago = pago.ToUpper();
            //    while (pago != "E" && pago != "L")
            //    {
            //        Console.WriteLine("Opcion invalida, Efectivo (E) o Linea (L)");
            //        pago = Console.ReadLine();
            //        pago = pago.ToUpper();
            //    }

            //    switch (programa)
            //    {
            //        case "1":
            //            creditos = 20;
            //            valorCredito = 200000;
            //            descuento = 18;

            //            Console.WriteLine($"Creditos del programa: {creditos}");

            //            if (pago == "E")
            //            {
            //                descuentod = (creditos * valorCredito) * (descuento / 100f);
            //                total = (creditos * valorCredito) * (1f - (descuento / 100f));
            //                Console.WriteLine($"Ha recibido un descuento del {descuento}% por pagar en efectivo, total a pagar: {total}");
            //                descuentoabs = descuentoabs + descuentod;
            //            }
            //            else
            //            {
            //                total = creditos * valorCredito;
            //                Console.WriteLine($"Total a pagar: {total}");
            //            }
            //            inscritos[0] = inscritos[0]+1;
            //            totalabs = totalabs + total;
            //            creditosabs = creditosabs + creditos;
            //            break;

            //        case "2":
            //            creditos = 18;
            //            valorCredito = 200000;
            //            descuento = 12;

            //            Console.WriteLine($"Creditos del programa: {creditos}");

            //            if (pago == "E")
            //            {
            //                descuentod = (creditos * valorCredito) * (descuento / 100f);
            //                total = (creditos * valorCredito) * (1f - (descuento / 100f));
            //                Console.WriteLine($"Ha recibido un descuento del {descuento}% por pagar en efectivo, total a pagar: {total}");
            //                descuentoabs = descuentoabs + descuentod;
            //            }
            //            else
            //            {
            //                total = creditos * valorCredito;
            //                Console.WriteLine($"Total a pagar: {total}");
            //            }
            //            inscritos[1] = inscritos[1]+1;
            //            totalabs = totalabs + total;
            //            creditosabs = creditosabs + creditos;
            //            break;
            //        case "3":
            //            creditos = 18;
            //            valorCredito = 200000;
            //            descuento = 10;

            //            Console.WriteLine($"Creditos del programa: {creditos}");

            //            if (pago == "E")
            //            {
            //                descuentod = (creditos * valorCredito) * (descuento / 100f);
            //                total = (creditos * valorCredito) * (1f - (descuento / 100f));
            //                Console.WriteLine($"Ha recibido un descuento del {descuento}% por pagar en efectivo, total a pagar: {total}");
            //                descuentoabs = descuentoabs + descuentod;
            //            }
            //            else
            //            {
            //                total = creditos * valorCredito;
            //                Console.WriteLine($"Total a pagar: {total}");
            //            }
            //            inscritos[2] = inscritos[2]+1;
            //            totalabs = totalabs + total;
            //            creditosabs = creditosabs + creditos;
            //            break;
            //        case "4":
            //            creditos = 18;
            //            valorCredito = 200000;
            //            descuento = 5;

            //            Console.WriteLine($"Creditos del programa: {creditos}");

            //            if (pago == "E")
            //            {
            //                descuentod = (creditos * valorCredito) * (descuento / 100f);
            //                total = (creditos * valorCredito) * (1f - (descuento / 100f));
            //                Console.WriteLine($"Ha recibido un descuento del {descuento}% por pagar en efectivo, total a pagar: {total}");
            //                descuentoabs = descuentoabs + descuentod;
            //            }
            //            else
            //            {
            //                total = creditos * valorCredito;
            //                Console.WriteLine($"Total a pagar: {total}");
            //            }
            //            inscritos[3] = inscritos[3]+1;
            //            totalabs = totalabs + total;
            //            creditosabs = creditosabs + creditos;
            //            break;
            //        case "5":
            //            creditos = 20;
            //            valorCredito = 200000;
            //            descuento = 5;

            //            Console.WriteLine($"Creditos del programa: {creditos}");

            //            if (pago == "E")
            //            {
            //                descuentod = (creditos * valorCredito) * (descuento / 100f);
            //                total = (creditos * valorCredito) * (1f - (descuento / 100f));
            //                Console.WriteLine($"Ha recibido un descuento del {descuento}% por pagar en efectivo, total a pagar: {total}");
            //                descuentoabs = descuentoabs + descuentod;
            //            }
            //            else
            //            {
            //                total = creditos * valorCredito;
            //                Console.WriteLine($"Total a pagar: {total}");
            //            }
            //            inscritos[4] = inscritos[4]+1;
            //            totalabs = totalabs + total;
            //            creditosabs = creditosabs + creditos;
            //            break;

            //        default:
            //            break;

            //    }
            //}
            //Console.WriteLine($"\nInscritos en Ingeniería de sistemas: {inscritos[0]}\nInscritos en Psicología: {inscritos[1]}\nInscritos en Economía: {inscritos[2]}\nInscritos en Comunicación Social: {inscritos[3]}\nInscritos en Administración de Empresas: {inscritos[4]}");
            //Console.WriteLine($"\nTotal de créditos inscritos: {creditosabs}\nValor total pagado (sin descuento): {totalabs + descuentoabs}\nValor total de descuentos aplicados: {descuentoabs}\nValor neto de las inscripciones: {totalabs}");

            ////Punto 6
            //    Console.WriteLine("=== SISTEMA DE VENTAS COMPUTRONIC ===");

            //    Console.Write("Ingrese la cantidad de empleados: ");
            //    int cantidadEmpleados = int.Parse(Console.ReadLine());
            //    while (cantidadEmpleados <= 0 || cantidadEmpleados>=15)
            //    {
            //        Console.Write("No me gusto ese numero, intenta otra vez: ");
            //        cantidadEmpleados = int.Parse(Console.ReadLine());
            //    }

            //    for (int i = 0; i < cantidadEmpleados; i++)
            //    {
            //        Console.WriteLine($"\n--- Empleado {i + 1} ---");
            //        ProcesarEmpleado(i + 1);
            //    }
            //}

            //static void ProcesarEmpleado(int numeroEmpleado)
            //{
            //    Console.Write($"Ingrese la cantidad de ventas realizadas por el empleado {numeroEmpleado}: ");
            //    int cantidadVentas = int.Parse(Console.ReadLine());
            //    while (cantidadVentas <= 0)
            //    {
            //        Console.Write("No me gusto ese numero, intenta otra vez: ");
            //        cantidadVentas = int.Parse(Console.ReadLine());
            //    }

            //    int ventasMenorIgual300k = 0;
            //    int ventasEntre300k800k = 0;
            //    int ventasMayorIgual800k = 0;
            //    double totalVentas = 0;
            //    double bonificacionTotal = 0;

            //    for (int i = 0; i < cantidadVentas; i++)
            //    {
            //        Console.Write($"Ingrese el valor de la venta {i + 1}: $");
            //        double venta = double.Parse(Console.ReadLine());
            //        while(venta <= 0)
            //        {
            //            Console.Write("No me gusto ese numero, intenta otra vez: ");
            //            venta = double.Parse(Console.ReadLine());
            //        }

            //        double bonificacion = CalcularBonificacion(venta);

            //        if (venta <= 300000)
            //        {
            //            ventasMenorIgual300k++;
            //        }
            //        else if (venta > 300000 && venta < 800000)
            //        {
            //            ventasEntre300k800k++;
            //        }
            //        else
            //        {
            //            ventasMayorIgual800k++;
            //        }

            //        totalVentas += venta;
            //        bonificacionTotal += bonificacion;
            //    }

            //    MostrarResultadosEmpleado(numeroEmpleado, ventasMenorIgual300k, ventasEntre300k800k,
            //                            ventasMayorIgual800k, totalVentas, bonificacionTotal);
            //}

            //static double CalcularBonificacion(double venta)
            //{
            //    if (venta <= 400000)
            //    {
            //        return venta * 0.03;
            //    }
            //    else if (venta > 400000 && venta <= 800000)
            //    {
            //        return venta * 0.05;
            //    }
            //    else
            //    {
            //        return venta * 0.10;
            //    }
            //}

            //static void MostrarResultadosEmpleado(int numeroEmpleado, int ventasMenor300k, int ventasEntre300k800k,
            //                                    int ventasMayor800k, double totalVentas, double bonificacionTotal)
            //{
            //    const double PAGO_BASICO = 500000;
            //    double totalPagar = PAGO_BASICO + bonificacionTotal;

            //    Console.WriteLine($"\n--- RESULTADOS EMPLEADO {numeroEmpleado} ---");
            //    Console.WriteLine($"Ventas ≤ $300.000: {ventasMenor300k}");
            //    Console.WriteLine($"Ventas > $300.000 y < $800.000: {ventasEntre300k800k}");
            //    Console.WriteLine($"Ventas ≥ $800.000: {ventasMayor800k}");
            //    Console.WriteLine($"Total ventas realizadas: ${totalVentas:N2}");
            //    Console.WriteLine($"Pago básico: ${PAGO_BASICO:N2}");
            //    Console.WriteLine($"Bonificación: ${bonificacionTotal:N2}");
            //    Console.WriteLine($"TOTAL A PAGAR: ${totalPagar:N2}");
            //    Console.WriteLine("----------------------------------------");

            ////ejercicio 7
            //int menores30 = 0;
            //int masculinos = 0;
            //int femeninos = 0;
            //int masculinos12a30 = 0;
            //int registradosFuera = 0;
            //int añoActual = 2025;
            //string salir = "";
            //int i = 0;

            //Console.WriteLine("--Registro de accidentes--");

            //while (salir != "salir")
            //{
            //    Console.Write("\nIngrese el nombre del conductor o 'salir' para salir: ");
            //    salir = Console.ReadLine();
            //    salir = salir.Trim().ToLower();
            //    if (salir == "salir") { break; }

            //    i++;

            //    Console.WriteLine($"\nConductor {i}:");

            //        Console.Write("Año de nacimiento: ");
            //        int añoNacimiento = int.Parse(Console.ReadLine());
            //        while (añoNacimiento > 2025 || añoNacimiento < 1905)
            //        {
            //            Console.Write("y yo nací ayer, Año de nacimiento: ");
            //            añoNacimiento = int.Parse(Console.ReadLine());
            //        }

            //        Console.Write("Sexo (1: Femenino, 2: Masculino): ");
            //        int sexo = int.Parse(Console.ReadLine());
            //        while (sexo <= 0 || sexo > 2)
            //        {
            //            Console.Write("Uhm... ese sexo no esta disponible (1: Femenino, 2: Masculino): ");
            //            sexo = int.Parse(Console.ReadLine());
            //        }

            //        Console.Write("Registro (1: Bogotá, 2: Otras ciudades): ");
            //        int registro = int.Parse(Console.ReadLine());
            //        while (registro <= 0 || registro > 2)
            //        {
            //            Console.Write("Ciudad invalida (1: Bogotá, 2: Otras ciudades): ");
            //            registro = int.Parse(Console.ReadLine());
            //        }

            //        int edad = añoActual - añoNacimiento;

            //        if (edad < 30) menores30++;

            //        if (sexo == 1) femeninos++;
            //        if (sexo == 2) masculinos++;

            //        if (sexo == 2 && edad >= 12 && edad <= 30) masculinos12a30++;

            //        if (registro == 2) registradosFuera++;
            //}

            //double porcMenores30 = (menores30 * 100.0) / i;
            //double porcMasculinos = (masculinos * 100.0) / i;
            //double porcFemeninos = (femeninos * 100.0) / i;
            //double porcMasculinos12a30 = (masculinos12a30 * 100.0) / i;
            //double porcRegistradosFuera = (registradosFuera * 100.0) / i;

            //Console.WriteLine("\nNuestro resultados arrojaron que: ");
            //Console.WriteLine($"Porcentaje de conductores menores de 30 años: {porcMenores30:F2}%");
            //Console.WriteLine($"Porcentaje de conductores masculinos: {porcMasculinos:F2}%");
            //Console.WriteLine($"Porcentaje de conductores femeninos: {porcFemeninos:F2}%");
            //Console.WriteLine($"Porcentaje de conductores masculinos (12-30 años): {porcMasculinos12a30:F2}%");
            //Console.WriteLine($"Porcentaje de conductores registrados fuera de Bogotá: {porcRegistradosFuera:F2}%");

            ////Ejercicio 8
            //Console.Write("Ingrese la cantidad de empleados: ");
            //int n = int.Parse(Console.ReadLine());

            //int[] cumplesPorMes = new int[12];
            //double[] bonosPorMes = new double[12];
            //int totalEdades = 0;
            //int empleadosConBono = 0;
            //double totalBonos = 0;

            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine($"\nEmpleado {i + 1}:");

            //    Console.Write("Año de nacimiento: ");
            //            int añoNacimiento = int.Parse(Console.ReadLine());
            //            while (añoNacimiento > 2025 || añoNacimiento < 1905)
            //            {
            //                Console.Write("Año de nacimiento invalido, otra vez: ");
            //                añoNacimiento = int.Parse(Console.ReadLine());
            //            }

            //    Console.Write("Mes de nacimiento (1-12): ");
            //    int mesNacimiento = int.Parse(Console.ReadLine());
            //    while(mesNacimiento<=0 || mesNacimiento > 12)
            //    {
            //        Console.Write("Mes de nacimiento invalido (1-12): ");
            //        mesNacimiento = int.Parse(Console.ReadLine());
            //    }

            //    int edad = 2025 - añoNacimiento;
            //    totalEdades += edad;

            //    if (edad > 18 && edad < 50)
            //    {
            //        empleadosConBono++;
            //        cumplesPorMes[mesNacimiento - 1]++;
            //        bonosPorMes[mesNacimiento - 1] += 150000;
            //        totalBonos += 150000;
            //    }
            //}

            //double promedioEdades = (double)totalEdades / n;

            //Console.WriteLine("\n=== RESULTADOS ===");
            //Console.WriteLine($"Promedio de edades: {promedioEdades:F1} años");
            //Console.WriteLine($"Total empleados con bono: {empleadosConBono}");
            //Console.WriteLine($"Total dinero en bonos: ${totalBonos:N0}");

            //Console.WriteLine("\n=== BONOS POR MES ===");
            //string[] meses = {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio",
            //             "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"};

            //for (int i = 0; i < 12; i++)
            //{
            //    if (cumplesPorMes[i] > 0)
            //    {
            //        Console.WriteLine($"{meses[i]}: {cumplesPorMes[i]} empleados - ${bonosPorMes[i]:N0}");
            //    }
            //}

            ////Ejercicio 9
            //Console.WriteLine("=== Hora de trabajar ===");

            //for (int camion = 1; camion <= 20; camion++)
            //{
            //    Console.WriteLine($"\n--- Camión {camion} ---");
            //    Console.Write("Capacidad del camión (18000-28000 litros): ");
            //    int capacidad = int.Parse(Console.ReadLine());
            //    while (capacidad < 18000 || capacidad > 28000)
            //    {
            //        Console.Write("No tenemos un camnion con esa capacidad (18000-28000 litros): ");
            //        capacidad = int.Parse(Console.ReadLine());
            //    }

            //    int cargaActual = 0;
            //    bool camionLleno = false;

            //    while (!camionLleno)
            //    {
            //        Console.Write("Peso del tanque (3000-9000 litros): ");
            //        int tanque = int.Parse(Console.ReadLine());
            //        while (tanque < 3000 || tanque > 9000)
            //        {
            //            Console.Write("No tenemos un tanque asi (3000-9000 litros): ");
            //            tanque = int.Parse(Console.ReadLine());
            //        }

            //        if (cargaActual + tanque > capacidad)
            //        {
            //            Console.WriteLine("¡DESPACHAR CAMIÓN! - Siguiente tanque excede la capacidad");
            //            camionLleno = true;
            //        }
            //        else
            //        {
            //            cargaActual += tanque;
            //            Console.WriteLine($"Cargar tanque. Carga actual: {cargaActual}/{capacidad} litros");

            //            if (cargaActual == capacidad)
            //            {
            //                Console.WriteLine("¡CAMION LLENO! - Despachar");
            //                camionLleno = true;
            //            }
            //        }
            //    }
            //}

            //Console.WriteLine("\n=== FIN DE LA JORNADA ===");
        }
    }
}
