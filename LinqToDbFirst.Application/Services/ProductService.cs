using LinqToDbFirst.Domain.Entities;
using LinqToDbFirst.Application.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LinqToDbFirst.Domain.Interfaces;
using AutoMapper;
using LinqToDbFirst.Domain.DTOs;

namespace LinqToDbFirst.Application.Services
{
    public class ProductService : Service, IProductService
    {
        private IProductRepository _products;

        public ProductService(IProductRepository products, IMapper mapper) : base(mapper)
        {
            _products = products;
        }

        
        public async Task<IEnumerable<ProductDTO>> GetAllProducts()
        {
            var products = await _products.GetAll();

            return _mapper.Map<IEnumerable<Product>, List<ProductDTO>>(products);
        }

        public void
            GetAllProductsWithTotalQtyAndTotalCostGroupByCategory()
        {
            _products.GetAllProductsWithTotalQtyAndTotalCostGroupByCategory();
        }

        //public async Task<IDictionary<ProductCategoryDTO, IDictionary<ProductCategoryDTO, ProductWithTotalQtyAndTotalCostDTO>>>
        //GetAllProductsWithTotalQtyAndTotalCostGroupByCategory()
        //{
        //    var products =  _products.GetAllProductsWithTotalQtyAndTotalCostGroupByCategory();

        //    products
        //}
    }
}
