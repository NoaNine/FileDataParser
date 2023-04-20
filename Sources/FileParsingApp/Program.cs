namespace FileParsingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Properties.Messages.Greeting);
            InputFile inputFile = new InputFile();
            Parser parser = new Parser();
            foreach(string a in args)
            {
                parser.Parsing(inputFile.Input(a));
            }
        }
    }
}