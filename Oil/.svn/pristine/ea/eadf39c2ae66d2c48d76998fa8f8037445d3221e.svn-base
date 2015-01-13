using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Client
{
    public partial class OptionsForm : Form
    {
        public OptionsForm()
        {
            InitializeComponent();
        }
        #region UserInterfaceCreateControls

        /// <summary>
        /// تعریف کنترلهای قسمت رابط کاربری در فرم
        /// </summary>
        private void UserInterfaceCreateControls()
        {
            PanelOfControls.Controls.Clear();

            Vs2013BlueRadioButton = new RadioButton
            {
                Size = new Size(170,30),
                Location = new Point(170,66),
                Text = @"ویژوال استودیو 2013 آبی"
            };
            PanelOfControls.Controls.Add(Vs2013BlueRadioButton);

            Vs2013LightRadioButton = new RadioButton
            {
                Size = new Size(170, 30),
                Location = new Point(170, 171),
                Text = @"ویژوال استودیو 2013 روشن"
            };
            PanelOfControls.Controls.Add(Vs2013LightRadioButton);

            Vs2013BluePictureBox = new PictureBox
            {
                BorderStyle = BorderStyle.FixedSingle,
                Size = new Size(140,50),
                Location = new Point(30,90),
                Image = Properties.Resources.Vs2013Blue,
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PanelOfControls.Controls.Add(Vs2013BluePictureBox);

            Vs2013LightPictureBox = new PictureBox
            {
                BorderStyle = BorderStyle.FixedSingle,
                Size = new Size(140, 50),
                Location = new Point(30, 200),
                Image = Properties.Resources.Vs2013Light,
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PanelOfControls.Controls.Add(Vs2013LightPictureBox);

            UserInterfaceGroupBox = new GroupBox
            {
                Size = new Size(364, 220),
                Location = new Point(8, 40),
                Text = @"رابط کاربری",
                TabIndex = 0
            };
            PanelOfControls.Controls.Add(UserInterfaceGroupBox);

            UserInterfaceSeperatorLabel = new Label
            {
                AutoSize = false,
                BorderStyle = BorderStyle.Fixed3D,
                Height = 2,
                Location = new Point(8, 310),
                Width = 365
            };
            PanelOfControls.Controls.Add(UserInterfaceSeperatorLabel);

            UserInterfaceOkButton = new SimpleButton
            {
                Font = new Font("Droid Arabic Naskh", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0),
                Location = new Point(95, 327),
                Size = new Size(80,30),
                Text = @"موافق",
                
            };
            PanelOfControls.Controls.Add(UserInterfaceOkButton);

            UserInterfaceCancelButton = new SimpleButton
            {
                Font = new Font("Droid Arabic Naskh",8.25F,FontStyle.Regular,GraphicsUnit.Point,0),
                Location = new Point(8, 327),
                Size = new Size(80, 30),
                Text = @"لغو"
            };
            PanelOfControls.Controls.Add(UserInterfaceCancelButton);
            

            //Events for radiobuttons
            Vs2013BlueRadioButton.Click += Vs2013BlueRadioButton_Click;
            Vs2013LightRadioButton.Click += Vs2013LightRadioButton_Click;
            UserInterfaceCancelButton.Click += UserInterfaceCancelButton_Click;
            UserInterfaceOkButton.Click += UserInterfaceOkButton_Click;
            UserInterfaceCheckVariables();

        }

        /// <summary>
        /// اعمال تم
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void UserInterfaceOkButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
           var dialogResult=  MessageBox.Show(@"تغییرات بعد از شروع مجدد نرم افزار اعمال می شود. آیا مایلید که نرم افزار را ریستارت نمایید", "", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information);
           if (dialogResult == DialogResult.OK)
            {
                Application.Restart();
            }
           if (dialogResult == DialogResult.Cancel)
           {
               Close();
           }
        }

        void UserInterfaceCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        void Vs2013LightRadioButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Theme = 1;
            
        }

        private void Vs2013BlueRadioButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Theme = 0;
        }

        /// <summary>
        /// این تابع چک میکند که کدام تم انتخاب شده است
        /// اگر تم انتخاب شده آبی بود چک باکس اول چک میخورد در غیر اینصورت چک باکس دوم
        /// </summary>
        private void UserInterfaceCheckVariables()
        {
            switch (Properties.Settings.Default.Theme)
            {
                case 0:
                    Vs2013BlueRadioButton.Checked = true;
                    break;

                case 1:
                    Vs2013LightRadioButton.Checked = true;
                    break;
            }
        }

        #endregion

        #region BackUpCreateControls

        /// <summary>
        /// تعریف کنترلهای قسمت پشتیبانگیری
        /// </summary>
        internal void BackUpCreateControls()
        {
            PanelOfControls.Controls.Clear();

            EnableAutoBackUpCheckBox = new CheckBox
            {
                Location = new Point(210,70),
                Size = new Size(150,25),
                Text = @"پشتیبان گیری اتوماتیک",
            };
            PanelOfControls.Controls.Add(EnableAutoBackUpCheckBox);

            SetTimerlLabel = new Label
            {
                Location = new Point(150,100),
                Size = new Size(211,21),
                Text = @"مدت زمان پشتیبانگیری(بر حسب دقیقه):"
            };
            PanelOfControls.Controls.Add(SetTimerlLabel);

            SetMinutesNumericUpDown = new NumericUpDown
            {
                Location = new Point(20, 95),
                Size = new Size(110, 29),
                Enabled = false
            };
            PanelOfControls.Controls.Add(SetMinutesNumericUpDown);

            PathLabel = new Label
            {
                Location = new Point(220, 145),
                Size = new Size(140, 21),
                Text = @"مسیر ذخیره فایل پشتیبان:",
            };
            PanelOfControls.Controls.Add(PathLabel);

            PathTextBox = new TextBox
            {
                Location = new Point(50,140),
                Size = new Size(170,29),
                ReadOnly = true,
                Text = Properties.Settings.Default.BackUpPath

            };
            PanelOfControls.Controls.Add(PathTextBox);

            SearchpathbButton = new SimpleButton
            {
                Location = new Point(20, 140),
                Size = new Size(29, 29),
                Text = @"..."
            };
            PanelOfControls.Controls.Add(SearchpathbButton);

            BackUpGroupBox = new GroupBox
            {
                Location = new Point(8, 40),
                Size = new Size(364, 220),
                Text = @"تنظیمات پشتیبان گیری",
                TabIndex = 0
            };
            PanelOfControls.Controls.Add(BackUpGroupBox);

            BackUpSeperatorLabel = new Label
            {
                AutoSize = false,
                BorderStyle = BorderStyle.Fixed3D,
                Height = 2,
                Location = new Point(8, 310),
                Width = 365
            };
            PanelOfControls.Controls.Add(BackUpSeperatorLabel);

            BackUpOkButton = new SimpleButton
            {
                Font = new Font("Droid Arabic Naskh",8.25F,FontStyle.Regular,GraphicsUnit.Point,0),
                Location = new Point(95, 327),
                Size = new Size(80, 30),
                Text = @"موافق",

            };
            PanelOfControls.Controls.Add(BackUpOkButton);

            BackUpCancelButton = new SimpleButton
            {
                Font = new Font("Droid Arabic Naskh",8.25F,FontStyle.Regular,GraphicsUnit.Point,0),
                Location = new Point(8, 327),
                Size = new Size(80, 30),
                Text = @"لغو"
            };
            PanelOfControls.Controls.Add(BackUpCancelButton);

            SearchpathbButton.Click += SearchpathbButton_Click;
            EnableAutoBackUpCheckBox.CheckedChanged += EnableAutoBackUpCheckBox_CheckedChanged;
            BackUpOkButton.Click += BackUpOkButton_Click;
            BackUpCancelButton.Click += BackUpCancelButton_Click;
            SetMinutesNumericUpDown.ValueChanged += SetMinutesNumericUpDown_ValueChanged;

            CheckVariablesForBackUp();
        }

        /// <summary>
        /// تبدیل دقیقه به میلی ثانیه برای تنظیم عمل پشتیبانگیری
        /// چون تایمر بر اساس میلی ثانیه عمل میکند
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SetMinutesNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.BackUpTime = (int) SetMinutesNumericUpDown.Value*60000;
        }

        void BackUpCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        void BackUpOkButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            Close();
        }

        void EnableAutoBackUpCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (EnableAutoBackUpCheckBox.Checked)
            {
                Properties.Settings.Default.AutoBackUp = true;
                SetMinutesNumericUpDown.Enabled = true;
            }
            else
            {
                Properties.Settings.Default.AutoBackUp = false;
               SetMinutesNumericUpDown.Enabled = false; 
            }
            
        }

        void SearchpathbButton_Click(object sender, EventArgs e)
        {
            BackUpPathFolderDialog.ShowDialog();
            try
            {
                Properties.Settings.Default.BackUpPath = BackUpPathFolderDialog.SelectedPath + @"\OilDataBase.sdf";
                Properties.Settings.Default.Save();
                PathTextBox.Text = Properties.Settings.Default.BackUpPath;

            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
            
        }

        private void CheckVariablesForBackUp()
        {
            if (Properties.Settings.Default.AutoBackUp)
            {
                EnableAutoBackUpCheckBox.Checked = true;
                SetMinutesNumericUpDown.Value = decimal.Divide(Properties.Settings.Default.BackUpTime, 60000);
            }

            PathTextBox.Text = Properties.Settings.Default.BackUpPath;}
        #endregion


        private void OptionsTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch (OptionsTreeView.SelectedNode.Name)
            {
                case "UserInterface":
                    UserInterfaceCreateControls();
                    ThemeController.ThemeControl(this, Properties.Settings.Default.Theme, Controls);
                    break;
                case "BackUp":
                    BackUpCreateControls();
                    ThemeController.ThemeControl(this, Properties.Settings.Default.Theme, Controls);
                    break;
            }
        }

        private void OptionsForm_Load(object sender, EventArgs e)
        {
            
            ThemeController.ThemeControl(this,Properties.Settings.Default.Theme,Controls);
            
        }

      

     
    }
}
