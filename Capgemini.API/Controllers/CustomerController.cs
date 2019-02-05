using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Capgemini.API.Services;
using Capgemini.Domain;
using Capgemini.Domain.DTO;
using Microsoft.AspNetCore.Mvc;

namespace Capgemini.API.Controllers
{
    public class CustomerController : BaseController
    {
        private readonly ICustomerService _customer;

        public CustomerController(ICustomerService customer)
        {
            _customer = customer;
        }

        [HttpPost]
        public async Task Post(CustormerDTO custormer) 
        => await _customer.AddCustormer(custormer);


        [HttpGet]
        public async Task<IEnumerable<Customer>> Get()
            =>await _customer.Bower();

        [HttpGet("{Id}")]
        public async Task<Customer> Get(Guid id )
            => await _customer.GetAsync(id);

        [HttpPut]
        public async Task Put(CustormerDTO custormerDto) { 
            var customer= new Customer(custormerDto);
             await _customer.UpdateCustormer(customer);
        }

        [HttpDelete("{Id}")]
        public async Task Delete(Guid id)
            => await _customer.DeleteCustormer(id);
    }
}