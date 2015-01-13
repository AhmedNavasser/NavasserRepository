using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations.Interfaces
{
    public interface IBackup
    {
        void BackUp(string source, string destination, bool autoBackup);
    }
}
