using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using DomainClasses;
using OilContext;
using Operations.Interfaces;

namespace Operations
{
    public class CategoryOpertion:ICategoryOperation
    {
        private readonly IDbSet<Category> _categories;

        /// <summary>
        /// این سازنده یک پارامتر از اینترفیس "آی یونیت آف ورک"را دریافت و اقدام به ساخت یک "دی بی ست" میکند
        /// </summary>
        /// <param name="unitOfWork">Object from IUnitOfWork interface</param>
        public CategoryOpertion(IUnitOfWork unitOfWork)
        {
            _categories = unitOfWork.Set<Category>();
        }
        /// <summary>
        /// اضافه کردن گروه برای محصولات استفاده می شود.
        /// </summary>
        /// <param name="productCategory">یک شی از گروه محصولات را به عنوان ورودی می پذیرد</param>
        /// <returns>یک عدد صحیح بین صفر و یک را به عنوان خروجی برمیگرداند و نشاندهنده موفقیت آمیز بودن با نبودن عمل درج می باشد</returns>
        public  void AddNewCategory(Category productCategory)
        {
            _categories.Add(productCategory);
        }

        /// <summary>
        /// لیستی از گروهها را بر میگرداند
        /// </summary>
        /// <returns> لیستی از گروهها را بر میگرداند</returns>
        public  List<Category> GetProductCategories()
        {
            return _categories.ToList();
        }
    }
}
