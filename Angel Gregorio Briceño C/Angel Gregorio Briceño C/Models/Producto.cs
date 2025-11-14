using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Angel_Gregorio_Briceño_C_.Models
{
    public class Producto
    {
        [Key]
        public int ProductoId { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El precio es obligatorio")]
        [Range(0.01, double.MaxValue, ErrorMessage = "El precio debe ser mayor a 0")]
        public decimal Precio { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "El stock no puede ser negativo")]
        public int Stock { get; set; }

        [StringLength(500)]
        public string Descripcion { get; set; }

        // Relación: Un producto puede estar en muchos detalles de venta
        public virtual ICollection<VentaDetalle>? VentaDetalles { get; set; }
    }
}