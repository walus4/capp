using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Capgemini.API.Services;
using Capgemini.Domain;
using Capgemini.Domain.DTO;
using Microsoft.AspNetCore.Mvc;

namespace Capgemini.API.Controllers
{
    public class ProductController : BaseController
    {
        private readonly IProductService _product;

        public ProductController(IProductService product)
        {
            _product = product;
        }

        [HttpPost]
        public async Task Post(ProductDTO product) => await _product.AddCustormer(product);

        [HttpGet]
        public async Task<IEnumerable<ProductDTO>> Get() => await _product.Bower();

        [HttpGet("{Id}")]
        public async Task<ProductDTO> Get(Guid id)
        {
            var product = await _product.Get(id);
            return Mapper.Map<Product, ProductDTO>(product);
        }

        [HttpPut]
        public async Task Put(ProductDTO custormer) => await _product.UpdateCustormer(custormer);

        [HttpDelete("{Id}")]
        public async Task Delete(Guid id) => await _product.DeleteCustormer(id);
    }
}