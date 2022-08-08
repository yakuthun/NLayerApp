﻿using NLayer.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Repositories
{
    public interface IProductRepository:IGenericRepository<Product>
    {
        //async, Product'ları listele 
        Task<List<Product>> GetProductsWithCategory();
    }
}
