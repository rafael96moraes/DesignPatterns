using FactoryMethod.VariableIncome.Products;
using FactoryMethod.VariableIncome.Products.Interface;
using System;

namespace FactoryMethod.VariableIncome.Messages
{
    class RealEstateFundsTemplate : EmailFactoryMethod
    {
        public IProducts CreateProduct()
        {
            return new RealEstateFunds();
        }

        public void SendMessage()
        {
            var product = CreateProduct();
            Console.WriteLine($"###### Prezado cliente do {product.GetTypeProduct()}, temos algumas atualizações[..]");
        }
    }
}
