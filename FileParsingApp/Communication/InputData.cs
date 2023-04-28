namespace FileParsingApp.Communication
{
    internal class InputData
    {
        public string[] GetFiles()
        {
            string pathDirectory = InputDirectory();
            ThrowDirectoryNotFoundException(pathDirectory);
            string[] files = Directory.GetFiles(pathDirectory);
            return files;
        }

        private string InputDirectory()
        {
            Console.WriteLine(FileParsingApp.Resources.Messages.Input);
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
