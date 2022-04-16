using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Runtime.Serialization;

namespace FileManager_2._0
{
    [Serializable]
    class AuthorizationSetings
    {
        public AuthorizationSetings()
        {
        }
        public string login;
        public string password;
        [OnSerializing]
        internal void OnSerializing(StreamingContext context)
        {
            login = Crypter.Encrypt(login);
            password = Crypter.Encrypt(password);
        }
        [OnDeserialized]
        internal void OnDeserialized(StreamingContext context)
        {
            login = Crypter.Decrypt(login);
            password = Crypter.Decrypt(password);
        }
    }
}
