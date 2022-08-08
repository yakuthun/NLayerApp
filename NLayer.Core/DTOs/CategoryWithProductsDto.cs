using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.DTOs
{
    public class CategoryWithProductsDto:CategoryDto
    {
        //hem Category hem de Products'ların bağlı olduğu Dto'muz hazır . 
        //Artık service'te bunu dönebiliriz
        public List<ProductDto> Products{ get; set; }
    }
}
