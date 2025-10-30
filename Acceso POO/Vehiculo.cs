using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acceso_POO
{
    internal class Vehiculo
    {
        private string marca { get; set; }
        private string modelo { get; set; }
        private float kilometraje { get; set; }

        public Vehiculo(string marca, string modelo, float kilometraje)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.kilometraje = kilometraje;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Marca del Vehiculo: {marca}\nModelo del Vehiculo: {modelo}\nKilometraje del vehiculo: {kilometraje}");
        }

        protected void CostoMantenamiento()
        {
            Console.WriteLine($"Costo de mantenimiento:\ncosto por kilometro: 700$\nKilometros: {kilometraje}\nCosto de Mantenimiento: {kilometraje*700}$");
        }

        public class Camion : Vehiculo
        {
            public Camion(string marca, string modelo, float kilometraje) : base(marca, modelo, kilometraje) { }
            public void CostoMantenimientoCamion()
            {
                CostoMantenamiento();
            }
        }
    }
}
