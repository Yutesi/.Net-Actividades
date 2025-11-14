using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Angel_Gregorio_Briceño_C_.Models
{
    public class Cliente
    {
        [Key]
        public int ClienteId { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El email es obligatorio")]
        [EmailAddress(ErrorMessage = "Formato de email inválido")]
        public string Email { get; set; }

        [StringLength(15)]
        public string Telefono { get; set; }

        [StringLength(200)]
        public string Direccion { get; set; }

        // Relación: Un cliente puede tener muchas ventas
        public virtual ICollection<Venta>? Ventas { get; set; }
    }
}