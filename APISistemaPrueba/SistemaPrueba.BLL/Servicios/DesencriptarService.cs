using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SistemaPrueba.BLL.Servicios.Contrato;
using SistemaPrueba.DAL.Repositorios.Contrato;
using SistemaPrueba.DTO;
using SistemaPrueba.Model;

namespace SistemaPrueba.BLL.Servicios
{
    public class DesencriptarService : IDesencriptarService
    {
        private readonly IGenericRepository<Encriptado> _encriptadoRepositorio;

        public DesencriptarService(IGenericRepository<Encriptado> encriptadoRepositorio)
        {
            _encriptadoRepositorio = encriptadoRepositorio;
        }

        public async Task<DesencriptadoDTO> DesencriptadoFrase(EncriptarDTO valor)
        {

            var valorEncontrado = await _encriptadoRepositorio.Obtener(u => u.idEncriptado == valor.idEncriptado);

            valorEncontrado.clave = (valorEncontrado.clave % 26 + 26) % 26;

            char[] caracteres = valorEncontrado.encriptado.ToCharArray();

            for (int i = 0; i < caracteres.Length; i++)
            {
                if (char.IsLetter(caracteres[i]))
                {
                    char inicio = char.IsUpper(caracteres[i]) ? 'A' : 'a';

                    caracteres[i] = (char)((caracteres[i] - inicio - valorEncontrado.clave + 26) % 26 + inicio);
                }
            }

            return new DesencriptadoDTO { valorReal = new string(caracteres), ValorCript = valorEncontrado.encriptado };

        }


    }
}
