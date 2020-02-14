using AkiExpress.MODELS.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AkiExpress.MODELS.Repositories
{
    public class CustomerRepo : ICustomerRepo
    {
        private AkiExpressDbContext ctx;
        public CustomerRepo(AkiExpressDbContext ctx)
        {
            this.ctx = ctx;
        }
        public async Task<Customer> Add(Customer cust)
        {
            ctx.Add(cust);
            await ctx.SaveChangesAsync();
            return cust;
        }
        public async Task<Customer> Get(int id)
        {
            return await ctx.Customers.FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<List<Customer>> GetAll()
        {
            return await ctx.Customers.ToListAsync();
        }

        public async Task<Customer> Remove(Customer cust)
        {
            ctx.Customers.Remove(cust);
            await ctx.SaveChangesAsync();
            return cust;
        }

        public async Task<Customer> Update(Customer cust)
        {
            ctx.Customers.Update(cust);
            await ctx.SaveChangesAsync();
            return cust;
        }
    }
}
