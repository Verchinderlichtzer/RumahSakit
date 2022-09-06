using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace RumahSakit
{
    public sealed class Encryptor
    {
        readonly TripleDESCryptoServiceProvider TripleDes = new TripleDESCryptoServiceProvider();

        byte[] TruncateHash(string key, int length)
        {
            var sha1 = new SHA1CryptoServiceProvider();
            var keyBytes = Encoding.Unicode.GetBytes(key);
            var hash = sha1.ComputeHash(keyBytes);
            Array.Resize(ref hash, length);
            return hash;
        }

        public Encryptor(string key)
        {
            TripleDes.Key = TruncateHash(key, TripleDes.KeySize / 8);
            TripleDes.IV = TruncateHash("", TripleDes.BlockSize / 8);
        }

        public string EncryptData(string plainText)
        {
            var plaintextBytes = Encoding.Unicode.GetBytes(plainText);
            var ms = new MemoryStream();
            var encStream = new CryptoStream(ms, TripleDes.CreateEncryptor(), CryptoStreamMode.Write);
            encStream.Write(plaintextBytes, 0, plaintextBytes.Length);
            encStream.FlushFinalBlock();
            return Convert.ToBase64String(ms.ToArray());
        }

        public string DecryptData(string cipherText)
        {
            var encryptedBytes = Convert.FromBase64String(cipherText);
            var ms = new MemoryStream();
            var decStream = new CryptoStream(ms, TripleDes.CreateDecryptor(), CryptoStreamMode.Write);
            decStream.Write(encryptedBytes, 0, encryptedBytes.Length);
            decStream.FlushFinalBlock();
            return Encoding.Unicode.GetString(ms.ToArray());
        }
    }
}
