using System;
using System.Collections.Generic;

namespace Capgemini.Domain.DTO
{
    public class OrderHeaderDTO
    {
        public Guid Id { get; set; }
        public string OrderNummber { get; set; }
        public Guid CustomerId { get; set; }
        public decimal OrderValue { get; set; }
        public DateTime OrderDate { get; set; }
        public int Status { get; set; }
        public IEnumerable<OrderLineDTO> Lines { get; set; }
    }
}