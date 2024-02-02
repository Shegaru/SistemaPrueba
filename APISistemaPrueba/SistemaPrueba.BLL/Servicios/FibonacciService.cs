using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SistemaPrueba.BLL.Servicios.Contrato;
using SistemaPrueba.DTO;

namespace SistemaPrueba.BLL.Servicios
{
    public class FibonacciService : IFibonacciService
    {
        public async Task<FibonacciDTO> EsFibonacci(FibonacciDTO valor)
        {
            int numero1 = 0;
            int numero2 = 1;

            bool respuesta = false;

            while (numero1 <= valor.numero)
            {
                if (numero1 == valor.numero)
                {
                    respuesta = true;
                }

                int temp = numero1;
                numero1 = numero2;
                numero2 = temp + numero2;
            }

            return new FibonacciDTO { numero = valor.numero , esFibonacci = respuesta};
        }
    }
}
