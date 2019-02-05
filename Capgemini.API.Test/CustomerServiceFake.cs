using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capgemini.API.Services;
using Capgemini.Domain;
using Capgemini.Domain.DTO;

namespace Capgemini.API.Test
{
    class CustomerServiceFake : ICustomerService
    {
        private readonly List<CustormerDTO> _custormerDtos;

        public CustomerServiceFake()
        {
            _custormerDtos = new List<CustormerDTO>
            {
                new CustormerDTO
                {
                    Id = new Guid("ab2bd817-98cd-4cf3-a80a-53ea0cd9c200"),
                    Name = "Orange Juice",
                    CompanyName = "Orange Tree",
                    PostalCode = "4885",
                    NIP = "526-11-84-467"
                },
                new CustormerDTO
                {
                    Id = new Guid("815accac-fd5b-478a-a9d6-f171a2f6ae7f"),
                    Name = "Diary Milk",
                    City = "Mad Cow",
                    HauseNo = "4.00M",
                    NIP = "526-11-84-467"
                },
            };
        }

        public Task AddCustormer(CustormerDTO Custormer)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Customer>> Bower()
        {
            throw new NotImplementedException();
        }

        public async Task<Customer> GetAsync(Guid id)
        {
            var customerdto = _custormerDtos.FirstOrDefault(a => a.Id == id);
            var customer = new Customer(customerdto);
            return customer;
        }

        public Task UpdateCustormer(Customer Custormer)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCustormer(Guid Id)
        {
            throw new NotImplementedException();
        }
    }
}