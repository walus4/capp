using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Capgemini.API.Services;
using Capgemini.Domain;
using Capgemini.Domain.DTO;
using Microsoft.AspNetCore.Mvc;

namespace Capgemini.API.Controllers
{
    public class InvoicesController : BaseController
    {
        private readonly IInvoiceService _invoice;

        public InvoicesController(IInvoiceService invoice)
        {
            _invoice = invoice;
        }

        [HttpPost]
        public async Task Post(OrderHeaderDTO invoiceDto)
            => await _invoice.AddInvoice(invoiceDto);


        [HttpGet]
        public async Task<IEnumerable<OrderHeder>> Get()
            => await _invoice.Bower();

        [HttpGet("{Id}")]
        public async Task<OrderHeder> Get(Guid id)
            => await _invoice.Get(id);

        [HttpPut]
        public async Task Put(OrderHeaderDTO invoiceDto)
        {
            await _invoice.UpdateInvoice(invoiceDto);
        }

        [HttpDelete("{Id}")]
        public async Task Delete(Guid id)
            => await _invoice.DeleteInvoice(id);
    }
}