using System;
using System.Windows.Forms;
using DomainClasses;
using OilContext;
using Operations;
using Operations.Interfaces;
using StructureMap;


namespace Client
{
    public partial class AddNewUserForm : Form
    {
        private IUserOperation _userOperation;
        private IUnitOfWork _unitOfWork;
        public AddNewUserForm()
        {
            InitializeComponent();
            
        }

        private void InitalizeObjects()
        {
            Container container = ObjectIntializer.StructureMapInitializer();
            _userOperation = container.TryGetInstance<IUserOperation>();
            _unitOfWork = container.TryGetInstance<IUnitOfWork>();
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddNewUserForm_Load(object sender, EventArgs e)
        {
            ThemeController.ThemeControl(this,Properties.Settings.Default.Theme,Controls);
            seperatorLabel.Height = 2;
            seperatorLabel.Width = Width -30;
        }
        /// <summary>
        /// گرفتن اطلاعات کاربر شامل نام کاربری و رمز عبور از ورودی
        /// </summary>
        /// <returns>یک شی از کلاس یوزر را برگشت می دهد</returns>
        private User GetUserInfo ()
        {
            var user = new User
            {
                UserName = userNameTextBox.Text.Trim(),
                Password = passwordTextBox.Text.Trim()
            };
            return user;
        }

        private void addNewUserButton_Click(object sender, EventArgs e)
        {

            Cursor.Current = Cursors.WaitCursor;
            var user = GetUserInfo();
            _userOperation.AddNewUser(_userOperation.EncryptUser(user));
            var saveChanges = _unitOfWork.SaveChanges();
            if(saveChanges == 1)
            {
                MessageBox.Show(@"کاربر جدید با موفقیت ثبت شد",@"ثبت کاربر",MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                Properties.Settings.Default.UserCreated = true;
                Properties.Settings.Default.Save();
                Hide();
                var loginForm = new LoginForm();
                loginForm.Activate();
            }
            else
            {
                MessageBox.Show(@"خطا در ثبت کاربر",@"ثبت کاربر",MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            
        }

        
    }
}
