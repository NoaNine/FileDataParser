namespace Math
{
    public class FileReader
    {
        public string[] Reader(string path)
        {
            CheckExist(path);
            string[] list = File.ReadAllLines(path);
            return list;
        }

        private void CheckExist(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException();
            }
        }
    }
}