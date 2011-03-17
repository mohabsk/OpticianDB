/*
 * Copyright (c) 2011 Geoffrey Prytherch
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy of this
 * software and associated documentation files (the "Software"), to deal in the Software
 * without restriction, including without limitation the rights to use, copy, modify, merge,
 * publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons
 * to whom the Software is furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all copies or
 * substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
 * INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR
 * PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE
 * FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR
 * OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
 * DEALINGS IN THE SOFTWARE.
 */

using System;
using System.Security.Cryptography;
using System.Text;

namespace OpticianDB
{

    public static class Hashing
    {
        internal static string getMd5Hash(string input)
        {
            byte[] data;
            using (MD5 md5Hasher = MD5.Create())
            {
                data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input));
            }

            StringBuilder sBuilder = new StringBuilder();


            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }

        internal static string SHA1Hash(string input)
        {
            byte[] data;
            using (SHA1 sha1Hasher = SHA1.Create())
            {
                data = sha1Hasher.ComputeHash(Encoding.Default.GetBytes(input));
            }

            StringBuilder sBuilder = new StringBuilder();


            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }

        internal static string GetHash(string input, string method)
        {
            switch (method)
            {
                case "md5":
                    return getMd5Hash(input);
                case "sha1":
                    return SHA1Hash(input);
                default:
                    return input;
            }
        }
    }
}
