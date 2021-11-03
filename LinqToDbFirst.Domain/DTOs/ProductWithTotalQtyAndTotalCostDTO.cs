using LinqToDbFirst.Domain.Entities;
using LinqToDbFirst.Domain.Interfaces;
using System;
using System.Collections.Generic;

#nullable disable


namespace LinqToDbFirst.Domain.DTOs
{
    public class ProductWithTotalQtyAndTotalCostDTO
    {
        public ProductDTO ProductDTO { get; init; }
        public int TotalQty { get; init; }
        public decimal Cost { get; init; }
    }
}
