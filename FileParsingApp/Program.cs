using Math;
using Math.Models;
using System.Threading.Channels;

namespace FileParsingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"Files\SomeFile.txt";
            FileReader fileReader = new FileReader();
            Converter converter = new Converter();
            Aggregator aggregator = new Aggregator();
            AggregatorResult aggregatorResult = aggregator.Maximum(converter.Convert(fileReader.Read(path)));
            Console.WriteLine("{0} {1}", Resources.Messages.OutputValue, aggregatorResult.Value);
            Console.WriteLine(Resources.Messages.OutputLines);
            aggregatorResult.FoundInRows.ForEach(s => Console.WriteLine(s));
            Console.WriteLine(Resources.Messages.BrokenLines);
            aggregatorResult.BrokenRows.ForEach(s => Console.WriteLine(s));
        }
    }
}