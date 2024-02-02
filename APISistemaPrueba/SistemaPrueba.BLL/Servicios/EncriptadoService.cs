using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoMapper;
using SistemaPrueba.BLL.Servicios.Contrato;
using SistemaPrueba.DAL.Repositorios.Contrato;
using SistemaPrueba.DTO;
using SistemaPrueba.Model;

namespace SistemaPrueba.BLL.Servicios
{
    public class EncriptadoService : IEncriptadoService
    {
        private IGenericRepository<Encriptado> _encriptadoRepositorio;
        private IMapper _mapper;

        public EncriptadoService(IGenericRepository<Encriptado> encriptadoRpositorio, IMapper mapper)
        {
            _encriptadoRepositorio = encriptadoRpositorio;
            _mapper = mapper;
        }

        public async Task<List<EncriptadoDTO>> Lista()
        {
            try
            {
                var listaEncriptados = await _encriptadoRepositorio.Consultar();
                return _mapper.Map<List<EncriptadoDTO>>(listaEncriptados.ToList());
            }
            catch
            {
                throw;
            }
        }

        public async Task<EncriptadoDTO> Crear(EncriptadoDTO modelo)
        {
            try
            {
                var encriptadoCreado = await _encriptadoRepositorio.Crear(_mapper.Map<Encriptado>(modelo));

                if (encriptadoCreado.idEncriptado == 0)
                    throw new TaskCanceledException("No se pudo crear");

                return _mapper.Map<EncriptadoDTO>(encriptadoCreado);
            }
            catch
            {
                throw;
            }
        }
    }
}
