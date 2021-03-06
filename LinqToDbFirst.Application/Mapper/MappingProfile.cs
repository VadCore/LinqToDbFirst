using AutoMapper;
using LinqToDbFirst.Domain.DTOs;
using LinqToDbFirst.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToDbFirst.Application.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Customer, CustomerDTO>();
            CreateMap<Product, ProductDTO>();
            CreateMap<ProductCategory, ProductCategoryDTO>();
        }
    }
}
