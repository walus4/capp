using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Capgemini.Domain;
using Capgemini.Domain.DTO;

namespace Capgemini.Web.Services
{
    public interface IInvoiceService
    {
        Task<IEnumerable<OrderHeder>> Bower();
        Task<OrderHeder> Get(Guid id);
        Task Delete(Guid id);
        Task Post(OrderHeaderDTO productDto);
        Task Put(OrderHeaderDTO productDto);
    }
}