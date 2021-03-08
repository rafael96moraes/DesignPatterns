using FactoryMethod.VariableIncome.Products.Interface;

namespace FactoryMethod.VariableIncome
{
    interface EmailFactoryMethod
    {
        IProducts CreateProduct();
        void SendMessage();
    }
}
