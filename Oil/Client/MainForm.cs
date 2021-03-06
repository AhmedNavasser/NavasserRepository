﻿using System;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Navasser.Theme.VisualStudio.Metro;
using Operations.Interfaces;

namespace Client
{
    public partial class MainForm : Form
    {
        private readonly IBackup _backup;
        public MainForm()
        {
            InitializeComponent();
            var container = ObjectIntializer.StructureMapInitializer();
            _backup = container.TryGetInstance<IBackup>();
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            GC.Collect();
        }

        internal void BlueTheme()
        {
            operationsMenu.Renderer = new BlueMenuStrip();
            operationsMenu.BackgroundImage = Properties.Resources.BlueBackground;
            toolOperations.Renderer = new BlueToolStrip();
            operationToolStripContainer.BackColor = ColorTranslator.FromHtml("#D6DBE9");


            foreach (var control in Controls.OfType<MdiClient>())
            {
                control.BackColor = ColorTranslator.FromHtml("#293955");
                break;
            }
        }

        internal void LightTheme()
        {
            operationsMenu.Renderer = new LightMenuStrip();
            operationsMenu.BackgroundImage = Properties.Resources.LightBackground;
            toolOperations.Renderer = new LightToolStrip();
            operationToolStripContainer.BackColor = ColorTranslator.FromHtml("#EEEEF2");


            foreach (var control in Controls.OfType<MdiClient>())
            {
                control.BackColor = ColorTranslator.FromHtml("#D9D9D9");
                break;
            }
        }

        /// <summary>
        /// چک میکند که کدام تم اعمال شده است
        /// </summary>
        internal void CheckTheme()
        {
            switch (Properties.Settings.Default.Theme)
            {
                case 0:
                    BlueTheme();
                    break;
                case 1:
                    LightTheme();
                    break;
            }


        }



        private void FrmMain_Load(object sender, EventArgs e)
        {
            CheckTheme();
            if (Properties.Settings.Default.AutoBackUp)
            {
                autoBackUpTimer.Interval = Properties.Settings.Default.BackUpTime;
                autoBackUpTimer.Enabled = true;
                autoBackUpTimer.Start();
            }
            else
                autoBackUpTimer.Stop();

        }

        private void ShowOptionFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var optionFrom = new OptionsForm
            {
                MdiParent = this
            };
            optionFrom.Show();
        }

        private void showNewRequestFormtoolStripButton_Click(object sender, EventArgs e)
        {
            var newRequestForm = new NewRequestForm
            {
                MdiParent = this
            };
            newRequestForm.Show();
        }

        private void showNewReqFromCoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addRequestForm = new AddReqFromCoForm
            {
                MdiParent = this
            };
            addRequestForm.Show();
        }

        private void showProductCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newProductCategoryForm = new NewProductCategoryForm
            {
                MdiParent = this
            };
            newProductCategoryForm.Show();
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addNewUserForm = new AddNewUserForm
            {
                MdiParent = this
            };
            addNewUserForm.Show();
        }

        /// <summary>
        /// با استفاده از یک ثرد عمل پشتیبانگیری را انجام میدهد
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void autoBackUpTimer_Tick(object sender, EventArgs e)
        {

            var backupThread = new Thread(BackUpHandler);
            backupThread.Start();

        }



        private void createBackUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _backup.BackUp(Properties.Settings.Default.DataBasePath, Properties.Settings.Default.BackUpPath, false);

        }

        private void BackUpHandler()
        {
            _backup.BackUp(Properties.Settings.Default.DataBasePath, Properties.Settings.Default.BackUpPath, Properties.Settings.Default.AutoBackUp);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Activated(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.AutoBackUp)
            {
                autoBackUpTimer.Interval = Properties.Settings.Default.BackUpTime;
                autoBackUpTimer.Enabled = true;
                autoBackUpTimer.Start();
            }
            else
                autoBackUpTimer.Stop();
        }

        private void searchProductToolStripButton_Click(object sender, EventArgs e)
        {
            var serachProductForm = new SearchProductForm
            {
                MdiParent = this
            };

            serachProductForm.Show();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var serachProductForm = new SearchProductForm
            {
                MdiParent = this
            };

            serachProductForm.Show();
        }

        private void editUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var editUserInfoForm = new EditUserInfoForm
            {
                MdiParent = this
            };
            editUserInfoForm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _backup.BackUp(Properties.Settings.Default.DataBasePath, Properties.Settings.Default.BackUpPath, true);
            Application.Exit();
        }

        private void addRequestToCoToolStripButton1_Click(object sender, EventArgs e)
        {
            var addReqFromCoForm = new AddReqFromCoForm();
            addReqFromCoForm.ShowDialog();
        }
    }
}
