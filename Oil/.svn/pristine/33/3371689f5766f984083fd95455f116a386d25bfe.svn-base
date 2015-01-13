using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DomainClasses;
using Navasser.Solar;
using OilContext;
using Operations.Interfaces;

namespace Client
{
    public partial class AddReqFromCoForm : Form
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IProductOperation _productOperation;
        private readonly ICategoryOperation _categoryOperation;



        private List<Category> _productCategories;
        private Category _localProductCategory;
        private List<CustomProductInfo> _products;

        public AddReqFromCoForm()
        {
            InitializeComponent();
            ThemeController.ThemeControl(this, Properties.Settings.Default.Theme, Controls);

            var container = ObjectIntializer.StructureMapInitializer();
            _unitOfWork = container.TryGetInstance<IUnitOfWork>();
            _productOperation = container.TryGetInstance<IProductOperation>();
            _categoryOperation = container.TryGetInstance<ICategoryOperation>();

            dateMaskedTextBox.Text = DateTime.Now.ToSolarDateTime();
            _productCategories = _categoryOperation.GetProductCategories();
            _products = _productOperation.GetProducts();
            dateMaskedTextBox.Text = DateTime.Now.ToSolarDateTime();

        }

        private void SetEmpty()
        {
            productIdTextBox.Text = string.Empty;
            shipSerialTextBox.Text = String.Empty;
            productNameTextBox.Text = string.Empty;
            countOfBoxesTextBox.Text = string.Empty;
            itemPerBoxTextBox.Text = String.Empty;
            netPriceMaskedTextBox.Text = string.Empty;
            intrestMaskedTextBox.Text = String.Empty;
            finalPriceMaskedTextBox.Text = String.Empty;
        }

        private void AddReqFromCoForm_Load(object sender, EventArgs e)
        {

            seperatorLabel.Width = Width - 35;
            seperatorLabel.Height = 2;
            seperatorLabel.AutoSize = false;

            foreach (var productCategory in _productCategories)
            {
                productCategoryComboBox.Properties.Items.Add(productCategory.CategoryName);
            }

            sumarrayDataGridView.DataSource = _products;

        }

        private int StringToInt(string text)
        {
            const string pattern = @"\d";
            string result = string.Empty;
            MatchCollection match = Regex.Matches(text, pattern, RegexOptions.IgnorePatternWhitespace);

            try
            {
                if (match.Count > 0)
                {
                    if (match.Count < 9)
                    {
                        for (var i = 0; i < 9 - match.Count; i++)
                        {
                            result += 0;
                        }
                    }
                    foreach (var number in match)
                    {
                        result += number;
                    }

                }
                return int.Parse(result);
            }
            catch (Exception)
            {

                return 000000000;
            }

        }

        private Product Iniitializer()
        {
            var newProduct = new Product
            {
                ProductCategory = _localProductCategory,
                ShipSerial = int.Parse(shipSerialTextBox.Text),
                ProductId = int.Parse(productIdTextBox.Text),
                ProductName = productNameTextBox.Text,
                CountOfBoxes = int.Parse(countOfBoxesTextBox.Text),
                ItemPerBox = int.Parse(itemPerBoxTextBox.Text),
                NetPrice = netPriceMaskedTextBox.Text,
                Intrest = intrestMaskedTextBox.Text,
                FinalPrice = finalPriceMaskedTextBox.Text
            };
            return newProduct;
        }
        private void addNewProductButton_Click(object sender, EventArgs e)
        {


            _productOperation.AddNewProduct(Iniitializer());
            var addResult = _unitOfWork.SaveChanges();
            if (addResult != 1)
            {
                MessageBox.Show(@"خطا در ثبت محصول");
            }
            else
            {
                MessageBox.Show(@"محصول جدید با موفقیت ثبت شد", @"ثبت محصول جدید", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                SetEmpty();
                _products = _productOperation.GetProducts();
                if (_products == null) return;
                sumarrayDataGridView.DataSource = _products;
            }
        }

        private void cancelButton_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        void Calculate()
        {
            Func<string, int> textToIntFunc = StringToInt;
            finalPriceMaskedTextBox.Text = (textToIntFunc(countOfBoxesTextBox.Text) * textToIntFunc(itemPerBoxTextBox.Text)
                * textToIntFunc(netPriceMaskedTextBox.Text) + textToIntFunc(itemPerBoxTextBox.Text) * textToIntFunc(intrestMaskedTextBox.Text)).ToString(CultureInfo.InvariantCulture);
            finalPriceMaskedTextBox.Text = textToIntFunc(finalPriceMaskedTextBox.Text).ToString(CultureInfo.InvariantCulture);
        }

        private void countOfBoxesTextBox_EditValueChanged(object sender, EventArgs e)
        {
            Calculate();

        }

        private void itemPerBoxTextBox_EditValueChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void netPriceMaskedTextBox_EditValueChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void intrestMaskedTextBox_EditValueChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void productCategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            _localProductCategory = _productCategories.FirstOrDefault(i => i.CategoryName == productCategoryComboBox.SelectedItem.ToString());


        }
    }
}
