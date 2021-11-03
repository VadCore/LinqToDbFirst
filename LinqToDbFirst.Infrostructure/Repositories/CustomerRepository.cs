using LinqToDbFirst.Domain.Entities;
using LinqToDbFirst.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinqToDbFirst.Infrostructure.Repositories
{
    public class CustomerRepository : SimplePrimaryKeyRepository<Customer>, ICustomerRepository
    {

        public CustomerRepository(AdventureWorksLT2019Context context) : base(context){}

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
    }
}
