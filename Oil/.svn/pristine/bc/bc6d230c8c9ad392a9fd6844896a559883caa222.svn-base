using System;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using DomainClasses;
using OilContext;
using Operations.Interfaces;

namespace Operations
{
    public  class UserOperation:IUserOperation

    {

        private  byte[] _encryptedUserName;
        private  byte[] _encryptedPassword;


        private readonly IDbSet<User> _users;

        public UserOperation(IUnitOfWork unitOfWork)
        {
            _users = unitOfWork.Set<User>();
        }


        /// <summary>
        /// اطلاعات یک کاربر را بازیابی می کند
        /// </summary>
        /// <param name="name">یک مقدار رشته ای برای نام کاربر دریافت می کند</param>
        /// <returns>یک شی از کلاس یوزر را بر میگرداند</returns>
        public User GetUser ( string name )
        {
            var user = _users.SingleOrDefault(u => u.UserName == name);
            return user;

        }

        /// <summary>
        /// یک رشته حاوی نام کاربری را دریافت و سپس آن را حذف میکند
        /// </summary>
        /// <param name="userName">یک رشته که بیانگر نام کاربر می باشد</param>
        /// <returns>یک مقدار صحیح بین صفر و یک که نشانگر موفقیت یا عدم موفقیت عمل حذف می باشد</returns>
        public  void DeleteUser(string userName)
        {
            _users.Load();
            var encryptedUserName = BitConverter.ToString(EncryptUserInfo(userName));

            var query = _users.SingleOrDefault(p => p.UserName == encryptedUserName);

            _users.Remove(query);

            
        }

        /// <summary>
        /// یک رشته را دریافت و آن را رمزنگاری می کند
        /// در واقع تک تک فیلدهای یک یوزر را رمزنگاری میکند
        /// </summary>
        /// <param name="data">یک رشته که حاوی نام کاربر می باشد</param>
        /// <returns>یک رشته رمزنگاری شده را بر میگرداند که میتواند نام کاربر یا رمز عبور آن باشد</returns>
        public  byte[] EncryptUserInfo ( string data )
        {
            var md5CryptoService = new MD5CryptoServiceProvider();

            var utf8Encoding = new UTF8Encoding();


            var tripleDesCrypto = new TripleDESCryptoServiceProvider
            {
                Key = md5CryptoService.ComputeHash(utf8Encoding.GetBytes("Pattern For Ciphering PKCS7")),
                Mode = CipherMode.ECB,
                Padding = PaddingMode.PKCS7
            };

            ICryptoTransform transform = tripleDesCrypto.CreateEncryptor();
            var encryptedData = transform.TransformFinalBlock(utf8Encoding.GetBytes(data),0,utf8Encoding.GetBytes(data).Length);


            return encryptedData;
        }

        /// <summary>
        /// یک شی از کلاس کاربر را رمزنگاری می کند
        /// </summary>
        /// <param name="userInfo">یک شی از کلاس کاربر را به عنوان ورودی میگیرد</param>
        /// <returns>یک شی رمزنگاری شده از کلاس کاربر را بر میگرداند</returns>
        public  User EncryptUser ( User userInfo )
        {
            var encryptedUser = new User();

            var md5CryptoService = new MD5CryptoServiceProvider();

            var utf8Encoding = new UTF8Encoding();

            var tripleDesCrypto = new TripleDESCryptoServiceProvider
            {
                Key = md5CryptoService.ComputeHash(utf8Encoding.GetBytes("Pattern For Ciphering PKCS7")),
                Mode = CipherMode.ECB,
                Padding = PaddingMode.PKCS7
            };

            ICryptoTransform transform = tripleDesCrypto.CreateEncryptor();
            encryptedUser.UserName = BitConverter.ToString(transform.TransformFinalBlock(utf8Encoding.GetBytes(userInfo.UserName),0,utf8Encoding.GetBytes(userInfo.UserName).Length));
            encryptedUser.Password = BitConverter.ToString(transform.TransformFinalBlock(utf8Encoding.GetBytes(userInfo.Password),0,utf8Encoding.GetBytes(userInfo.Password).Length));

            return encryptedUser;
        }

        /// <summary>
        /// یک شی از کلاس کاربر را رمزگشایی می کند
        /// </summary>
        /// <param name="encryptedUser">یک شی رمزنگاری شده از کلاس کاربر را دریافت میکند</param>
        /// <returns>یک شی رمزگشایی شده را بر میگرداند</returns>
        public  User DecryptUser ( User encryptedUser )
        {
            if (encryptedUser != null)
            {
                User decryptedUser = new User();


                MD5CryptoServiceProvider md5CryptoService = new MD5CryptoServiceProvider();

                UTF8Encoding utf8Encoding = new UTF8Encoding();

                var tripleDesCrypto = new TripleDESCryptoServiceProvider
                {
                    Key = md5CryptoService.ComputeHash(utf8Encoding.GetBytes("Pattern For Ciphering PKCS7")),
                    Mode = CipherMode.ECB,
                    Padding = PaddingMode.PKCS7
                };

                ICryptoTransform transform = tripleDesCrypto.CreateDecryptor();
                _encryptedUserName = EncryptUserInfo(encryptedUser.UserName);
                _encryptedPassword = EncryptUserInfo(encryptedUser.Password);
                decryptedUser.UserName = utf8Encoding.GetString(transform.TransformFinalBlock(_encryptedUserName, 0, _encryptedUserName.Length));
                decryptedUser.Password = utf8Encoding.GetString(transform.TransformFinalBlock(_encryptedPassword, 0, _encryptedPassword.Length));

                return decryptedUser;
            }

            return null;
        }

        /// <summary>
        /// اضافه نمودن کاربر جدید
        /// </summary>
        /// <param name="user">یک شی از کلاس یوزر دریافت نموده و اقدام به اضافه نمودن آن به جدول میکند</param>
        /// <returns>مقدار برگشتی این تابع یک عدد صحیح که صفر یا یک می باشد. یک به معنای موفقیت آمیز بودن عمل و صفر ناموفق بودن</returns>
        
        public void AddNewUser(User user)
        {
            _users.Add(user);
        }
    }
}