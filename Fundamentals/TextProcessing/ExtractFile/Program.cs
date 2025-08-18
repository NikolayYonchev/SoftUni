using System;
using System.Linq;
using System.Collections.Generic;
/*


 */
namespace Fundamentals
{

    internal class Program
    {
        static void Main(string[] arguments)
        {
            string filePath = Console.ReadLine();

            string fileName = string.Empty;
            string fileExtension = string.Empty;

            int lastSeparatorIndex = filePath.LastIndexOf('\\');
            int extensionIndex = filePath.LastIndexOf('.');

            if (lastSeparatorIndex != -1 && extensionIndex != -1 && extensionIndex > lastSeparatorIndex)
            {
                fileName = filePath.Substring(lastSeparatorIndex + 1, extensionIndex - lastSeparatorIndex - 1);
                fileExtension = filePath.Substring(extensionIndex + 1);
            }

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");

        }
    }
}
