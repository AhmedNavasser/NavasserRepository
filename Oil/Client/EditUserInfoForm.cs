using System;using System.Windows.Forms;
using OilContext;
using Operations.Interfaces;

namespace Client
{
    public partial class EditUserInfoForm:Form
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUserOperation _userOperation;
        public EditUserInfoForm ()
        {
            
            InitializeComponent();
            ThemeController.ThemeControl(this,Properties.Settings.Default.Theme,Controls);
            var container = ObjectIntializer.StructureMapInitializer();
            _unitOfWork = container.TryGetInstance<IUnitOfWork>();
            _userOperation = container.TryGetInstance<IUserOperation>();

            DisableObjects();
        }

        private void DisableObjects()
        {
            deleteButton.Enabled = false;
            editButton.Enabled = false;
            newProfileGroupBox.Enabled = false;
        }

        void SetEmpty()
        {
            userNameTextBox.Text = string.Empty;
            NewUserNameTextBox.Text = string.Empty;
            newPasswordTextBox.Text = string.Empty;
            
        }
        private void searchButton_Click ( object sender,EventArgs e )
        {
            var user = _userOperation.DecryptUser(_userOperation.GetUser(BitConverter.ToString(_userOperation.EncryptUserInfo(userNameTextBox.Text))));
            if (user != null)
            {
                deleteButton.Enabled = true;
                newProfileGroupBox.Enabled = true; 
                userValiadatePictureBox.Image = Properties.Resources.accept;
            }
            else
            {
                deleteButton.Enabled = false;
                newProfileGroupBox.Enabled = false; 
                userValiadatePictureBox.Image = Properties.Resources.cancel;
            }
        }

        private void deleteButton_Click ( object sender,EventArgs e )
        {
            DialogResult deleteResult = MessageBox.Show(@"?آیا مطمئن هستید که میخواهید این کاربر را حذف نمایید",
                @"هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (deleteResult == DialogResult.Yes)
            {
                _userOperation.DeleteUser(userNameTextBox.Text);
                var result = _unitOfWork.SaveChanges();
                deleteButton.Enabled = false;

                if (result == 1)
                {
                    MessageBox.Show(@"حذف کاربر با موفقیت انجام شد", @"حذف کاربر", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(@"خطا در حذف کاربر", @"حذف کاربر", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }

            SetEmpty();
        }

        private void NewUserNameTextBox_Leave ( object sender,EventArgs e )
        {
            if (string.IsNullOrEmpty(NewUserNameTextBox.Text))
            {
                MessageBox.Show(@"لطفا نام کاربری را وارد نمایید");
                editButton.Enabled = false;
            }
        }

        private void newPasswordTextBox_Leave ( object sender,EventArgs e )
        {
            if (string.IsNullOrEmpty(newPasswordTextBox.Text))
            {
                MessageBox.Show(@"لطفا رمز را وارد نمایید");
                editButton.Enabled = false;
            }

            
        }

        private void newPasswordTextBox_TextChanged ( object sender,EventArgs e )
        {
            if(!string.IsNullOrEmpty(NewUserNameTextBox.Text) & !string.IsNullOrEmpty(newPasswordTextBox.Text))
            {
                editButton.Enabled = true;
            }}
    }
}
