using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AkiExpress.MODELS.Repositories
{
    public interface ICustomerRepo
    {
        public Task<Customer> Get(int id);
        public Task<List<Customer>> GetAll();
        public Task<Customer> Add(Customer cust);
        public Task<Customer> Update(Customer cust);
        public Task<Customer> Remove(Customer cust);

    }
}
