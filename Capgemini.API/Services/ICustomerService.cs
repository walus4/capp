using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Capgemini.Domain;
using Capgemini.Domain.DTO;

namespace Capgemini.API.Services
{
    public interface ICustomerService
    {
        Task AddCustormer(CustormerDTO Custormer);
        Task<IEnumerable<Customer>> Bower();
        Task<Customer> GetAsync(Guid id);
        Task UpdateCustormer(Customer Custormer);
        Task DeleteCustormer(Guid Id);
    }
}