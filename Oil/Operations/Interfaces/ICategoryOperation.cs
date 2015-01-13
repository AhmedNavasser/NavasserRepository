using System.Collections.Generic;
using DomainClasses;

namespace Operations.Interfaces
{
    public interface ICategoryOperation
    {
        void AddNewCategory(Category productCategory);
        List<Category> GetProductCategories();
    }
}
