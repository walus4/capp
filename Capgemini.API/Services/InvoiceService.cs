using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Capgemini.API.Infastructure;
using Capgemini.Domain;
using Capgemini.Domain.DTO;

namespace Capgemini.API.Services
{
    public class InvoiceService :IInvoiceService
    {

        private readonly CapgeminiContext _context;

        public InvoiceService(CapgeminiContext context)
        {
            _context = context;
        }

        public async Task AddInvoice(OrderHeaderDTO invoiceDto)
        {
            try
            {
                var invoice = new OrderHeder(invoiceDto.CustomerId,invoiceDto.Lines);
                _context.OrderHeders.Add(invoice);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw e ;
            }
        }

        public async Task<IEnumerable<OrderHeder>> Bower()
            => _context.OrderHeders;

        public async Task<OrderHeder> Get(Guid id)
            => _context.OrderHeders .FirstOrDefault(w => w.Id == id);


        public async Task UpdateInvoice(OrderHeaderDTO invoiceDto)
        {
            var updateInvice = new OrderHeder(invoiceDto);
             _context.OrderHeders.Update(updateInvice);
            _context.SaveChanges();
        }

        public async Task DeleteInvoice(Guid Id)
        {
            var InvoiceToDelete = _context.OrderHeders.Find(Id);
            if (InvoiceToDelete != null)
            {
                InvoiceToDelete.Invoicecancel();
                _context.OrderHeders.Update(InvoiceToDelete);
                _context.SaveChanges();
            }
        }
    }
}
