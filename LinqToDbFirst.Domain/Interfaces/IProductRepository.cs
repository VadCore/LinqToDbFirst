using LinqToDbFirst.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinqToDbFirst.Domain.Interfaces
{
    public interface IProductRepository : ISimplePrimaryKeyRepository<Product>
    {
        public IEnumerable<(Product Product, int TotalQty, decimal TotalCost)>
            GetAllProductsWithTotalQtyAndTotalCostGroupByCategory();
    }
}
