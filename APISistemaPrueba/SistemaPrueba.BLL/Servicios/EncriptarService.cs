using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SistemaPrueba.BLL.Servicios.Contrato;
using SistemaPrueba.DAL.Repositorios.Contrato;
using SistemaPrueba.DTO;
using SistemaPrueba.Model;

namespace SistemaPrueba.BLL.Servicios
{
    public class EncriptarService : IEncriptarService
    {
        public async Task<EncriptarDTO> EncriptarFrase(EncriptarDTO valores)
        {
            try
            {
                char[] caracteres = valores.frase.ToCharArray();

                for (int i = 0; i < caracteres.Length; i++)
                {
                    if (char.IsLetter(caracteres[i]))
                    {
                        char inicio = char.IsUpper(caracteres[i]) ? 'A' : 'a';
                        caracteres[i] = (char)((caracteres[i] - inicio + valores.clave) % 26 + inicio);
                    }
                }

                return new EncriptarDTO { frase = new string (caracteres), clave = valores.clave };

            }
            catch
            {
                throw;
            }
        }
    }
}
