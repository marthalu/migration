using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TiendaDeRopa.Domain
{
  public class Tienda
  {
    public Guid Id { get; set; }
    public string Talla { get; set; }
    public float Precio { get; set; }

    public Prenda Prenda { get; set; }
    private Guid _IdPrenda;
  }
}
