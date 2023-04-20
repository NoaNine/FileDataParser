namespace FileParsingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Properties.Messages.Greeting);
            Input input = new Input();
            Parser parser = new Parser();
            foreach (string a in args)
            {
                parser.ParseLine(input.InputPath(a));
            }
        }
    }
}