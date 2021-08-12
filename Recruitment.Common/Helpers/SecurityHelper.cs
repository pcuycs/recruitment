using System;
using System.Security.Cryptography;
using System.Text;

namespace Recruitment.Common
{
    public static class SecurityHelper
    {
        /// <summary>
        /// Creates the md5 hash.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns></returns>
        public static string CreateMD5Hash(this string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return string.Empty;
            }

            // Step 1, calculate MD5 hash from input
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hashBytes = md5.ComputeHash(inputBytes);

            // Step 2, convert byte array to hex string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                sb.Append(hashBytes[i].ToString("X2"));
            }

            return sb.ToString();
        }
    }
}
