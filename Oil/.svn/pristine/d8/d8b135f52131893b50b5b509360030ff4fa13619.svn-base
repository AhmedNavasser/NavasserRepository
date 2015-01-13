using System;
using System.Data.Entity;
using System.Windows.Forms;
using DomainClasses;
using OilContext;
using Operations;
using Operations.Interfaces;

namespace Client
{
    public partial class NewUserForm : Form
    {
        private readonly IUserOperation _userOperation;
        private readonly IUnitOfWork _unitOfWork;
        public NewUserForm()
        {
            InitializeComponent();
            var container = ObjectIntializer.StructureMapInitializer();
            _unitOfWork = container.TryGetInstance<IUnitOfWork>();
            _userOperation = container.GetInstance<UserOperation>();
        }

        private void CreateDataBase()
        {
            try
            {
                Database.SetInitializer(new CreateDatabaseIfNotExists<OilDbContext>());
                Properties.Settings.Default.DataBasePath = Application.StartupPath + @"\OilDataBase.sdf";
                Properties.Settings.Default.Save();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, @"خطای ساخت پایگاه داده", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void NewUserForm_Load(object sender, EventArgs e)
        {
            seperatorLabel.Height = 2;
            seperatorLabel.Width = Width - 45;
            seperatorLabel.AutoSize = false;
            CreateDataBase();

        }



        private void cancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private User GetNewUserInfo()
        {
            var user = new User
            {
                UserName = userNameTextBox.Text.Trim(),
                Password = passwordTextBox.Text.Trim()
            };
            return user;
        }
        private void createUserButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            var user = GetNewUserInfo();
            _userOperation.AddNewUser(_userOperation.EncryptUser(user));
            var saveChanges = _unitOfWork.SaveChanges();
            if (saveChanges == 1)
            {
                MessageBox.Show(@"کاربر جدید با موفقیت ثبت شد", @"ثبت کاربر", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                Properties.Settings.Default.UserCreated = true;
                Properties.Settings.Default.Save();
                Hide();
                var loginForm = new LoginForm();
                loginForm.Activate();
            }
            else
            {
                MessageBox.Show(@"خطا در ثبت کاربر", @"ثبت کاربر", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }


    }
}
