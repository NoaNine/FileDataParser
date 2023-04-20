namespace DataFile
{
    public class Line
    {
        public char[] TextInLine { get; private set; }
        public bool ValidForBroken { get; private set; }

        public Line(char[] text, bool validForBroken)
        {
            TextInLine = text;
            ValidForBroken = validForBroken;
        }
    }
}