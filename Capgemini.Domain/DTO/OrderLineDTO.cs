using System;
using System.Collections.Generic;

namespace Capgemini.Domain.DTO
{
    public class OrderLineDTO
    {
        public Guid Id { get; set; }
        public string OrderNummber { get; set; }
        public Guid ProductNo { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public OrderHeaderDTO Heder { get; set; }
    }
}