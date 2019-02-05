using System;
using System.Collections.Generic;
using System.Text;
using Capgemini.Domain.DTO;

namespace Capgemini.Domain
{
    public class Product
    {
        public Guid Id { get; protected set; }
        public string Name { get; protected set; }
        public string Description { get; protected set; }
        public decimal Price { get; protected set; }
        public int QuantityOnStock { get; protected set; }

        private Product()
        {
            
        }

        public Product(string name,string description, decimal price)
        {
            Id=new Guid();
            Name =ChcekStringIsEmpty(name);
            Description = ChcekStringIsEmpty(description);
            Price = ChcekPrice(price);
            QuantityOnStock = RandomValue();
        }

        public Product(ProductDTO modelDto)
        {
            Id=modelDto.Id;
            Name = modelDto.Name;
            Description = modelDto.Description;
            Price = ChcekPrice(modelDto.Price);
            QuantityOnStock = modelDto.QuantityOnStock;
        }
        private decimal ChcekPrice(decimal price)
            => price > 0 ? price : 100;

        private string ChcekStringIsEmpty(string input)
        {
            if (input!=null)
            {
               return input.Length > 0 ? input : "ala ma kota ";
            }
           throw new NullReferenceException();
        }
            

        private int RandomValue()
        {
            var random= new Random();
            return random.Next(1, 100000);
        }
       
    }
}
