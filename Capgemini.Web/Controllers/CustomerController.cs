using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Capgemini.Domain;
using Capgemini.Domain.DTO;
using Capgemini.Helper;
using Capgemini.Web.Models;
using Capgemini.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace Capgemini.Web.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerServece _customer;
        public ICustomerServece Customer => _customer;

        public CustomerController(ICustomerServece customer)
        {
            _customer = customer;
        }

        public async Task<IActionResult> Index()
        {
            var customerList = await Customer.Bower();
            return View(customerList);
        }

        public IActionResult AddNew()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddNew(CustormerDTO customer)
        {
            await _customer.Post(customer);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(Guid customerid)
        {
            var customer = await _customer.Get(customerid);
            return View(customer);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(CustormerDTO customerDTO)
        {
             await _customer.Put(customerDTO);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(Guid customerid)
        {
             await _customer.Delete(customerid);
            return RedirectToAction("Index");
        }

        public async Task<PartialViewResult> CustomerDDL()
        {
            var cuslomerList = await _customer.Bower();
            return PartialView(cuslomerList);
        }
        
    }
}