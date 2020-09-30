using System;

namespace TesteVersionamentoAPI.Models
{
    public class Product
    {
        public Product() { }

        public Product(Guid id, string name, string description, decimal price)
            => (Id, Name, Description, Price) = (id, name, description, price);

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}