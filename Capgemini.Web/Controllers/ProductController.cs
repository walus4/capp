using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Capgemini.Domain.DTO;
using Capgemini.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace Capgemini.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _product;
       

        public ProductController(IProductService product)
        {
            _product = product;
        }

        public async Task<IActionResult> Index()
        {
            var productList = await _product.Bower();
            return View(productList);
        }

        public IActionResult AddNew()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddNew(ProductDTO product)
        {
            await _product.Post(product);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(Guid id)
        {
            var product = await _product.Get(id);
            return View(product);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(ProductDTO productDTO)
        {
            await _product.Put(productDTO);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(Guid id)
        {
            await _product.Delete(id);
            return RedirectToAction("Index");
        }
    }
}