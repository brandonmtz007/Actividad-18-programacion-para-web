using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp5.Shared.Modelo
{
    public class Pedido
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "El número de pedido no puede estar vacío")]
        public int Numero_pedido { get; set; }

        [Required(ErrorMessage = "La fecha de pedido no puede estar vacía")]
        public DateTime Fecha_pedido { get; set; }

        [Required(ErrorMessage = "El estado no puede estar vacío")]
        [MaxLength(50)]
        public string? Estado { get; set; }

        [Required(ErrorMessage = "La fecha estimada no puede estar vacía")]
        public DateTime Fecha_estimada { get; set; }

        public int Cliente_id { get; set; }

        public virtual Persona? Cliente { get; set; }
        public virtual ICollection<Producto>? Productos { get; set; }
    }
}
