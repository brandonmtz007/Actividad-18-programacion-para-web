using BlazorApp5.Shared.Modelo;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BlazorApp5.Server.Data
{
    public class PersonaContexto : DbContext
    {
        public PersonaContexto(DbContextOptions<PersonaContexto> options) : base(options)
        {
        }

        public DbSet<Persona> Personas { get; set; }
        public DbSet<Producto>? Productos { get; set; }
        public DbSet<Pedido>? Pedidos { get; set; }
    }
}
