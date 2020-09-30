using System;
using System.Collections.Generic;
using TesteVersionamentoAPI.Models;

namespace TesteVersionamentoAPI.Context
{
    public static class FakeDataFactory
    {
        public static IEnumerable<Product> CreateFakeProducts(int count = 50)
        {
            for (int index = 0; index < count; index++)
            {
                yield return new Product(Guid.NewGuid(), $"Teste {index}", $"Descrição {index}", index);
            }
        }

        public static void SaveFakeProducts(IEnumerable<Product> products, ApiContext apiContext)
        {
            apiContext.Products.AddRange(products);
            apiContext.SaveChanges();
        }
    }
}