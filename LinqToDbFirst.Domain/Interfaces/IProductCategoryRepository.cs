using LinqToDbFirst.Domain.DTOs;
using LinqToDbFirst.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinqToDbFirst.Domain.Interfaces
{
    public interface IProductCategoryRepository : ISimplePrimaryKeyRepository<ProductCategory>
    {
        //public IEnumerable<(Product Product, int TotalQty, decimal TotalCost)>
        //    GetAllProductsWithTotalQtyAndTotalCostGroupByCategory();

        public IEnumerable<ParentCategoryWithCategoryWithProductsWithTotalQtyAndTotalCostDTO>
            GetAllProductsWithTotalQtyAndTotalCostGroupByCategory();
    }
}
