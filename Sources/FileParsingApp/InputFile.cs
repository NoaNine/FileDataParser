using System.IO;

namespace FileParsingApp
{
    internal class InputFile
    {
        public string InputPath(string arg) 
        {
            if (string.IsNullOrEmpty(arg))
            {
                Console.WriteLine(Properties.Messages.Input);
                string path = Console.ReadLine();
                CheckExists(path);
            }
            else
            {
                CheckExists(arg);
                return arg;
            }
            return "";
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
