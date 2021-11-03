using LinqToDbFirst.Domain.DTOs;
using LinqToDbFirst.Domain.Entities;
using LinqToDbFirst.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinqToDbFirst.Infrostructure.Repositories
{
    public class ProductRepository : SimplePrimaryKeyRepository<Product>, IProductRepository
    {

        public ProductRepository(AdventureWorksLT2019Context context) : base(context){}

        //public async Task<Customer> GetById(int id)
        //{
        //    return await entities.FindAsync(id);
        //}

        //public void Delete(int id)
        //{
        //    Customer entity = entities.Find(id);
        //    if (entity != null)
        //        entities.Remove(entity);
        //}

        //public async Task<IEnumerable<ParentCategoryWithCategoryWithProductsWithTotalQtyAndTotalCostDTO>>
        //   GetAllProductsWithTotalQtyAndTotalCostGroupByCategory()
        //{

        //}

        public async Task<IDictionary<ProductCategoryDTO, IDictionary<ProductCategoryDTO, ProductWithTotalQtyAndTotalCostDTO>>> 
            GetAllProductsWithTotalQtyAndTotalCostGroupByCategory()
        {
            var products = entities.Include(p=> p.ProductCategory)
                                   .ThenInclude(pc=> pc.ParentProductCategory)
                                   .Select(p=> new ProductWithTotalQtyAndTotalCostDTO
                                   { 
                                        ProductDTO = p,
                                        Cost = p.SalesOrderDetails.Where(od => od.SalesOrder.Status == 5)
                                                .Select(od=> od.OrderQty, )
                                   })
                
                //.Include(p => p.SalesOrderDetails.Where(od => od.SalesOrder.Status == 5));
        }
    }
}
