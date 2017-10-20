using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Threading.Tasks;

/*
 Using this for reference:
 https://stackoverflow.com/questions/202011/encrypt-and-decrypt-a-string
     */

namespace PasswordEncryption {
    [AttributeUsageAttribute(AttributeTargets.Field, Inherited = false)]
    public sealed class Program : Attribute {
        [NonSerialized()] private static string userPassword = "mypassword";
        static void Main(string[] args) {
            EncryptPassword(userPassword);
        }
        private static void EncryptPassword (string pass) {
            if (String.IsNullOrEmpty(pass) || String.IsNullOrWhiteSpace(pass))
                throw new ArgumentNullException("plainText is null in EcryptPassword()");
            string outStr = null;
            RijndaelManaged aesAlg = null;
            try {

            } finally {

            }
        }
        private static void DecryptPassword (string pass) {

        }
    }
}
