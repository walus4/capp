using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Capgemini.Domain;
using Capgemini.Domain.DTO;
using Capgemini.Helper;
using Newtonsoft.Json;

namespace Capgemini.Web.Services
{
    public class ProductService : IProductService
    {
        private readonly IApiHelper _api;

        public ProductService(IApiHelper api)
        {
            _api = api;
        }

        public async Task<IEnumerable<ProductDTO>> Bower()
        {
            var client = _api.Initial();
            var response = await client.GetAsync("Product");
            if (response.IsSuccessStatusCode)
            {
                var content = response.Content.ReadAsStringAsync();
                var customerList = JsonConvert.DeserializeObject<IEnumerable<ProductDTO>>(content.Result);
                return customerList;
            }

            return null;
        }

        public async Task<ProductDTO> Get(Guid id)
        {
            var client = _api.Initial();
            var response = await client.GetAsync($"Product/{id}");
            if (response.IsSuccessStatusCode)
            {
                var content = response.Content.ReadAsStringAsync();
                var customer = JsonConvert.DeserializeObject<ProductDTO>(content.Result);
                return customer = JsonConvert.DeserializeObject<ProductDTO>(content.Result);
                ;
            }

            return null;
        }

        public async Task Delete(Guid id)
        {
            var client = _api.Initial();
            await client.DeleteAsync($"Product/{id}");
        }

        public async Task Post(ProductDTO productDto)
        {
            string test = JsonConvert.SerializeObject(productDto).ToString();
            var content = new StringContent(JsonConvert.SerializeObject(productDto).ToString(), Encoding.UTF8,
                "application/json");
            var client = _api.Initial();
            await client.PostAsync("Product", content);
        }

        public async Task Put(ProductDTO productDto)
        {
            var content = new StringContent(JsonConvert.SerializeObject(productDto).ToString(), Encoding.UTF8,
                "application/json");
            var client = _api.Initial();
            await client.PutAsync("Product", content);
        }
    }
}
