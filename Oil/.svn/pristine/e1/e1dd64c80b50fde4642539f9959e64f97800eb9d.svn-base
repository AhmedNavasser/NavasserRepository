using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DomainClasses
{
    public class User:IDisposable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

        private bool _disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    Dispose();
                }
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
