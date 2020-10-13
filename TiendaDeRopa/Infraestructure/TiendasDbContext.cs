using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TiendaDeRopa.Domain;
using TiendaDeRopa.Infraestructure.EntityConfugurations;

namespace TiendaDeRopa.Infraestructure
{
  public class TiendasDbContext : DbContext
  {
    public TiendasDbContext(DbContextOptions<TiendasDbContext> options) : base(options)
    {

    }

    public DbSet<Tienda> Tiendas { get; set; }
    public DbSet<Prenda> Prendas { get; set; }

    protected override void OnModelCreating(ModelBuilder builder) {
      builder.ApplyConfiguration(new TiendaEntityConfiguration());
      builder.ApplyConfiguration(new PrendaEntityConfiguration());
    }
     }
  }
