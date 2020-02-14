using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AkiExpress.MODELS;
using AkiExpress.MODELS.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AkiExpress.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerRepo repo;
        public CustomersController(ICustomerRepo repo)
        {
            this.repo = repo;
        }

        // GET: api/Customers
        [HttpGet]
        public async Task<IEnumerable<Customer>> Get()
        {
            return await repo.GetAll();
        }

        // GET: api/Customers/5
        [HttpGet("{id}", Name = "Get")]
        public async Task<Customer> Get(int id)
        {
            return await repo.Get(id);
        }

        // POST: api/Customers
        [HttpPost]
        public async Task<ActionResult<Customer>> Post([FromBody] Customer cust)
        {
            await repo.Add(cust);
            return CreatedAtAction("GetCustomerModel", new { id = cust.Id }, cust);
        }

        // PUT: api/Customers/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
