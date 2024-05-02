using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar.Auth.Interface.IService
{
    public interface IPasswordEncryptionService
    {
        string EncryptPassword(string text);
        string DecryptPassword(string cipherText);
    }
}
