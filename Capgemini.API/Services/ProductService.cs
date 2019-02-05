using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Capgemini.API.Infastructure;
using Capgemini.Domain;
using Capgemini.Domain.DTO;
using Microsoft.Extensions.DependencyInjection;

namespace Capgemini.API.Services
{
    public class ProductService : IProductService
    {
        private readonly CapgeminiContext _context;

        public ProductService(CapgeminiContext context)
        {
            _context = context;
        }

        public async Task AddCustormer(ProductDTO product)
        {
            try
            {
                var newproduct = new Product(product.Name, product.Description, product.Price);
                _context.Products.Add(newproduct);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<IEnumerable<ProductDTO>> Bower()
        {
            IEnumerable<Product> products = _context.Products;
            List<ProductDTO> productDtos = new List<ProductDTO>();
            foreach (var product in products)
            {
                productDtos.Add(Mapper.Map<Product, ProductDTO>(product));
            }

            return productDtos;
        }

        public async Task<Product> Get(Guid id) => _context.Products.FirstOrDefault(w => w.Id == id);

        public async Task UpdateCustormer(ProductDTO product)
        {
            var updateProduct = new Product(product);
            _context.Products.Update(updateProduct);
            _context.SaveChanges();
        }

        public async Task DeleteCustormer(Guid Id)
        {
            var productToDelete = _context.Products.Find(Id);
            if (productToDelete != null)
            {
                _context.Products.Remove(productToDelete);
                _context.SaveChanges();
            }
        }
    }
}