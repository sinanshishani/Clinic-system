using System;
using System.Security.Cryptography;
using System.Text;
using EClinic.Framework.DependencyInjection;

namespace EClinic.Framework.Security.Cryptography
{
    public enum SupportedHash
    {
        SHA256, SHA384, SHA512
    }


    public class HashService : IDependency
    {
        public string ComputeHash(string plainText, SupportedHash hash)
        {
            int minSaltLength = 4, maxSaltLength = 16;

            Random r = new Random();
            int saltLength = r.Next(minSaltLength, maxSaltLength);
            byte[] saltBytes = new byte[saltLength];

            using (var rng = new RNGCryptoServiceProvider())
                rng.GetNonZeroBytes(saltBytes);


            byte[] plainData = Encoding.UTF8.GetBytes(plainText);
            byte[] plainDataWithSalt = new byte[plainData.Length + saltBytes.Length];

            for (int x = 0; x < plainData.Length; x++)
                plainDataWithSalt[x] = plainData[x];

            for (int n = 0; n < saltBytes.Length; n++)
                plainDataWithSalt[plainData.Length + n] = saltBytes[n];

            byte[] hashValue = null;

            switch (hash)
            {
                case SupportedHash.SHA256:
                    SHA256Managed sha = new SHA256Managed();
                    hashValue = sha.ComputeHash(plainDataWithSalt);
                    sha.Dispose();
                    break;
                case SupportedHash.SHA384:
                    SHA384Managed sha1 = new SHA384Managed();
                    hashValue = sha1.ComputeHash(plainDataWithSalt);
                    sha1.Dispose();
                    break;
                case SupportedHash.SHA512:
                    SHA512Managed sha2 = new SHA512Managed();
                    hashValue = sha2.ComputeHash(plainDataWithSalt);
                    sha2.Dispose();
                    break;
            }

            byte[] result = new byte[hashValue.Length + saltBytes.Length];

            for (int x = 0; x < hashValue.Length; x++)
                result[x] = hashValue[x];

            for (int n = 0; n < saltBytes.Length; n++)
                result[hashValue.Length + n] = saltBytes[n];

            return Convert.ToBase64String(result);
        }


        public string ComputeHash(string plainText, SupportedHash hash, byte[] salt)
        {
            byte[] plainData = Encoding.UTF8.GetBytes(plainText);
            byte[] plainDataWithSalt = new byte[plainData.Length + salt.Length];

            for (int x = 0; x < plainData.Length; x++)
                plainDataWithSalt[x] = plainData[x];
            for (int n = 0; n < salt.Length; n++)
                plainDataWithSalt[plainData.Length + n] = salt[n];

            byte[] hashValue = null;

            switch (hash)
            {
                case SupportedHash.SHA256:
                    SHA256Managed sha = new SHA256Managed();
                    hashValue = sha.ComputeHash(plainDataWithSalt);
                    sha.Dispose();
                    break;
                case SupportedHash.SHA384:
                    SHA384Managed sha1 = new SHA384Managed();
                    hashValue = sha1.ComputeHash(plainDataWithSalt);
                    sha1.Dispose();
                    break;
                case SupportedHash.SHA512:
                    SHA512Managed sha2 = new SHA512Managed();
                    hashValue = sha2.ComputeHash(plainDataWithSalt);
                    sha2.Dispose();
                    break;
            }

            byte[] result = new byte[hashValue.Length + salt.Length];

            for (int x = 0; x < hashValue.Length; x++)
                result[x] = hashValue[x];

            for (int n = 0; n < salt.Length; n++)
                result[hashValue.Length + n] = salt[n];

            return Convert.ToBase64String(result);
        }


        public bool Confirm(string plainText, string hashValue, SupportedHash hash)
        {
            byte[] hashBytes = Convert.FromBase64String(hashValue);
            int hashSize = 0;

            switch (hash)
            {
                case SupportedHash.SHA256:
                    hashSize = 32;
                    break;
                case SupportedHash.SHA384:
                    hashSize = 48;
                    break;
                case SupportedHash.SHA512:
                    hashSize = 64;
                    break;
            }

            byte[] saltBytes = new byte[hashBytes.Length - hashSize];

            for (int x = 0; x < saltBytes.Length; x++)
                saltBytes[x] = hashBytes[hashSize + x];

            string newHash = ComputeHash(plainText, hash, saltBytes);

            return (hashValue == newHash);
        }
    }
}