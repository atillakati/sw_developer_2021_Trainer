using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wifi.ConsoleTools
{
    /// <summary>
    /// Source: https://www.dreamincode.net/forums/topic/365698-Validating-ISBN10-and-ISBN13-codes/
    /// </summary>
    public abstract class IsbnValidator
    {

        // ********************************************************************
        // * ISBN Reference:                                                  *
        // * http://en.wikipedia.org/wiki/International_Standard_Book_Number  *
        // ********************************************************************

        /// <summary>
        /// This method will validate a ISBN 10 or ISBN 13 code.
        /// </summary>
        /// <param name="isbn">code to validate
        /// <returns>true, if valid, otherwise false</returns>
        public static bool TryValidate(string isbn)
        {
            bool result = false;

            if (!string.IsNullOrEmpty(isbn))
            {
                switch (isbn.Length)
                {
                    case 10:
                        result = IsValidIsbn10(isbn);
                        break;

                    case 13:
                        result = IsValidIsbn13(isbn);
                        break;

                    default:
                        result = false;
                        break;
                }
            }

            return result;
        }

        /// <summary>
        /// Validates ISBN10 codes
        /// </summary>
        /// <param name="isbn10">code to validate
        /// <returns>true if valid</returns>
        private static bool IsValidIsbn10(string isbn10)
        {
            bool result = false;
            if (!string.IsNullOrEmpty(isbn10))
            {
                long j;
                if (isbn10.Contains('-')) isbn10 = isbn10.Replace("-", "");

                // Check if it contains any non numeric chars, if yes, return false
                if (!Int64.TryParse(isbn10.Substring(0, isbn10.Length - 1), out j))
                    result = false;

                // Checking if the last char is not 'X' and 
                // and if it's a numeric value
                char lastChar = isbn10[isbn10.Length - 1];
                if (lastChar == 'X' && !Int64.TryParse(lastChar.ToString(), out j))
                    result = false;

                int sum = 0;
                // Using the alternative way of calculation
                for (int i = 0; i < 9; i++)
                    sum += Int32.Parse(isbn10[i].ToString()) * (i + 1);

                // Getting the remainder or the checkdigit
                int remainder = sum % 11;

                // Check if the checkdigit is same as the last number of ISBN 10 code
                result = (remainder == int.Parse(isbn10[9].ToString()));
            }

            return result;
        }

        /// <summary>
        /// Validates ISBN13 codes
        /// </summary>
        /// <param name="isbn13">code to validate
        /// <returns>true, if valid</returns>
        private static bool IsValidIsbn13(string isbn13)
        {
            bool result = false;
            if (!string.IsNullOrEmpty(isbn13))
            {
                long j;
                if (isbn13.Contains('-')) isbn13 = isbn13.Replace("-", "");

                // Check if it contains any non numeric chars, if yes, return false
                if (!Int64.TryParse(isbn13, out j))
                    result = false;

                int sum = 0;
                // Comment Source: Wikipedia
                // The calculation of an ISBN-13 check digit begins with the first
                // 12 digits of the thirteen-digit ISBN (thus excluding the check digit itself).
                // Each digit, from left to right, is alternately multiplied by 1 or 3,
                // then those products are summed modulo 10 to give a value ranging from 0 to 9.
                // Subtracted from 10, that leaves a result from 1 to 10. A zero (0) replaces a
                // ten (10), so, in all cases, a single check digit results.
                for (int i = 0; i < 12; i++)
                {
                    sum += Int32.Parse(isbn13[i].ToString()) * (i % 2 == 1 ? 3 : 1);
                }

                int remainder = sum % 10;
                int checkDigit = 10 - remainder;
                if (checkDigit == 10) checkDigit = 0;

                result = (checkDigit == int.Parse(isbn13[12].ToString()));
            }

            return result;
        }

    }
}
