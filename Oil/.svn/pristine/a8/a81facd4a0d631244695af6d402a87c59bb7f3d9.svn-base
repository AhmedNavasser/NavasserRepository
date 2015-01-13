using System;
using System.Windows.Forms;
using System.IO;

namespace Operations
{
    /// <summary>
    /// 
    /// </summary>
    public static class Operation
    {
        /// <summary>
        /// از پایگاه داده یک نسخه پشتیبان تهیه میکند
        /// </summary>
        /// <param name="source">مبدا فایل پایگاه داده را تعیین می کند</param>
        /// <param name="destination">مقصد فایل پایگاه داده را تعیین می کند</param>
        /// <param name="autoBackup">تعیین می کند که عمل تهیه نسخه پشتیبان به صورت اتوماتیک انجام شود یا دستی</param>
        public static void BackUp ( string source,string destination,bool autoBackup )
        {
            if(string.IsNullOrEmpty(destination))
            {
                MessageBox.Show("مسیری برای پشتیبانگیری انتخاب نشده است","عدم انتخاب مسیر",MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    if(File.Exists(source))
                    {
                        File.Copy(source,destination,true);
                    }
                    if(autoBackup == false)
                        MessageBox.Show("پشتیبانگیری با موفقیت انجام شد","پشتیبان گیری");

                }
                catch(Exception exception)
                {

                    MessageBox.Show(exception.Message,"خطای پشتیبانگیری",MessageBoxButtons.OK,MessageBoxIcon.Error);

                }
            }
        }

    }
}
