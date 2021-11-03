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
    public class ProductCategoryRepository : SimplePrimaryKeyRepository<ProductCategory>, IProductCategoryRepository
    {

        public ProductCategoryRepository(AdventureWorksLT2019Context context) : base(context){}

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

        //public async Task<IDictionary<ProductCategoryDTO, IDictionary<ProductCategoryDTO, ProductWithTotalQtyAndTotalCostDTO>>> 
        //public IEnumerable<(Product Product, int TotalQty, decimal TotalCost)>

        public IEnumerable<ParentCategoryWithCategoryWithProductsWithTotalQtyAndTotalCostDTO>
            GetAllProductsWithTotalQtyAndTotalCostGroupByCategory()
        {
            //var result = entities.Where(pc=> pc.ParentProductCategoryId == null)
            //                .Include(pc => pc.InverseParentProductCategory)
            //                       .ThenInclude(pc => pc.Products.Select(p => new 
            //                       {
            //                           ProductDTO = p,

            //                           TotalQty = p.SalesOrderDetails.Where(od => od.SalesOrder.Status == 5)
            //                                    .Select(od => (int)od.OrderQty).Sum(),

            //                           TotalCost = p.SalesOrderDetails.Where(od => od.SalesOrder.Status == 5)
            //                                    .Select(od => od.OrderQty * od.UnitPrice).Sum()

            //                       })).ToList();


            var result = entities.Where(pc => pc.ParentProductCategoryId == null)
                            .Select(pc =>
                            new ParentCategoryWithCategoryWithProductsWithTotalQtyAndTotalCostDTO
                            {
                                ParentCategoryDTO = new ProductCategoryDTO 
                                { 
                                 Name = pc.Name
                                },
                                CategoryWithProductsWithTotalQtyAndTotalCostDTO =
                                    pc.InverseParentProductCategory.Select(c => new CategoryWithProductsWithTotalQtyAndTotalCostDTO
                                    {
                                        CategoryDTO = new ProductCategoryDTO 
                                        { 
                                            Name = c.Name
                                        },
                                        ProductWithTotalQtyAndTotalCostDTO = c.Products.Select(p => new ProductWithTotalQtyAndTotalCostDTO
                                        {
                                            ProductDTO = new ProductDTO 
                                            { 
                                                 Name = p.Name,
                                                 ProductNumber = p.ProductNumber,
                                                 Color = p.Color,
                                                 Size = p.Size,
                                                 Weight = p.Weight
                                            },

                                            TotalQty = p.SalesOrderDetails.Where(od => od.SalesOrder.Status == 5)
                                                .Select(od => (int)od.OrderQty).Sum(),

                                            TotalCost = p.SalesOrderDetails.Where(od => od.SalesOrder.Status == 5)
                                                .Select(od => od.OrderQty * od.UnitPrice).Sum()

                                        })

                                    })
                            }).ToList();

            return result;

            var stop = true;
        }
    }
}


//var result = entities.Where(pc => pc.ParentProductCategoryId == null)
//                            .Select(pc =>
//                            new ParentCategoryWithCategoryWithProductsWithTotalQtyAndTotalCostDTO
//                            {
//                                Name = pc.Name,
//                                CategoryWithProductsWithTotalQtyAndTotalCostDTO =
//                                    pc.InverseParentProductCategory.Select(c => new CategoryWithProductsWithTotalQtyAndTotalCostDTO
//                                    {
//                                        Name = c.Name,

//                                        ProductWithTotalQtyAndTotalCostDTO = c.Products.Select(p => new ProductWithTotalQtyAndTotalCostDTO
//                                        {
//                                            Name = p.Name,
//                                            ProductNumber = p.ProductNumber,
//                                            Color = p.Color,
//                                            Size = p.Size,
//                                            Weight = p.Weight,

//                                            TotalQty = p.SalesOrderDetails.Where(od => od.SalesOrder.Status == 5)
//                                                .Select(od => (int)od.OrderQty).Sum(),

//                                            TotalCost = p.SalesOrderDetails.Where(od => od.SalesOrder.Status == 5)
//                                                .Select(od => od.OrderQty * od.UnitPrice).Sum()
//                                        })

//                                    })
//                            }).ToList();