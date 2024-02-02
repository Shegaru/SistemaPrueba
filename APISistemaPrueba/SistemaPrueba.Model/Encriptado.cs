using System;
using System.Collections.Generic;

namespace SistemaPrueba.Model
{
    public partial class Encriptado
    {
        public int idEncriptado { get; set; }
        public string? frase { get; set; }
        public int? clave { get; set; }

        public string? encriptado { get; set; }
    }
}
