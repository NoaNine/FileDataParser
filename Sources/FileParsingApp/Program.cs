namespace FileParsingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Properties.Messages.Greeting);
            InputFile inputFile = new InputFile();
            Parser parser = new Parser();
            string path = @"E:\Foxminded\Task3\Documents\SomeFile.txt";
            parser.ParseLine(path);
            //foreach (string a in args)
            //{
            //    parser.Parsing(inputFile.Input(a));
            //}
        }
    }
}