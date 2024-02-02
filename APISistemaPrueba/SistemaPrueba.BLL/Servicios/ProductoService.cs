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
    public class ProductoService : IProductoService
    {
        private IGenericRepository<Producto> _productoRepositorio;
        private IMapper _mapper;

        public ProductoService(IGenericRepository<Producto> productoRepositorio, IMapper mapper)
        {
            _productoRepositorio = productoRepositorio;
            _mapper = mapper;
        }

        public async Task<List<ProductoDTO>> Lista()
        {
            try
            {
                var queryProducto = await _productoRepositorio.Consultar();
                var listaProductos = queryProducto.Distinct().ToList();

                return _mapper.Map<List<ProductoDTO>>(listaProductos);
            }
            catch
            {
                throw;
            }
        }

        public async Task<ProductoDTO> Crear(ProductoDTO modelo)
        {
            try
            {
                var productoCreado = await _productoRepositorio.Crear(_mapper.Map<Producto>(modelo));

                if (productoCreado.Codigo == 0)
                    throw new TaskCanceledException("No se pudo crear");

               return _mapper.Map<ProductoDTO>(productoCreado);
            }
            catch
            {
                throw;
            }
        }

        public async Task<bool> Editar(ProductoDTO modelo)
        {
            try
            {
                var productoModelo = _mapper.Map<Producto>(modelo);

                var productoEncontrado = await _productoRepositorio.Obtener(u => u.Codigo == productoModelo.Codigo);

                if(productoEncontrado == null)
                    throw new TaskCanceledException("No se encontró el código del producto");

                productoEncontrado.Codigo = productoModelo.Codigo;
                productoEncontrado.Descripcion = productoModelo.Descripcion;
                productoEncontrado.ListaPrecios = productoModelo.ListaPrecios;
                productoEncontrado.Imagen = productoModelo.Imagen;
                productoEncontrado.PermiteVenta = productoModelo.PermiteVenta;
                productoEncontrado.PorcentajeIva = productoModelo.PorcentajeIva;

                bool respuesta = await _productoRepositorio.Editar(productoEncontrado);

                if(!respuesta)
                    throw new TaskCanceledException("No se pudo editar");


                return respuesta;
            }
            catch
            {
                throw;
            }
        }

        public async Task<bool> Eliminar(int id)
        {
            try
            {
                var productoEncontrado = await _productoRepositorio.Obtener(u => u.Codigo == id);
                
                if(productoEncontrado == null)
                    throw new TaskCanceledException("No se encontró el producto");

                bool respuesta = await _productoRepositorio.Eliminar(productoEncontrado);

                if (!respuesta)
                    throw new TaskCanceledException("No se pudo eliminar");


                return respuesta;

            }
            catch
            {
                throw;
            }
        }

    }
}
