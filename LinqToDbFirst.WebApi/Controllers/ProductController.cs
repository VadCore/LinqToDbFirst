using LinqToDbFirst.Domain.DTOs;
using LinqToDbFirst.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinqToDbFirst.WebApi.Controllers
{
    public class ProductController : BaseController
    {

        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductDTO>>> GetAllProducts()
        {
            return OkOrNotFound(await _productService.GetAllProducts());
        }

        //[HttpGet]
        //public async Task GetAllProductsWithTotalQtyAndTotalCostGroupByCategory()
        //{
        //    await _productService.GetAllProductsWithTotalQtyAndTotalCostGroupByCategory();
        //}

        [HttpGet]
        public async Task<ActionResult<Dictionary<string, Dictionary<string, List<ProductSaleStatisticsDTO>>>>>
            GetAllProductSaleStatisticsGroupByCategories()
        {
            return OkOrNotFound(await _productService.GetAllProductSaleStatisticsGroupByCategories());
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ParentCategoryWithProductStatisticsDTO>>>
            GetAllProductSaleStatisticsGroupByCategories2()
        {
            return OkOrNotFound(await _productService.GetAllProductSaleStatisticsGroupByCategories3());
        }
    }
}
