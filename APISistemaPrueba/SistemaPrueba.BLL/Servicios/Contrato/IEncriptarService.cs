using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SistemaPrueba.DTO;

namespace SistemaPrueba.BLL.Servicios.Contrato
{
    public interface IEncriptarService
    {
        Task<EncriptarDTO> EncriptarFrase(EncriptarDTO valores);
    }
}
