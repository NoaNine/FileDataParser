using Math;
using System.Globalization;

namespace FileParsingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"E:\Foxminded\Task3\Files\SomeFile.txt";
            string path2 = "E:\\Foxminded\\Task3\\FileParsingApp\\bin\\Files";
            if (args.Length > 0)
            {
                CopyFile(args);
            }
            else
            {
                InputData inputData = new InputData();
                CopyFile(inputData.GetFiles());
            }
        }

        private static void CopyFile(string[] files)
        {

        }
    }
}