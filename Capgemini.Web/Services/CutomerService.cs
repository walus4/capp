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
    public class CutomerService : ICustomerServece
    {
        private readonly IApiHelper _api;

        public CutomerService(IApiHelper api)
        {
            _api = api;
        }

        public async Task<IEnumerable<CustormerDTO>> Bower()
        {
            var client = _api.Initial();
            var response = await client.GetAsync("Customer");
            if (response.IsSuccessStatusCode)
            {
                var content = response.Content.ReadAsStringAsync();
                var customerList = JsonConvert.DeserializeObject<IEnumerable<CustormerDTO>>(content.Result);
                return customerList;
            }

            return null;
        }

        public async Task<Customer> Get(Guid id)
        {
            var client = _api.Initial();
          
            var response = await client.GetAsync($"Customer/{id}");
            if (response.IsSuccessStatusCode)
            {
                var content = response.Content.ReadAsStringAsync();
                var customer = JsonConvert.DeserializeObject<Customer>(content.Result);
                return  customer = JsonConvert.DeserializeObject<Customer>(content.Result);
                ;
            }

            return null;
        }

        public async Task Delete(Guid id)
        {
            var client = _api.Initial();

            await client.DeleteAsync($"Customer/{id}");
        }

        public async Task Post(CustormerDTO customer)
        {
            Customer custoemer = Mapper.Map<CustormerDTO, Customer>(customer);
            var content = new StringContent(JsonConvert.SerializeObject(custoemer).ToString(), Encoding.UTF8,
                "application/json");
            var client = _api.Initial();
            await client.PostAsync("Customer", content);
        }

        public async Task Put(CustormerDTO customer)
        {
            Customer custoemer = Mapper.Map<CustormerDTO, Customer>(customer);
            var content = new StringContent(JsonConvert.SerializeObject(custoemer).ToString(), Encoding.UTF8,
                "application/json");
            var client = _api.Initial();
            await client.PutAsync("Customer", content);
        }
    }
}