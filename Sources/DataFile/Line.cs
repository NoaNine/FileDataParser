namespace DataFile
{
    public class Line
    {
        public char[] TextInLine { get; private set; }
        public bool ValidForBroken { get; private set; }
        public double Sum { get; private set; }

        public Line(char[] text, bool validForBroken, double sum)
        {
            TextInLine = text;
            ValidForBroken = validForBroken;
            Sum = sum;
        }
    }
}