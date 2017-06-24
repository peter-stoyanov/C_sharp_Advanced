using System;
using System.Collections.Generic;

namespace BashSoft
{
    public static class OutputWriter
    {
        /// <summary>
        /// Writes empty line in the console
        /// </summary>
        public static void WriteEmptyLine()
        {
            Console.WriteLine();
        }

        /// <summary>
        /// Writes the passed string in the console
        /// </summary>
        /// <param name="msg"></param>
        public static void WriteMessage(string msg)
        {
            Console.Write(msg);
        }

        /// <summary>
        /// Writes the passed string on a new line in the console
        /// </summary>
        /// <param name="msg"></param>
        public static void WriteMessageOnNewLine(string msg)
        {
            Console.WriteLine(msg);
        }

        /// <summary>
        /// Displays exseption in the console with color formatting
        /// </summary>
        /// <param name="msg"></param>
        public static void DisplayException(string msg)
        {
            ConsoleColor currentColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine(msg);

            Console.ForegroundColor = currentColor;
        }

        /// <summary>
        /// Prints student data in the console
        /// </summary>
        /// <param name="student"></param>
        public static void PrintStudent(KeyValuePair<string, List<int>> student)
        {
            WriteMessageOnNewLine(string.Format($"{student.Key} - {string.Join(", ", student.Value)}"));
        }
    }
}
