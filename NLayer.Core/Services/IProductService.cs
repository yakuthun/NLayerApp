using NLayer.Core.DTOs;
using NLayer.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Services
{
    public interface IProductService:IService<Product>
    {
        //Generic'te Product dönüyorduk
        //Dönüş tipimizi burada özelleştiriyoruz. Direkt olarak Product'la beraber Category'i döneceğim.
        //Özelleştirme için bir DTO oluşturalım.
        Task<CustomResponseDto<List<ProductWithCategoryDto>>> GetProductsWithCategory();
    }
}
