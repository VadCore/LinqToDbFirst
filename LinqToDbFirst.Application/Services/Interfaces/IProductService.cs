﻿using LinqToDbFirst.Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinqToDbFirst.Application.Services.Interfaces
{
    public interface IProductService
    {
        public Task<IEnumerable<ProductDTO>> GetAllProducts();
    }
}
