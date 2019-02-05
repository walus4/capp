using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Capgemini.Domain;
using Capgemini.Domain.DTO;

namespace Capgemini.API.Services
{
    public interface IProductService
    {
        Task AddCustormer(ProductDTO Custormer);
        Task<IEnumerable<ProductDTO>> Bower();
        Task<Product> Get(Guid id);
        Task UpdateCustormer(ProductDTO Custormer);
        Task DeleteCustormer(Guid Id);

    }
}