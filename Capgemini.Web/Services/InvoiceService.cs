using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Capgemini.Domain;
using Capgemini.Domain.DTO;
using Capgemini.Helper;
using Newtonsoft.Json;

namespace Capgemini.Web.Services
{
    public class InvoiceService : IInvoiceService
    {
        private readonly IApiHelper _api;

        public InvoiceService(IApiHelper api)
        {
            _api = api;
        }

        public async Task<IEnumerable<OrderHeder>> Bower()
        {
            var client = _api.Initial();
            var response = await client.GetAsync("Invoices");
            if (response.IsSuccessStatusCode)
            {
                var content = response.Content.ReadAsStringAsync();
                var invoiceList = JsonConvert.DeserializeObject<IEnumerable<OrderHeder>>(content.Result);
                return invoiceList;
            }

            return null;
        }

        public async Task<OrderHeder> Get(Guid id)
        {
            var client = _api.Initial();
            var response = await client.GetAsync($"Invoices/{id}");
            if (response.IsSuccessStatusCode)
            {
                var content = response.Content.ReadAsStringAsync();
                var invoice = JsonConvert.DeserializeObject<OrderHeder>(content.Result);
                return invoice;
                ;
            }

            return null;
        }

        public async Task Delete(Guid id)
        {
            var client = _api.Initial();
            await client.DeleteAsync($"Invoices/{id}");
        }

        public async Task Post(OrderHeaderDTO productDto)
        {
            string test = JsonConvert.SerializeObject(productDto).ToString();
            var content = new StringContent(JsonConvert.SerializeObject(productDto).ToString(), Encoding.UTF8,
                "application/json");
            var client = _api.Initial();
            await client.PostAsync("Invoices", content);
        }

        public async Task Put(OrderHeaderDTO productDto)
        {
            var content = new StringContent(JsonConvert.SerializeObject(productDto).ToString(), Encoding.UTF8,
                "application/json");
            var client = _api.Initial();
            await client.PutAsync("Invoices", content);
        }
    }
}
