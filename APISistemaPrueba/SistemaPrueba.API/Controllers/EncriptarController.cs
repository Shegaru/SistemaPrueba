using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using SistemaPrueba.BLL.Servicios.Contrato;
using SistemaPrueba.API.Utilidad;
using SistemaPrueba.DTO;

namespace SistemaPrueba.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EncriptarController : ControllerBase
    {
        private readonly IEncriptarService _encriptarServicio;

        public EncriptarController(IEncriptarService encriptarServicio)
        {
            _encriptarServicio = encriptarServicio;
        }

        [HttpPost]
        [Route("EncriptaFrase")]
        public async Task<IActionResult> EncriptaFrase([FromBody] EncriptarDTO valor)
        {

            var rsp = new Response<EncriptarDTO>();

            try
            {
                rsp.status = true;
                rsp.value = await _encriptarServicio.EncriptarFrase(valor);

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
