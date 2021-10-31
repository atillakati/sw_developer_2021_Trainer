using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wifi.ConsoleTools
{
    public class UIHelper
    {
        /// <summary>
        /// Prints a red colored message with (no automatic newline) to default Output-Stream on the console.
        /// </summary>
        /// <param name="message">The message which should displayed</param>        
        public static void PrintColoredMessage(string message)
        {
            PrintColoredMessage(message, ConsoleColor.Red);
        }

        /// <summary>
        /// Prints a colored message with (no automatic newline) to default Output-Stream on the console.
        /// </summary>
        /// <param name="message">The message which should displayed</param>
        /// <param name="messageColor">The color the provided message should be displayed in.</param>        
        public static void PrintColoredMessage(string message, ConsoleColor messageColor)
        {
            ConsoleColor oldColor = Console.ForegroundColor;
            Console.ForegroundColor = messageColor;

            Console.Write(message);

            Console.ForegroundColor = oldColor;
        }


        /// <summary>
        /// Prints a centered header text with borders to the console
        /// with default border charakter = # and clearscreen first = true
        /// </summary>
        /// <param name="headerText">Header text to display centered on console</param>
        public static void PrintHeader(string headerText)
        {
            PrintHeader(headerText, '#', true);
        }

        public static int GetInt(string inputPrompt)
        {
            bool inputIsValid = false;
            int inputValue = 0;

            do
            {
                Console.Write(inputPrompt);
                try
                {
                    inputValue = int.Parse(Console.ReadLine());
                    inputIsValid = true;
                }
                catch
                {
                    inputIsValid = false;
                }
            }
            while (!inputIsValid);

            return inputValue;
        }

        public static string GetString(string inputPrompt)
        {
            bool inputIsValid = false;
            string inputValue = string.Empty;

            do
            {
                Console.Write(inputPrompt);

                inputValue = Console.ReadLine();
                inputIsValid = !string.IsNullOrEmpty(inputValue);
            }
            while (!inputIsValid);

            return inputValue;
        }

        public static decimal GetDecimal(string inputPrompt)
        {
            bool inputIsValid = false;
            decimal inputValue = 0.0m;

            do
            {
                Console.Write(inputPrompt);
                try
                {
                    inputValue = decimal.Parse(Console.ReadLine());
                    inputIsValid = true;
                }
                catch
                {
                    inputIsValid = false;
                }
            }
            while (!inputIsValid);

            return inputValue;
        }

        /// <summary>
        /// Prints a centered header text with borders to the console
        /// </summary>
        /// <param name="headerText">Header text to display centered on console</param>
        /// <param name="borderChar">The charakter to draw the borders</param>
        /// <param name="clearScreenFirst">True, if the screen should be cleared first, else false</param>
        public static void PrintHeader(string headerText, char borderChar, bool clearScreenFirst)
        {
            int xPos = 0;

            if (clearScreenFirst)
            {
                Console.Clear();
            }

            Console.WriteLine(new string(borderChar, Console.WindowWidth - 1));
            xPos = Console.WindowWidth / 2 - headerText.Length / 2;
            Console.CursorLeft = xPos;
            Console.WriteLine(headerText);
            Console.WriteLine(new string(borderChar, Console.WindowWidth - 1));
        }
    }
}
