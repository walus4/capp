using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Capgemini.Domain;
using Capgemini.Domain.DTO;

namespace Capgemini.Web.Services
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDTO>> Bower();
        Task<ProductDTO> Get(Guid id);
        Task Delete(Guid id);
        Task Post(ProductDTO productDto);
        Task Put(ProductDTO productDto);
    }
}