namespace Math
{
    public class FileReader
    {
        public List<string> Reader(string path)
        {
            CheckExist(path);
            List<string> rows = new List<string>();
            foreach(string line in File.ReadLines(path)) 
            { 
                rows.Add(line); 
            }
            return new List<string>();
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