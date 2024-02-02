using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaPrueba.API.Utilidad;
using SistemaPrueba.BLL.Servicios.Contrato;
using SistemaPrueba.DTO;

namespace SistemaPrueba.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DesencriptarController : ControllerBase
    {
        private readonly IDesencriptarService _desencriptarServicio;

        public DesencriptarController(IDesencriptarService desencriptarServicio)
        {
            _desencriptarServicio = desencriptarServicio;
        }

        [HttpPost]
        [Route("DesencriptaFrase")]
        public async Task<IActionResult> DesencriptaFrase([FromBody] EncriptarDTO valor)
        {

            var rsp = new Response<DesencriptadoDTO>();

            try
            {
                rsp.status = true;
                rsp.value = await _desencriptarServicio.DesencriptadoFrase(valor);

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
