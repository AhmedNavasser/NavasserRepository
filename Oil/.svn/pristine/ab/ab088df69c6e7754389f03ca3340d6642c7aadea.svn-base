using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;

namespace Client
{
    /// <summary>
    /// برای کنترل تم از این کلاس استفاده میشود
    /// </summary>
    public class ThemeController 
    {
        /// <summary>
        /// از این تابع برای اعمال تم بر روی فرم ها استفاده میشود
        /// </summary>
        /// <param name="ownerControl">فرم حاوی کنترل ها</param>
        /// <param name="themeIndex">ایندکس تم. 0 برای ویژوال استودیو آبی و 1 برای لایت</param>
        /// <param name="controlCollection">لیست کنترلهای موجود در فرم</param>
        public static void ThemeControl(Control ownerControl,int themeIndex, Control.ControlCollection controlCollection)
        {
            switch (themeIndex)
            {
                    // آبی
                case 0:
                    foreach (Control control in controlCollection)
                    {
                        if (ownerControl is Form)
                            ownerControl.BackColor = ColorTranslator.FromHtml("#B4C1D9");

                        if (control.HasChildren)
                        {
                            ThemeControl(ownerControl,themeIndex,control.Controls);
                        }

                        if (control is TreeView)
                        {
                            var treeView = control as TreeView;
                            treeView.BackColor = ColorTranslator.FromHtml("#B4C1D9");
                        }

                        if (control is SimpleButton)
                        {
                            var button = control as SimpleButton;
                            button.LookAndFeel.SkinName = "Visual Studio 2013 Blue";
                            button.LookAndFeel.UseDefaultLookAndFeel = false;
                        }

                        if (control is TextEdit)
                        {
                            var textEdit = control as TextEdit;
                            textEdit.LookAndFeel.SkinName = "Visual Studio 2013 Blue";
                            textEdit.LookAndFeel.UseDefaultLookAndFeel = false;
                        }

                        if (control is GridControl)
                        {
                            var grideControl = control as GridControl;
                            grideControl.LookAndFeel.SkinName = "Visual Studio 2013 Blue";
                            grideControl.LookAndFeel.UseDefaultLookAndFeel = false;

                        }
                    }
                    
                    break;
                    // لایت
                case 1:
                    foreach (Control control in controlCollection)
                    {
                        if (ownerControl is Form)
                            ownerControl.BackColor = ColorTranslator.FromHtml("#F0F0F0");
                        
                        if (control.HasChildren)
                        {
                            ThemeControl(ownerControl,themeIndex, control.Controls);
                            break;
                        }

                        if (control is SimpleButton)
                        {
                            var button = control as SimpleButton;
                            button.LookAndFeel.SkinName = "Visual Studio 2013 Light";
                            button.LookAndFeel.UseDefaultLookAndFeel = false;
                        }

                        if (control is TextEdit)
                        {
                            var textEdit = control as TextEdit;
                            textEdit.LookAndFeel.SkinName = "Visual Studio 2013 Light";
                            textEdit.LookAndFeel.UseDefaultLookAndFeel = false;
                        }

                        if (control is GridControl)
                        {
                            var grideControl = control as GridControl;
                            grideControl.LookAndFeel.SkinName = "Visual Studio 2013 Light";
                            grideControl.LookAndFeel.UseDefaultLookAndFeel = false;

                        }
                    }
                    break;

            }
        }
    }
}
