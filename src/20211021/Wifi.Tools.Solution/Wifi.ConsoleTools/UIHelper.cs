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

    }
}
