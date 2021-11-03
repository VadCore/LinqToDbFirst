using LinqToDbFirst.Domain.DTOs;
using LinqToDbFirst.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinqToDbFirst.WebApi.Controllers
{
    public class ProductCategoryController : BaseController
    {

        private IProductCategoryService _productCategoryService;

        public ProductCategoryController(IProductCategoryService productCategoryService)
        {
            _productCategoryService = productCategoryService;
        }

        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<ProductDTO>>> GetAllProducts()
        //{
        //    return OkOrNotFound(await _productCategoryService.GetAllProducts());
        //}

        [HttpGet]
        public ActionResult<IEnumerable<ParentCategoryWithCategoryWithProductsWithTotalQtyAndTotalCostDTO>>
            GetAllProductsWithTotalQtyAndTotalCostGroupByCategory()
        {
            return OkOrNotFound(_productCategoryService.GetAllProductsWithTotalQtyAndTotalCostGroupByCategory());
        }
    }
}
