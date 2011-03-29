// 
//  Copyright (c) 2011 Geoffrey Prytherch
//  
//  Permission is hereby granted, free of charge, to any person obtaining a copy of  this
//  software and associated documentation files (the "Software"), to deal in the Software
//  without restriction, including without limitation the rights to use, copy, modify, merge,
//  publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons
//  to whom the Software is furnished to do so, subject to the following conditions:
//  
//  The above copyright notice and this permission notice shall be included in all copies or
//  substantial portions of the Software.
//  
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
//  INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR
//  PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE
//  FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR
//  OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
//  DEALINGS IN THE SOFTWARE.
//  
using System.Security.Cryptography;
using System.Text;

namespace OpticianDB
{
    /// <summary>
    ///   Contains methods that assist with generating a cryptographic hash of an input
    /// </summary>
    public static class Hashing
    {
        /// <summary>
        ///   Fetches the MD5 sum of the inputted string
        /// </summary>
        /// <param name = "value">The string to be hashed</param>
        /// <returns>The hashed string</returns>
        public static string Md5Hash(string value)
        {
            byte[] data;
            using (MD5 md5Hasher = MD5.Create())
            {
                data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(value));
            }

            StringBuilder sBuilder = new StringBuilder();


            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }

        /// <summary>
        ///   Fetches the SHA1 sum of the inputted string
        /// </summary>
        /// <param name = "value">The string to be hashed.</param>
        /// <returns>The hashed string.</returns>
        public static string Sha1Hash(string value)
        {
            byte[] data;
            using (SHA1 sha1Hasher = SHA1.Create())
            {
                data = sha1Hasher.ComputeHash(Encoding.Default.GetBytes(value));
            }

            StringBuilder sBuilder = new StringBuilder();


            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }

        /// <summary>
        ///   Fetches the hash of a given string from the selected method
        /// </summary>
        /// <param name = "input">The string to be hashed.</param>
        /// <param name = "method">The method that the string is hashed by.</param>
        /// <returns>The hashed string</returns>
        public static string GetHash(string input, HashMethods method)
        {
            switch (method)
            {
                case HashMethods.Md5:
                    return Md5Hash(input);
                case HashMethods.Sha1:
                    return Sha1Hash(input);
                default:
                    return input;
            }
        }
    }
}