using System.Windows.Forms;
using DevExpress.XtraEditors;


namespace Client
{
    partial class OptionsForm
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
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("رابط کاربری");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("محیط", new System.Windows.Forms.TreeNode[] {
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("پشتیبان گیری");
            this.PanelOfTreeItems = new System.Windows.Forms.Panel();
            this.OptionsTreeView = new System.Windows.Forms.TreeView();
            this.PanelOfControls = new System.Windows.Forms.Panel();
            this.BackUpPathFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.formIconPictureBox = new System.Windows.Forms.PictureBox();
            this.PanelOfTreeItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formIconPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelOfTreeItems
            // 
            this.PanelOfTreeItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelOfTreeItems.Controls.Add(this.OptionsTreeView);
            this.PanelOfTreeItems.Location = new System.Drawing.Point(384, 143);
            this.PanelOfTreeItems.Name = "PanelOfTreeItems";
            this.PanelOfTreeItems.Size = new System.Drawing.Size(194, 366);
            this.PanelOfTreeItems.TabIndex = 0;
            // 
            // OptionsTreeView
            // 
            this.OptionsTreeView.BackColor = System.Drawing.SystemColors.Control;
            this.OptionsTreeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OptionsTreeView.Location = new System.Drawing.Point(41, 12);
            this.OptionsTreeView.Name = "OptionsTreeView";
            treeNode4.Name = "UserInterface";
            treeNode4.Text = "رابط کاربری";
            treeNode5.Name = "Environment";
            treeNode5.Text = "محیط";
            treeNode6.Name = "BackUp";
            treeNode6.Text = "پشتیبان گیری";
            this.OptionsTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6});
            this.OptionsTreeView.RightToLeftLayout = true;
            this.OptionsTreeView.Size = new System.Drawing.Size(139, 156);
            this.OptionsTreeView.TabIndex = 2;
            this.OptionsTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.OptionsTreeView_AfterSelect);
            // 
            // PanelOfControls
            // 
            this.PanelOfControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelOfControls.Location = new System.Drawing.Point(3, 143);
            this.PanelOfControls.Name = "PanelOfControls";
            this.PanelOfControls.Size = new System.Drawing.Size(380, 366);
            this.PanelOfControls.TabIndex = 1;
            // 
            // formIconPictureBox
            // 
            this.formIconPictureBox.Image = global::Client.Properties.Resources.Configure;
            this.formIconPictureBox.Location = new System.Drawing.Point(12, 12);
            this.formIconPictureBox.Name = "formIconPictureBox";
            this.formIconPictureBox.Size = new System.Drawing.Size(121, 116);
            this.formIconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.formIconPictureBox.TabIndex = 3;
            this.formIconPictureBox.TabStop = false;
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 535);
            this.Controls.Add(this.formIconPictureBox);
            this.Controls.Add(this.PanelOfControls);
            this.Controls.Add(this.PanelOfTreeItems);
            this.Font = new System.Drawing.Font("Droid Arabic Naskh", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تنظیمات";
            this.Load += new System.EventHandler(this.OptionsForm_Load);
            this.PanelOfTreeItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.formIconPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelOfTreeItems;
        private System.Windows.Forms.TreeView OptionsTreeView;
        private System.Windows.Forms.Panel PanelOfControls;
        private System.Windows.Forms.FolderBrowserDialog BackUpPathFolderDialog;
        //User Defined UserInterface
        private RadioButton Vs2013BlueRadioButton;
        private RadioButton Vs2013LightRadioButton;
        private PictureBox Vs2013BluePictureBox;
        private PictureBox Vs2013LightPictureBox;
        private GroupBox UserInterfaceGroupBox;
        private Label UserInterfaceSeperatorLabel;
        private SimpleButton UserInterfaceOkButton;
        private SimpleButton UserInterfaceCancelButton;

        //User Defined BackUp
        private CheckBox EnableAutoBackUpCheckBox;
        private Label SetTimerlLabel;
        private NumericUpDown SetMinutesNumericUpDown;
        private Label PathLabel;
        private SimpleButton SearchpathbButton;
        private GroupBox BackUpGroupBox;
        private TextBox PathTextBox;
        private Label BackUpSeperatorLabel;
        private SimpleButton BackUpOkButton;
        private SimpleButton BackUpCancelButton;
        private PictureBox formIconPictureBox;

    }
}