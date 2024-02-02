using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace SistemaPrueba.DTO
{
    public class EncriptadoDTO
    {
        public int idEncriptado { get; set; }
        public string? frase { get; set; }
        public int? clave { get; set; }
        public string? encriptado { get; set; }

    }
}
