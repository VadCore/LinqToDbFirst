﻿using LinqToDbFirst.Domain.Entities;
using LinqToDbFirst.Domain.Interfaces;
using System;
using System.Collections.Generic;

#nullable disable


namespace LinqToDbFirst.Domain.DTOs
{
    public class CategoryWithProductsWithTotalQtyAndTotalCostDTO
    {
        public IEnumerable<ProductWithTotalQtyAndTotalCostDTO> ProductWithTotalQtyAndTotalCostDTO { get; init; }
    }
}