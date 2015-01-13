using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using DomainClasses;
using OilContext;
using Operations.Interfaces;

namespace Operations
{
    public  class ProductOperation:IProductOperation
    {
        private readonly IDbSet<Product> _products;

        public ProductOperation(IUnitOfWork unitOfWork)
        {
            _products = unitOfWork.Set<Product>();
        }
        /// <summary>
        /// یک محصول را اضافه می کند
        /// </summary>
        /// <param name="product">یک شی از کلاس محصوئل را به عنوان ورودی می گیرد</param>
        
        public  void AddNewProduct ( Product product )
        {
            _products.Add(product);
        }

        /// <summary>
        /// لیستی از نام محصولات را بر میگرداند.از این تابع برای پر کردن کامبوباکس ها در فرم جستجوی محصولات استفاده میشود
        /// </summary>
        /// <returns>یک لیستی از رشته ها که حاوی نام محصولات را بر میگرداند</returns>
        public  List<string> GetProductsName ()
        {
            return _products.Select(p => p.ProductName).Distinct().ToList();
        }

        /// <summary>
        ///  لیستی از شماره سریالهای بار تحویلی را بر میگرداند.از این تابع برای پر کردن کامبوباکس ها در فرم جستجوی محصولات استفاده میشود
        /// </summary>
        /// <returns>یک لیستی از اعداد صحیح که شامل شماره سریال بار را برمیگرداند</returns>
        public  List<int> GetShipSerial ()
        {
            return _products.Select(p => p.ShipSerial).Distinct().ToList();
        }

        /// <summary>
        /// این تابع بر اساس یک ایندکس عمل جستجو برای یک ورودی را انجام میدهد
        /// </summary>
        /// <param name="searchIndex">یک ایندکس از داده شمارشی سرچ ایندکس در فرم جستجوی محصول دریافت و بر اساس آن عمل 
        /// جسجتجو را انجام میدهد
        /// </param>
        /// <param name="criteria">یک ورودی از کامبوباکسهای فرم جستجو به عنوان ورودی دریافت میکند</param>
        /// <returns>نتایج جستجو از هر یک از توابع را به عنوان خروجی بر میگرداند</returns>
        public  IList SearchProducts ( int searchIndex,string criteria )
        {
            dynamic query = 0;
            switch(searchIndex)
            {
                case 1:
                    query = SearchProductByCategory(criteria);
                    break;
                case 2:
                    query = SearchProductByName(criteria);
                    break;
                case 3:
                    query = GetProductsByShipSerial(int.Parse(criteria));
                    break;
            }
            return query;
        }

        /// <summary>
        /// لیستی از محصولات را بر اساس یک ورودی برمیگرداند. این تابع خود در تابع بالا صدا زده می شود
        /// </summary>
        /// <param name="shipSerial">یک عدد صحیح که نشانگر شماره سریال بار را به عنوان ورودی می پذیرد</param>
        /// <returns>لیستی از محصولات را بر می گرداند</returns>
        internal  List<CustomProductInfo> GetProductsByShipSerial ( int shipSerial )
        {
            var query = _products.Where(p => p.ShipSerial == shipSerial).Select(
                p =>
                    new CustomProductInfo
                    {
                        Category = p.ProductCategory.CategoryName,
                        ShipSerial = p.ShipSerial,
                        ProductId = p.ProductId,
                        ProductName = p.ProductName,
                        CountOfBoxes = p.CountOfBoxes,
                        ItemPerBox = p.ItemPerBox,
                        NetPrice = p.NetPrice,
                        Intrest = p.Intrest,
                        FinalPrice = p.FinalPrice
                    });
            return query.ToList();
        }

