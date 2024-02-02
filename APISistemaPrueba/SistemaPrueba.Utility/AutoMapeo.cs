using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoMapper;
using SistemaPrueba.DTO;
using SistemaPrueba.Model;

namespace SistemaPrueba.Utility
{
    public class AutoMapeo : Profile
    {
        public AutoMapeo()
        {
            #region Encriptado
            CreateMap<Encriptado, EncriptadoDTO>().ReverseMap();
            #endregion

            #region Producto
            CreateMap<Producto, ProductoDTO>()
                .ForMember(destino =>
                destino.PermiteVenta,
                opt => opt.MapFrom(origen => origen.PermiteVenta == true ? 1 : 0)
                );

            CreateMap<ProductoDTO, Producto>()
                .ForMember(destino =>
                destino.PermiteVenta,
                opt => opt.MapFrom(origen => origen.PermiteVenta == 1 ? true : false)
                );
            #endregion


        }

    }
}
