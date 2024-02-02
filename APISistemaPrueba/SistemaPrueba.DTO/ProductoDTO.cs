using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPrueba.DTO
{
    public class ProductoDTO
    {
        public int Codigo { get; set; }
        public string? Descripcion { get; set; }
        public int? ListaPrecios { get; set; }
        public string? Imagen { get; set; }
        public int? PermiteVenta { get; set; }
        public int? PorcentajeIva { get; set; }
    }
}
