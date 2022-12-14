using AutoMapper;
using NLayer.Core.DTOs;
using NLayer.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Service.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<ProductFeature, ProductFeatureDto>().ReverseMap();
            CreateMap<ProductUpdateDto, Product>();//productdto gelir ise product'a dönüştürüyor
            //reverse'e tersine ihtiyacımız yok.
            CreateMap<Product, ProductWithCategoryDto>().ReverseMap();//product'ı productwithCategoryDto'a dönüştürdüm.
            CreateMap<Category, CategoryWithProductsDto>().ReverseMap();
        }
    }
}