        /// <summary>
        /// این تابع لیست دلخواهی از محصولات را بر میگرداند. منظور از دلخواه یعنی یک کلاس تعدیل شده 
        /// از کلاس محصول می باشد که شامل کلیه آیتم های این کلاس نمی باشد
        /// </summary>
        /// <returns>لیستی از محصولات را بر میگرداند</returns>
        public  List<CustomProductInfo> GetProducts()
        {
            var query = _products.Select(
                p =>
                    new CustomProductInfo
                    {
                        Category = p.ProductCategory.CategoryName,
                        ShipSerial = p.ShipSerial,
                        ProductId = p.ProductId,
                        ProductName = p.ProductName,
                        CountOfBoxes = p.CountOfBoxes,
                        ItemPerBox = p.ItemPerBox,
                        NetPrice = p.NetPrice,
                        Intrest = p.Intrest,
                        FinalPrice = p.FinalPrice
                    });
            return query.ToList();
        }

        /// <summary>
        /// این تابع لیست دلخواهی از محصولات را بر میگرداند. منظور از دلخواه یعنی یک کلاس تعدیل شده
        /// از کلاس محصول می باشد که شامل کلیه آیتم های این کلاس نمی باشد
        /// </summary>
        /// <param name="productName">یک رشته شامل نام محصول را به عنوان ورودی می پذیرد</param>
        /// <returns>لیستی از محصولات را بر میگرداند</returns>
        internal  List<CustomProductInfo> SearchProductByName(string productName)
        {

            var query = _products.Where(p => p.ProductName == productName).Select(
                p =>
                    new CustomProductInfo
                    {
                        Category = p.ProductCategory.CategoryName,
                        ShipSerial = p.ShipSerial,
                        ProductId = p.ProductId,
                        ProductName = p.ProductName,
                        CountOfBoxes = p.CountOfBoxes,
                        ItemPerBox = p.ItemPerBox,
                        NetPrice = p.NetPrice,
                        Intrest = p.Intrest,
                        FinalPrice = p.FinalPrice
                    });
            return query.ToList();
        }

        /// <summary>
        /// این تابع لیست دلخواهی از محصولات را بر میگرداند. منظور از دلخواه یعنی یک کلاس تعدیل شده
        /// از کلاس محصول می باشد که شامل کلیه آیتم های این کلاس نمی باشد
        /// </summary>
        /// <param name="productCategory">یک رشته که نشانگر گروه محصول را به عنوان ورودی می پذیرد</param>
        /// <returns>لیستی از محصولات را برمیگرداند</returns>
        internal  List<CustomProductInfo> SearchProductByCategory ( string productCategory )
        {
            var query = _products.Where(p => p.ProductCategory.CategoryName == productCategory).Select(
                p =>
                    new CustomProductInfo
                    {
                        Category = p.ProductCategory.CategoryName,
                        ShipSerial = p.ShipSerial,
                        ProductId = p.ProductId,
                        ProductName = p.ProductName,
                        CountOfBoxes = p.CountOfBoxes,
                        ItemPerBox = p.ItemPerBox,
                        NetPrice = p.NetPrice,
                        Intrest = p.Intrest,
                        FinalPrice = p.FinalPrice
                    });
            return query.ToList();

        }

        /// <summary>
        /// این تابع لیست دلخواهی از محصولات را بر میگرداند. منظور از دلخواه یعنی یک کلاس تعدیل شده
        /// از کلاس محصول می باشد که شامل کلیه آیتم های این کلاس نمی باشد
        /// </summary>
        /// <param name="shipSerialNumber">یک عدد صحیح که نشانگر شماره سریال را به عنوان ورودی می پذیرد</param>
        /// <returns>لیستی از محصولات را برمیگرداند</returns>
        internal  List<CustomProductInfo> SearchProductByShipSerial ( int shipSerialNumber )
        {
            var query = _products.Where(p => p.ShipSerial == shipSerialNumber).Select(
                p =>
                    new CustomProductInfo
                    {
                        Category = p.ProductCategory.CategoryName,
                        ShipSerial = p.ShipSerial,
                        ProductId = p.ProductId,
                        ProductName = p.ProductName,
                        CountOfBoxes = p.CountOfBoxes,
                        ItemPerBox = p.ItemPerBox,
                        NetPrice = p.NetPrice,
                        Intrest = p.Intrest,
                        FinalPrice = p.FinalPrice
                    });
            return query.ToList();
        }
    }
}