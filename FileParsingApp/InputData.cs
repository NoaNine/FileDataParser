using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileParsingApp
{
    internal class InputData
    {
        public string[] GetFiles()
        {
            string pathDirectory = InputDirectory();
            ThrowDirectoryNotFoundException(pathDirectory);
            string[] file = Directory.GetFiles(pathDirectory);
            return file; 
        }

        private string InputDirectory()
        {
            Console.WriteLine(Properties.Messages.Input);
            string pathDirectory = Console.ReadLine();
            return pathDirectory;
        }

        private void ThrowDirectoryNotFoundException(string directory)
        {
            if (Directory.Exists(directory))
            {
                throw new DirectoryNotFoundException();
            }
        }
    }
}
