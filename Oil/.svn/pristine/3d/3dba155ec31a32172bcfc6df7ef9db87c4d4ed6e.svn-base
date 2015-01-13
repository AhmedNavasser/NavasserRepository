using System;
using System.Windows.Forms;
using Operations.Interfaces;


namespace Client
{
    public partial class SearchProductForm : Form
    {
        private IProductOperation _productOperation;
        private ICategoryOperation _categoryOperation;

        /// <summary>
        /// بر اساس مقادیر این داده شمارشی تعیین می شود که جستجو بر چه اساسی باشد
        /// 1 بر اساس گروه محصول
        /// 2 بر اساس کد محصول
        /// 3 بر اساس شماره سریال بار
        /// </summary>
        private enum SearchIndex
        {
            ByCategoryName = 1,
            ByProductName = 2,
            ByShipSerial = 3
        };

        private int _radioButtonIndex;
        public SearchProductForm()
        {
            InitializeComponent();
            ThemeController.ThemeControl(this,Properties.Settings.Default.Theme,Controls);
            var container = ObjectIntializer.StructureMapInitializer();
            
            _categoryOperation = container.TryGetInstance<ICategoryOperation>();
            _productOperation = container.TryGetInstance<IProductOperation>();
        }
        private void LoadShipSerialNumber ()
        {
            var localSerialNumber = _productOperation.GetShipSerial();
            foreach(var serial in localSerialNumber)
            {
                shipSerialComboBox.Properties.Items.Add(serial);
            }
        }

        private void LoadProductNames ()
        {
            var localProductName = _productOperation.GetProductsName();
            foreach(var productName in localProductName)
            {
                productNameComboBox.Properties.Items.Add(productName);
            }
        }

        private void LoadProductCategories ()
        {
            var localCategories = _categoryOperation.GetProductCategories();
            foreach(var category in localCategories)
            {
                productCategoryComboBox.Properties.Items.Add(category.CategoryName);
            }
        }

        private void SearchProductForm_Load(object sender, EventArgs e)
        {

            LoadProductCategories();
            LoadProductNames();
            LoadShipSerialNumber();
        }
        
        /// <summary>
        /// این تابع بر اساس ایندکی یکی از رادیو باتونها عمل میکند. بدین ترتیب
        /// که یک ایندکس را گرفته و بر اساس آن یکی از توابع جستجو را صدا می کند
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                switch(_radioButtonIndex)
                {
                    case 1:
                        sumarrayGridControl.DataSource = _productOperation.SearchProducts((int)SearchIndex.ByCategoryName,
                            productCategoryComboBox.SelectedItem.ToString());
                        break;
                    case 2:
                        sumarrayGridControl.DataSource = _productOperation.SearchProducts((int)SearchIndex.ByProductName,
                            productNameComboBox.SelectedItem.ToString());
                        break;
                    case 3:
                        sumarrayGridControl.DataSource = _productOperation.SearchProducts((int)SearchIndex.ByShipSerial,
                            shipSerialComboBox.SelectedItem.ToString());
                        break;
                }
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
        }

        private void byCategoryRadioButton_CheckedChanged(object sender, EventArgs e)
        {

            if (byCategoryRadioButton.Checked)
            {
                categoryNameLabel.Enabled = true;
                productCategoryComboBox.Enabled = true;
                _radioButtonIndex = 1;
            }
            else
            {
                categoryNameLabel.Enabled = false;
                productCategoryComboBox.Enabled = false;
            }
        }

        private void byProductIdRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (byProductIdRadioButton.Checked)
            {
                productNameLabel.Enabled = true;
                productNameComboBox.Enabled = true;
                _radioButtonIndex = 2;
            }
            else
            {
                productNameLabel.Enabled = false;
                productNameComboBox.Enabled = false;
            }
        }

        private void byShipSreialRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (byShipSreialRadioButton.Checked)
            {

                shipSerialLabel.Enabled = true;
                shipSerialComboBox.Enabled = true;
                _radioButtonIndex = 3;
            }
            else
            {
                shipSerialLabel.Enabled = false;
                shipSerialComboBox.Enabled = false;
            }
        }

        

        
    }
}
