﻿using System.Security.Cryptography;
using System.Text;
using Is4ServerWithoutUi.Services.Interfaces;

namespace Is4ServerWithoutUi.Services.Implementations
{
    public class EncryptionService : IBaseEncryptionService
    {
        /// <summary>
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string Md5Hash(string input)
        {
            // Initiate encryptor.
            var encryptor = MD5.Create();

            // Read input string as byte stream,
            var inputBytes = Encoding.ASCII.GetBytes(input);

            // Calculate the encrypted data.
            var encryptedData = encryptor.ComputeHash(inputBytes);

            // step 2, convert byte array to hex string
            var stringBuilder = new StringBuilder();

            foreach (var data in encryptedData)
                stringBuilder.Append(data.ToString("X2"));

            return stringBuilder.ToString();
        }
    }
}