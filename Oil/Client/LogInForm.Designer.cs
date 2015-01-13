namespace Client
{
    partial class LoginForm
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
            this.loginGroupbox = new System.Windows.Forms.GroupBox();
            this.passwordTextBox = new DevExpress.XtraEditors.TextEdit();
            this.userNameTextBox = new DevExpress.XtraEditors.TextEdit();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.seperatorLabel = new System.Windows.Forms.Label();
            this.loginButton = new DevExpress.XtraEditors.SimpleButton();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.exitButton = new DevExpress.XtraEditors.SimpleButton();
            this.formIconPictureBox = new System.Windows.Forms.PictureBox();
            this.virtualKeyBoardButton = new DevExpress.XtraEditors.SimpleButton();
            this.loginGroupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userNameTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formIconPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // loginGroupbox
            // 
            this.loginGroupbox.Controls.Add(this.passwordTextBox);
            this.loginGroupbox.Controls.Add(this.userNameTextBox);
            this.loginGroupbox.Controls.Add(this.passwordLabel);
            this.loginGroupbox.Controls.Add(this.userNameLabel);
            this.loginGroupbox.Location = new System.Drawing.Point(12, 126);
            this.loginGroupbox.Name = "loginGroupbox";
            this.loginGroupbox.Size = new System.Drawing.Size(398, 129);
            this.loginGroupbox.TabIndex = 0;
            this.loginGroupbox.TabStop = false;
            this.loginGroupbox.Text = "ورود";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(12, 76);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Properties.Appearance.Font = new System.Drawing.Font("Droid Arabic Naskh", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Properties.Appearance.Options.UseFont = true;
            this.passwordTextBox.Properties.UseSystemPasswordChar = true;
            this.passwordTextBox.Size = new System.Drawing.Size(309, 32);
            this.passwordTextBox.TabIndex = 3;
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(12, 32);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Properties.Appearance.Font = new System.Drawing.Font("Droid Arabic Naskh", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTextBox.Properties.Appearance.Options.UseFont = true;
            this.userNameTextBox.Size = new System.Drawing.Size(309, 32);
            this.userNameTextBox.TabIndex = 1;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(334, 81);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(58, 22);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "رمز ورود:";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(327, 32);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(65, 22);
            this.userNameLabel.TabIndex = 0;
            this.userNameLabel.Text = "نام کاربری:";
            // 
            // seperatorLabel
            // 
            this.seperatorLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.seperatorLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.seperatorLabel.Location = new System.Drawing.Point(11, 260);
            this.seperatorLabel.Name = "seperatorLabel";
            this.seperatorLabel.Size = new System.Drawing.Size(35, 13);
            this.seperatorLabel.TabIndex = 4;
            // 
            // loginButton
            // 
            this.loginButton.Appearance.Font = new System.Drawing.Font("Droid Arabic Naskh", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Appearance.Options.UseFont = true;
            this.loginButton.Location = new System.Drawing.Point(119, 326);
            this.loginButton.LookAndFeel.UseDefaultLookAndFeel = false;
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(101, 37);
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "ورود";
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // gridView1
            // 
            this.gridView1.Name = "gridView1";
            // 
            // exitButton
            // 
            this.exitButton.Appearance.Font = new System.Drawing.Font("Droid Arabic Naskh", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Appearance.Options.UseFont = true;
            this.exitButton.Location = new System.Drawing.Point(12, 325);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(101, 37);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "خروج";
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click_1);
            // 
            // formIconPictureBox
            // 
            this.formIconPictureBox.Image = global::Client.Properties.Resources.User_Accounts;
            this.formIconPictureBox.Location = new System.Drawing.Point(24, 4);
            this.formIconPictureBox.Name = "formIconPictureBox";
            this.formIconPictureBox.Size = new System.Drawing.Size(121, 116);
            this.formIconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.formIconPictureBox.TabIndex = 1;
            this.formIconPictureBox.TabStop = false;
            // 
            // virtualKeyBoardButton
            // 
            this.virtualKeyBoardButton.Appearance.Font = new System.Drawing.Font("Droid Arabic Naskh", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.virtualKeyBoardButton.Appearance.Options.UseFont = true;
            this.virtualKeyBoardButton.Location = new System.Drawing.Point(12, 276);
            this.virtualKeyBoardButton.Name = "virtualKeyBoardButton";
            this.virtualKeyBoardButton.Size = new System.Drawing.Size(398, 37);
            this.virtualKeyBoardButton.TabIndex = 7;
            this.virtualKeyBoardButton.Text = "صفحه کلید مجازی (برای امنیت بیشتر)";
            this.virtualKeyBoardButton.Click += new System.EventHandler(this.virtualKeyBoardButton_Click);
            // 
            // LoginForm
            // 
            this.AcceptButton = this.loginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 373);
            this.ControlBox = false;
            this.Controls.Add(this.virtualKeyBoardButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.seperatorLabel);
            this.Controls.Add(this.formIconPictureBox);
            this.Controls.Add(this.loginGroupbox);
            this.Font = new System.Drawing.Font("Droid Arabic Naskh", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LoginForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ورود";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.loginGroupbox.ResumeLayout(false);
            this.loginGroupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userNameTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formIconPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox loginGroupbox;
        private System.Windows.Forms.PictureBox formIconPictureBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label seperatorLabel;
        private DevExpress.XtraEditors.SimpleButton loginButton;
        private DevExpress.XtraEditors.TextEdit passwordTextBox;
        private DevExpress.XtraEditors.TextEdit userNameTextBox;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton exitButton;
        private DevExpress.XtraEditors.SimpleButton virtualKeyBoardButton;

    }
}

