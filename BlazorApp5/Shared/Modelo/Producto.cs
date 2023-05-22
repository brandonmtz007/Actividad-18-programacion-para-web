﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp5.Shared.Modelo
{
    public class Producto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre no puede estar vacío")]
        [MaxLength(50)]
        public string? Nombre { get; set; }

        public string? Descripcion { get; set; }

        [Required(ErrorMessage = "El precio no puede estar vacío")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Precio { get; set; }

        [Required(ErrorMessage = "La cantidad no puede estar vacía")]
        public int Cantidad { get; set; }

        [Required(ErrorMessage = "La categoría no puede estar vacía")]
        [MaxLength(50)]
        public string? Categoria { get; set; }

        [Required(ErrorMessage = "La imagen no puede estar vacía")]
        [MaxLength(255)]
        public string? Imagen { get; set; }
        public virtual ICollection<Pedido>? Pedido { get; set; }
    }
}
