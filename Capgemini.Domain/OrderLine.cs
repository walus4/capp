using System;

namespace Capgemini.Domain
{
    public class OrderLine
    {
        public Guid Id { get; protected set; }
        public string OrderNummber { get; protected set; }
        public Guid ProductNo { get; protected set; }
        public decimal Price { get; protected set; }
        public int Quantity { get; protected set; }
        public OrderHeder Heder { get; protected set; }


        public OrderLine(string orderNummber, Guid productNo, decimal price, int quantity)
        {
            Id = new Guid();
            OrderNummber = orderNummber;
            ProductNo = productNo;
            Price = price;
            Quantity = quantity;
        }
    }
}