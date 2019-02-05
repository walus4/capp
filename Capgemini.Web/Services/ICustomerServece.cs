using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Capgemini.Domain;
using Capgemini.Domain.DTO;
using Capgemini.Web.Models;

namespace Capgemini.Web.Services
{
    public interface ICustomerServece
    {
        Task<IEnumerable<CustormerDTO>> Bower();
        Task<Customer> Get(Guid id);
        Task Delete(Guid id);
        Task Post(CustormerDTO customer);
        Task Put(CustormerDTO customer);
    }
}