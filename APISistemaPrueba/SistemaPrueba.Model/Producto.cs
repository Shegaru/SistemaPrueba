using System;
using System.Collections.Generic;

namespace SistemaPrueba.Model
{
    public partial class Producto
    {
        public int Codigo { get; set; }
        public string? Descripcion { get; set; }
        public int? ListaPrecios { get; set; }
        public string? Imagen { get; set; }
        public bool? PermiteVenta { get; set; }
        public int? PorcentajeIva { get; set; }
    }
}
