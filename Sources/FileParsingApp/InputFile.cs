using System.IO;

namespace FileParsingApp
{
    internal class InputFile
    {
        public string Input(string arg) 
        {
            if (!string.IsNullOrEmpty(arg))
            {
                CheckFormat(arg);
                CheckExists(arg);
                return arg;
            }
            return InputPathFromConsole();
        }

        private string InputPathFromConsole()
        {
            Console.WriteLine(Properties.Messages.Input);
            string path = Console.ReadLine();
            CheckFormat(path);
            CheckExists(path);
            return path;
        }

        private void CheckFormat(string input)
        {

        }

        private void CheckExists(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException();
            }
        }
    }
}
