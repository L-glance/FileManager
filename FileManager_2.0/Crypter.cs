using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FileManager_2._0
{
    internal class Crypter
    {
        private static string _key = "<RSAKeyValue><Modulus>2Ili2sg7FKVY7NaaxM2SpTGJ/qri3OXrFPww6U4wkEFWhtZtnKwmffACoF8rzUoOgGx5YcSktNuhmVMRiqsovVd38B0EAtrOQ1mrcQMIERyjwif0u1lG3Ltb20RYKHVX0NL/IwX8Zaer3LOzvnz3kHaW5G8vFbzfBIOpDMPbpSE=</Modulus><Exponent>AQAB</Exponent><P>6Ah57ppLRt5Hb/S3fOHnAoD0SS3/twUQNAKBX6rYl+Ykzb4BWRuKVEa1acLWh7dC9s4+QXI5G5j+1QjeMSJH/w==</P><Q>7uclV/B+4QgIYNoUJE69817dg49dYohS9JfCkK6cLA1roUeY2/6SdWMVngtUajgUqABNfRYTpGn1Zs+LOhES3w==</Q><DP>TuOi4TbgZSXpz+y5/eGoczd41vCmwokcKzK23dnubia3WKRDPRKaA3FO+LhfzCDIybTxgbreI73u1mt/b+Eh7Q==</DP><DQ>CsaKPKkwT94Y4qVzex/CGZQR0blJsQQNGdMuh3AYwzPnwuKD1oho+rp5YyOHrzLQW7OHyziPsj7FPtnlobzbaQ==</DQ><InverseQ>k4N3zBFzSEjwU3DctKGyYAwfSrQk5sAG4aMA5Nvxhkwu2bSN6fmZ80IkYxmHVTqYs55CFhQ/4hxvhwmIh9nKXg==</InverseQ><D>1Yo3GLbZvLSLC5Vfr7FjatF92s2/SETdHibOPWZEch5dLEAOfLEwjIXCsVDpq1vbDT7sPURlgY4OwVuwMuY0FyTcSYwYo5ebMwnHPrlMbnWUSVZLNgD18jSOAaRty9uml/F/xjLo1R9LPw4cKvKzOwthokUjVZY3lz6bPFtUK1k=</D></RSAKeyValue>";
        public static string Encrypt(string text)
        {
            var rsa = new RSACryptoServiceProvider();
            rsa.FromXmlString(_key);
            byte[] EncryptContent = rsa.Encrypt(Encoding.UTF8.GetBytes(text), true);

            return Convert.ToBase64String(EncryptContent);
        }
        public static string Decrypt(string text)
        {
            var rsa = new RSACryptoServiceProvider();
            rsa.FromXmlString(_key);
            byte[] DecryptContent = rsa.Decrypt(Convert.FromBase64String(text),true);

            return Encoding.UTF8.GetString(DecryptContent);
        }
    }
}
