using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Capgemini.Domain;
using Capgemini.Domain.DTO;

namespace Capgemini.API.Services
{
    public interface IInvoiceService
    {
        Task AddInvoice(OrderHeaderDTO Custormer);
        Task<IEnumerable<OrderHeder>> Bower();
        Task<OrderHeder> Get(Guid id);
        Task UpdateInvoice(OrderHeaderDTO Custormer);
        Task DeleteInvoice(Guid Id);
    }
}