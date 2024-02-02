using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using SistemaPrueba.BLL.Servicios.Contrato;
using SistemaPrueba.DTO;
using SistemaPrueba.API.Utilidad;

namespace SistemaPrueba.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EncriptadoController : ControllerBase
    {

        private readonly IEncriptadoService _encriptadoServicio;

        public EncriptadoController(IEncriptadoService encriptadoServicio)
        {
            _encriptadoServicio = encriptadoServicio;
        }

        [HttpGet]
        [Route("lista")]
        public async Task<IActionResult> Lista()
        {
            var rsp = new Response<List<EncriptadoDTO>>();

            try
            {
                rsp.status = true;
                rsp.value = await _encriptadoServicio.Lista();

            }catch (Exception ex)
            {
                rsp.status=false;
                rsp.msg = ex.Message;
            }

            return Ok(rsp);
        }

        [HttpPost]
        [Route("Guardar")]
        public async Task<IActionResult> Guardar([FromBody] EncriptadoDTO encriptado)
        {
            var rsp = new Response<EncriptadoDTO>();

            try
            {
                rsp.status = true;
                rsp.value = await _encriptadoServicio.Crear(encriptado);

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
