namespace Math.Models
{
    public class AggregatorResult
    {
        public double Value { get; set; }
        public List<int> FoundInRows { get; set; } = new List<int>();
        public List<int> BrokenRows { get; set; } = new List<int>();
    }
}
