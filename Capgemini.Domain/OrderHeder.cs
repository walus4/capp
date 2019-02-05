using System;
using System.Collections.Generic;
using System.Linq;
using Capgemini.Domain.DTO;

namespace Capgemini.Domain
{
    public class OrderHeder
    {
        private ISet<OrderLine> _lines = new HashSet<OrderLine>();
        public Guid Id { get; protected set; }
        public string OrderNummber { get; protected set; }
        public Guid CustomerId { get; protected set; }
        public decimal OrderValue { get; protected set; }
        public DateTime OrderDate { get; protected set; }
        public int Status { get; protected set; }

        public IEnumerable<OrderLine> Lines
        {
            get => _lines;
            set { _lines = new HashSet<OrderLine>(); }
        }

        private OrderHeder()
        {
        }

        public OrderHeder(Guid customerId,IEnumerable<OrderLineDTO> linesDtos)
        {
            Id = new Guid();
            CustomerId = customerId;
            OrderValue = caluceateInvoiceVlue(linesDtos);
            OrderDate = DateTime.UtcNow;
            Status = 1;
            OrderNummber = GenereteOdrerNO();
        }

        protected string GenereteOdrerNO() =>
            $"FV/{DateTime.UtcNow.Year.ToString()}/{DateTime.UtcNow.Month}/{new Guid()}";

        public void AddLine(string orderNummber, Guid productNo, int quantity, decimal price)
        {
            _lines.Add(new OrderLine(orderNummber, productNo, price, quantity));
        }

        public void Invoicecancel()
        {
            Status = 0;
        }

        public OrderHeder(OrderHeaderDTO modelDto)
        {
            Id = modelDto.Id;
            Status = modelDto.Status!=null?modelDto.Status :1;
            CustomerId = modelDto.CustomerId;
            OrderDate = modelDto.OrderDate;
            OrderValue = modelDto.OrderValue;
            OrderNummber = modelDto.OrderNummber;
            Lines = LineformDTO(modelDto.Lines);

        }

        private IEnumerable<OrderLine> LineformDTO(IEnumerable<OrderLineDTO> linesDto)
        {
            OrderHeder order= new OrderHeder();
            foreach (var orderLineDto in linesDto)
            {
                order.AddLine( orderLineDto.OrderNummber, orderLineDto.ProductNo, orderLineDto.Quantity, orderLineDto.Price);
            }
            return order.Lines;
        }

        private decimal caluceateInvoiceVlue(IEnumerable<OrderLineDTO> linesDtos)
        {
            decimal invoiceValue = 0;
            foreach (var lineDto in linesDtos)
            {
                invoiceValue += (lineDto.Price * lineDto.Quantity);
            }

            return invoiceValue;
        }
    }
}