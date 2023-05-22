using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp5.Shared.Modelo
{
    public class Persona
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre no puede estar vacío")]
        [MaxLength(50)]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "La dirección no puede estar vacía")]
        [MaxLength(100)]
        public string? Direccion { get; set; }

        [Required(ErrorMessage = "El correo no puede estar vacío")]
        [MaxLength(50)]
        [EmailAddress]
        public string? Correo { get; set; }

        [Required(ErrorMessage = "El teléfono no puede estar vacío")]
        [MaxLength(20)]
        public string? Telefono { get; set; }
        [ForeignKey("Cliente_id")]
        public virtual ICollection<Pedido>? Pedidos { get; set; }
    }
}
