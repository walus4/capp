using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Capgemini.Domain.DTO;
using Capgemini.Web.Models;
using Capgemini.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace Capgemini.Web.Controllers
{
    public class InvoiceController : Controller
    {
        private readonly IInvoiceService _invoice;

        public InvoiceController(IInvoiceService invoice)
        {
            _invoice = invoice;
        }

        public async Task<IActionResult> Index()
        {
            var productList = await _invoice.Bower();
            return View(productList);
        }

        [HttpPost]
        public async Task<IActionResult> AddNew(List<Line> lines=null, Guid customerid=new Guid())
        {
            var line = new List<OrderLineDTO>();
            foreach (var item in lines)
            {Console.WriteLine(item.Id);
            Console.WriteLine(item.Price);
                line.Add(new OrderLineDTO {Price = item.Price, Quantity = 1, ProductNo = item.Id});
            }

            var invoiceDto = new OrderHeaderDTO {CustomerId = customerid, Lines = line};
            await _invoice.Post(invoiceDto);
            return RedirectToAction("Index");
        }
    }
}