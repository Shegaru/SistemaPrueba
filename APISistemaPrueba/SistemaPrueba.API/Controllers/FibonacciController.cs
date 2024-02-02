using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using SistemaPrueba.BLL.Servicios.Contrato;
using SistemaPrueba.API.Utilidad;
using SistemaPrueba.DTO;


namespace SistemaPrueba.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FibonacciController : ControllerBase
    {
        private readonly IFibonacciService _fibonacciServicio;

        public FibonacciController(IFibonacciService fibonacciServicio)
        {
            _fibonacciServicio = fibonacciServicio;
        }


        [HttpPost]
        [Route("validaFibo")]
        public async Task<IActionResult> validaFibo([FromBody] FibonacciDTO valor)
        {

            var rsp = new Response<FibonacciDTO>();

            try
            {
                rsp.status = true;
                rsp.value = await _fibonacciServicio.EsFibonacci(valor);

            }
            catch (Exception ex)
            {
                rsp.status = false;
                rsp.msg = ex.Message;
            }

            return Ok(rsp);
        }


    }
}
