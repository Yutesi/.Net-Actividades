using Angel_Gregorio_Briceño_C_.Models;
using System.ComponentModel.DataAnnotations;

namespace Angel_Gregorio_Briceño_C_.Models
{
    public class VentaDetalle
    {
        [Key]
        public int VentaDetalleId { get; set; }

        [Required]
        public int VentaId { get; set; }

        [Required]
        public int ProductoId { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "La cantidad debe ser al menos 1")]
        public int Cantidad { get; set; }

        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "El precio debe ser mayor a 0")]
        public decimal Precio { get; set; }

        // Relaciones
        public virtual Venta Venta { get; set; }
        public virtual Producto Producto { get; set; }
    }
}