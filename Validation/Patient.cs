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
using System.Text.RegularExpressions;

namespace OpticianDB.Validation
{
    public static class Patient
    {
        /// <summary>
        /// Validates the given name using regex
        /// </summary>
        /// <param name="value">The name to be validated.</param>
        /// <returns><c>true</c> if the name can be validated; Otherwise, <c>false</c></returns>
        public static bool Name(string value)
        {
            string nameCriteria = "^(([A-Z][A-Za-z]*)|[- '])*$"; //TODO: accents?
            Regex name = new Regex(nameCriteria);
            return name.IsMatch(value);
        }

        /// <summary>
        /// Validates the UK/International telephone number using regex
        /// </summary>
        /// <param name="value">The UK/International telephone number to be validated.</param>
        /// <returns><c>true</c> if the telephone number can be validated; Otherwise, <c>false</c></returns>
        public static bool TelNum(string value) //FIXME //TODO: also -
        {
            value = value.Replace(" ", "");
            string telNumCriteria = "^(0[123578][0-9]{8,9})|(\\x2B[0-9]+)$";
            Regex telNum = new Regex(telNumCriteria, RegexOptions.IgnoreCase);
            return telNum.IsMatch(value);
        }

        /// <summary>
        /// Validates the NHS number using a regex algorithm and a checkdigit verification algorithm
        /// </summary>
        /// <param name="value">The NHS number to be validated.</param>
        /// <returns><c>true</c> if the given NHS number can be validated; Otherwise, <c>false</c></returns>
        public static bool NhsNumber(string value) // TEST WITH 450 557 7104
        {
            value = value.Replace(" ", "");
            string nhsNumCriteria = "^[0-9]{10}$";
            Regex nhsNum = new Regex(nhsNumCriteria, RegexOptions.IgnoreCase);
            if (!nhsNum.IsMatch(value))
            {
                return false;
            }

            char[] valarray = value.ToCharArray();
            int result = 0;
            for (int i = 0; i < 9; i++)
            {
                int factor = 10 - i;
                result += int.Parse(valarray[i].ToString()) * factor;
            }

            int resultremainder = result % 11;
            int checkdigit = 11 - resultremainder;

            if (checkdigit == 10)
            {
                return false;
            }

            if (checkdigit == 11)
            {
                checkdigit = 0;
            }

            return valarray[9].ToString() == checkdigit.ToString();
        }

        /// <summary>
        /// Validates the given email address using the official RFC regex.
        /// </summary>
        /// <param name="value">The email to be validated.</param>
        /// <returns><c>true</c> if the email can be validated; Otherwise, <c>false</c></returns>
        public static bool Email(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return true;
            }
            //(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|"(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\[(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[a-z0-9-]*[a-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])
            string emailcriteria =
                "(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|\"(?:[\\x01-\\x08\\x0b\\x0c\\x0e-\\x1f\\x21\\x23-\\x5b\\x5d-\\x7f]|\\\\[\\x01-\\x09\\x0b\\x0c\\x0e-\\x7f])*\")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\\[(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[a-z0-9-]*[a-z0-9]:(?:[\\x01-\\x08\\x0b\\x0c\\x0e-\\x1f\\x21-\\x5a\\x53-\\x7f]|\\\\[\\x01-\\x09\\x0b\\x0c\\x0e-\\x7f])+)\\])";
            Regex emailmatch = new Regex(emailcriteria, RegexOptions.IgnoreCase);
            return emailmatch.IsMatch(value);
        }

        /// <summary>
        /// Validates the selected recall method with the given information.
        /// </summary>
        /// <param name="method">The selected method of recall.</param>
        /// <param name="address">The entered address.</param>
        /// <param name="email">The entered email.</param>
        /// <param name="telNum">The entered telephone number.</param>
        /// <returns><c>true</c> if the selected recall method is valid for the given information; Otherwise, <c>false</c></returns>
        public static bool RecallMethod(string method, string address, string email, string telNum) //todo: enum
        {
            switch (method)
            {
                case "Post":
                    if (string.IsNullOrEmpty(address))
                        return false;
                    break;
                case "Phone":
                    if (string.IsNullOrEmpty(telNum))
                        return false;
                    break;
                case "Email":
                    if (string.IsNullOrEmpty(email))
                        return false;
                    break;
            }
            return true;
        }
    }
}