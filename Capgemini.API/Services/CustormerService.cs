using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Capgemini.API.Infastructure;
using Capgemini.Domain;
using Capgemini.Domain.DTO;

namespace Capgemini.API.Services
{
    public class CustormerService : ICustomerService
    {
        private readonly CapgeminiContext _context;

        public CustormerService(CapgeminiContext context, object context1)
        {
            _context = context;
        }

        public async Task AddCustormer(CustormerDTO Custormer)
        {
            try
            {
                var customer = new Customer(Custormer.Name, Custormer.Surname, Custormer.City, Custormer.PostalCode,
                    Custormer.Street, Custormer.HauseNo, Custormer.AppartamentNo, Custormer.CompanyName, Custormer.NIP);
                _context.Customers.Add(customer);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<IEnumerable<Customer>> Bower()
            => _context.Customers;

        public async Task<Customer> GetAsync(Guid id)
            => _context.Customers.FirstOrDefault(w => w.Id == id);


        public async Task UpdateCustormer(Customer Custormer)
        {
            _context.Customers.Update(Custormer);
            _context.SaveChanges();
        }

        public async Task DeleteCustormer(Guid Id)
        {
            var CustomerToDelete = _context.Customers.Find(Id);
            if (CustomerToDelete != null)
            {
                _context.Customers.Remove(CustomerToDelete);
                _context.SaveChanges();
            }
        }
    }
}