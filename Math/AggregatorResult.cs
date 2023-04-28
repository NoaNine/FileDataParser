namespace Math
{
    public class AggregatorResult
    {
        private List<int> _foundInRows = new List<int>();
        private List<int> _brokenRows = new List<int>();

        public double Value { get; set; }
        public List<int> FoundInRows { get => _foundInRows; set => _foundInRows = value; }
        public List<int> BrokenRows { get => _brokenRows; set => _brokenRows = value; }
    }
}
