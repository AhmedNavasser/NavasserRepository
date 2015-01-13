using System.Collections;
using System.Collections.Generic;
using DomainClasses;

namespace Operations.Interfaces
{
    public interface IProductOperation
    {
        void AddNewProduct(Product product);
        List<string> GetProductsName();
        List<int> GetShipSerial();
        IList SearchProducts(int searchIndex, string criteria);
        List<CustomProductInfo> GetProducts();

    }
}
