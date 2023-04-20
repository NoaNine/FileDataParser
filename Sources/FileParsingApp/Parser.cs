using DataFile;

namespace FileParsingApp
{
    internal class Parser
    {
        public void ParseLine(string path)
        {
            List<Line> lines = new List<Line>();
            CopyFile(lines, path);
        }

        private void CopyFile(List<Line> lines, string path)
        {
            foreach (string line in File.ReadLines(path))
            {
                lines.Add(new Line(line.ToCharArray()));
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
