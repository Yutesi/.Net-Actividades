using Angel_Gregorio_Briceño_C_.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Angel_Gregorio_Briceño_C_.Models
{
    public class Venta
    {
        [Key]
        public int VentaId { get; set; }

        [Required]
        public int ClienteId { get; set; }

        [Required]
        public DateTime FechaVenta { get; set; } = DateTime.Now;

        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "El total debe ser mayor a 0")]
        public decimal Total { get; set; }

        // Relaciones
        public virtual Cliente Cliente { get; set; }
        public virtual ICollection<VentaDetalle> VentaDetalles { get; set; }
    }
}