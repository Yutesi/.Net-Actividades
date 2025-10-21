using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Banco_de_Problemas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float intereses;
            float interesesA = 0f;
            float original;

            Console.WriteLine("Dame la cantidad que pediras de prestamo:");
            float monto = float.Parse(Console.ReadLine());

            for (int i = 0; i < 5; i++) {
                intereses = monto * 0.05f;
                interesesA = interesesA + intereses;
                original = monto;
                monto = monto * 1.05f;

                Console.WriteLine($"Intereses del año {2025 + i}: {intereses}$");
                Console.WriteLine($"Intereses del tercer trimestre del año {2025 + i}: {original*0.0375f}$");
                Console.WriteLine($"Intereses del primer mes del año {2025 + i}: {original* 0.004166666666f}$");
                Console.WriteLine("");

            }
            Console.WriteLine($"Total a pagar: {monto}$ | Interese Total: {interesesA}$");
        }
    }
}
