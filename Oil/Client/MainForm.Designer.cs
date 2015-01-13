namespace Client
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.operationsMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showProductCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newRequestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sumarrayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.showNewReqFromCoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.editUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editRequestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editReqFromCoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteRequestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createBackUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showOptionFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operationToolStripContainer = new System.Windows.Forms.ToolStripContainer();
            this.toolOperations = new System.Windows.Forms.ToolStrip();
            this.showNewRequestFormtoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.addRequestToCoToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.editRequestToolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.deleteRequestToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.searchProductToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.autoBackUpTimer = new System.Windows.Forms.Timer(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip.SuspendLayout();
            this.operationsMenu.SuspendLayout();
            this.operationToolStripContainer.ContentPanel.SuspendLayout();
            this.operationToolStripContainer.SuspendLayout();
            this.toolOperations.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 527);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(902, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // operationsMenu
            // 
            this.operationsMenu.Font = new System.Drawing.Font("Droid Arabic Naskh", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operationsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.userToolStripMenuItem,
            this.editToolStripMenuItem,
            this.backUpToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.operationsMenu.Location = new System.Drawing.Point(0, 0);
            this.operationsMenu.Name = "operationsMenu";
            this.operationsMenu.Size = new System.Drawing.Size(902, 29);
            this.operationsMenu.TabIndex = 4;
            this.operationsMenu.Text = "Operations";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.createReportToolStripMenuItem,
            this.toolStripMenuItem1,
            this.showNewReqFromCoToolStripMenuItem,
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(41, 25);
            this.fileToolStripMenuItem.Text = "سند";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showProductCategoryToolStripMenuItem,
            this.newRequestToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.newToolStripMenuItem.Text = "جدید";
            // 
            // showProductCategoryToolStripMenuItem
            // 
            this.showProductCategoryToolStripMenuItem.Name = "showProductCategoryToolStripMenuItem";
            this.showProductCategoryToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.showProductCategoryToolStripMenuItem.Text = "گروه محصول";
            this.showProductCategoryToolStripMenuItem.Click += new System.EventHandler(this.showProductCategoryToolStripMenuItem_Click);
            // 
            // newRequestToolStripMenuItem
            // 
            this.newRequestToolStripMenuItem.Name = "newRequestToolStripMenuItem";
            this.newRequestToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.newRequestToolStripMenuItem.Text = "درخواست";
            // 
            // createReportToolStripMenuItem
            // 
            this.createReportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sumarrayToolStripMenuItem,
            this.detailsToolStripMenuItem});
            this.createReportToolStripMenuItem.Enabled = false;
            this.createReportToolStripMenuItem.Name = "createReportToolStripMenuItem";
            this.createReportToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.createReportToolStripMenuItem.Text = "صدور فاکتور";
            // 
            // sumarrayToolStripMenuItem
            // 
            this.sumarrayToolStripMenuItem.Name = "sumarrayToolStripMenuItem";
            this.sumarrayToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.sumarrayToolStripMenuItem.Text = "فاکتور کلی";
            // 
            // detailsToolStripMenuItem
            // 
            this.detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
            this.detailsToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.detailsToolStripMenuItem.Text = "ریز حساب";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(238, 6);
            // 
            // showNewReqFromCoToolStripMenuItem
            // 
            this.showNewReqFromCoToolStripMenuItem.Name = "showNewReqFromCoToolStripMenuItem";
            this.showNewReqFromCoToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.showNewReqFromCoToolStripMenuItem.Text = "ثبت بار تحویلی از شرکتهای تولیدی";
            this.showNewReqFromCoToolStripMenuItem.Click += new System.EventHandler(this.showNewReqFromCoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(238, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.exitToolStripMenuItem.Text = "خروج";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewUserToolStripMenuItem,
            this.toolStripMenuItem5,
            this.editUserToolStripMenuItem});
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(44, 25);
            this.userToolStripMenuItem.Text = "کاربر";
            // 
            // addNewUserToolStripMenuItem
            // 
            this.addNewUserToolStripMenuItem.Name = "addNewUserToolStripMenuItem";
            this.addNewUserToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.addNewUserToolStripMenuItem.Text = "ایجاد کاربر جدید";
            this.addNewUserToolStripMenuItem.Click += new System.EventHandler(this.addNewUserToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(187, 6);
            // 
            // editUserToolStripMenuItem
            // 
            this.editUserToolStripMenuItem.Name = "editUserToolStripMenuItem";
            this.editUserToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.editUserToolStripMenuItem.Text = "ویرایش مشخصات کاربر";
            this.editUserToolStripMenuItem.Click += new System.EventHandler(this.editUserToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editRequestToolStripMenuItem,
            this.editReqFromCoToolStripMenuItem,
            this.toolStripMenuItem3,
            this.searchToolStripMenuItem,
            this.toolStripMenuItem4,
            this.deleteRequestToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(57, 25);
            this.editToolStripMenuItem.Text = "ویرایش";
            // 
            // editRequestToolStripMenuItem
            // 
            this.editRequestToolStripMenuItem.Name = "editRequestToolStripMenuItem";
            this.editRequestToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.editRequestToolStripMenuItem.Text = "ویرایش درخواست";
            // 
            // editReqFromCoToolStripMenuItem
            // 
            this.editReqFromCoToolStripMenuItem.Name = "editReqFromCoToolStripMenuItem";
            this.editReqFromCoToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.editReqFromCoToolStripMenuItem.Text = "ویرایش بار تحویلی از شرکتهای تولیدی";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(254, 6);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.searchToolStripMenuItem.Text = "جستجوی اقلام موجود";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(254, 6);
            // 
            // deleteRequestToolStripMenuItem
            // 
            this.deleteRequestToolStripMenuItem.Name = "deleteRequestToolStripMenuItem";
            this.deleteRequestToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.deleteRequestToolStripMenuItem.Text = "حذف درخواست";
            // 
            // backUpToolStripMenuItem
            // 
            this.backUpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createBackUpToolStripMenuItem});
            this.backUpToolStripMenuItem.Name = "backUpToolStripMenuItem";
            this.backUpToolStripMenuItem.Size = new System.Drawing.Size(61, 25);
            this.backUpToolStripMenuItem.Text = "پشتیبان";
            // 
            // createBackUpToolStripMenuItem
            // 
            this.createBackUpToolStripMenuItem.Name = "createBackUpToolStripMenuItem";
            this.createBackUpToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.createBackUpToolStripMenuItem.Text = "تهیه نسخه پشتیبان از اطلاعات";
            this.createBackUpToolStripMenuItem.Click += new System.EventHandler(this.createBackUpToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showOptionFormToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(64, 25);
            this.optionsToolStripMenuItem.Text = "اختیارات";
            // 
            // showOptionFormToolStripMenuItem
            // 
            this.showOptionFormToolStripMenuItem.Name = "showOptionFormToolStripMenuItem";
            this.showOptionFormToolStripMenuItem.Size = new System.Drawing.Size(119, 26);
            this.showOptionFormToolStripMenuItem.Text = "تنظیمات";
            this.showOptionFormToolStripMenuItem.Click += new System.EventHandler(this.ShowOptionFormToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showHelpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(42, 25);
            this.helpToolStripMenuItem.Text = "کمک";
            // 
            // showHelpToolStripMenuItem
            // 
            this.showHelpToolStripMenuItem.Name = "showHelpToolStripMenuItem";
            this.showHelpToolStripMenuItem.Size = new System.Drawing.Size(132, 26);
            this.showHelpToolStripMenuItem.Text = "نمایش کمک";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(132, 26);
            this.aboutToolStripMenuItem.Text = "درباره ... ";
            // 
            // operationToolStripContainer
            // 
            // 
            // operationToolStripContainer.ContentPanel
            // 
            this.operationToolStripContainer.ContentPanel.Controls.Add(this.toolOperations);
            this.operationToolStripContainer.ContentPanel.Size = new System.Drawing.Size(902, 41);
            this.operationToolStripContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.operationToolStripContainer.Location = new System.Drawing.Point(0, 29);
            this.operationToolStripContainer.Name = "operationToolStripContainer";
            this.operationToolStripContainer.Size = new System.Drawing.Size(902, 66);
            this.operationToolStripContainer.TabIndex = 17;
            this.operationToolStripContainer.Text = "operationToolStripContainer";
            // 
            // toolOperations
            // 
            this.toolOperations.AutoSize = false;
            this.toolOperations.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolOperations.CanOverflow = false;
            this.toolOperations.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolOperations.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showNewRequestFormtoolStripButton,
            this.toolStripSeparator1,
            this.addRequestToCoToolStripButton1,
            this.editRequestToolStripButton2,
            this.deleteRequestToolStripButton,
            this.toolStripSeparator2,
            this.searchProductToolStripButton});
            this.toolOperations.Location = new System.Drawing.Point(0, 0);
            this.toolOperations.Name = "toolOperations";
            this.toolOperations.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolOperations.Size = new System.Drawing.Size(902, 28);
            this.toolOperations.TabIndex = 16;
            this.toolOperations.Text = "Operations";
            // 
            // showNewRequestFormtoolStripButton
            // 
            this.showNewRequestFormtoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.showNewRequestFormtoolStripButton.Image = global::Client.Properties.Resources.NewFile_6276;
            this.showNewRequestFormtoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.showNewRequestFormtoolStripButton.Name = "showNewRequestFormtoolStripButton";
            this.showNewRequestFormtoolStripButton.Size = new System.Drawing.Size(23, 25);
            this.showNewRequestFormtoolStripButton.Text = "درخواست جدید";
            this.showNewRequestFormtoolStripButton.Click += new System.EventHandler(this.showNewRequestFormtoolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // addRequestToCoToolStripButton1
            // 
            this.addRequestToCoToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addRequestToCoToolStripButton1.Image = global::Client.Properties.Resources.Save_6530;
            this.addRequestToCoToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addRequestToCoToolStripButton1.Name = "addRequestToCoToolStripButton1";
            this.addRequestToCoToolStripButton1.Size = new System.Drawing.Size(23, 25);
            this.addRequestToCoToolStripButton1.Text = "ثبت بار تحویلی از شرکتهای تولیدی";
            this.addRequestToCoToolStripButton1.Click += new System.EventHandler(this.addRequestToCoToolStripButton1_Click);
            // 
            // editRequestToolStripButton2
            // 
            this.editRequestToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.editRequestToolStripButton2.Image = global::Client.Properties.Resources.Open_6529;
            this.editRequestToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editRequestToolStripButton2.Name = "editRequestToolStripButton2";
            this.editRequestToolStripButton2.Size = new System.Drawing.Size(23, 25);
            this.editRequestToolStripButton2.Text = "ویرایش درخواست";
            // 
            // deleteRequestToolStripButton
            // 
            this.deleteRequestToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteRequestToolStripButton.Image = global::Client.Properties.Resources.Clearallrequests_8816;
            this.deleteRequestToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteRequestToolStripButton.Name = "deleteRequestToolStripButton";
            this.deleteRequestToolStripButton.Size = new System.Drawing.Size(23, 25);
            this.deleteRequestToolStripButton.Text = "toolStripButton1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // searchProductToolStripButton
            // 
            this.searchProductToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.searchProductToolStripButton.Image = global::Client.Properties.Resources.Find_5650;
            this.searchProductToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.searchProductToolStripButton.Name = "searchProductToolStripButton";
            this.searchProductToolStripButton.Size = new System.Drawing.Size(23, 25);
            this.searchProductToolStripButton.Text = "جستجوی محصول";
            this.searchProductToolStripButton.Click += new System.EventHandler(this.searchProductToolStripButton_Click);
            // 
            // autoBackUpTimer
            // 
            this.autoBackUpTimer.Enabled = true;
            this.autoBackUpTimer.Tick += new System.EventHandler(this.autoBackUpTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(902, 549);
            this.Controls.Add(this.operationToolStripContainer);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.operationsMenu);
            this.Font = new System.Drawing.Font("Droid Arabic Naskh", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مرکز پخش روغن موتور نواصر";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.operationsMenu.ResumeLayout(false);
            this.operationsMenu.PerformLayout();
            this.operationToolStripContainer.ContentPanel.ResumeLayout(false);
            this.operationToolStripContainer.ResumeLayout(false);
            this.operationToolStripContainer.PerformLayout();
            this.toolOperations.ResumeLayout(false);
            this.toolOperations.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.MenuStrip operationsMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sumarrayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem showNewReqFromCoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editRequestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editReqFromCoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createBackUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showOptionFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem deleteRequestToolStripMenuItem;
        private System.Windows.Forms.ToolStripContainer operationToolStripContainer;
        private System.Windows.Forms.ToolStripMenuItem showProductCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newRequestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem editUserToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolOperations;
        private System.Windows.Forms.ToolStripButton showNewRequestFormtoolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton addRequestToCoToolStripButton1;
        private System.Windows.Forms.ToolStripButton editRequestToolStripButton2;
        private System.Windows.Forms.ToolStripButton deleteRequestToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Timer autoBackUpTimer;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripButton searchProductToolStripButton;
    }
}



