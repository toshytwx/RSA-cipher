using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RSAEncryptor
{
    class RSAEncryptor
    {
        public RSAParameters publicKey;
        public RSAParameters privateKey;
        
        public byte[] Encrypt(String dataToEncrypt)
        {
            byte[] encryptedBytes = null;
            byte[] dataInBytes = Encoding.UTF8.GetBytes(dataToEncrypt);
            using (var rsa = new RSACryptoServiceProvider(1024))
            {
                rsa.ImportParameters(publicKey);
                encryptedBytes = rsa.Encrypt(dataInBytes, true);
            }
            return encryptedBytes;
        }

        public byte[] Decrypt(byte[] encryptedDataInBytes)
        {
            byte[] plainData = null;
            using (var rsa = new RSACryptoServiceProvider(1024))
            {
                rsa.ImportParameters(privateKey);
                plainData = rsa.Decrypt(encryptedDataInBytes, true);
            }
            return plainData;
        }
    }
}
