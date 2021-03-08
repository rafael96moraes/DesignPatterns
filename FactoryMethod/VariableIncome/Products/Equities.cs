using FactoryMethod.VariableIncome.Products.Interface;

namespace FactoryMethod.VariableIncome.Products
{
    class Equities : IProducts
    {
        string TypeProduct = "Fundos imobiliários";

        public string GetTypeProduct()
        {
            return TypeProduct;
        }
    }
}
