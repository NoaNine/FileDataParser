    namespace Math
{
    public class FileReader
    {
        public string[] Read(string path)
        {
            ThrowIfNotExists(path);
            string[] list = File.ReadAllLines(path);
            return list;
        }

        private void ThrowIfNotExists(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException();
            }
        }
    }
}