namespace Client
{
    partial class NewProductCategoryForm
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
            this.categoryNameLabel = new System.Windows.Forms.Label();
            this.categoryNameTextBox = new DevExpress.XtraEditors.TextEdit();
            this.addNewCategoryButton = new DevExpress.XtraEditors.SimpleButton();
            this.formIconPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.categoryNameTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formIconPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // categoryNameLabel
            // 
            this.categoryNameLabel.AutoSize = true;
            this.categoryNameLabel.Location = new System.Drawing.Point(400, 150);
            this.categoryNameLabel.Name = "categoryNameLabel";
            this.categoryNameLabel.Size = new System.Drawing.Size(50, 21);
            this.categoryNameLabel.TabIndex = 0;
            this.categoryNameLabel.Text = "نام گروه:";
            // 
            // categoryNameTextBox
            // 
            this.categoryNameTextBox.Location = new System.Drawing.Point(138, 147);
            this.categoryNameTextBox.Name = "categoryNameTextBox";
            this.categoryNameTextBox.Properties.Appearance.Font = new System.Drawing.Font("Droid Arabic Naskh", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryNameTextBox.Properties.Appearance.Options.UseFont = true;
            this.categoryNameTextBox.Size = new System.Drawing.Size(258, 28);
            this.categoryNameTextBox.TabIndex = 3;
            // 
            // addNewCategoryButton
            // 
            this.addNewCategoryButton.Appearance.Font = new System.Drawing.Font("Droid Arabic Naskh", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewCategoryButton.Appearance.Options.UseFont = true;
            this.addNewCategoryButton.Location = new System.Drawing.Point(13, 133);
            this.addNewCategoryButton.Name = "addNewCategoryButton";
            this.addNewCategoryButton.Size = new System.Drawing.Size(119, 52);
            this.addNewCategoryButton.TabIndex = 4;
            this.addNewCategoryButton.Text = "ایجاد گروه جدید";
            this.addNewCategoryButton.Click += new System.EventHandler(this.addNewCategoryButton_Click);
            // 
            // formIconPictureBox
            // 
            this.formIconPictureBox.Image = global::Client.Properties.Resources.Blank_Folder;
            this.formIconPictureBox.Location = new System.Drawing.Point(11, 3);
            this.formIconPictureBox.Name = "formIconPictureBox";
            this.formIconPictureBox.Size = new System.Drawing.Size(121, 116);
            this.formIconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.formIconPictureBox.TabIndex = 5;
            this.formIconPictureBox.TabStop = false;
            // 
            // NewProductCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 196);
            this.Controls.Add(this.formIconPictureBox);
            this.Controls.Add(this.addNewCategoryButton);
            this.Controls.Add(this.categoryNameTextBox);
            this.Controls.Add(this.categoryNameLabel);
            this.Font = new System.Drawing.Font("Droid Arabic Naskh", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewProductCategoryForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ایجاد گروه جدید";
            this.Load += new System.EventHandler(this.NewProductCategoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoryNameTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formIconPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label categoryNameLabel;
        private DevExpress.XtraEditors.TextEdit categoryNameTextBox;
        private DevExpress.XtraEditors.SimpleButton addNewCategoryButton;
        private System.Windows.Forms.PictureBox formIconPictureBox;
    }
}