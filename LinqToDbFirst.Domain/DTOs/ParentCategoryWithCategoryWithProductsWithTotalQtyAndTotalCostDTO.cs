using LinqToDbFirst.Domain.DTOs;
using LinqToDbFirst.Domain.Entities;
using LinqToDbFirst.Domain.Interfaces;
using System;
using System.Collections.Generic;

#nullable disable


namespace LinqToDbFirst.Domain.DTOs
{
    public class ParentCategoryWithCategoryWithProductsWithTotalQtyAndTotalCostDTO
    {
        public IEnumerable<CategoryWithProductsWithTotalQtyAndTotalCostDTO> CategoryWithProductsWithTotalQtyAndTotalCostDTO { get; init; }
    }
}
