using System;
using System.Data.Entity;
using System.Windows.Forms;
using DomainClasses;
using OilContext;
using Operations;
using Operations.Interfaces;


namespace Client
{
    public partial class NewProductCategoryForm : Form
    {
        private IUnitOfWork _unitOfWork;
        private ICategoryOperation _category;
        public NewProductCategoryForm()
        {
            InitializeComponent();

            var container = ObjectIntializer.StructureMapInitializer();
            _unitOfWork = container.TryGetInstance<IUnitOfWork>();
            _category = container.TryGetInstance<ICategoryOperation>();

        }
        

       private void NewProductCategoryForm_Load(object sender, EventArgs e)
        {
            ThemeController.ThemeControl(this, Properties.Settings.Default.Theme, Controls);
        }

       private Category GetNewProductCategory ()
       {
           var productCategory = new Category
           {
               CategoryName = categoryNameTextBox.Text
           };
           return productCategory;
       }
        private void addNewCategoryButton_Click(object sender, EventArgs e)
        {
            var productCategory = GetNewProductCategory();
            try
            {
                _category.AddNewCategory(productCategory);
                var addResult = _unitOfWork.SaveChanges();
                if (addResult == 1)
                {
                    MessageBox.Show(@" گروه  " + categoryNameTextBox.Text + @"با موفقیت ایجاد شد ", @"ایجاد گروه جدید", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                categoryNameTextBox.Text = string.Empty;
                categoryNameTextBox.Focus();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, @"خطا در ایجاد گروه", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        
    }
}
