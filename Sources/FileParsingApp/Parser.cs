using DataFile;

namespace FileParsingApp
{
    internal class Parser
    {
        public void ParseLine(string path)
        {
            List<Line> lines = new List<Line>();
            foreach(string line in File.ReadLines(path))
            {
                Console.WriteLine(line);
            }
        }

        private void CheckIsEmpty()
        {

        }

        private void TransferCulture() 
        {

        }
    }
}
