using FactoryMethod.VariableIncome.Products;
using FactoryMethod.VariableIncome.Products.Interface;
using System;

namespace FactoryMethod.VariableIncome.Messages
{
    class EquitiesTemplate : EmailFactoryMethod
    {
        public IProducts CreateProduct()
        {
            return new Equities();
        }

        public void SendMessage()
        {
            var product = CreateProduct();
            Console.WriteLine($"###### Temos novidades para produtos de {product.GetTypeProduct()}!");
        }
    }
}
